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

namespace Ej0025
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            Alumno A = new Alumno(Interaction.InputBox("Ingrese el nombre del alumno: "));
            Libro L = new Libro(Interaction.InputBox("Ingrese el título del libro: "),
                                Interaction.InputBox("Ingrese el contenido del libro: "));
            MessageBox.Show("El Alumno " + A.Nombre + " ha leido el libro '" + L.Titulo + "'" +
                "\n\nCuyo contenido es: " + A.Lee(L));
        }
    }


    public class Alumno
    {
        private string Vnombre;
        public Alumno(string pNombre) {this.Vnombre = pNombre;}
        public string Nombre { get { return this.Vnombre; } }
        public string Lee(Libro pLibro) { return pLibro.Contenido;}
    }
    public class Libro
    {
        private string Vcontenido;
        private string Vtitulo;
        public Libro(string pTitulo, string pContenido)
        {this.Vcontenido = pContenido; this.Vtitulo = pTitulo;}
        public string Contenido { get { return this.Vcontenido; } }
        public string Titulo { get { return this.Vtitulo; } }
    }
}
