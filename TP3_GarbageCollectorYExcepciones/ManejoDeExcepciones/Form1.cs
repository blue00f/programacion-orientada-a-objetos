namespace ManejoDeExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {

            try
            {
                // Primera validaci�n
                int numero = int.Parse(txtNumero.Text);

                // Segunda validaci�n
                int[] numeros = { 10, 20, 30 };
                int indice = int.Parse(txtIndice.Text);
                int valor = numeros[indice];

                // Tercera validaci�n
                int divisor = int.Parse(txtDivisor.Text);
                int res = 10 / divisor;

                // Cuarta validaci�n
                string texto = txtTexto.Text;
                if (string.IsNullOrEmpty(texto)) { texto = null; }
                int longitud = texto.Length;

                // Quinta validaci�n
                int grande = checked(int.Parse(txtNumGrande.Text) * 1000000);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "EXCEPCI�N: FormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "EXCEPCI�N: IndexOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "EXCEPCI�N: DivideByZeroException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "EXCEPCI�N: NullReferenceException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "EXCEPCI�N: OverflowException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("�Proceso finalizado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
