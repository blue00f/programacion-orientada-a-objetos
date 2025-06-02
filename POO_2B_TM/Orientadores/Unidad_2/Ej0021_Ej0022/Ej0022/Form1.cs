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

namespace Ej0022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }
        private void CalculaDescuento(Producto P)
        {
            P.Precio=decimal.Parse(Interaction.InputBox("Ingrese el precio del producto nacional: "));
            MessageBox.Show("El precio sin descuento es: " + P.Precio + "\n" +
                            "El precio con descuento es: " + P.PrecioConDescuento().ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }       

        private void button1_Click(object sender, EventArgs e)
        {       
            this.CalculaDescuento( new ProductoNacional());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CalculaDescuento(new ProductoImportado());
        }
    }
    abstract public class Producto
    {   public decimal Precio { get; set; }
        abstract public decimal PrecioConDescuento();
    }  
    public class ProductoNacional : Producto
    {
        public override decimal PrecioConDescuento()
        {
            return this.Precio * 0.90m;
        }
    }
    public class ProductoImportado : Producto
    {
        public override decimal PrecioConDescuento()
        {
            return this.Precio * 0.80m;
        }
    }

}
