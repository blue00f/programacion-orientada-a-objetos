using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIComparable
{
    internal class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona (string pNombre, string pApellido)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }

        public int CompareTo(Persona? other)
        {
            return this.Apellido.CompareTo(other.Apellido);
        }
    }
}
