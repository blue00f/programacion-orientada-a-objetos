using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0010Bis
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}
        Form vF;
        public Form1(Form pF) : this() {vF = pF;}
        private void Form1_Load(object sender, EventArgs e)
        {
            Test T = new Test();
            T.X = 25;
            MessageBox.Show(T.X.ToString() + " = Valor cargado desde una instancia de Test que se " +
                                             "encuentra en el mismo ensamblado Ej0010Bis\n\r" +
                                             "Esto se puede realizar porque Test está marcado como internal");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vF.Show();
            vF.Activate();
            this.Close();
        }
    }
    public class Test
    {
        protected internal int X = 10;
    }
}
