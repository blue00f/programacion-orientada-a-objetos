using Ejercicio01.Entidades;
using Microsoft.VisualBasic;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        Institucion institucion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            institucion = new Institucion();
            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.MultiSelect = false;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void Mostrar(DataGridView pGrilla, object pDatos)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pDatos;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = Interaction.InputBox("Ingrese el legajo", "Alta cliente");
                if (legajo.Length == 0) throw new Exception("El legajo está vacio!");
                if (institucion.ValidarLegajoRepetido(legajo)) throw new Exception("El legajo está repetido!");
                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta cliente");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                Cliente cliente = new Cliente(legajo, nombre);
                institucion.AgregarCliente(cliente);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                institucion.BorrarCliente(cliente);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
                grillaClientes_RowEnter(null, null);
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                string nombre = Interaction.InputBox("Ingrese el nombre", "Modificar cliente", cliente.Nombre);
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                var clienteActualizado = new Cliente(cliente.Legajo, nombre);
                institucion.ModificarCliente(clienteActualizado);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                if (cliente.ObtenerCobros().Count == 2) throw new Exception("El cliente llegó al máximo de 2 cobros!");

                string codigo = Interaction.InputBox("Ingrese el código", "Alta cobro");
                if (codigo.Length == 0) throw new Exception("El código está vacio!");
                if (institucion.ValidarCodigoRepetido(codigo)) throw new Exception("El código está repetido!");
                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta cobro");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");
                DateTime fechaVencimiento = DateTime.Parse(Interaction.InputBox("Ingrese fecha de vencimiento", "Alta cobro", DateTime.Now.Date.ToShortDateString()));
                string inputImporte = Interaction.InputBox("Ingrese el importe", "Alta cobro");
                if (!decimal.TryParse(inputImporte, out decimal importe)) throw new Exception("El importe debe ser numérico!");

                if (radCobroNormal.Checked)
                {
                    CobroNormal cobro = new CobroNormal(codigo, nombre, fechaVencimiento, importe, cliente);
                    institucion.AgregarCobro(cobro, cliente);
                }
                else
                {
                    CobroEspecial cobro = new CobroEspecial(codigo, nombre, fechaVencimiento, importe, cliente);
                    institucion.AgregarCobro(cobro, cliente);
                }
                Mostrar(grillaCobros, institucion.ObtenerCobrosDelCliente(cliente));
                grillaCobros.Columns["Recargo"].Visible = false;
                grillaCobros.Columns["Cliente"].Visible = false;
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
                if (grillaClientes.Rows.Count > 0)
                {
                    var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                    Mostrar(grillaCobros, institucion.ObtenerCobrosDelCliente(cliente));
                    grillaCobros.Columns["Recargo"].Visible = false;
                    grillaCobros.Columns["Cliente"].Visible = false;

                    Mostrar(grillaCobrosPagados, institucion.ObtenerCobrosPagadosDelCliente(cliente));
                    grillaCobrosPagados.Columns["Cliente"].Visible = false;

                    if (radOrdMayor.Checked)
                    {
                        var datos = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                        datos.Sort(new Cobro.ImporteASC());
                        Mostrar(grillaImporteOrd, datos);
                    }
                    else
                    {
                        var datos = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                        datos.Sort(new Cobro.ImporteDESC());
                        Mostrar(grillaImporteOrd, datos);
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes!");
                if (grillaCobros.Rows.Count == 0) throw new Exception("No hay cobros!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                var cobro = grillaCobros.SelectedRows[0].DataBoundItem as Cobro;
                cobro.AlertaImporteAlto += Funcion_AlertaImporteAlto;

                int diasRetraso = (DateTime.Now.Date - cobro.FechaVencimiento.Date).Days;
                decimal recargo = cobro.CalcularRecargo(cobro.Importe, diasRetraso);
                decimal total = cobro.Importe + cobro.Recargo;
                MessageBox.Show($"Importe: {cobro.Importe}\nRecargo: {recargo}\nTotal: {total}", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                institucion.PagarCobro(cobro, cliente);

                Mostrar(grillaCobrosPagados, institucion.ObtenerCobrosPagadosDelCliente(cliente));
                grillaCobrosPagados.Columns["Cliente"].Visible = false;

                Mostrar(grillaCobros, institucion.ObtenerCobrosDelCliente(cliente));
                grillaCobros.Columns["Recargo"].Visible = false;
                grillaCobros.Columns["Cliente"].Visible = false;

                Mostrar(grillaInfoPago, institucion.ObtenerConsultaDeCobro());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Funcion_AlertaImporteAlto(object? sender, EventArgs e)
        {
            MessageBox.Show("El importe total superó los 10.000", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void radOrdMayor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (grillaCobrosPagados.Rows.Count > 0)
                {
                    if (grillaClientes.Rows.Count > 0)
                    {
                        var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                        var datos = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                        datos.Sort(new Cobro.ImporteASC());
                        Mostrar(grillaImporteOrd, datos);
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void radOrdMenor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (grillaCobrosPagados.Rows.Count > 0)
                {
                    if (grillaClientes.Rows.Count > 0)
                    {
                        var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                        var datos = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                        datos.Sort(new Cobro.ImporteDESC());
                        Mostrar(grillaImporteOrd, datos);
                    }
                }
            }
            catch (Exception)
            { }
        }
    }
}
