using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ej0002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Alumno A;
        private void Form1_Load(object sender, EventArgs e)
        {
            A = new Alumno();
            // Suscripción al Evento
            A.CambioEnNombre += FuncionCambioEnNombre;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            A.Nombre = Interaction.InputBox("Ingrese el Nombre:");
            // Cancelación a la suscripción al evento
            A.CambioEnNombre -= FuncionCambioEnNombre;
        }
        private void FuncionCambioEnNombre(object sender, EventArgs e)
        {
            MessageBox.Show("Se produjo un cambio en el nombre, ahora es: " + A.Nombre);
        }

    }
    public class Alumno
    {
        public event EventHandler CambioEnNombre;
        private string Vnombre = "";
        public string Nombre
        {
            get { return Vnombre; }
            set
            {
                this.Vnombre = value;
                CambioEnNombre?.Invoke(this,null);
            }
        }
    }
}
