using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "1000"; textBox2.Text = "250"; textBox3.Text = "";
                textBox5.Text = "1000"; textBox6.Text = "0"; textBox7.Text = "";
                textBox4.Text = "";
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) / int.Parse(textBox6.Text)).ToString();
            }
            catch (DivideByZeroException Ex) when (int.Parse(textBox2.Text)==0) { MuestraError(Ex,"Número 2"); }
            catch (DivideByZeroException Ex) when (int.Parse(textBox6.Text) == 0) { MuestraError(Ex, "Número 4"); }
            catch (Exception Ex) { MuestraError(Ex,"Genérico"); }
            finally
            {
                textBox4.Text += NuevaLinea(1) + "--------------------------" +
                NuevaLinea(1) + "Se ejecutó finally !!!!!!!!";
            }
        }
       
        private string NuevaLinea(int pCantidad)
        {
            string s = "";
            for (int i = 0; i < pCantidad; i++) { s += Environment.NewLine; }
            return s;
        }
        private void MuestraError(Exception pEx,string pTextoAdicional)
        {
            textBox4.Text += "Mensaje: " + pEx.Message + NuevaLinea(2) +
                             "Genetado por: " + pTextoAdicional + NuevaLinea(2) +
                             "Tipo de Error: " + pEx.GetType().ToString() + NuevaLinea(2) +
                             "Origen: " + pEx.Source + NuevaLinea(2) +
                             "Stack: " + pEx.StackTrace + NuevaLinea(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "1000"; textBox2.Text = "0"; textBox3.Text = "";
                textBox5.Text = "1000"; textBox6.Text = "200"; textBox7.Text = "";
                textBox4.Text = "";
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                textBox6.Text = (int.Parse(textBox5.Text) / int.Parse(textBox6.Text)).ToString();
            }
            catch (DivideByZeroException Ex) when (int.Parse(textBox2.Text) == 0) { MuestraError(Ex, "Número 2"); }
            catch (DivideByZeroException Ex) when (int.Parse(textBox6.Text) == 0) { MuestraError(Ex, "Número 4"); }
            catch (Exception Ex) { MuestraError(Ex,"Genérico"); }
            finally
            {
                textBox4.Text += NuevaLinea(1) + "--------------------------" +
                NuevaLinea(1) + "Se ejecutó finally !!!!!!!!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "1000"; textBox2.Text = "150"; textBox3.Text = "";
                textBox5.Text = "1000"; textBox6.Text = "A"; textBox7.Text = "";
                textBox4.Text = "";
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) / int.Parse(textBox6.Text)).ToString();
            }
            catch (DivideByZeroException Ex) when (int.Parse(textBox2.Text) == 0) { MuestraError(Ex, "Número 2"); }
            catch (DivideByZeroException Ex) when (int.Parse(textBox6.Text) == 0) { MuestraError(Ex, "Número 4"); }
            catch (Exception Ex) { MuestraError(Ex, "Genérico"); }
            finally
            {
                textBox4.Text += NuevaLinea(1) + "--------------------------" +
                NuevaLinea(1) + "Se ejecutó finally !!!!!!!!";
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "1000"; textBox2.Text = "A"; textBox3.Text = "";
                textBox5.Text = "1000"; textBox6.Text = "20"; textBox7.Text = "";
                textBox4.Text = "";
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) / int.Parse(textBox6.Text)).ToString();
            }

            catch (DivideByZeroException Ex) when (int.Parse(textBox2.Text) == 0) { MuestraError(Ex, "Número 2"); }
            catch (DivideByZeroException Ex) when (int.Parse(textBox6.Text) == 0) { MuestraError(Ex, "Número 4"); }
            catch (Exception Ex) { MuestraError(Ex, "Genérico"); }
            finally
            {
                textBox4.Text += NuevaLinea(1) + "--------------------------" +
                NuevaLinea(1) + "Se ejecutó finally !!!!!!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "1000"; textBox2.Text = "250"; textBox3.Text = "";
                textBox5.Text = "1000"; textBox6.Text = "20"; textBox7.Text = "";
                textBox4.Text = "";
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) / int.Parse(textBox6.Text)).ToString();

            }
            catch (DivideByZeroException Ex) { MuestraError(Ex,""); }
            catch (Exception Ex) { MuestraError(Ex,""); }
            finally
            {
                textBox4.Text += NuevaLinea(1) + "--------------------------" +
                NuevaLinea(1) + "Se ejecutó finally !!!!!!!!";
            }
        }
    }
}
