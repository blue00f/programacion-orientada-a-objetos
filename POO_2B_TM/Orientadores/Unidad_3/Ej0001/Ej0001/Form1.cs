using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0001
{
    public partial class Form1 : Form
    {
        //Definición  de un Objeto de tipo String
        string G = "Prueba sobre subsistencia de generaciones";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Primera consulta. G es un objeto de generación 0.
            TextBox1.Text = TextBox1.Text + Leyenda() + GC.GetGeneration(G);
            SaltoDeLinea();
        }
        private void SaltoDeLinea()
        {
            TextBox1.Text +=  Environment.NewLine + Environment.NewLine;
        }
        private string Leyenda()
        {
            return "El objeto G es de generación: ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Segunda consulta. G es un objeto de generación 1. Observar que se ejecutó el GC.
            GC.Collect(); GC.WaitForPendingFinalizers();
            TextBox1.Text += Leyenda() + GC.GetGeneration(G);
            SaltoDeLinea();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Tercera consulta. G es un objeto de generación 2. Observar que se ejecutó el GC.
            GC.Collect(); GC.WaitForPendingFinalizers();
            TextBox1.Text += Leyenda() + GC.GetGeneration(G);
            SaltoDeLinea();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // N consulta. G es un objeto de generación 2. Observar que se ejecutó el GC.
            // Observar que la máxima generación es 2.
            GC.Collect(); GC.WaitForPendingFinalizers();
            TextBox1.Text += Leyenda() + GC.GetGeneration(G);
            SaltoDeLinea();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = new char();
        }
        private void TextBox2_Enter(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
