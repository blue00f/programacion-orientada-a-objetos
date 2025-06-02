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

namespace Ej0019
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
                Cuadrado C = new Cuadrado(int.Parse(Interaction.InputBox("Lado: ")));
                MessageBox.Show("Area del cuadrado: " + C.Area().ToString());
            }
        }
        abstract class Forma
        {
            abstract public int Area();
        }
        class Cuadrado : Forma
        {
            int lado = 0;
            public Cuadrado(int n) { lado = n; }
            // Como Cuadrado hereda de Forma y en Forma está el método abstracto Area
            // Aquí se debe implementar obligatoriamente con override para no generar
            // un error en tiempo de compilación.
            public override int Area() { return lado * lado; }
        }
}

