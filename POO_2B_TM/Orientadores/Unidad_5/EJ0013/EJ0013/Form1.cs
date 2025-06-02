using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cliente> C = new List<Cliente>();
        List<Proveedor> P = new List<Proveedor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            C.AddRange(new Cliente[] {new Cliente("Sol", "Fernandez", "Colegiales"),
                                      new Cliente("Juan", "Perez","Saavedra"),
                                      new Cliente("Ariel", "Garcia","Colegiales"),
                                      new Cliente("Cecilia","Costa","Nuñez"),
                                      new Cliente("Ana", "Martinez", "Belgrano"),});

            P.AddRange(new Proveedor[] { new Proveedor("Distribuidora Tex","Saavedra"),
                                         new Proveedor("Distribuidora InterTex","Nuñez")});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Resultado = (from cli in C where cli.Localidad == "Saavedra" select cli.ToString())
                     .Concat(from pro in P where pro.Localidad == "Saavedra" select pro.Nombre);
            foreach (var p in Resultado)
            {
                this.listBox1.Items.Add(p);
            }

        }
    }
    public class Cliente
    {
        public Cliente(string pNombre, string pApellido, string pLocalidad)
        {
            Nombre = pNombre; Apellido = pApellido; Localidad = pLocalidad;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Localidad { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
    public class Proveedor
    {
        public Proveedor(string pNombre, string pLocalidad) { Nombre = pNombre; Localidad = pLocalidad; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }

    }
}
