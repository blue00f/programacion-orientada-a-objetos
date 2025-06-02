using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Contenedor.Contenido VarC = new Contenedor.Contenido();
        }
    }
    public class Contenedor
    {
        void Uso()
        { Contenido C = new Contenido(this); }
        public class Contenido
        {
            Contenedor C;
            public Contenido() { }
            public Contenido(Contenedor pContenedor)
            { C = pContenedor; C.Uso(); }
        }
    }
}
