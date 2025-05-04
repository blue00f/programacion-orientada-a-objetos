using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;

namespace EjemploServidor
{
    // Declaro una subclase de EventArgs para los eventos del servidor
    public class ServidorEventArgs : EventArgs
    {
        public ServidorEventArgs(IPEndPoint ep)
        {
            EndPoint = ep;
        }

        public IPEndPoint EndPoint { get; }
    }

    // Declaro una subclase de ServidorEventArgs específicamente para el evento DatosRecibidos
    public class DatosRecibidosEventArgs : ServidorEventArgs
    {
        public DatosRecibidosEventArgs(IPEndPoint ep, string datos) : base(ep)
        {
            DatosRecibidos = datos;
        }

        public string DatosRecibidos { get; set; }
    }

    public class Servidor
    {
        // Esta estructura permite guardar la información sobre un cliente
        private struct InfoDeUnCliente
        {
            public Socket Socket; // Socket utilizado para mantener la conexión con el cliente
            public Thread Thread; // Thread utilizado para escuchar al cliente
        }

        Thread listenerThread; // Thread de escucha de nuevas conexiones
        TcpListener listener; // Este objeto nos permite escuchar las conexiones entrantes

        // En este dictionary vamos a guardar la información de todos los clientes conectados.
        // ConcurrentDictionary se puede usar desde múltiples threads sin necesidad de locks.
        // Ver: https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2
        ConcurrentDictionary<IPEndPoint, InfoDeUnCliente> clientes = new ConcurrentDictionary<IPEndPoint, InfoDeUnCliente>();

        public event EventHandler<ServidorEventArgs> NuevaConexion;
        public event EventHandler<ServidorEventArgs> ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

        public int PuertoDeEscucha { get; }

        public Servidor(int puerto)
        {
            PuertoDeEscucha = puerto;
        }

        public void Escuchar()
        {
            listener = new TcpListener(IPAddress.Any, PuertoDeEscucha);

            // Inicio la escucha
            listener.Start();

            // Creo un thread para que se quede escuchando la llegada de los clientes sin interferir con la UI
            listenerThread = new Thread(EsperarCliente);
            // La siguiente línea hace que cuando se cierre la aplicación también se detenga el thread de escucha.
            // Ver: https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread.isbackground
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        public void Cerrar()
        {
            // Recorro todos los clientes y voy cerrando las conexiones
            foreach (var cliente in clientes.Values)
            {
                // Cierro la conexión con el cliente
                cliente.Socket.Close();
            }
        }

        public void EnviarDatos(string datos)
        {
            // Recorro todos los clientes conectados y les envío el mensaje en el parámetro datos
            foreach (var cliente in clientes.Values)
            {
                // Envío el mensaje codificado en UTF-8 (https://es.wikipedia.org/wiki/UTF-8)
                cliente.Socket.Send(Encoding.UTF8.GetBytes(datos));
            }
        }

        private void EsperarCliente()
        {
            while (true)
            {
                // Cuando se recibe la conexión, guardo la información del cliente
                // Guardo el socket que utilizó para mantener la conexión con el cliente
                var socket = listener.AcceptSocket(); // Se queda esperando la conexión de un cliente

                // Guardo el RemoteEndPoint, que utilizo para identificar al cliente
                // Casteo a IPEndPoint para poder obtener la IP y el puerto del cliente
                var endPoint = socket.RemoteEndPoint as IPEndPoint;

                // Creo un thread para que se encargue de escuchar los mensajes del cliente.
                // Uso una función anónima para que el thread tenga acceso a la ip del cliente actual
                var thread = new Thread(() => LeerSocket(endPoint));
                thread.IsBackground = true;

                // Agrego la información del cliente al dictionary de clientes
                clientes[endPoint] = new InfoDeUnCliente()
                {
                    Socket = socket,
                    Thread = thread,
                };

                // Disparo el evento NuevaConexion
                NuevaConexion?.Invoke(this, new ServidorEventArgs(endPoint));

                // Inicio el thread encargado de escuchar los mensajes del cliente
                thread.Start();
            }
        }

        private void LeerSocket(IPEndPoint endPoint)
        {
            var buffer = new byte[100]; // Array a utilizar para recibir los datos que llegan
            var cliente = clientes[endPoint]; // Información del cliente que se va a escuchar
            while (cliente.Socket.Connected)
            {
                try
                {
                    // Me quedo esperando a que llegue un mensaje desde el cliente
                    int cantidadRecibida = cliente.Socket.Receive(buffer, buffer.Length, SocketFlags.None);

                    // Me fijo cuántos bytes recibí. Si no recibí nada, entonces se desconectó el cliente
                    if (cantidadRecibida > 0)
                    {
                        // Decodifico el mensaje recibido usando UTF-8 (https://es.wikipedia.org/wiki/UTF-8)
                        var datosRecibidos = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);

                        // Disparo el evento de la recepción del mensaje
                        DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(endPoint, datosRecibidos));
                    }
                    else
                    {
                        // Disparo el evento de la finalización de la conexión
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(endPoint));
                        break;
                    }
                }
                catch
                {
                    if (!cliente.Socket.Connected)
                    {
                        // Disparo el evento de la finalización de la conexión
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(endPoint));
                        break;
                    }
                }
            }
            // Elimino el cliente del dictionary que guarda la información de los clientes
            clientes.TryRemove(endPoint, out cliente);
        }
    }
}
