using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_01
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona(string pNombre, string pApellido)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }
        public abstract string MostrarInfo();
        ~Persona() => MessageBox.Show("GC liberó el recurso de una persona!");
    }
}
