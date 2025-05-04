using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
        List<Producto> _ListaProducto = new List<Producto>();
        private void button1_Click(object sender, EventArgs e)
        {
            _ListaProducto.AddRange( new Producto[] { new Producto() { Codigo = 1, Descripcion = "Tuerca", EAN13 = "7791234567895" },
                                                      new Producto() { Codigo = 2, Descripcion = "Arandela", EAN13 = "7793654098716" },
                                                      new Producto() { Codigo = 3, Descripcion = "Tornillo", EAN13 = "7798258013769" }});
            textBox1.Clear();
            foreach (Producto P in _ListaProducto)
            {   foreach (string S in P) { textBox1.Text += S + Environment.NewLine;}
                textBox1.Text+=Environment.NewLine;
            }
        }

       
    }

    public class Producto : IEnumerator, IEnumerable
    {
        string _Current = "";
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string EAN13 { get; set; }
        public object Current => _Current;
        static int c = 0;
        bool r = false;
        public bool MoveNext()
        {
            if (c == 0) { _Current = "País: " + EAN13.Substring(0, 3); r = true; c++; }
            else if (c == 1) { _Current = "Empresa: " + EAN13.Substring(3, 4); r = true; c++; }
            else if (c == 2) { _Current = "Producto: " + EAN13.Substring(6, 5); r = true; c++; }
            else if (c == 3) { _Current = "Dígito Verificador: " + EAN13.Substring(12, 1); r = true; c++; }
            else { Reset(); }
            return r;
        }
        public void Reset() { c = 0;r = false; _Current = ""; }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }

}
