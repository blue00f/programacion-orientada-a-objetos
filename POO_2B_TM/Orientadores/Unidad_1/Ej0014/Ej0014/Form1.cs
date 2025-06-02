using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0014
{
   
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                PasajePorValor PV = new PasajePorValor();
                int i = 10;
                MessageBox.Show("valor de la variable i que será usada como " +
                                "argumento antes de llamar a la función: " + i);
                PV.RecibeNumero(ref i);
                MessageBox.Show("valor de la variable i después de llamar a la función: " + i);
            }
        }
        class PasajePorValor
        {
            public void RecibeNumero(ref int i)
            {
                MessageBox.Show("valor del parámetro i dentro de la función: " + i);
                i = 20;
                MessageBox.Show("valor del parámetro i luego de asignarle 20 dentro de la función: " + i);
            }
        }
    
}
