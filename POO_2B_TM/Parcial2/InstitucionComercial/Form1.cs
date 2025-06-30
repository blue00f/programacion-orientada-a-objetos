using Microsoft.VisualBasic;
using Parcial2.Entidades;
using System.Drawing;

namespace Parcial2
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
            institucion.AlertaImporteAlto += FuncionAlertaImporteAlto;
        }

        private void FuncionAlertaImporteAlto(object? sender, EventArgs e) => MessageBox.Show("El importe pagado superó los $10.000", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                if (!institucion.ValidarLegajoRepetido(legajo)) throw new Exception("El legajo está repetido!");

                string nombre = Interaction.InputBox("Nombre:", "Alta cliente");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                Cliente c = new Cliente(legajo, nombre);
                institucion.AgregarCliente(c);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
                grillaClientes_RowEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de cliente!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                institucion.BorrarCliente(cliente);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
                grillaClientes_RowEnter(null, null);

                if (grillaClientes.Rows.Count == 0) grillaCobros.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de cliente!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                string nombre = Interaction.InputBox("Nombre:", "Modificación del cliente", cliente.Nombre);
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                Cliente clienteNuevo = new Cliente(cliente.Legajo, nombre);
                institucion.ModificarCliente(clienteNuevo);
                Mostrar(grillaClientes, institucion.ObtenerClientes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de cliente!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                if (!institucion.ValidarDosCobrosPendientes(cliente)) throw new Exception("Solo se pueden tener dos cobros pendientes!");

                string codigo = Interaction.InputBox("Codigo:", $"Alta cobro de {cliente.Nombre}");
                if (codigo.Length == 0) throw new Exception("El código está vacio!");
                if (!institucion.ValidarCodigoRepetido(codigo)) throw new Exception("El código está repetido!");

                string nombre = Interaction.InputBox("Nombre:", $"Alta cobro de {cliente.Nombre}");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");

                DateTime fechaVencimiento = DateTime.Parse(Interaction.InputBox("Fecha de vencimiento:", $"Alta cobro de {cliente.Nombre}", DateTime.Now.Date.ToString()));

                string importeInput = Interaction.InputBox("Importe:", $"Alta cobro de {cliente.Nombre}");
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

                Mostrar(grillaCobros, institucion.ObtenerCobrosPendienteDeUnCliente(cliente));
                grillaCobros.Columns["Cliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay registros de cliente!");
                if (grillaCobros.Rows.Count == 0) throw new Exception("No hay registros de cobros!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                var cobro = grillaCobros.SelectedRows[0].DataBoundItem as Cobro;

                institucion.PagarCobro(cobro, cliente);

                int diasDeRetraso = (DateTime.Now - cobro.FechaVencimiento).Days;
                if (cobro is CobroNormal)
                {
                    decimal recargo = cobro.CalcularRecargo(diasDeRetraso);
                    MessageBox.Show($"Importe: ${cobro.Importe}\nRecargo: ${recargo}\nTotal: ${cobro.Importe + recargo}", "Descripción del pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    decimal recargo = cobro.CalcularRecargo(diasDeRetraso);
                    MessageBox.Show($"Importe: ${cobro.Importe}\nRecargo: ${recargo}\nTotal: ${cobro.Importe + recargo}", "Descripción del pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Mostrar(grillaCobros, institucion.ObtenerCobrosPendienteDeUnCliente(cliente));
                Mostrar(grillaCobrosPagados, institucion.ObtenerCobrosPagadosDeUnCliente(cliente));
                Mostrar(grillaConsultaDatos, institucion.ObtenerTodosLosCobrosPagados());

                grillaClientes_RowEnter(null, null);

                grillaCobrosPagados.Columns["Cliente"].Visible = false;
                grillaCobrosPagadosOrd.Columns["Cliente"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count > 0)
                {
                    var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                    var cobro = grillaCobros.SelectedRows[0].DataBoundItem as Cobro;

                    Mostrar(grillaCobros, institucion.ObtenerCobrosPendienteDeUnCliente(cliente));
                    Mostrar(grillaCobrosPagados, institucion.ObtenerCobrosPagadosDeUnCliente(cliente));
                    radImporteAsc_CheckedChanged(null, null);
                    radImporteDesc_CheckedChanged(null, null);

                    grillaCobros.Columns["Cliente"].Visible = false;
                    grillaCobrosPagados.Columns["Cliente"].Visible = false;
                }
            }
            catch (Exception) { }
        }

        private void radImporteAsc_CheckedChanged(object sender, EventArgs e)
        {
            var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

            if (radImporteAsc.Checked)
            {
                var cobrosPagadosAsc = institucion.ObtenerCobrosPagadosDeUnCliente(cliente);
                cobrosPagadosAsc.Sort(new Cobro.ImporteASC());
                Mostrar(grillaCobrosPagadosOrd, cobrosPagadosAsc);
            }
            else
            {
                var cobrosPagadosDesc = institucion.ObtenerCobrosPagadosDeUnCliente(cliente);
                cobrosPagadosDesc.Sort(new Cobro.ImporteDESC());
                Mostrar(grillaCobrosPagadosOrd, cobrosPagadosDesc);
            }
            grillaCobrosPagadosOrd.Columns["Cliente"].Visible = false;
        }

        private void radImporteDesc_CheckedChanged(object sender, EventArgs e)
        {
            var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

            if (radImporteAsc.Checked)
            {
                var cobrosPagadosAsc = institucion.ObtenerCobrosPagadosDeUnCliente(cliente);
                cobrosPagadosAsc.Sort(new Cobro.ImporteASC());
                Mostrar(grillaCobrosPagadosOrd, cobrosPagadosAsc);
            }
            else
            {
                var cobrosPagadosDesc = institucion.ObtenerCobrosPagadosDeUnCliente(cliente);
                cobrosPagadosDesc.Sort(new Cobro.ImporteDESC());
                Mostrar(grillaCobrosPagadosOrd, cobrosPagadosDesc);
            }
            grillaCobrosPagadosOrd.Columns["Cliente"].Visible = false;
        }
    }
}
