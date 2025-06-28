using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Futbolista
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Futbolista(int pNumero, string pNombre, string pApellido)
        {
            Numero = pNumero;
            Nombre = pNombre;
            Apellido = pApellido;
        }
    }
}
