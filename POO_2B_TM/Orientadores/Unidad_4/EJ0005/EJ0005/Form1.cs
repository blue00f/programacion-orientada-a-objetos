using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0005
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false;
            textBox5.Enabled = false; textBox6.Enabled = false; textBox7.Enabled = false;
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            Persona[] P = { new Persona() { Nombre="Juan",Apellido="Garcia",Edad=22},
                            new Persona() { Nombre="Ana",Apellido="Kardo",Edad=34},
                            new Persona() { Nombre="Cecilia",Apellido="Perez",Edad=29},
                            new Persona() { Nombre="Leonardo",Apellido="Romano",Edad=41}};

            textBox1.Text = "Antes de Ordenar: " + Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox1.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }

            Array.Sort(P, new Persona.NombreAsc());
            textBox2.Text += Environment.NewLine + Environment.NewLine + "Orden por Nombre ASC: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox2.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }

            Array.Sort(P, new Persona.NombreDesc());
            textBox3.Text += Environment.NewLine + Environment.NewLine + "Orden por Nombre DESC: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox3.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }

            Array.Sort(P, new Persona.ApellidoAsc());
            textBox4.Text += Environment.NewLine + Environment.NewLine + "Orden por Apellido ASC: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox4.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }

            Array.Sort(P, new Persona.ApellidoDesc());
            textBox5.Text += Environment.NewLine + Environment.NewLine + "Orden por Apellido DESC: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox5.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }

            Array.Sort(P, new Persona.EdadAsc());
            textBox6.Text += Environment.NewLine + Environment.NewLine + "Orden por Edad ASC: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox6.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }

            Array.Sort(P, new Persona.EdadDesc());
            textBox7.Text += Environment.NewLine + Environment.NewLine + "Orden por Edad DESC: " +
                             Environment.NewLine + Environment.NewLine;
            foreach (Persona xP in P)
            { textBox7.Text += "\t" + xP.Nombre + "\t" + xP.Apellido + "\t" + xP.Edad.ToString() + Environment.NewLine; }
        }
        public class Persona
        {   public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public class NombreAsc : IComparer<Persona>
                {public int Compare(Persona x, Persona y){ return String.Compare(x.Nombre, y.Nombre); }}
            public class NombreDesc : IComparer<Persona>
                {public int Compare(Persona x, Persona y){ return String.Compare(x.Nombre, y.Nombre) * -1; }}
            public class ApellidoAsc : IComparer<Persona>
                { public int Compare(Persona x, Persona y){ return String.Compare(x.Apellido, y.Apellido); }}
            public class ApellidoDesc : IComparer<Persona>
                {public int Compare(Persona x, Persona y) { return String.Compare(x.Apellido, y.Apellido) * -1;}}
            public class EdadAsc : IComparer<Persona>
                {public int Compare(Persona x, Persona y)
                    {
                        int rdo = 0;
                        if (x.Edad < y.Edad) rdo = -1;
                        if (x.Edad == y.Edad) rdo = 0;
                        if (x.Edad > y.Edad) rdo = 1;
                        return rdo;
                    }
                }
            public class EdadDesc : IComparer<Persona>
                {public int Compare(Persona x, Persona y)
                    {
                        int rdo = 0;
                        if (x.Edad < y.Edad) rdo = -1;
                        if (x.Edad == y.Edad) rdo = 0;
                        if (x.Edad > y.Edad) rdo = 1;
                        return rdo * -1;
                    }
                }
        }
    }
}
