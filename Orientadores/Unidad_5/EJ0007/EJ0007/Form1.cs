using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuestraEmpleado<EmpleadoAdministrativo> ME = new MuestraEmpleado<EmpleadoAdministrativo>();
            MessageBox.Show(ME.Mostrar(new EmpleadoAdministrativo("Ana","Martinez"))); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MuestraEmpleado<EmpleadoVenta> ME = new MuestraEmpleado<EmpleadoVenta>();
            MessageBox.Show(ME.Mostrar(new EmpleadoVenta("Juan", "Perez")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Genera un error ya que el tipo socio no es un Empleado.
            //MuestraEmpleado<Socio> ME = new MuestraEmpleado<Socio>();
            //MessageBox.Show(ME.Mostrar(new Socio()));
        }
    }
    public class MuestraEmpleado<T> where T : Empleado
    {
        public string Mostrar(T pEmpleado)
        {
            return pEmpleado.Nombre + " " + pEmpleado.Apellido;
        }
    }
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
    public class EmpleadoAdministrativo : Empleado
    { public EmpleadoAdministrativo(string pNombre, string pApellido) { Nombre = pNombre;Apellido = pApellido; } }
    public class EmpleadoVenta : Empleado
    { public EmpleadoVenta(string pNombre, string pApellido) { Nombre = pNombre; Apellido = pApellido; } }
    public class Socio
    { }



}
