using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_02
{
    internal sealed class Empleado : Persona
    {
        public int Legajo { get; set; }
        public Empleado(string pNombre, string pApellido, int pLegajo) : base(pNombre, pApellido) => Legajo = pLegajo;
        public override string MostrarInfo() => $"{this.Legajo} {base.MostrarInfo()}";

        // Clases anidadas que brindan el servicio de ordenamiento por legajo
        internal class LegajoASC : IComparer<Empleado>
        {
            public int Compare(Empleado? x, Empleado? y) => x.Legajo.CompareTo(y.Legajo);
        }
        internal class LegajoDESC : IComparer<Empleado>
        {
            public int Compare(Empleado? x, Empleado? y) => (new LegajoASC()).Compare(x, y) * -1;
        }
    }
}
