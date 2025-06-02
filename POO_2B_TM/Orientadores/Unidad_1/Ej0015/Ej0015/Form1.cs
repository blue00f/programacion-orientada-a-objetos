using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int[] MiArray = { 1, 3, 5 };
            MessageBox.Show("Valor del primer elemento del Array antes de llamar" +
                                     " a la función CambioDeVAlores es: " + MiArray[0]);
            CambioDeValores(MiArray);
            MessageBox.Show("Valor del primer elemento del Array después de llamar" +
                            " a la función CambioDeVAlores es: " + MiArray[0]);
        }
        void CambioDeValores(int[] pArray)
        {
            pArray[0] = 9;  // Este cambio afecta al elemento original.
            pArray = new int[4] { 2, 4, 6, 8};   // Este cambio es local.
            MessageBox.Show("Dentro del método el primer elemento del Array es: " + pArray[0]);
        }
    }
   
}
