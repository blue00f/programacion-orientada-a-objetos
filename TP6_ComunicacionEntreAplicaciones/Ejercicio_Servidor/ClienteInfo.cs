using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Servidor
{
    internal class ClienteInfo
    {
        public string Ip { get; set; }
        public int Puerto { get; set; }
        public IPEndPoint EndPoint => new IPEndPoint(IPAddress.Parse(Ip), Puerto);
    }
}
