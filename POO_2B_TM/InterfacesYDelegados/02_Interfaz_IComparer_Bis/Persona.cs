using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo07
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        internal class NombreASC : IComparer<Persona>
        {
            public event EventHandler<DatosEventArgs> Datos;
            public int Compare(Persona? x, Persona? y)
            {
                var v = x.Nombre.CompareTo(y.Nombre);
                Datos?.Invoke(this, new DatosEventArgs(x, y,v));
                return v;
            }

        }
        internal class NombreDESC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y)
            {
                return x.Nombre.CompareTo(y.Nombre) * -1;
            }
        }
        internal class ApellidoASC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y)
            {
                var r = x.Apellido.CompareTo(y.Apellido);
                return r!=0 ? r : (new NombreASC()).Compare(x,y) ;
            }
        }
        internal class ApellidoDESC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y)
            {
                return (new ApellidoASC()).Compare(x,y) * -1;
            }
        }
        internal class EdadASC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y)
            {
                int rdo = 0;
                if (x.Edad<y.Edad) rdo=-1;
                if (x.Edad>y.Edad) rdo= 1;
                return rdo;           
            }
            //public int Compare(Persona? x, Persona? y)
            //{
            //    return x.Edad.CompareTo(y.Edad);
            //}
        }
        internal class EdadDESC : IComparer<Persona>
        {
            public int Compare(Persona? x, Persona? y)
            {
                return x.Edad.CompareTo(y.Edad) * -1;
            }
        }
    }
}
