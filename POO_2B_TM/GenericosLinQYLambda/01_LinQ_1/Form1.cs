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
using System.Collections;


namespace EJemplo12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaración del delegado.
        delegate bool Dele(string pString);
        delegate IEnumerable<string> Dele2(string[] pArray, int pLimite);
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        IEnumerable<string> FuncPrueba(string[] pArray,int pLimite)
        {
            return pArray.Where(n => n.Length >= pLimite);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dele ejemplodelegado = pCadena => { return pCadena.Length > 6; };
            MessageBox.Show("La cadena ingresada mide más de 6 caracteres: " + 
                            ejemplodelegado(Interaction.InputBox("Ingrese el Texto:")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Nombres = {"Ana","Pedro", "Cecilia", "Guillermo", "Sol", "Ezequiel",
                                "Martin", "María", "Marcelo", "Adriana" };
            Dele2 ejemplodelegado2 = FuncPrueba;
            textBox1.Clear();
            foreach (string S in ejemplodelegado2(Nombres, 
                     int.Parse(Interaction.InputBox("Ingrese la cantidad de caractéres mínima"))))
            {
                textBox1.Text += S + Environment.NewLine;
            }
        }

  
    }
}
