using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_IDisposable
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
        Perro p;
        private void button1_Click(object sender, EventArgs e)
        {
            p = new Perro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p is IDisposable) p.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p = null;
            GC.Collect();
        }
    }

    public class Perro : IDisposable
    {
        bool ejecutoDispose = false;
        public void Dispose()
        {
           MessageBox.Show("Se ejecutó el dispose y se liberan los recursos no administrados !!!");
           ejecutoDispose=true;
        }
        ~Perro( )
        {
            if (!ejecutoDispose) MessageBox.Show("Liberamos los objetos que se liberarían en el dispose ya que el dispose no se ejecutó !!!");
            MessageBox.Show("El finalizador lo ejecutó el GC y libera los recursos administrados !!!");
        }
    }
}
