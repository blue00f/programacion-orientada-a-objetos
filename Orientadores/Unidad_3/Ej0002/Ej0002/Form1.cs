using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ej0002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        Coche C;
        private void button1_Click(object sender, EventArgs e)
        {
            C = new Coche(new Motor());
            MessageBox.Show("Se instanció un Coche y se le agregó un motor." + Environment.NewLine +
                            "   1. Si oprime 'Ejecutar el Dispose' se libera el motor y evita que se ejecute el Finalizador cuando el GC realice una recolección." + Environment.NewLine +
                            "   2. Si oprime 'Ejecutar el Finalizador' se procede a la recolección de residuos pero no se recolecta Coche pues sigue en uso." + Environment.NewLine +
                            "   3. Si oprime 'Ejecutar el Finalizador' luego de haber oprimido el botón 'Liberar el objeto Coche' se procede a la recolección y se ejecuta el Finalizador de coche.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (C != null && C is IDisposable) { C.Dispose(); };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (C != null) { C = null; MessageBox.Show("Se libero el objeto Coche !!!"); }
        }
    }

    public class Coche : IDisposable
    {

        Motor Vmotor;
        bool UsoDispose = false;
        public Coche(Motor pMotor)
        {
            Vmotor = pMotor;
        }
        // Finalizador
        ~Coche()
        { if (!UsoDispose) { Vmotor = null; MessageBox.Show("Se ejecutó el Finalizador !!!!"); } }

        public void Dispose()
        {
            if (Vmotor != null)
            {
                Vmotor = null;
                UsoDispose = !UsoDispose;
                MessageBox.Show("Se ejecutó el Dispose y se liberó el motor !!!!");
            }
        }
    }
    public class Motor
    { }
}
