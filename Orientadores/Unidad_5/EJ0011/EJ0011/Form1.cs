using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0011
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
            var S = "";
            new EjemploLINQ().RetornaPares(new int[] { 1, 2, 3, 4, 5, 6, 7 }).ForEach(X => S += X + " ");
            MessageBox.Show(S + "son  números pares !!!");
        }
    }
    class EjemploLINQ
    {
        public List<int> RetornaPares(int[] pDatos)
        { return (from num in pDatos where (num % 2) == 0 select num).ToList<int>(); }
    }
}
