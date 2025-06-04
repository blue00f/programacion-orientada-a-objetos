using Microsoft.VisualBasic;

namespace ExcepcionPersonalizada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Ingrese el código con el formato (A123):", "Ingreso cliente").ToUpper();
                if (!Cliente.ValidaFormatoCodigo(codigo)) throw new FormatoErroneoCodigoException(codigo);
                string nombre = Interaction.InputBox("Ingrese el nombre: ", "Ingreso cliente");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");
                string apellido = Interaction.InputBox("Ingrese el apellido: ", "Ingreso cliente");
                if (apellido.Length == 0) throw new Exception("El apellido está vacio!");

                Cliente c = new(codigo, nombre, apellido);
                MessageBox.Show(c.ToString(), "Datos del cliente ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatoErroneoCodigoException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("¡Ingreso finalizado!", "Ejecución de Finally", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
