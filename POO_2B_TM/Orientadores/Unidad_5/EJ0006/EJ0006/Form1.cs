using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0006
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
            ClaseGenerica<int> G = new ClaseGenerica<int>(4);
            G.MetodoGenerico(10);
            G.PropiedadGenerica = 20;
            MessageBox.Show("La propiedad posee el valor: " + G.PropiedadGenerica);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseGenerica<string> G = new ClaseGenerica<string>("Valor 1");
            G.MetodoGenerico("Valor 2");
            G.PropiedadGenerica = "Valor 3";
            MessageBox.Show("La propiedad posee el valor: " + G.PropiedadGenerica);
        }
    }
    class ClaseGenerica<T>
    {
        private T CampoGenerico;

        public ClaseGenerica(T value)
        {
            CampoGenerico = value;
        }
        public void MetodoGenerico(T pGenerico)
        {
            MessageBox.Show("El constructor recibió el valor: " + CampoGenerico);
            MessageBox.Show("Tipo de Parámetro: " + typeof(T).ToString() + "   " + pGenerico);     
        }
        public T PropiedadGenerica { get; set; }
    }
}
