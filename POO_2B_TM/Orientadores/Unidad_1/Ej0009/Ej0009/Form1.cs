using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0009
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
        public class Persona
        {
            DateTime VfechaDeNacimiento;
            public DateTime FechaDeNacimiento
            {
                set {this.VfechaDeNacimiento = value; }
            }
            public byte Edad
            {
                get
                {
                    byte axo = (byte)this.VfechaDeNacimiento.Year;
                    if (this.VfechaDeNacimiento.DayOfYear <= DateTime.Now.DayOfYear) { axo -= 1; }
                    return(byte)(DateTime.Now.Year - axo);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Persona P = new Persona();
            P.FechaDeNacimiento = DateTime.Parse(this.textBox1.Text);
            MessageBox.Show("La edad es :" + P.Edad.ToString());

        }
    }
}
