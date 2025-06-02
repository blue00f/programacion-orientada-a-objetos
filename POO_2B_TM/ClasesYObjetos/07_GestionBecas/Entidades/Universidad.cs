using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial.Entidades
{
    internal class Universidad
    {
        List<Beca> lb;
        List<Alumno> la;
        public Universidad() { lb = new List<Beca>(); la = new List<Alumno>(); }
        public bool ValidaCodigoAlumno(Alumno pAlumno)
        {
            return la.Exists(a => a.Legajo == pAlumno.Legajo);
        }
        private bool AgregarBeca(Beca pBeca)
        {
            bool rta = false;
            if (pBeca != null && !lb.Exists(b => b.Codigo == pBeca.Codigo))
            {
                lb.Add(pBeca.CloneTipado()); rta = true;
            }
            return rta;
        }
        public void BorrarBeca(Beca pBeca)
        {
            Beca b = lb.Find(b => b.Codigo == pBeca.Codigo);
            if (b != null)
            {
                lb.Remove(b);
            }

        }
        public void AgregarAlumno(Alumno pAlumno)
        {
            if (pAlumno != null && !ValidaCodigoAlumno(pAlumno))
            {
                la.Add(pAlumno.CloneTipado());
            }
        }
        public void BorrarAlumno(Alumno pAlumno)
        {
            Alumno a = la.Find(a => a.Legajo == pAlumno.Legajo);
            if (a != null) { la.Remove(a); }
        }
        public void ModificarAlumno(Alumno pAlumno)
        {
            Alumno a = la.Find(a => a.Legajo == pAlumno.Legajo);
            if (a != null)
            {
                a.Nombre = pAlumno.Nombre;
                a.Apeliido = pAlumno.Apeliido;
                a.Dni = pAlumno.Dni;
            }
        }
        public void Crear_Asignar_Beca(Alumno pAlumno, Beca pBeca)
        {
            Alumno a = la.Find(a => a.Legajo == pAlumno.Legajo);
            if (a != null)
            {
                Beca b = pBeca.CloneTipado();
                if (AgregarBeca(b)) a.AsignarBeca(b);
            }
        }
        public List<object> RetornaAlumnos()
        { return (from a in la select new { a.Legajo, a.Nombre, Apellido = a.Apeliido, DNI = a.Dni, Cuota = a.ObtenerCuota().Importe }).ToList<object>(); }
        public List<object> RetornaBecas()
        { return (from b in lb select new { b.Codigo, b.Fecha, b.Importe }).ToList<object>(); }
        public List<object> RetornaBecaAlumno(Alumno pAlumno)
        {
            Alumno alu = la.Find(a => a.Legajo == pAlumno.Legajo);
            List<object> becas = new List<object>();

            if (alu != null)
            {
                Beca b = alu.ObtenerBeca();
                if (b != null) becas.Add(new Beca() { Codigo = b.Codigo, Fecha = b.Fecha, Importe = b.Importe });
            }

            return becas;

        }
        public decimal CalcularPago(Alumno pAlumno)
        {
            decimal rta = 0m;
            Alumno a = la.Find(a => a.Legajo == pAlumno.Legajo);
            if (a != null)
            {
                rta = a.CuotaNeta();
            }
            return rta;

        }
    }
}
