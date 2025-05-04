using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Clear();
            Persona[] P = { new Persona() { Nombre="Juan",Apellido="Garcia",Edad=22},
                            new Persona() { Nombre="Ana",Apellido="Kardo",Edad=34},
                            new Persona() { Nombre="Cecilia",Apellido="Perez",Edad=29},
                            new Persona() { Nombre="Leonardo",Apellido="Romano",Edad=41}};

            textBox1.Text = "Antes de Ordenar: " + Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox1.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }
            Array.Sort(P);
            textBox1.Text += Environment.NewLine + Environment.NewLine + "Despues de Ordenar: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox1.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
    public class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public int CompareTo(Persona other)
        {
            return String.Compare(this.Nombre, other.Nombre);
        }
    }
}

