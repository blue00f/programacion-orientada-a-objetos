using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona P = new Persona();
            P[""] = "Juan Martinez";
            MessageBox.Show(P["Director"]);
            MessageBox.Show(P["Director", "Ingeniería"]);
        }
    }
    public class Persona
    {
        string Vnombre = "";
        public string this[string pCargo]
        {
            get { return pCargo + " " + this.Vnombre; }
            set { this.Vnombre = value; }
        }
        public string this[string pCargo, string pDepartamento]
        {
            get { return "Departamento: " + pDepartamento + " - " + pCargo + " " + this.Vnombre; }
            set { this.Vnombre = value; }
        }

    }
}
