using InstitucionComercial_V2.Entidades;
using Microsoft.VisualBasic;

namespace InstitucionComercial_V2
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
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            institucion.ImporteAlto += FuncionImporteAlto;
        }

        private void FuncionImporteAlto(object? sender, EventArgs e) => MessageBox.Show("El importe alto excedió los $10.000", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void Mostrar(DataGridView pGrilla, object pDatos)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pDatos;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = Interaction.InputBox("Legajo:", "Alta cliente");
                if (legajo.Length == 0) throw new Exception("El legajo está vacio!");
                if (!institucion.ValidarLegajoRepetido(legajo)) throw new Exception("Legajo repetido!");
                string nombre = Interaction.InputBox("Nombre:", "Alta cliente");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                Cliente c = new(legajo, nombre);
                institucion.AgregarCliente(c);
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de clientes!");

                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                institucion.BorrarCliente(cliente);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
                grillaClientes_RowEnter(null, null);
                if (institucion.ObtenerClientes().Count == 0)
                {
                    grillaCobros.DataSource = null;
                    grillaCobrosPagados.DataSource = null;
                }
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de clientes!");

                var clienteViejo = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                string nombre = Interaction.InputBox("Nombre", "Modificación cliente", clienteViejo.Nombre);
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                Cliente clienteNuevo = new(clienteViejo.Legajo, nombre);
                institucion.ModificarCliente(clienteNuevo);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
                grillaClientes_RowEnter(null, null);
                Mostrar(grillaConsultaDatos, institucion.ObtenerTodosLosCobros());
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de clientes!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                if (!institucion.ValidarDosCobros(cliente)) throw new Exception("El cliente solo puede tener dos pagos!");

                string codigo = Interaction.InputBox("Código:", $"Alta cobro de {cliente.Nombre}");
                if (codigo.Length == 0) throw new Exception("El código está vacio!");
                if (!institucion.ValidarCodigoRepetido(codigo)) throw new Exception("El código está repetido");

                string nombre = Interaction.InputBox("Nombre:", $"Alta cobro de {cliente.Nombre}");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                DateTime fechaVencimiento = DateTime.Parse(Interaction.InputBox("Fecha de vencimiento:", $"Alta cobro de {cliente.Nombre}", DateTime.Now.Date.ToString()));

                string importeInput = Interaction.InputBox("Importe a cobrar:", $"Alta cobro de {cliente.Nombre}");
                if (importeInput.Length == 0) throw new Exception("El importe está vacio!");
                if (!decimal.TryParse(importeInput, out decimal importe)) throw new Exception("El importe debe ser numérico!");

                if (radCobroNormal.Checked)
                {
                    CobroNormal cobro = new CobroNormal(codigo, nombre, fechaVencimiento, importe);
                    institucion.AgregarCobro(cobro, cliente);
                }
                else
                {
                    CobroEspecial cobro = new CobroEspecial(codigo, nombre, fechaVencimiento, importe);
                    institucion.AgregarCobro(cobro, cliente);
                }

                Mostrar(grillaCobros, institucion.ObtenerCobroDelCliente(cliente));
                grillaCobros.Columns["Cliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de clientes!");
                if (grillaCobros.Rows.Count == 0) throw new Exception("No hay registros de cobros pendientes!");

                var cobro = grillaCobros.SelectedRows[0].DataBoundItem as Cobro;
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                if (cobro is CobroNormal) MostrarInfoPago(cobro);
                else MostrarInfoPago(cobro);
                institucion.PagarCobro(cobro, cliente);


                grillaClientes_RowEnter(null, null);
                Mostrar(grillaCobros, institucion.ObtenerCobroDelCliente(cliente));
                Mostrar(grillaConsultaDatos, institucion.ObtenerTodosLosCobros());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void MostrarInfoPago(Cobro? cobro)
        {
            if (cobro.FechaVencimiento >= DateTime.Now)
            {
                MessageBox.Show($"Importe a pagar: {cobro.Importe}");
            }
            else
            {
                int diasRetraso = (DateTime.Now - cobro.FechaVencimiento).Days;
                decimal importeRecargo = cobro.CalcularImporteConRetraso(diasRetraso);
                MessageBox.Show($"Importe a pagar: {cobro.Importe}\nRecargo: {importeRecargo}\nTotal: {cobro.Importe + importeRecargo}");
            }
        }

        private void grillaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count > 0)
                {
                    var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                    Mostrar(grillaCobros, institucion.ObtenerCobroDelCliente(cliente));

                    var datos = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                    var consulta = (from c in datos select c).ToList();
                    Mostrar(grillaCobrosPagados, consulta);

                    radOrdenarImporteAsc_CheckedChanged(null, null);
                    radOrdenarImporteDesc_CheckedChanged(null, null);

                    grillaCobros.Columns["Cliente"].Visible = false;
                    grillaCobrosPagados.Columns["Cliente"].Visible = false;
                }
            }
            catch (Exception) { }
        }

        private void radOrdenarImporteAsc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de clientes!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                var importeAsc = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                importeAsc.Sort(new Cobro.ImporteASC());
                Mostrar(grillaImporteOrd, importeAsc);
                grillaImporteOrd.Columns["Cliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void radOrdenarImporteDesc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de clientes!");

                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                var importeDesc = institucion.ObtenerCobrosPagadosDelCliente(cliente);
                importeDesc.Sort(new Cobro.ImporteDESC());
                Mostrar(grillaImporteOrd, importeDesc);
                grillaImporteOrd.Columns["Cliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
