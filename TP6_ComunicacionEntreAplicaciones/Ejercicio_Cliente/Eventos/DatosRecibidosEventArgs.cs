using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cliente.Eventos
{
    internal class DatosRecibidosEventArgs : EventArgs
    {
        public string DatosRecibidos { get; set; }
        public DatosRecibidosEventArgs(string pDatos)
        {
            DatosRecibidos = pDatos;
        }
    }
}
