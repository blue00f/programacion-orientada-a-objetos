using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0011
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}
        private void button1_Click(object sender, EventArgs e)
        {
            Persona P = new Persona();
            // Los datos privados de la clase person no son accesibles desde Form1.
            // Intentar hacerlo produciría un error
            //    string N = P.vNombre;
            //    double E = P.vEstatura;
            // 'vNombre' es indirectamente accedido a través del método ObtenerNombre.
            string n = P.ObtenerNombre();
            // 'vEstatura' es indirectamente accedido via la propiedad.
            double s = P.Estatura;
            MessageBox.Show("La persona se llama: " + P.ObtenerNombre() + " y su estatura es: " +
                            P.Estatura.ToString());
        }
    }
    class Persona
    {
        private string vNombre = "Rodriguez, Pablo";
        private double vEstatura = 1.80;
        public string ObtenerNombre()
        {return vNombre;}
        public double Estatura
        {get { return vEstatura; }}
    }
}
