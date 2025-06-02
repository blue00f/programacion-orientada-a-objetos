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

namespace EJ0007
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
            Empleado E1 = new Empleado() { Nombre = "Juan", Jefe = null };
            Empleado E2 = new Empleado() { Nombre = "Pedro", Jefe = E1 };
            Empleado E3 = (Empleado)E2.Clone();
            

            textBox1.Clear();
            textBox1.Text += "E1 es jefe de E2" + Environment.NewLine + Environment.NewLine;
            textBox1.Text += "E1 Nombre: " + E1.Nombre + Environment.NewLine;
            textBox1.Text += "E2 Nombre: " + E2.Nombre + " -  El nombre del Jefe de E2: " + E2.Jefe.Nombre + 
                             Environment.NewLine+Environment.NewLine;
            textBox1.Text += "E3 es un clon de E2" + Environment.NewLine;
            textBox1.Text += "E3 Nombre: " + E3.Nombre + " -  El nombre del Jefe de E3: " + E3.Jefe.Nombre +
                              Environment.NewLine + Environment.NewLine;
            textBox1.Text += "Se procede a cambiarle el nombre al jefe de E3" + Environment.NewLine;
            E3.Jefe.Nombre = Interaction.InputBox("Ingrese el nuevo nombre para el jefe de E3: ") + Environment.NewLine;
            textBox1.Text += "E3 Nombre: " + E3.Nombre + " -  El nombre del Jefe de E3: " + E3.Jefe.Nombre +
                             Environment.NewLine + Environment.NewLine;
            textBox1.Text += "Se procede a cambiarle el nombre a E3" + Environment.NewLine;
            E3.Nombre = Interaction.InputBox("Ingrese el nuevo nombre para E3: ");
            textBox1.Text += "E3 Nombre: " + E3.Nombre + " -  El nombre del Jefe de E3: " + E3.Jefe.Nombre +
                             Environment.NewLine + Environment.NewLine;
            textBox1.Text += "Observar a continuación lo que ocurrió. El nombre de E2 se ha conservado a pesar de " +
                             "haber cambiado el nombre de E3 Sin embargo el cambio del nombre del jefe de E3 afectó el " +
                             "nombre del jefe de E2." + Environment.NewLine + Environment.NewLine;
            textBox1.Text += "E2 Nombre: " + E2.Nombre + " -  El nombre del Jefe de E2: " + E2.Jefe.Nombre +
                            Environment.NewLine + Environment.NewLine;
            textBox1.Text += "Esto es debido a que la clonación realizada es superficial. " +
                             "Se puede solucionar esto con una clonación profunda." + Environment.NewLine;      
        }
    }
    public class Empleado : ICloneable
    {
        public string Nombre { get; set; }
        public Empleado Jefe { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
