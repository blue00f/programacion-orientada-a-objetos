using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using SistemaDeVentas.Entidades;
using SistemaDeVentas.Eventos;

namespace SistemaDeVentas
{
    public partial class Form1 : Form
    {
        Venta venta;
        public Form1()
        {
            InitializeComponent();
            venta = new Venta();
            venta.StockBajo += F_StockBajo;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }
        private void Mostrar(DataGridView pGrilla, object pObjeto)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pObjeto;
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Interaction.InputBox("Ingrese el ID (AB-12)", "Alta cliente");
                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta cliente");
                string apellido = Interaction.InputBox("Ingrese el apellido", "Alta cliente");


                string formatoId = @"^[A-Z]{2}-[0-9]{2}";
                if (!Regex.IsMatch(id, formatoId)) throw new Exception("El ID no cumple con el formato (ejemplo AB-12)");
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacio");

                Cliente c = new Cliente(id, nombre, apellido);
                venta.AgregarCliente(c);
                Mostrar(grillaClientes, venta.ObtenerClientes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes para borrar");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                venta.BorrarCliente(cliente.Id);
                Mostrar(grillaClientes, venta.ObtenerClientes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes para modificar");

                var clienteViejo = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                string nombre = Interaction.InputBox("Ingrese el nombre", "Modificación cliente", clienteViejo.Nombre);
                string apellido = Interaction.InputBox("Ingrese el apellido", "Modificación cliente", clienteViejo.Apellido);

                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacio");
                Cliente clienteNuevo = new Cliente(clienteViejo.Id, nombre, apellido);

                venta.ModificarCliente(clienteNuevo);
                Mostrar(grillaClientes, venta.ObtenerClientes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Ingrese el código (1234-A)", "Alta producto");
                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta producto");
                string inputStock = Interaction.InputBox("Ingrese el stock", "Alta producto");
                string inputPrecio = Interaction.InputBox("Ingrese el precio", "Alta producto");

                string formatoCodigo = @"^[0-9]{4}-[A-Z]{1}";

                if (!Regex.IsMatch(codigo, formatoCodigo)) throw new Exception("El código no cumple con el formato");
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio");
                if (!int.TryParse(inputStock, out int stock)) throw new Exception("El stock debe ser un número");
                if (!decimal.TryParse(inputPrecio, out decimal precio)) throw new Exception("El precio debe ser un número");

                Producto p = new Producto(codigo, nombre, stock, precio);
                venta.AgregarProducto(p);
                Mostrar(grillaProductos, venta.ObtenerProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay productos para borrar");
                var producto = grillaProductos.SelectedRows[0].DataBoundItem as Producto;
                venta.BorrarProducto(producto.Codigo);
                Mostrar(grillaProductos, venta.ObtenerProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay productos para modificar");
                var productoViejo = grillaProductos.SelectedRows[0].DataBoundItem as Producto;
                string nombre = Interaction.InputBox("Ingrese el nombre", "Modificación producto", productoViejo.Nombre);
                string inputStock = Interaction.InputBox("Ingrese el stock", "Modificación producto", productoViejo.Stock.ToString());
                string inputPrecio = Interaction.InputBox("Ingrese el precio", "Modificación producto", productoViejo.Precio.ToString());


                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio");
                if (!int.TryParse(inputStock, out int stock)) throw new Exception("El stock debe ser un número");
                if (!decimal.TryParse(inputPrecio, out decimal precio)) throw new Exception("El precio debe ser un número");

                Producto productoNuevo = new Producto(productoViejo.Codigo, nombre, stock, precio);

                venta.ModificarProducto(productoNuevo);

                Mostrar(grillaProductos, venta.ObtenerProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_StockBajo(object? sender, StockBajoEventArgs e)
        {
            MessageBox.Show($"El producto {e.Nombre} tiene {e.Stock} de stock!", "ALERTA DE STOCK BAJO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay productos para comprar");
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes en la grilla");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                var producto = grillaProductos.SelectedRows[0].DataBoundItem as Producto;
                string inputCantidad = Interaction.InputBox("Ingrese la cantidad a comprar", "Compra de producto");

                if (!int.TryParse(inputCantidad, out int cantidad)) throw new Exception("La cantidad debe ser numerica");

                venta.AsignarCompraACliente(cliente.Id, producto.Codigo, cantidad);

                Mostrar(grillaCompras, venta.ObtenerComprasCliente(cliente.Id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(grillaClientes.Rows.Count > 0)
                {
                    var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                    Mostrar(grillaCompras, venta.ObtenerComprasCliente(cliente.Id));
                }
            }
            catch (Exception) { }
        }
    }
}
