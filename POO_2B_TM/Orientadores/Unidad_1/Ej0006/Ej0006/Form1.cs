using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0006
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
    }
    public class Cliente

    {
        string Vnombre = "";
        string Vapellido = "";
        public string Nombre
        {
            get { return this.Vnombre; }
            set { this.Vnombre = value; }
        }
        public string Apellido
        {
            get { return this.Vapellido; }
            set { this.Vapellido = value; }
        }
    }
}
