using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Moto M = new Moto();
            Application.Exit();
        }
    }
    public class Moto
    {
        //Constructor
        public Moto() { MessageBox.Show("Se ha creado una Moto !!!"); }
        // Finalizador
        ~Moto() { MessageBox.Show("Se ha destruido una Moto !!!"); }
    }
    
}
