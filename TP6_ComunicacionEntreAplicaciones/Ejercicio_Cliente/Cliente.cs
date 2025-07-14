using Ejercicio_Cliente.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cliente
{
    internal class Cliente
    {
        public event EventHandler ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;
        Socket socket;
        Thread thread;

        public string Nombre { get; set; }
        public bool Conectado { get; private set; }
        public IPEndPoint LocalEndPoint
        {
            get { return socket?.LocalEndPoint as IPEndPoint; }
        }
        public IPEndPoint RemoteEndPoint
        {
            get { return socket?.RemoteEndPoint as IPEndPoint; }
        }

        public void Conectar(string pIp, int pPuerto)
        {
            if (Conectado) return;
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(pIp, pPuerto);
            Conectado = true;
            thread = new Thread(LeerSocket);
            thread.IsBackground = true;
            thread.Start();
        }
        public void EnviarDatos(string pDatos)
        {
            if (!Conectado) return;
            byte[] bytes = Encoding.UTF8.GetBytes(pDatos);
            socket?.Send(bytes);
        }
        private void LeerSocket()
        {
            var buffer = new byte[100];
            while (true)
            {
                try
                {
                    int cantidadRecibida = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (cantidadRecibida > 0)
                    {
                        string mensaje = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
                        DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(mensaje));
                    }
                }
                catch
                {
                    socket.Close();
                    break;
                }
            }
            Conectado = false;
            ConexionTerminada?.Invoke(this, null);
        }
    }
}
