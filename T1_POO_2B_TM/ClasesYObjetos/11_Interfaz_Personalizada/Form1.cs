using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazPersonalizada
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
            MetodoConsumePolimorfismo(new Suma());
        }

        private void MetodoConsumePolimorfismo(ICalcular pObjeto)
        {
            textBox3.Text=pObjeto.Ejecutar(Convert.ToDecimal(textBox1.Text),Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodoConsumePolimorfismo(new Resta());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodoConsumePolimorfismo(new Multiplicar());
        }
    }

    public class Suma : ICalcular
    {
        public decimal Ejecutar(decimal n1, decimal n2) =>  n1+n2;
      
    }
    public class Resta : ICalcular
    {
        public decimal Ejecutar(decimal n1, decimal n2) => n1-n2;
        
    }
    public class Multiplicar : ICalcular
    {
        public decimal Ejecutar(decimal n1, decimal n2) => n1 * n2;
    }
    public interface ICalcular
    {
        decimal Ejecutar(decimal n1, decimal n2);      
    }
}
