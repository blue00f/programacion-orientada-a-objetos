using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_2
{
    internal class Persona
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Auto> Autos { get; set; }
    }
}
