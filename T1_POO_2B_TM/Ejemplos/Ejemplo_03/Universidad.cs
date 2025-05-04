using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Universidad
    {
        List<Asignatura> las;
        public Universidad()
        {
            las = new List<Asignatura>();
        }
        public void AgregarAsignatura(Asignatura pA)
        {
            var asignatura = BuscarAsignatura(pA);
            if (asignatura == null) las.Add(pA.CloneTipado());
        }
        public void EliminarAsignatura(Asignatura pA)
        {
            Asignatura? asignatura = BuscarAsignatura(pA);
            if (asignatura != null) las.Remove(asignatura);
        }
        public void ModificarAsignatura(Asignatura pAOriginal, Asignatura pAModificado)
        {
            Asignatura? asignaturaOriginal = BuscarAsignatura(pAOriginal);
            if (asignaturaOriginal != null)
            {
                Asignatura? asignaturaModificado = BuscarAsignatura(pAModificado);
                if (asignaturaModificado == null || asignaturaOriginal.Codigo == asignaturaModificado.Codigo)
                {
                    asignaturaOriginal.Codigo = pAModificado.Codigo;
                    asignaturaOriginal.Descripcion = pAModificado.Descripcion;
                }
            }
        }
        public List<Asignatura> ObtenerAsignaturas()
        {
            List<Asignatura> lasAux = new List<Asignatura>();
            las.ForEach(x => lasAux.Add(x.CloneTipado())); // Clonamos cada asignatura
            return lasAux;
        }
        public void AsignarAlumnoAsignatura(Alumno pAlumno, Asignatura pAsignatura)
        {
            Asignatura? asignatura = BuscarAsignatura(pAsignatura);
            if (asignatura != null)
            {
                var existe = false;
                foreach (var asi in las)
                {
                    foreach (var alu in asi.ObtenerAlumnos())
                    {
                        if (alu.Legajo == pAlumno.Legajo)
                        {
                            existe =true; 
                        }
                    }

                   
                }
                if(!existe) asignatura.AgregarAlumno(pAlumno); //No clonamos pAlumno porque tenemos la verteza que lo clona la asignatura al agregarlo
            }
        }
        public void EliminarAlumnoAsignatura(Alumno pAlumno, Asignatura pAsignatura)
        {
            Asignatura? asignatura = BuscarAsignatura(pAsignatura);
            if (asignatura != null)
            {
                asignatura.EliminarAlumno(pAlumno);
            }
        }
        public void ModificarAlumnoAsignatura(Alumno pAlumnoOriginal, Alumno pAlumnoModificado, Asignatura pAsignatura)
        {
            Asignatura? asignatura = BuscarAsignatura(pAsignatura);
            if (asignatura != null)
            {
                var existe = false;
                foreach (var asi in las)
                {
                    foreach (var alu in asi.ObtenerAlumnos())
                    {
                        if (alu.Legajo == pAlumnoModificado.Legajo)
                        {
                            existe = true;
                        }
                    }


                }
            
                if(!existe) asignatura.ModificarAlumno(pAlumnoOriginal, pAlumnoModificado);
            }
        }
        public Asignatura? BuscarAsignatura(Asignatura pA)
        {
            return las.Find(x => x.Codigo == pA.Codigo);
        }
    }
}
