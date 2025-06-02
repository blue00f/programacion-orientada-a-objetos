using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MotoEspecial M = new MotoEspecial();
        }
    }
    public class Moto
    {
        ~Moto() { MessageBox.Show("Se ha destruido una Moto !!!"); }
    }
    public class MotoEspecial : Moto
    {
        ~MotoEspecial() { MessageBox.Show("Se ha destruido una MotoEspecial !!!"); }
    }
}
