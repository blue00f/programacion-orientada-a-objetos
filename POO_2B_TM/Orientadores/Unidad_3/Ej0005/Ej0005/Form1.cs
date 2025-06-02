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

namespace Ej0005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cuenta C;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                C = new Cuenta(int.Parse(Interaction.InputBox("Número: ")),
                                         Interaction.InputBox("Descripción: "),
                           decimal.Parse(Interaction.InputBox("Saldo: ")));
            }
            catch (SaldoNegativoException Ex)
            {
                MessageBox.Show("El error es: " + Ex.Message + Environment.NewLine +
                                "Nro. Cuenta: " + Ex.Cuenta.Numero.ToString() + Environment.NewLine +
                                "Descripción: " + Ex.Cuenta.Descripcion + Environment.NewLine + Environment.NewLine +
                                "Saldo: " + Ex.Cuenta.Saldo);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                C.Saldo=decimal.Parse(Interaction.InputBox("Saldo: "));
            }
            catch (SaldoNegativoException Ex)
            {
                MessageBox.Show("El error es: " + Ex.Message + Environment.NewLine + Environment.NewLine +
                                "Nro. Cuenta: " + Ex.Cuenta.Numero.ToString() + Environment.NewLine +
                                "Descripción: " + Ex.Cuenta.Descripcion + Environment.NewLine +
                                "Saldo: " + Ex.Cuenta.Saldo);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
    public class SaldoNegativoException : Exception
    {
        Cuenta Vcuenta;
        public SaldoNegativoException(Cuenta pCuenta)
        { Vcuenta = pCuenta; }
        public Cuenta Cuenta { get { return Vcuenta; } set { Vcuenta = value; } }
        public override string Message => "Error por saldo negativo !!!!";

    }
    public class Cuenta
    {
        decimal Vsaldo;
        public Cuenta(int pNumero, string pDescripcion, decimal pSaldo)
        { Numero = pNumero; Descripcion = pDescripcion;Saldo = pSaldo; }
        
        public int Numero { get; set; }
        public string Descripcion {get;set;}
        public decimal Saldo
        {
            get 
               { return Vsaldo; }
            set
               { Vsaldo = value; if (Vsaldo < 0) throw new SaldoNegativoException(this); }
        }

    }

}
