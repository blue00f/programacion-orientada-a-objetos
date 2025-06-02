using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Collections.ArrayList lista1 = new System.Collections.ArrayList();
            lista1.Add(3);
            lista1.Add(105);

            System.Collections.ArrayList lista2 = new System.Collections.ArrayList();
            lista2.Add("Programación Orientada a Objetos.");
            lista2.Add("Programación Estructurada.");
        }
    }
}
