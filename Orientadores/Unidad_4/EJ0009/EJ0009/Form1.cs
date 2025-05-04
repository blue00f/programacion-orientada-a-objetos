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

namespace EJ0009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaración del Delegado
        public delegate string Delegado(String pTexto);
        // Declaración de la variable D del tipo Delegado (Delegado es un delegate)
        Delegado D;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Intanciación. Se denomina así al hecho de asignarle 
            D = UsoDelDelegado;
        }
        public string UsoDelDelegado(string pTexto) { MessageBox.Show("1" + pTexto); return pTexto; }
        private void button1_Click(object sender, EventArgs e)
        {
            // llamada al Delegado.
            MessageBox.Show(D(Interaction.InputBox("Ingrese un Texto: ")));
        }
    }
}
