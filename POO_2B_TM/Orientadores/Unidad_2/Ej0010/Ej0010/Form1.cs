using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej0010Bis;

namespace Ej0010
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e)
        {
            Test T = new Test();
            // Esto da error del tipo: No accesible por su nivel de protección
            // MessageBox.Show(T.X);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TestUnitario TU = new TestUnitario();
            TU.Ejecutar();
        }
        private void button2_Click(object sender, EventArgs e)
        { Ej0010Bis.Form1 F = new Ej0010Bis.Form1(this); F.Show();} 
    }
    public class TestUnitario : Test
    {   public void Ejecutar()
        {
            TestUnitario T = new TestUnitario();
            T.X = 5;
            MessageBox.Show(T.X.ToString() + " = Valor cargado desde una instancia de TestUnitario" +
                                             " del ensamblado Ej0010 que hereda de Test que se encuentra " +
                                             "en el ensamblado Ej0010Bis. \n\r" +
                                  "Esto se puede realizar debido a que el campo X está marcado como protected");
        }
    }
}
