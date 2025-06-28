using Microsoft.VisualBasic;

namespace Ejercicio_Generics
{
    public partial class Form1 : Form
    {
        Gestor<Producto> productos;
        Gestor<Vendedor> vendedores;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productos = new Gestor<Producto>();
            vendedores = new Gestor<Vendedor>();
            foreach (var control in Controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.MultiSelect = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void Mostrar(DataGridView pGrilla, object pDataSource)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pDataSource;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Código del producto:", "Alta producto");
                if (codigo.Length == 0) throw new Exception("Código vacio!");
                string nombre = Interaction.InputBox("Nombre del producto:", "Alta producto");
                if (nombre.Length == 0) throw new Exception("Nombre vacio!");
                string precioInput = Interaction.InputBox("Precio del producto:", "Alta producto");
                if (!decimal.TryParse(precioInput, out decimal precio)) throw new Exception("El precio no es numérico!");

                Producto p = new(codigo, nombre, precio);
                productos.Agregar(p);
                Mostrar(grillaProductos, productos.ObtenerItems());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");
                decimal precioFiltro = decimal.Parse(Interaction.InputBox("Ingrese el precio para saber qué producto lo supera:", "Filtro por precio del producto"));
                List<Producto> caros = productos.Filtrar<decimal>(p => p.Precio, precio => precio > precioFiltro);
                Mostrar(grillaFiltroProductos, caros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = Interaction.InputBox("Legajo del vendedor:", "Alta vendedor");
                if (legajo.Length == 0) throw new Exception("Código vacio!");
                string nombre = Interaction.InputBox("Nombre del vendedor:", "Alta vendedor");
                if (nombre.Length == 0) throw new Exception("Nombre vacio!");
                string apellido = Interaction.InputBox("Apellido del vendedor:", "Alta vendedor");
                if (apellido.Length == 0) throw new Exception("Apellido vacio!");

                Vendedor v = new(legajo, nombre, apellido);
                vendedores.Agregar(v);
                Mostrar(grillaVendedor, vendedores.ObtenerItems());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaVendedor.Rows.Count == 0) throw new Exception("No hay registros de vendedores!");
                char letra = char.Parse(Interaction.InputBox("Ingrese la primera letra del apellido", "Buscar por apellido"));
                List<Vendedor> vendedorPorLetraApe = vendedores.Filtrar<string>(v => v.Apellido, ape => ape.StartsWith(letra));
                Mostrar(grillaFiltroVendedor, vendedorPorLetraApe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
