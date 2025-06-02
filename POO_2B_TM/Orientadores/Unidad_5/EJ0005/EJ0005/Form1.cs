using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0005
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
    }

    class ClaseBaseGenerica<T> { }
    
    // Correcto
    class NodoA : ClaseBaseGenerica<int> { }

    // Genera un eror donde indica que T no se encontró.
    class NodoB :ClaseBaseGenerica<T> {}

    //Generates an error
    //class NodoC : T {}
}
