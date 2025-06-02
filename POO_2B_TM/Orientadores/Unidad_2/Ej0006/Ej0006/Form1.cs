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

        private void button1_Click(object sender, EventArgs e)
        {
            UsaPunto P = new UsaPunto();
            P.Usar();
        }
    }
    public class Punto
    {
        public int x;
        public int y;
    }
    public class UsaPunto
    {
        public void Usar()
        {
            Punto p = new Punto();
            // Acceso directo a los miembros. CUIDADO: SE PUEDE ESTAR VIOLANDO EL ENCAPSULAMIENTO.
            p.x = 10;
            p.y = 15;
            MessageBox.Show("Los valores de las coordenadas son: x = " + p.x + " - y = " + p.y);
        }
    }
}

