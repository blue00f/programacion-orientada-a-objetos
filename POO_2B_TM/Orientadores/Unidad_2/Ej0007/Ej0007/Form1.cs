using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            PuntoDerivada P = new PuntoDerivada();
            P.Usar();
        }
    }
    public class Punto
    {
        protected int x;
        protected int y;
    }
    public class PuntoDerivada : Punto
    {
        public void Usar()
        {
            PuntoDerivada p = new PuntoDerivada();
            // Acceso a los miembros declarados como PROTECTED en la super clase.
            p.x = 10;
            p.y = 15;
            MessageBox.Show("Los valores de las coordenadas son: x = " + p.x + " - y = " + p.y);
        }
    }
}
