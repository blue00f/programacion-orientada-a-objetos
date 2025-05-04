using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int valor;
            this.EjemploOut(out valor);
            MessageBox.Show("El valor observado es el cargado dentro de " +
                "la función por medio del parámetro out: " + valor.ToString());
        }
        void EjemploOut(out int p)
        {
            p = 55;
        }
    }
}
