using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lista genérica donde se le hace explísito que tipo de dato contendrá
            // colocando List<int>
            List<int> lista = new List<int>();

            // No se procede a la operación de Boxing, debido a que internamente la lista administra int
            lista.Add(3);

            // Error en tiempo de compilación que indica que no se puede ingresar un string a la lista de enteros
            lista.Add("Programación Orientada a Objetos.");
        }
    }
}
