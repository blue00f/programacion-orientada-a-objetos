namespace Herencia_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int legajo;
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido está vacio!");
                if (!int.TryParse(txtLegajo.Text, out legajo)) throw new Exception("El legajo no es un número!");

                Cliente p = new Cliente(nombre, apellido, legajo);
                lstClientes.Items.Add(p.MostrarInfo());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
