using Microsoft.VisualBasic;

namespace Ejercicio_ICloneable
{
    public partial class Form1 : Form
    {
        List<Producto> productos;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            productos = new List<Producto>();
            grillaProductos.MultiSelect = false;
            grillaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Mostrar(object pProductos)
        {
            grillaProductos.DataSource = null;
            grillaProductos.DataSource = pProductos;
        }
        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del producto:", "Creación del producto");
            decimal precio = Convert.ToDecimal(Interaction.InputBox("Ingrese el precio del producto:", "Creación del producto"));
            int stock = Convert.ToInt16(Interaction.InputBox("Ingrese el stock del producto:", "Creación del producto"));
            Producto producto = new Producto(nombre, precio, stock);
            productos.Add(producto);
            Mostrar(productos);
        }
        private void btnClonarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");
                var producto = grillaProductos.SelectedRows[0].DataBoundItem as Producto;

                if (producto is ICloneable)
                {
                    var productoClonado = producto.CloneTipado();
                    MessageBox.Show(productoClonado.MostrarInfo(), "Clone tipado del objeto creado usando IS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
