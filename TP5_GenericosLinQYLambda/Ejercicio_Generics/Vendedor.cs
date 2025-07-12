using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Generics
{
    internal class Vendedor : ICloneable, ICloneableTipado<Vendedor>
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Vendedor(string pLegajo, string pNombre, string pApellido)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apellido = pApellido;
        }

        public object Clone() => this.MemberwiseClone();
        public Vendedor? CloneTipado() => this.Clone() as Vendedor;
    }
}
