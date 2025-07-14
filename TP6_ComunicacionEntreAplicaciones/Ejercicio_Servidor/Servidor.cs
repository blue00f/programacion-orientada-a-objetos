using Ejercicio_Servidor.Eventos;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Servidor
{
    internal class Servidor
    {
        public event EventHandler<ServidorEventArgs> NuevaConexion;
        public event EventHandler<ServidorEventArgs> ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

        Thread listenerThread;
        TcpListener listener;
        ConcurrentDictionary<IPEndPoint, InfoDeUnCliente> clientes = new ConcurrentDictionary<IPEndPoint, InfoDeUnCliente>();
        private struct InfoDeUnCliente
        {
            public Socket Socket;
            public Thread Thread;
        }

        public int PuertoDeEscucha { get; }
        public Servidor(int pPuerto)
        {
            PuertoDeEscucha = pPuerto;
        }

        public List<ClienteInfo> ObtenerClientesConectados()
        {
            return clientes.Keys.Select(ep => new ClienteInfo
            {
                Ip = ep.Address.ToString(),
                Puerto = ep.Port
            }).ToList();
        }

        public void Escuchar()
        {
            listener = new TcpListener(IPAddress.Any, PuertoDeEscucha);
            listener.Start();
            listenerThread = new Thread(EsperarCliente);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }
        public void Cerrar()
        {
            foreach (var cliente in clientes.Values)
            {
                cliente.Socket.Close();
            }
        }
        public void EnviarDatos(string pDatos)
        {
            foreach (var cliente in clientes.Values)
            {
                cliente.Socket.Send(Encoding.UTF8.GetBytes(pDatos));
            }
        }

        // Este método sirve para que el cliente pueda enviar un mensaje a TODOS los demás clientes excepto a él mismo
        public void EnviarDatos(IPEndPoint pEmisor, string pDatos)
        {
            foreach (var cliente in clientes)
            {
                if (!cliente.Key.Equals(pEmisor))
                {
                    cliente.Value.Socket.Send(Encoding.UTF8.GetBytes(pDatos));
                }
            }
        }
        public void EnviarDatosA(IPEndPoint pDestino, string pDatos)
        {
            if (clientes.TryGetValue(pDestino, out var cliente))
            {
                cliente.Socket.Send(Encoding.UTF8.GetBytes(pDatos));
            }
        }

        private void EsperarCliente()
        {
            while (true)
            {
                var socket = listener.AcceptSocket();
                var endPoint = socket.RemoteEndPoint as IPEndPoint;
                var thread = new Thread(() => LeerSocket(endPoint));
                thread.IsBackground = true;

                clientes[endPoint] = new InfoDeUnCliente()
                {
                    Socket = socket,
                    Thread = thread
                };
                NuevaConexion?.Invoke(this, new ServidorEventArgs(endPoint));
                thread.Start();
            }
        }
        private void LeerSocket(IPEndPoint pEndPoint)
        {
            var buffer = new byte[100];
            var cliente = clientes[pEndPoint];
            while (cliente.Socket.Connected)
            {
                try
                {
                    int cantidadRecibida = cliente.Socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (cantidadRecibida > 0)
                    {
                        var datosRecibidos = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
                        DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(pEndPoint, datosRecibidos));
                    }
                    else
                    {
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(pEndPoint));
                        break;
                    }
                }
                catch
                {
                    if (!cliente.Socket.Connected) break;
                }
            }
            clientes.TryRemove(pEndPoint, out cliente);
            ConexionTerminada?.Invoke(this, new ServidorEventArgs(pEndPoint));
        }
    }
}
