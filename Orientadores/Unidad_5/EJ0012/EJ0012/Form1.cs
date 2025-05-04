using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cliente> C = new List<Cliente>();
        List<Distribuidor> D = new List<Distribuidor>();

        private void Form1_Load(object sender, EventArgs e)
        {
            C.AddRange(new Cliente[] {new Cliente("Sol", "Fernandez", "Internacional"),
                                      new Cliente("Juan", "Perez","Nacional"),
                                      new Cliente("Ariel", "Garcia","Nacional"),
                                      new Cliente("Cecilia","Costa","Internacional"),
                                      new Cliente("Ana", "Martinez", "Nacional"),});

            D.AddRange(new Distribuidor[] { new Distribuidor("Distribuidora Tex","Nacional"),
                                            new Distribuidor("Distribuidora InterTex","Internacional")});

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var T = from cli in C select cli;
            foreach (Cliente Z in T.ToList<Cliente>())
            {
                this.listBox1.Items.Add(Z.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var T = from cli in C where cli.Tipo=="Nacional" select cli;
            foreach (Cliente Z in T.ToList<Cliente>())
            {
                this.listBox2.Items.Add(Z.ToString());
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            var T = from cli in C where cli.Tipo == "Nacional" && cli.Nombre[0]=='A' select cli;
            foreach (Cliente Z in T.ToList<Cliente>())
            {
                this.listBox3.Items.Add(Z.ToString());
            }
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
             var T = from cli in C orderby cli.Apellido ascending select cli;
            foreach (Cliente Z in T.ToList<Cliente>())
            {
                this.listBox4.Items.Add(Z.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var T = from cli in C group cli by cli.Tipo;
    
            // customerGroup is an IGrouping<string, Customer>
            foreach (var GrupoClientes in T)
            {
                this.listBox5.Items.Add(GrupoClientes.Key);
                foreach (var Cliente in GrupoClientes)
                {
                    this.listBox5.Items.Add("   " + Cliente.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var JoinCD = from cli in C join dis in D on cli.Tipo equals dis.Tipo
                         select new { Cliente = cli.ToString(), Distribuidor = dis.Nombre };
            foreach (var Z in JoinCD.ToList())
            {
                this.listBox6.Items.Add(Z.Cliente + " " + Z.Distribuidor);
            }
        }
    }
    public class Cliente
    {
        public Cliente(string pNombre, string pApellido, string pTipo)
        {
            Nombre = pNombre;Apellido = pApellido;Tipo = pTipo;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + Tipo;
        }
    }
    public class Distribuidor
    {
        public Distribuidor(string pNombre, string pTipo) { Nombre = pNombre;Tipo = pTipo; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

    }
}
