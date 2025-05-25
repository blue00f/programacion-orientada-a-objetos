using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Alumno : ICloneable
    {
        Asignatura? asignatura;
        public Alumno()
        {
            asignatura = null;
        }
        public string? Legajo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        //public Asignatura? Asignatura { get { return asignatura; } set { asignatura = value; } }

        public void CargarAsignatura(Asignatura pAsignatura) => asignatura=pAsignatura;
        public Asignatura? ObtenerAsignatura() => asignatura;
        public object Clone() => this.MemberwiseClone();
        public Alumno CloneTipado() => (Alumno)this.Clone();
    }
}
