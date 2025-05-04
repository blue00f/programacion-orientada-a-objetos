using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0028
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
    public class Radio
    {
        public Radio() { }
        public Radio(string pNombrePrograma) { }
        public Radio(string pNombrePrograma, bool pGrabar) { }
    }
    public class Potencia
    {
        public Potencia(int pBase,int pPotencia) { }
        public Potencia(decimal pBase, int pPotencia) { }
        public Potencia(double pBase, int pPotencia) { }
    }
}
