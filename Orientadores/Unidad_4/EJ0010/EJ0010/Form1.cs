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

namespace EJ0010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaración del Delegado
        public delegate void Delegado(String pTexto);
        // Declaración de la variable D del tipo Delegado (Delegado es un delegate)
        Delegado D;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Intanciación. Se denomina así al hecho de asignarle 
            D = UsoDelDelegado;
        }
        public void UsoDelDelegado(string pTexto) { MessageBox.Show(pTexto); }
        public void RecibeDelegado(string pS,Delegado pD) { pD(pS); }
        private void button1_Click(object sender, EventArgs e)
        {
            RecibeDelegado(Interaction.InputBox("Ingrese Texto: "), D);

        } 
    }
}
