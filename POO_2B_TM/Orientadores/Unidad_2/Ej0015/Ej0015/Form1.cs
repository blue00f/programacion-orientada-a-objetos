using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClaseNoEstatica CNE = new ClaseNoEstatica();
        private void Form1_Load(object sender, EventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {
            // Acceso al campo estático X de la clase ClaseNoEstatica.
            // Se accede al campo X a través del nombre de la clase por ser X estática 
            MessageBox.Show(ClaseNoEstatica.X.ToString());
            // Se accede al campo Y a través de la instancia CNE pues Y no es estática
            MessageBox.Show(CNE.Y.ToString());
            // Se accede al campo Z a través del nombre de la clase, pues la clase es 
            // estática y el campo también.
            MessageBox.Show(ClaseEstatica.Z.ToString());
            // La clase ClaseEstatica no se puede instanciar. En caso de hacerlo dará 
            // un error
            //ClaseEstatica CE = new ClaseEstatica();
        }
    }
    static class ClaseEstatica
    {static public int Z = 30;}
    class ClaseNoEstatica
    {
     static public int X = 10;
     public int Y = 20;
    }
}
