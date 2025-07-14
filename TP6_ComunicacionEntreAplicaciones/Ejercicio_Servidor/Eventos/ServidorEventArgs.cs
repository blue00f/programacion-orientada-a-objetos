using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Servidor.Eventos
{
    internal class ServidorEventArgs : EventArgs
    {
        public IPEndPoint EndPoint { get; }
        public ServidorEventArgs(IPEndPoint pEndPoint)
        {
            EndPoint = pEndPoint;
        }
    }
}
