using ActividadIntegradora_02.Entidades;
using ActividadIntegradora_02.Eventos;
using ActividadIntegradora_02.Excepciones;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ActividadIntegradora_02
{
    public partial class Form1 : Form
    {
        Bolsa bolsa;
        public Form1()
        {
            InitializeComponent();
            bolsa = new Bolsa();
            bolsa.CambioCotizacion += F_CambioCotizacion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.MultiSelect = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            cbxTipoInversor.Items.Add("Común");
            cbxTipoInversor.Items.Add("Premium");
            cbxTipoInversor.SelectedIndex = 0;
        }

        #region "Métodos de servicio"
        public void Mostrar(DataGridView grilla, object pObject)
        {
            grilla.DataSource = null;
            grilla.DataSource = pObject;
            if (grilla.Columns.Contains("Objeto"))
            {
                grilla.Columns["Objeto"].Visible = false;
            }
            if (grilla.Columns.Contains("CotizacionActual"))
            {
                grilla.Columns["Codigo"].HeaderText = "Código";
                grilla.Columns["Denominacion"].HeaderText = "Denominación";
                grilla.Columns["CotizacionActual"].HeaderText = "Cotización actual";
                grilla.Columns["CantidadEmitida"].HeaderText = "Cantidad emitida";
            }
        }
        private Inversor? ConvertirAnonimoAInversor(DataGridView grilla)
        {
            var o = grilla.SelectedRows[0].DataBoundItem;
            var t = o.GetType();
            var z = t.GetProperties();
            var w = z[5].GetValue(o);
            var inversor = (Inversor)w;
            return inversor;
        }

        private List<Inversor> ConvertirAnonimosAListaInversores(List<object> pListaAnonimos)
        {
            List<Inversor> inversores = new List<Inversor>();
            foreach (var item in pListaAnonimos)
            {
                var t = item.GetType();
                var z = t.GetProperties();
                var w = z[5].GetValue(item);

                if (w is Inversor inversor)
                {
                    inversores.Add(inversor);
                }
            }
            return inversores;
        }

        private void MostrarComisionesEnLabels(Inversor inversor, Accion accion, int cantidad)
        {
            decimal valorAccion = accion.CotizacionActual * cantidad;
            decimal comision = inversor.CalcularComision(valorAccion);

            if (inversor is InversorPremium)
            {
                if (valorAccion <= 20000) totalPremiumHasta20k += comision;
                else totalPremiumSobre20k += comision;
            }
            else
            {
                totalComunes += comision;
            }
            lblRecaudadoComun.Text = $"Recaudado por inversores comunes: ${totalComunes}";
            lblRecaudadoPremiumHasta20000.Text = $"Recaudado por inversores premium hasta $20.000: ${totalPremiumHasta20k:0.00}";
            lblRecaudadoPremiumSupera20000.Text = $"Recaudado por inversores premium que superan los $20.000: ${totalPremiumSobre20k:0.00}";
            lblRecaudadoTotal.Text = $"Total general: ${(totalComunes + totalPremiumHasta20k + totalPremiumSobre20k):0.00}";
        }

        private void MostrarOrdenamientoGrillas()
        {
            var accionesAsc = bolsa.ObtenerAcciones();
            accionesAsc.Sort(new Accion.AccionASC());
            Mostrar(grillaAccionAsc, accionesAsc);

            var accionesDesc = bolsa.ObtenerAcciones();
            accionesDesc.Sort(new Accion.AccionDESC());
            Mostrar(grillaAccionDesc, accionesDesc);

            var inversoresAsc = ConvertirAnonimosAListaInversores((List<object>)bolsa.ObtenerInversores());
            inversoresAsc.Sort(new Inversor.InversorASC());
            Mostrar(grillaInversorAsc, inversoresAsc);

            var inversoresDesc = ConvertirAnonimosAListaInversores((List<object>)bolsa.ObtenerInversores());
            inversoresDesc.Sort(new Inversor.InversorDESC());
            Mostrar(grillaInversorDesc, inversoresDesc);
        }
        private void btnVerCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaAcciones.Rows.Count == 0) throw new Exception("No hay acciones en la grilla!");
                var accion = grillaAcciones.SelectedRows[0].DataBoundItem as Accion;
                foreach (var p in accion)
                {
                    MessageBox.Show(p, "Visualización de las 3 partes del código", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grillaInversores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grillaInversores.Rows.Count > 0)
                {
                    var inversor = ConvertirAnonimoAInversor(grillaInversores);
                    Mostrar(grillaAccionesDelInversor, bolsa.ObtenerAccionesDelInversor(ConvertirAnonimoAInversor(grillaInversores)));
                    lblTotalInvertidoPorInversor.Text = $"Total invertido: ${inversor.ObtenerCompraAcciones().Sum(a => a.CantidadComprada * a.Accion.CotizacionActual):0.00}";
                }
            }
            catch (Exception) { }
        }
        #endregion

        #region "ABM Inversores"
        private void btnAgregarInversor_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre", "Agregar inversor");
                string apellido = Interaction.InputBox("Ingrese el apellido", "Agregar inversor");
                string dni = Interaction.InputBox("Ingrese el DNI", "Agregar inversor");

                if (!bolsa.ValidarInversorRepetido(dni)) throw new Exception("El DNI está repetido!");

                if (nombre.Length == 0) throw new ValorVacioException("nombre");
                if (apellido.Length == 0) throw new ValorVacioException("apellido");
                if (!Inversor.ValidarDni(dni)) throw new Exception("El DNI no cumple con el formato!");

                if (cbxTipoInversor.SelectedIndex == 0)
                {
                    InversorComun inversor = new InversorComun(nombre, apellido, dni);
                    bolsa.AgregarInversor(inversor);
                }
                else
                {
                    InversorPremium inversor = new InversorPremium(nombre, apellido, dni);
                    bolsa.AgregarInversor(inversor);
                }
                Mostrar(grillaInversores, bolsa.ObtenerInversores());
                MostrarOrdenamientoGrillas();
            }
            catch (ValorVacioException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarInversor_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaInversores.Rows.Count == 0) throw new Exception("No hay inversores para borrar!");
                var inversor = ConvertirAnonimoAInversor(grillaInversores);
                bolsa.BorrarInversor(inversor);
                Mostrar(grillaInversores, bolsa.ObtenerInversores());
                if (grillaAcciones.Rows.Count > 1) Mostrar(grillaAccionesDelInversor, ConvertirAnonimoAInversor(grillaInversores));
                MostrarOrdenamientoGrillas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificarInversor_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaInversores.Rows.Count == 0) throw new Exception("No hay inversores para modificar!");
                var inversorViejo = ConvertirAnonimoAInversor(grillaInversores);
                string nombre = Interaction.InputBox("Ingrese el nombre", "Modificar inversor", inversorViejo.Nombre);
                string apellido = Interaction.InputBox("Ingrese el apellido", "Modificar inversor", inversorViejo.Apellido);

                if (nombre.Length == 0) throw new ValorVacioException("nombre");
                if (apellido.Length == 0) throw new ValorVacioException("apellido");

                if (inversorViejo is InversorComun)
                {
                    InversorComun inversor = new InversorComun(nombre, apellido, inversorViejo.Dni);
                    bolsa.ModificarInversor(inversor);
                }
                else
                {
                    InversorPremium inversor = new InversorPremium(nombre, apellido, inversorViejo.Dni);
                    bolsa.ModificarInversor(inversor);
                }
                Mostrar(grillaInversores, bolsa.ObtenerInversores());
                MostrarOrdenamientoGrillas();
            }
            catch (ValorVacioException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "ABM Acciones"
        private void btnAgregarAccion_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Ingrese el código con el formato (AAAA-1234-A1B2)", "Agregar acción");
                if (!Accion.ValidarCodigo(codigo)) throw new FormatoCodigoInvalidoException(codigo);
                if (!bolsa.ValidarAccionRepetido(codigo)) throw new CodigoRepetidoException(codigo);

                string denominacion = Interaction.InputBox("Ingrese la denominación", "Agregar acción");
                decimal cotizacionActual;
                int cantidadEmitida;

                string inputCotizacionActual = Interaction.InputBox("Ingrese la cotización actual", "Agregar acción");
                string inputCantidadEmitida = Interaction.InputBox("Ingrese la cantidad emitida", "Agregar acción");

                if (denominacion.Length == 0) throw new ValorVacioException(denominacion);
                if (!decimal.TryParse(inputCotizacionActual, out cotizacionActual)) throw new NoEsNumericoException("Cotización actual", inputCotizacionActual);
                if (cotizacionActual < 0) throw new CotizacionInvalidaException(cotizacionActual);
                if (!int.TryParse(inputCantidadEmitida, out cantidadEmitida)) throw new NoEsNumericoException("Cantidad emitida", inputCantidadEmitida);

                Accion accion = new Accion(codigo, denominacion, cotizacionActual, cantidadEmitida);
                bolsa.AgregarAccion(accion);
                Mostrar(grillaAcciones, bolsa.ObtenerAcciones());
                MostrarOrdenamientoGrillas();
            }
            catch (NoEsNumericoException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValorVacioException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CodigoRepetidoException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatoCodigoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CotizacionInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarAccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaAcciones.Rows.Count == 0) throw new Exception("No hay acciones para borrar!");
                var accion = grillaAcciones.SelectedRows[0].DataBoundItem as Accion;
                bolsa.BorrarAccion(accion);
                Mostrar(grillaAcciones, bolsa.ObtenerAcciones());
                if (grillaAcciones.Rows.Count > 1) Mostrar(grillaAccionesDelInversor, ConvertirAnonimoAInversor(grillaInversores));
                MostrarOrdenamientoGrillas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarAccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaAcciones.Rows.Count == 0) throw new Exception("No hay acciones para modificar!");
                var accionVieja = grillaAcciones.SelectedRows[0].DataBoundItem as Accion;
                decimal cotizacionActual;
                int cantidadEmitida;

                string denominacion = Interaction.InputBox("Ingrese la denominación", "Modificar acción", accionVieja.Denominacion);
                string inputCotizacionActual = Interaction.InputBox("Ingrese la cotización actual", "Modificar acción", accionVieja.CotizacionActual.ToString());
                if (!decimal.TryParse(inputCotizacionActual, out cotizacionActual)) throw new NoEsNumericoException("Cotización actual", inputCotizacionActual);
                if (cotizacionActual < 0) throw new CotizacionInvalidaException(cotizacionActual);

                string inputCantidadEmitida = Interaction.InputBox("Ingrese la cantidad emitida", "Modificar acción", accionVieja.CantidadEmitida.ToString());
                if (!int.TryParse(inputCantidadEmitida, out cantidadEmitida)) throw new NoEsNumericoException("Cantidad emitida", inputCantidadEmitida);

                Accion accion = new Accion(accionVieja.Codigo, denominacion, cotizacionActual, cantidadEmitida);
                bolsa.ModificarAccion(accion);
                Mostrar(grillaAcciones, bolsa.ObtenerAcciones());

                var inversor = ConvertirAnonimoAInversor(grillaInversores);
                Mostrar(grillaAccionesDelInversor, bolsa.ObtenerAccionesDelInversor(inversor));
                MostrarOrdenamientoGrillas();
            }
            catch (NoEsNumericoException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CotizacionInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_CambioCotizacion(object? sender, CambioCotizacionEventArgs e)
        {
            MessageBox.Show($"Se cambió el valor de la cotización actual de la acción a: {e.CotizacionActual}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region "Comprar y Vender Acciones"


        decimal totalComunes = 0;
        decimal totalPremiumHasta20k = 0;
        decimal totalPremiumSobre20k = 0;

        private void btnComprarAccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaInversores.Rows.Count == 0) throw new Exception("No hay inversores en la grilla!");
                if (grillaAcciones.Rows.Count == 0) throw new Exception("No hay acciones en la grilla!");

                var inversor = ConvertirAnonimoAInversor(grillaInversores);
                var accion = grillaAcciones.SelectedRows[0].DataBoundItem as Accion;
                int cantidad;
                if (!int.TryParse(Interaction.InputBox("Ingrese la cantidad de acciones a comprar", "Compra de acción"), out cantidad)) throw new Exception("La cantidad de acciones a comprar debe ser numérico!");

                bolsa.ComprarAccion(inversor, accion, cantidad);
                Mostrar(grillaAccionesDelInversor, bolsa.ObtenerAccionesDelInversor(inversor));
                Mostrar(grillaAcciones, bolsa.ObtenerAcciones());
                grillaInversores_RowEnter(null, null);

                MostrarComisionesEnLabels(inversor, accion, cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVenderAccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaInversores.Rows.Count == 0) throw new Exception("No hay inversores en la grilla!");
                if (grillaAcciones.Rows.Count == 0) throw new Exception("No hay acciones en la grilla!");

                var inversor = ConvertirAnonimoAInversor(grillaInversores);
                var accion = grillaAcciones.SelectedRows[0].DataBoundItem as Accion;
                string codigo = grillaAccionesDelInversor.SelectedRows[0].Cells[0].Value.ToString();
                int cantidad;
                if (bolsa.ObtenerAccionesDelInversor(inversor).Count == 0) throw new Exception("El inversor no tiene acciones para vender!");
                if (!int.TryParse(Interaction.InputBox("Ingrese la cantidad de acciones a vender", "Venta de acción"), out cantidad)) throw new Exception("La cantidad de acciones a vender debe ser numérico!");

                bolsa.VenderAccion(inversor, codigo, cantidad);
                Mostrar(grillaAccionesDelInversor, bolsa.ObtenerAccionesDelInversor(inversor));
                grillaInversores_RowEnter(null, null);
                MostrarComisionesEnLabels(inversor, accion, cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
