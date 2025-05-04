using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDelFinalizador
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNacimiento = pFechaNacimiento;
        }

        public string VerDatos()
        {
            return $"{Nombre} {Apellido} - {FechaNacimiento.Date}";
        }
        ~Cliente()
        {
            MessageBox.Show($"El objeto {this.Nombre} ha sido destruido.");
        }
    }
}
