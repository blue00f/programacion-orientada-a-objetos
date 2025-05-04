using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0009
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
         
            int[] Vnumeros = new int [7] { 1, 2, 3, 4, 5, 6, 7 };
            var ELQ = new EjemploLINQ(Vnumeros);
            string[] Vpares = ELQ.RetornaPares();
            this.listBox1.Items.Clear(); this.listBox1.Items.AddRange(Vpares);
        }
    }
    class EjemploLINQ
    {
        IEnumerable<int> Vquery;
        private int[] numeros;
        public EjemploLINQ(int[] pDatos)
        {
        // Las tres partes de una consulta LinQ:
        //  1. Origen de Datos.
            numeros = pDatos;
        //  2. Creación de la consulta.
                Vquery =
                from num in numeros
                where (num % 2) == 0
                select num; 
        }  
        public string[] RetornaPares()
        {
            // 3. Ejecución de la consulta.
            string numerosRetorno="";
            foreach (int num in Vquery)
            {
                numerosRetorno += num + ",";
            }
            numerosRetorno = numerosRetorno.Substring(0, numerosRetorno.Length - 1);
            char[] S = { ',' };
            return numerosRetorno.Split(S);
        }
        
    }

}
