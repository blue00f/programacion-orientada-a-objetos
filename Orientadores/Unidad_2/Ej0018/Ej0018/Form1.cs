using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ej0018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Auto A = new Auto();
        Vehiculo V;
        private void Form1_Load(object sender, EventArgs e)
        {
            V = A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A.Marca = Interaction.InputBox("Marca: ");
            A.Modelo = Interaction.InputBox("Modelo: ");
            A.Precio = decimal.Parse(Interaction.InputBox("Precio: "));
            MessageBox.Show("Marca: " + A.Marca + "   Modelo: " + A.Modelo + "    Precio: " + A.Precio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V.
            V.Marca = Interaction.InputBox("Marca: ");
            MessageBox.Show("Marca: " + A.Marca + "   Modelo: " + A.Modelo + "    Precio: " + A.Precio);
        }
    }
    public class Vehiculo
    {
        public string Marca { get; set; }
    }

    public class Auto : Vehiculo
    {
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
    }
}
