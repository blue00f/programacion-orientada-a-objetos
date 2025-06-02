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

namespace EJ0008
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
            var I = new Intercambio();
            var Valor1 = int.Parse(Interaction.InputBox("Valor 1: "));
            var Valor2 = int.Parse(Interaction.InputBox("Valor 2: "));
            MessageBox.Show("Antes de Intercambiar - Valor 1: " + Valor1.ToString() + "   Valor 2: " + Valor2.ToString());      
            I.Ejecutar<int>(ref Valor1,ref Valor2 );
            MessageBox.Show("Después de Intercambiar - Valor 1: " + Valor1.ToString() + "   Valor 2: " + Valor2.ToString());

            var Cadena1 = Interaction.InputBox("Cadena 1: ");
            var Cadena2 = Interaction.InputBox("Cadena 2: ");
            MessageBox.Show("Antes de Intercambiar - Cadena 1: " + Cadena1 + "   Cadena 2: " + Cadena2);
            I.Ejecutar<string>(ref Cadena1,ref Cadena2);
            MessageBox.Show("Después de Intercambiar - Cadena 1: " + Cadena1 + "   Cadena 2: " + Cadena2);
        }
    }

    public class Intercambio
    {
        public void Ejecutar<T>(ref T valor1,ref T valor2)
        {
            T aux = valor1;
            valor1 = valor2;
            valor2 = aux;
        }
    }
}
