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

namespace Ej0020
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
            ImpuestoComun C = new ImpuestoComun();
            ImpuestoEspecial E = new ImpuestoEspecial();
            C.Importe = decimal.Parse(Interaction.InputBox("Importe para Impuesto Común: "));
            E.Importe = decimal.Parse(Interaction.InputBox("Importe para Impuesto Especial: "));
            MessageBox.Show("Total a pagar Impuesto Común (10%): " + C.TotalAPagar().ToString());
            MessageBox.Show("Total a pagar Impuesto Especial (20% = 1%): " + E.TotalAPagar().ToString());
        }
    }
    abstract class Impuesto
    {
        public decimal Importe { get; set; }
        virtual public decimal ImpuestoEnPesos() { return this.Importe * 0.10m; }
        abstract public decimal TotalAPagar();
    }
    class ImpuestoComun : Impuesto
    {
        override public decimal TotalAPagar()
        {
            return Importe + ImpuestoEnPesos();

        }
    }
        class ImpuestoEspecial : Impuesto
        {
            override public decimal ImpuestoEnPesos() { return this.Importe * 0.20m; }
            private decimal TasaAdicional() { return this.Importe * 0.01m; }
            override public decimal TotalAPagar() { return Importe + ImpuestoEnPesos() + TasaAdicional(); }
        }
    
}
