using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // En la línea siguiente se puede observar como intentar instanciar
            // la clase Pi de error debido al nivel de protección que posee la misma
            Pi valor1 = new Pi();
            // En la línea siguiente se observa como se puede obtener el valor de la 
            // propiedad ValorPi.
            double valor2 = Pi.ValorPi;
        }
    }
    class Pi
    {
        // Private Constructor:
        private Pi() { }
        public static double ValorPi = Math.PI;  //3.14159.........
    }
}
