using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente> { new Cliente("Juan", "Londres"),
                                                         new Cliente("María","Madrid"),
                                                         new Cliente("Mariana","Buenos Aires"),
                                                         new Cliente("Pedro","Buenos Aires") };
            IEnumerable<string> Z = from C in clientes where C.Ciudad == "Buenos Aires" select C.Nombre ;
            foreach (string S in Z)
            {
                this.listBox1.Items.Add(S);
            }
        }
    }
    public class Cliente
    {
        public Cliente(string pNombre, string pCiudad) { Nombre = pNombre; Ciudad = pCiudad; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
    }
}
