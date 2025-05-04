using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAlumnos
{
    internal class Alumno
    {
        #region "Propiedades"
        private const int TOTAL_MATERIAS = 36;
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private DateOnly Vfecha_nacimiento;
        public DateOnly Fecha_Nacimiento
        {
            set { Vfecha_nacimiento = value; }
        }

        private DateOnly Vfecha_ingreso;
        public DateOnly Fecha_Ingreso
        {
            set { Vfecha_ingreso = value; }
        }
        private int Vedad;
        public int Edad
        {
            get
            {
                Vedad = DateTime.Now.Year - Vfecha_nacimiento.Year;
                return Vedad;
            }
        }
        public bool Activo { get; set; }
        private int Vcant_materia_aprobadas;
        public int Cant_Materia_Aprobadas
        {
            set { Vcant_materia_aprobadas = value; }
        }
        #endregion

        #region "Constructores y Finalizador"
        public Alumno(int pLegajo, string pNombre, string pApellido, DateOnly pFechaNacimiento, DateOnly pFechaIngreso, int pCantMateriasAprobadas)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apellido = pApellido;
            Vfecha_nacimiento = pFechaNacimiento;
            Vfecha_ingreso = pFechaIngreso;
            Activo = true;
            Vcant_materia_aprobadas = pCantMateriasAprobadas;
        }
        public Alumno()
        {
            Legajo = 0;
            Nombre = null;
            Apellido = null;
            Vfecha_nacimiento = DateOnly.MinValue;
            Vfecha_ingreso = DateOnly.MinValue;
            Activo = true;
            Vcant_materia_aprobadas = 0;
        }
        ~Alumno() => MessageBox.Show($"{this.Legajo}-{this.Nombre} {this.Apellido}");

        #endregion

        #region "Metodos"
        public enum TipoRetorno
        {
            Dias, Meses, Anios
        }
        public int Antiguedad(TipoRetorno pUnidadTiempo)
        {
            int diferencia = 0;
            if (pUnidadTiempo == TipoRetorno.Meses)
            {
                diferencia = (DateTime.Now.Year - Vfecha_ingreso.Year) * 12 + (DateTime.Now.Month - Vfecha_ingreso.Month);
            }
            else if (pUnidadTiempo == TipoRetorno.Anios)
            {
                diferencia = DateTime.Now.Year - Vfecha_ingreso.Year;
            }
            return diferencia;
        }
        public int Materias_No_Aprobadas()
        {
            return TOTAL_MATERIAS - Vcant_materia_aprobadas;
        }
        public int Edad_De_Ingreso()
        {
            return Vfecha_ingreso.Year - Vfecha_nacimiento.Year;
        }
        #endregion
    }
}
