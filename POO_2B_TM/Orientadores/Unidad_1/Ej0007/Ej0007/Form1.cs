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

        private void button1_Click(object sender, EventArgs e)
        {
            Reloj R = new Reloj();
            R.Horas = int.Parse(this.textBox1.Text);
            this.textBox2.Text = (R.Horas * 3600).ToString();
        }
    }
    public class Reloj
    {
        int Vhoras = 0;
        public int Horas
        {
            get { return this.Vhoras;}
            set {
                    if (value < 0 || value > 24)
                    { MessageBox.Show("La hora debe ser mayor a 0 y menor a 24 !!!"); }
                    else
                    { this.Vhoras = value; }
                }
        }
    }
}
