using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente MiCliente;
        private void button1_Click(object sender, EventArgs e)
        {
            MiCliente.Nombre = this.textBox1.Text;
            MiCliente.Apellido = this.textBox2.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Nombre es: " + this.textBox1.Text + "\r\nEl Apellido es: " + this.textBox2.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MiCliente = new Cliente();
        }
    }
    public class Cliente
    {
        string Vnombre = "";
        string Vapellido = "";
        public string Nombre { get => this.Vnombre; set => this.Vnombre = value; }
        public string Apellido { get=> this.Vapellido; set=> this.Vapellido=value; }
    }
}
