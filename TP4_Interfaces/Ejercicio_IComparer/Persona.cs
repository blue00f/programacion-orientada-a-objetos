using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIComparer
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Instrumento { get; set; }
        public int Edad { get; set; }
        public Persona (string pNombre, string pApellido, string pInstrumento, int pEdad)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Instrumento = pInstrumento;
            Edad = pEdad;
        }

        internal class NombreASC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y)
            {
                int rdo = x.Nombre.CompareTo(y.Nombre);
                if (rdo == 0) rdo = x.Apellido.CompareTo(y.Apellido);
                return rdo;
            }
        }
        internal class InstrumentoASC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y) => x.Instrumento.CompareTo(y.Instrumento);
        }
        internal class InstrumentoDESC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y) => (new InstrumentoASC().Compare(x,y)) * -1;
        }
        internal class EdadASC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y) => x.Edad.CompareTo(y.Edad);
        }
        internal class EdadDESC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y) => (new EdadASC().Compare(x,y))* -1;
        }
    }
}
