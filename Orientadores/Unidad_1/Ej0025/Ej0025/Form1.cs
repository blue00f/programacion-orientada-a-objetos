using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0025
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e)
        {
            Empleado Ve = new Empleado("Juan","Perez","L0001");
            MessageBox.Show(Ve.Datos());
            Application.Exit();
        }
    }
    public class Persona
    {
        string Vnombre = "";
        string Vapellido = "";
        public Persona(string pNombre, string pApellido)
        { this.Vnombre = pNombre; this.Vapellido = pApellido; }
        public string Nombre { get { return this.Vnombre; }  set { this.Vnombre = value; } }
        public string Apellido { get { return this.Vapellido; } set { this.Vapellido = value; } }
    } 
    public class Empleado : Persona
    {
        string Vlegajo = "";
        public Empleado(string pNombre, string pApellido,string pLegajo) 
            : base(pNombre, pApellido) { this.Vlegajo = pLegajo; }
        public string Legajo { get { return this.Vlegajo; } set { this.Vlegajo = value; } }
        public string Datos() { return "Legajo: " + this.Legajo + "\nNombre: " + this.Nombre + 
                                       "\nApellido: " + this.Apellido; }
    }

    
}
