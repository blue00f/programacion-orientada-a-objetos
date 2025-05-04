using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0023
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
    public class Lugar
    {
        private string Vnombre;
        public Lugar(string pNombre) => Vnombre = pNombre;
        public string Nombre
        {
            get => Vnombre;
            set => Vnombre = value;
        }
    }

}
