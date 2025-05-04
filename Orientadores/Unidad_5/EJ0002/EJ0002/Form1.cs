using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Collections.ArrayList lista = new System.Collections.ArrayList();
            // Se agrega un entero a la lista.
            lista.Add(3);
            //Se agrega un string a la lista.
            lista.Add("Programación Orientada a Objetos.");

            int t = 0;
            // se causa un excepción de cambio de tipo al tratar de operar t+=x si x es un string.
            foreach (int x in lista)
            {
                t += x;
            }
        }
    }
}
