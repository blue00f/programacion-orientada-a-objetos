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


namespace Ej0024
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        Maquina M =null;
        private void button1_Click(object sender, EventArgs e)
        {M = new Maquina(); }
        private void button2_Click(object sender, EventArgs e)
        { M.Dispose();}
        private void button3_Click(object sender, EventArgs e)
        {M.Procesar();}   
    }
    public class Maquina: IDisposable
    {
        private Entrada E = null;
        private Proceso P = null;
        private Salida S = null;
        private Boolean SeUsoDispose = false;
        public Maquina() 
        {
            //Constructor donde se instancian los agregados
            E = new Entrada(decimal.Parse(Interaction.InputBox("Cantidad ingresada de cobre en Kg: ")),
                          decimal.Parse(Interaction.InputBox("Cantidad ingresada de estaño en Kg: ")));
            P = new Proceso();
            S = new Salida();
            MessageBox.Show("Se han creado los objetos Entrada, Proceso y Salida !!!");
        }
        public void Procesar()
        {
            P.ProducirBronce(E);
            S.VerResultados(P);
        }
        public void Dispose()
        {
            //Finalizador que puede ser llamado por el usuario. El mismo rompe la composición
            this.E = null; this.P = null; this.S = null;
            MessageBox.Show("Dispose: Se han destruido los objetos Entrada, Proceso y Salida !!!");
            this.SeUsoDispose = true;
        }
        ~Maquina()
        {
            //Finalizador que es llamdo por el Garbage Colector. El mismo rompe la composición en caso que no se 
            //haya roto por el llamado al Dispose
            if (!this.SeUsoDispose)
            {
                this.E = null; this.P = null; this.S = null;
                MessageBox.Show("Garbage Collector: Se han destruido los objetos Entrada, Proceso y Salida !!!");
            }
        }
    }
    public class Entrada
    {
        private decimal VCantidadCobreKg = 0;
        private decimal VCantidadEstanoKg = 0;
        public Entrada(decimal pCantidadCobreKg, decimal pCantidadEstanoKg)
                { this.CantidadCobreKg = pCantidadCobreKg; this.CantidadEstanoKg = pCantidadEstanoKg; }
        public decimal CantidadCobreKg
        {
            get { return VCantidadCobreKg; }
            set {
                if (value < 1) { MessageBox.Show("La cantidad debe ser mayor a 1 Kg"); }
                else { this.VCantidadCobreKg = value; }
                }
        }
        public decimal CantidadEstanoKg
        {
            get { return VCantidadEstanoKg; }
            set
            {
                if (value < 1) { MessageBox.Show("La cantidad debe ser mayor a 1 Kg"); }
                else { this.VCantidadEstanoKg = value; }
            }
        }
    }
    public class Proceso
    {
        decimal VQCobre = 0;
        decimal VQEstano = 0;
        decimal VQBronce = 0;
        public decimal SobranteCobre
        { get { return VQCobre; } }
        public decimal SobranteEstano
        { get { return VQEstano; } }
        public decimal BronceProducido
        { get { return VQBronce; } }
        public void ProducirBronce(Entrada pEntrada)
        {
            if (pEntrada.CantidadCobreKg < 1 || pEntrada.CantidadEstanoKg < 1)
            { MessageBox.Show("Alguna o ambas cantidades de los metales de ingreso es menor a 1 !!!"); }
            else
            {
                this.VQCobre = pEntrada.CantidadCobreKg;
                this.VQEstano = pEntrada.CantidadEstanoKg;
                while (VQCobre >= 1)
                {
                    if (VQEstano >= 9) { VQBronce++; VQCobre--; VQEstano -= 9; }
                    else {break;}
                }
            }
        }
    }
    public class Salida
    {    
        public void VerResultados(Proceso pProceso)
        {
            MessageBox.Show("El bronce producido es: " + pProceso.BronceProducido + " Kg\n" +
                            "Cobre sobrante: " + pProceso.SobranteCobre + " Kg\n" +
                            "Estaño sobrante: " + pProceso.SobranteEstano + " Kg");
        }
    }
}
