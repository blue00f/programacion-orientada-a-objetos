using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClaseDerivada CD;
        private void Form1_Load(object sender, EventArgs e)
        {
            // La siguiente línea de código da error pues no se puede
            // instanciar una clase abstracta
            //ClaseAbstracta CA = new ClaseAbstracta();
            CD= new ClaseDerivada();
        }
        private void button1_Click(object sender, EventArgs e) {CD.Metodo1();}
        private void button2_Click(object sender, EventArgs e) { CD.Metodo2();}
    }
    abstract class ClaseAbstracta
    {
        public void Metodo1() { MessageBox.Show("Se ejecutó el método 1"); }
        public void Metodo2() { MessageBox.Show("Se ejecutó el método 2"); }
    }
    class ClaseDerivada : ClaseAbstracta
    {

    }

}
