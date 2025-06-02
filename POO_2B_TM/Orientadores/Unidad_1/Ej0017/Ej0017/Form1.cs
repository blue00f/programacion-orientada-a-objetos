using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
           int ArgumentoDeSoloLEctura = 44;
            this.EjemploInArgumento(ArgumentoDeSoloLEctura);
            Console.WriteLine(ArgumentoDeSoloLEctura);     // El valor sigue siendo 44        
        }

        private void EjemploInArgumento(in int number)
            {
            int VarInterna = number; //    al ser in puede asignarse
            // La línea de código siguiente da error pues al se in no
            // se le puede asignar valores.
                number = 19;
            }
    }
  
}
