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

namespace Ej0003
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
        }
        private void FuncionCambioEnNombre(object sender, DatosCambioEnNombreEventArgs e)
        {
            MessageBox.Show("Se produjo un cambio en el nombre, ahora es: " + e.Nombre + "\n\r" +
                            "El evento se desencadenó a las: " + e.HoraEvento);
        }
    }
    public class Alumno
    {
        public event EventHandler <DatosCambioEnNombreEventArgs> CambioEnNombre;
        private string Vnombre = "";
        public string Nombre
        {
            get { return Vnombre; }
            set
            {
                this.Vnombre = value;
                CambioEnNombre?.Invoke(this, new DatosCambioEnNombreEventArgs(this.Nombre));
            }
        }
    }
    public class DatosCambioEnNombreEventArgs : EventArgs
    {
       private string vNombre = "";
        private string vHora = "";
       public DatosCambioEnNombreEventArgs(string pNombre)
        {
            this.vNombre = pNombre;
            this.vHora = DateTime.Now.ToShortTimeString();
        }
        public string Nombre { get { return this.vNombre; }}
        public string HoraEvento { get { return this.vHora; }}     
    }

}
