using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Auto A = new Auto();
            A.Consumo( 245, 120);
        }
    }
    class Auto
    {    
        public void Arranque()
        {/* Aquí se coloca el cóodigo del método */ }

        public void CargaDeCombustible(int litros)
        { /* Aquí se coloca el cóodigo del método */ }

        public  int Consumo(int km, int velocidad)
        { /* Aquí se coloca el cóodigo del método */ return 1; }
    }
}
