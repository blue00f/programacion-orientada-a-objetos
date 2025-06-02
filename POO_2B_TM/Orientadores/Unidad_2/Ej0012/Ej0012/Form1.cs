using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0012
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show((new ClaseDerivada()).Acceder().ToString());
            Application.Exit();
        }
    }
    public class ClaseBase
    {
        private protected int X = 0;
    }
    public class ClaseDerivada : ClaseBase
    {
        public int Acceder()
        {
            ClaseBase ObjetoBase = new ClaseBase();
            // Error CS1540, porque es privado de ClaseBase y no se puede acceder desde la interfaz ClaseBase. 
            // ObjetoBase.X = 5;  
            // OK, se puede acceder directamente desde ClaseDerivada porque es una sub clase de ClaseBAse
            X = 5;
            return X;
        }
    }

    
}
