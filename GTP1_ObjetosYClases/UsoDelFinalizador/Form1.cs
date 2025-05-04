using UsoDelFinalizador;

namespace UsoDelFinalizador
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clientes = new List<Cliente>();
            dgvClientes.Rows.Clear();
            dgvClientes.MultiSelect = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Mostrar()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
        }
        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                if (nombre.Length == 0) throw new Exception("El nombre no debe estar vacio");
                if (apellido.Length == 0) throw new Exception("El apellido no debe estar vacio");

                Cliente c = new Cliente(nombre, apellido, fechaNacimiento);
                clientes.Add(c);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDestruirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.Rows.Count == 0) throw new Exception("No hay clientes para borrar");

                int index = dgvClientes.SelectedRows[0].Index;

                // Se rompe la referencia del objeto y se lo borra de la lista
                clientes[index] = null;
                clientes.RemoveAt(index);

                // Se llama al Garbage Collector para que se ejecute el finalizador de la clase Cliente.
                // Normalmente, el GC se ejecuta de manera automatica cuando detecta muchos objetos sin referencia.
                // Esto es una prueba para ver la ejecucion del finalizador de Cliente al momento de romper la referencia de un objeto.
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
