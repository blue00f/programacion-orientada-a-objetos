using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Servidor.Eventos
{
    internal class DatosRecibidosEventArgs : ServidorEventArgs
    {
        public string DatosRecibidos { get; set; }
        public DatosRecibidosEventArgs(IPEndPoint pEndPoint, string pDatos) : base(pEndPoint)
        {
            DatosRecibidos = pDatos;
        }
    }
}
