using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace EjemploCliente
{
    // Declaro una subclase de EventArgs para el evento DatosRecibidos
    public class DatosRecibidosEventArgs : EventArgs
    {
        public DatosRecibidosEventArgs(string datos)
        {
            DatosRecibidos = datos;
        }

        public string DatosRecibidos { get; set; }
    }

    public class Cliente
    {
        Socket socket; // Socket utilizado para enviar datos al Servidor y recibir datos del mismo
        Thread thread; // Thread utilizado para escuchar los mensajes enviados por el servidor

        // Flag utilizado para saber si el cliente está conectado al servidor o no.
        public bool Conectado { get; private set; }

        // Si estoy conectado esta propiedad nos permite obtener la IP y el puerto local
        public IPEndPoint LocalEndPoint
        {
            get { return socket?.LocalEndPoint as IPEndPoint; }
        }

        // Si estoy conectado esta propiedad nos permite obtener la IP y el puerto del servidor
        public IPEndPoint RemoteEndPoint
        {
            get { return socket?.RemoteEndPoint as IPEndPoint; }
        }

        public event EventHandler ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

        public void Conectar(string ip, int puerto)
        {
            if (Conectado) return;

            // Creamos un socket con la configuración correcta para enviar y recibir datos sobre TCP
            // Ver: https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.sockettype
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            // Me conecto al objeto de la clase Servidor, determinado por los parámetros ip y puerto
            socket.Connect(ip, puerto);
            Conectado = true;

            // Creo e inicio un thread para que escuche los mensajes enviados por el Servidor
            thread = new Thread(LeerSocket);
            thread.IsBackground = true; // Background thread (https://docs.microsoft.com/en-us/dotnet/standard/threading/foreground-and-background-threads)
            thread.Start();
        }

        public void EnviarDatos(string datos)
        {
            if (!Conectado) return;

            // Envío el mensaje codificado en UTF-8 (https://es.wikipedia.org/wiki/UTF-8)
            byte[] bytes = Encoding.UTF8.GetBytes(datos);
            socket?.Send(bytes);
        }

        private void LeerSocket()
        {
            // Declaro un array de bytes para contener los mensajes de entrada
            var buffer = new byte[100];
            while (true)
            {
                try
                {
                    // Me quedo esperando a que llegue algún mensaje
                    int cantidadRecibida = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (cantidadRecibida > 0)
                    {
                        // Decodifico el mensaje usando UTF-8 (https://es.wikipedia.org/wiki/UTF-8)
                        string mensaje = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
                        // Disparo el evento DatosRecibidos, pasando como arg el mensaje que llegó desde el servidor
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
            // Finalizó la conexión, por lo tanto genero el evento correspondiente
            ConexionTerminada?.Invoke(this, new EventArgs());
        }
    }
}