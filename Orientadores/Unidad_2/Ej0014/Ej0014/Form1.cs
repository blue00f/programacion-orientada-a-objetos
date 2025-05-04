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

        }
        ClaseSellada CS = new ClaseSellada();
        private void button1_Click(object sender, EventArgs e)
        {
            CS.Metodo1();
        }
    }
    sealed class ClaseSellada
    {
        public void Metodo1() { MessageBox.Show("Se ejecutó el Método 1 !!!"); }
    }
    class Derivada : ClaseSellada
    { }
}
