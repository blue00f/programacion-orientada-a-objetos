using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0016
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
        private void button1_Click(object sender, EventArgs e)
        {
            ClaseDerivada CD = new ClaseDerivada();
            // Consume el campo B heredado a la clase derivada a través del método Bderivada.
            MessageBox.Show(CD.Bderivada());
            // Consume el campo B desde la clase derivada a través del método Bderivada2 accediendo 
            // a la clase base.
            MessageBox.Show(CD.Bderivada2());
            // Consume el campo C heredado a la clase derivada a través del método Cderivada.
            MessageBox.Show(CD.Cderivada());
            // Consume el campo C desde la clase derivada a través del método Cderivada2 accediendo 
            // a la clase base.
            MessageBox.Show(CD.Cderivada2());
            // Consume el campo D heredado a la clase derivada a través del método Dderivada.
            MessageBox.Show(CD.Dderivada());
            // Consume el campo D desde la clase derivada a través del método Dderivada2 accediendo 
            // a la clase base.
            MessageBox.Show(CD.Dderivada2());
            // Consume el campo C heredado de la clase base.
            MessageBox.Show(CD.C);
            // Consume el campo D heredado de la clase base.
            MessageBox.Show(CD.D);
        }
    }
    public class ClaseBase
    {
        public ClaseBase() { MessageBox.Show("Constructor de ClaseBase"); }
        private string A = "Miembro private A";
        protected string B = "Miembro Protected B";
        internal string C = "Miembro  internal C";
        public string D = "Miembro public D";

    }
    public class ClaseDerivada : ClaseBase
    {
        public ClaseDerivada() : base()
        { MessageBox.Show("Constructor de ClaseDerivada"); }
        public string Bderivada() {return this.B; }
        public string Bderivada2() { return base.B; }
        public string Cderivada() { return this.C; }
        public string Cderivada2() { return base.C; }
        public string Dderivada() { return this.D; }
        public string Dderivada2() { return base.D; }
    }
}
