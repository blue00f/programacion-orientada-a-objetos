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

namespace EJ0011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool P;
        // Declaración del Delegado
        public delegate void Delegado(String pTexto);
        // Declaración de la variable D del tipo Delegado (Delegado es un delegate)
        Delegado D1,D2,D3,TodosLosMetodos;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Intanciación. Se denomina así al hecho de asignarle 
            D1 = Metodo1; D2 = Metodo2;D3 = Metodo3;
            TodosLosMetodos = D1 + D2;
            TodosLosMetodos += D3;
           
        }
        public void Metodo1(string pTexto) { MessageBox.Show("EL método 1 se ejecutó y muestra el texto: " + pTexto); }
        public void Metodo2(string pTexto) { MessageBox.Show("EL método 2 se ejecutó y muestra el texto: " + pTexto); }
        public void Metodo3(string pTexto) { MessageBox.Show("EL método 3 se ejecutó y muestra el texto: " + pTexto); }
        private void button2_Click(object sender, EventArgs e)
        {
            TodosLosMetodos -= Metodo1;
            button2.Visible = false;button5.Visible = true;button1_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TodosLosMetodos -= Metodo2;
            button3.Visible = false; button6.Visible = true; button1_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TodosLosMetodos -= Metodo3;
            button4.Visible = false; button7.Visible = true; button1_Click(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TodosLosMetodos += Metodo1;
            button5.Visible = false; button2.Visible = true; button1_Click(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TodosLosMetodos += Metodo2;
            button6.Visible = false; button3.Visible = true; button1_Click(null, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TodosLosMetodos += Metodo3;
            button7.Visible = false; button4.Visible = true; button1_Click(null, null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TodosLosMetodos(Interaction.InputBox("Ingrese Texto: "));
                if(!P){ button2.Visible = true; button3.Visible = true; button4.Visible = true;P = !P; }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }   
}

