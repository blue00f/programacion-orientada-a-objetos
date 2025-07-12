using ActividadIntegradora_03.Entidades;
using Microsoft.VisualBasic;

namespace ActividadIntegradora_03
{
    public partial class Form1 : Form
    {
        Gestor productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productos = new Gestor();

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

        private void Mostrar(DataGridView pGrilla, object pDatos)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pDatos;
        }
        private void ActualizarGrillas(DataGridView pGrilla, object pDatos)
        {
            Mostrar(pGrilla, pDatos);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Interaction.InputBox("Ingrese el ID:", "Alta producto", "001-L01-OP200-26/06/2025");
                if (!Gestor.ValidarIdProducto(id)) throw new Exception("El formato del ID es incorrecto!");
                if (!productos.ValidarProductoRepetido(id)) throw new Exception("El ID está repetido!");

                string descripcion = Interaction.InputBox("Ingrese la descripcion:", "Alta producto");
                if (descripcion.Length == 0) throw new Exception("La descripción no debe estar vacía!");

                string precioInput = Interaction.InputBox("Ingrese el precio:", "Alta producto");
                if (!decimal.TryParse(precioInput, out decimal precio)) throw new Exception("El precio no es numérico!");
                if (precio < 1) throw new Exception("El precio tiene un valor incorrecto!");

                string stockInput = Interaction.InputBox("Ingrese el stock:", "Alta producto");
                if (!int.TryParse(stockInput, out int stock)) throw new Exception("El stock no es numérico!");
                if (precio < 1) throw new Exception("El stock tiene un valor incorrecto!");

                Producto producto = new(id, descripcion, precio, stock);
                productos.AgregarProducto(producto);
                Mostrar(grillaProductos, productos.ObtenerProductos());

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
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");
                var producto = grillaProductos.SelectedRows[0].DataBoundItem as Producto;
                productos.BorrarProducto(producto);
                Mostrar(grillaProductos, productos.ObtenerProductos());
                ActualizarGrillas();
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
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");
                var productoViejo = grillaProductos.SelectedRows[0].DataBoundItem as Producto;

                string descripcion = Interaction.InputBox("Ingrese la descripcion:", "Alta producto", productoViejo.Descripcion);
                if (descripcion.Length == 0) throw new Exception("La descripción no debe estar vacía!");

                string precioInput = Interaction.InputBox("Ingrese el precio:", "Alta producto", productoViejo.Precio.ToString());
                if (!decimal.TryParse(precioInput, out decimal precio)) throw new Exception("El precio no es numérico!");
                if (precio < 1) throw new Exception("El precio tiene un valor incorrecto!");

                string stockInput = Interaction.InputBox("Ingrese el stock:", "Alta producto", productoViejo.Stock.ToString());
                if (!int.TryParse(stockInput, out int stock)) throw new Exception("El stock no es numérico!");
                if (precio < 1) throw new Exception("El stock tiene un valor incorrecto!");

                Producto productoNuevo = new(productoViejo.Id, descripcion, precio, stock);
                productos.ModificarProducto(productoNuevo);
                Mostrar(grillaProductos, productos.ObtenerProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Producto productoClonado;
        private void btnClonarDeLaGrilla_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");
                var producto = grillaProductos.SelectedRows[0].DataBoundItem as Producto;
                productoClonado = producto.CloneTipado();

                txtDescripcionClon.Text = $"{productoClonado.Descripcion}";
                txtPrecioClon.Text = $"{productoClonado.Precio}";
                txtStockClon.Text = $"{productoClonado.Stock}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnModificarClon_Click(object sender, EventArgs e)
        {
            if (txtDescripcionClon.Text.Length != 0 || txtPrecioClon.Text.Length != 0 || txtStockClon.Text.Length != 0)
            {
                productoClonado.Descripcion = Interaction.InputBox("Ingrese la descripción:", "Modificación del clon", productoClonado.Descripcion);

                productoClonado.Precio = decimal.Parse(Interaction.InputBox("Ingrese el precio:", "Modificación del clon", productoClonado.Precio.ToString()));
                productoClonado.Stock = int.Parse(Interaction.InputBox("Ingrese el stock:", "Modificación del clon", productoClonado.Stock.ToString()));

                txtDescripcionClon.Text = productoClonado.Descripcion;
                txtPrecioClon.Text = productoClonado.Precio.ToString();
                txtStockClon.Text = productoClonado.Stock.ToString();
                Mostrar(grillaProductos, productos.ObtenerProductos());
            }
        }


        string[] leyenda = { "Código de producto", "Número de línea", "Código de operador", "Fecha de fabricación" };
        private void btnIterarId_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");
                var producto = grillaProductos.SelectedRows[0].DataBoundItem as Producto;
                int i = 0;
                foreach (var parte in producto)
                {
                    MessageBox.Show(parte.ToString(), leyenda[i], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grillaProductos.Rows.Count == 0) throw new Exception("No hay registros de producto!");

                ActualizarGrillas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrillas()
        {
            if (productos.ObtenerProductos().Count == 0)
            {
                grillaPrecioAsc.DataSource = null;
                grillaPrecioDesc.DataSource = null;
                grillaIdAsc.DataSource = null;
                grillaIdDesc.DataSource = null;
            }
            var p1 = productos.ObtenerProductos();
            p1.Sort(new Producto.IdASC()); Mostrar(grillaIdAsc, p1);

            var p2 = productos.ObtenerProductos();
            p2.Sort(new Producto.IdDESC()); Mostrar(grillaIdDesc, p2);

            var p3 = productos.ObtenerProductos();
            p3.Sort(new Producto.PrecioASC()); Mostrar(grillaPrecioAsc, p3);

            var p4 = productos.ObtenerProductos();
            p4.Sort(new Producto.PrecioDESC()); Mostrar(grillaPrecioDesc, p4);
        }
    }
}
