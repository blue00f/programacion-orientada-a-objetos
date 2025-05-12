using Microsoft.VisualBasic;
using Ejemplo_06.Exceptions;

namespace Ejemplo_06
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
        private int MiFuncion(string pMiValor)
        {
            if (!Information.IsNumeric(pMiValor)) throw new NumeroNoValidoException(pMiValor,this);
            int z = Convert.ToInt16(pMiValor);
            if (z > 10) throw new MayorA10Exception(z,this);
            return z;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x=0;
            try
            {
                var input = Interaction.InputBox("Ingrese un valor para X", "X", "0", 0, 0);
                x= MiFuncion(input);
            }
            catch (NumeroNoValidoException ex)
            { 
                MessageBox.Show($"Ingresó una letra.{Environment.NewLine}{ex.Message}{Environment.NewLine}" +
                                $"Ocurrió en el objeto: {ex.Origen.GetType().Name}"); 
            }
            catch (MayorA10Exception ex) when (x>10 && x<100)
            {
                MessageBox.Show($"ex.Message {Environment.NewLine}" +
                                $"Ocurrió en el objeto: {ex.Origen.GetType().Name}");
            }
            catch (MayorA10Exception ex) when (x > 99)
            {
                MessageBox.Show($"Valor muy peligroso !!!{Environment.NewLine}{ex.Message}{Environment.NewLine}" +
                                $"Ocurrió en el objeto: {ex.Origen.GetType().Name}");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Siempre pasamos por el Finally");
            }
        }
    }


}
