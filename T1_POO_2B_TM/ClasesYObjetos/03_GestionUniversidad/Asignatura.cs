using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Asignatura : ICloneable
    {
        List<Alumno> la;
        public Asignatura()
        {
            la = new List<Alumno>();
        }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public void AgregarAlumno(Alumno pA)
        {  
          
            var alumnoClonado = pA.CloneTipado();
            alumnoClonado.CargarAsignatura(this); // Asignamos la asignatura al alumno clonado
            if (BuscarAlumno(pA) == null) la.Add(alumnoClonado); 
        }

        public object Clone()
        {
            var asignaturaAux = (Asignatura)this.MemberwiseClone();
            var listaAlumnos = asignaturaAux.ObtenerAlumnos();
            if (listaAlumnos.Count > 0)
            {
                listaAlumnos.ForEach(x => asignaturaAux.AgregarAlumno(x)); // Asignamos cada alumno a la asignatura auxiliar
            }
            return asignaturaAux;
        }
        public Asignatura CloneTipado() => (Asignatura)this.Clone();

        public void EliminarAlumno(Alumno pA)
        {
            Alumno? alumno = BuscarAlumno(pA);
            if (alumno != null) la.Remove(alumno);          
        }
        public void ModificarAlumno(Alumno pAlumnoOriginal,Alumno pAlumnoModificado)
        {
            Alumno? alumnoOriginal = BuscarAlumno(pAlumnoOriginal);
            if (alumnoOriginal != null)
            {
                Alumno? alumnoModificado = BuscarAlumno(pAlumnoModificado);
                if (alumnoModificado == null  || alumnoOriginal.Legajo==alumnoModificado.Legajo)
                {
                    alumnoOriginal.Legajo = pAlumnoModificado.Legajo;
                    alumnoOriginal.Nombre = pAlumnoModificado.Nombre;
                    alumnoOriginal.Apellido = pAlumnoModificado.Apellido;
                }
            }
        }
        public void ModificarAsignaturaAlumno(Alumno pAlumno, Asignatura pAsignatura)
        {
            Alumno? alumno = BuscarAlumno(pAlumno);
            if (alumno != null)
            {
                alumno.CargarAsignatura(pAsignatura.CloneTipado());
            }
        }
        public List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnosAux = new List<Alumno>();
            la.ForEach(x => alumnosAux.Add(x.CloneTipado())); // Clonamos para no modificar la lista original
            return alumnosAux;
           
        }
        private Alumno? BuscarAlumno(Alumno pAlumno)
        {
            return la.Find(x => x.Legajo == pAlumno.Legajo);
        }
    }
}
