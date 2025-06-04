using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurreccionDeObjetos
{
    internal class Refugio
    {
        public string Nombre { get; set; }
        public Perro UltimoPerroRescatado;
        public Refugio(string pNombre) { Nombre = pNombre; }
    }
}
