using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calculo C = new Calculo();
            MessageBox.Show(C.Sumar(3, 5).ToString());
            MessageBox.Show(C.Sumar(3.5, 5.4).ToString());
            MessageBox.Show(C.Sumar(new int[] { 2, 4, 6, 8 }).ToString());
        }
    }
    public class Calculo
    {
        public int Sumar(int n1, int n2) { return n1 + n2; }
        public double Sumar(double n1, double n2) { return n1 + n2; }
        public int Sumar(int[] n)
        {int r = 0; foreach (int x in n) { r += x; } return r; }
    }
}
