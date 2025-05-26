using Microsoft.VisualBasic;
using SistemaBecas.Entidades;
using System.Net;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaBecas
{
    public partial class Form1 : Form
    {
        Universidad universidad;
        public Form1()
        {
            InitializeComponent();
            universidad = new Universidad();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grillaBeneficiarios.MultiSelect = false;
            grillaBeneficiarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaBecas.MultiSelect = false;
            grillaBecas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaBecaDelBeneficiario.MultiSelect = false;
            grillaBecaDelBeneficiario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cbxTipoBeneficiario.SelectedIndex = 0;
            dtpFechaOtorgamiento.MaxDate = DateTime.Now;
        }

        private void Mostrar(DataGridView pGrilla, object pObjeto)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pObjeto;
        }
        private void btnAgregarBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = Interaction.InputBox("Ingrese el legajo", "Alta beneficiario");

                if (legajo.Length == 0) throw new Exception("El legajo está vacio");
                if (universidad.ValidarLegajoRepetido(legajo)) throw new Exception("El legajo está repetido");

                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta beneficiario");
                string apellido = Interaction.InputBox("Ingrese el apellido", "Alta beneficiario");
                string dni = Interaction.InputBox("Ingrese el DNI", "Alta beneficiario");
                if (nombre.Length == 0) throw new Exception("El legajo está vacio");
                if (apellido.Length == 0) throw new Exception("El legajo está vacio");
                if (dni.Length == 0) throw new Exception("El legajo está vacio");


                if (cbxTipoBeneficiario.SelectedIndex == 0)
                {
                    Ingresante benef = new Ingresante(legajo, nombre, apellido, dni, 0);
                    universidad.AgregarBeneficiario(benef);
                }
                else if (cbxTipoBeneficiario.SelectedIndex == 1)
                {
                    Grado benef = new Grado(legajo, nombre, apellido, dni, 0);
                    universidad.AgregarBeneficiario(benef);
                }
                else
                {
                    Posgrado benef = new Posgrado(legajo, nombre, apellido, dni, 0);
                    universidad.AgregarBeneficiario(benef);
                }
                Mostrar(grillaBeneficiarios, universidad.ObtenerBeneficiarios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaBeneficiarios.Rows.Count == 0) throw new Exception("No hay beneficiarios en la grilla");
                var benef = grillaBeneficiarios.SelectedRows[0].DataBoundItem as Beneficiario;
                universidad.BorrarBeneficiario(benef);
                Mostrar(grillaBeneficiarios, universidad.ObtenerBeneficiarios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaBeneficiarios.Rows.Count == 0) throw new Exception("No hay beneficiarios en la grilla");
                var benefViejo = grillaBeneficiarios.SelectedRows[0].DataBoundItem as Beneficiario;

                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta beneficiario", benefViejo.Nombre);
                string apellido = Interaction.InputBox("Ingrese el apellido", "Alta beneficiario", benefViejo.Apellido);
                string dni = Interaction.InputBox("Ingrese el DNI", "Alta beneficiario", benefViejo.Dni);
                if (nombre.Length == 0) throw new Exception("El legajo está vacio");
                if (apellido.Length == 0) throw new Exception("El legajo está vacio");
                if (dni.Length == 0) throw new Exception("El legajo está vacio");

                if (benefViejo is Ingresante)
                {
                    Ingresante benef = new Ingresante(benefViejo.Legajo, nombre, apellido, dni, 0);
                    universidad.ModificarBeneficiario(benef);
                }
                else if (benefViejo is Grado)
                {
                    Grado benef = new Grado(benefViejo.Legajo, nombre, apellido, dni, 0);
                    universidad.ModificarBeneficiario(benef);
                }
                else
                {
                    Posgrado benef = new Posgrado(benefViejo.Legajo, nombre, apellido, dni, 0);
                    universidad.ModificarBeneficiario(benef);
                }
                Mostrar(grillaBeneficiarios, universidad.ObtenerBeneficiarios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarBeca_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Ingrese el código con el formato [1234AB]", "Alta beca");
                string formatoCodigo = @"^[0-9]{4}[A-Z]{2}";
                DateTime fechaOtorgamiento = dtpFechaOtorgamiento.Value;

                if (!Regex.IsMatch(codigo, formatoCodigo)) throw new Exception("El código no cumple con el formato");
                if (universidad.ValidarCodigoBecaRepetido(codigo)) throw new Exception("El código está repetido");

                string inputImporte = Interaction.InputBox("Ingrese el importe", "Alta beca");
                if (!decimal.TryParse(inputImporte, out decimal importe)) throw new Exception("El importe debe ser numérico");

                Beca beca = new Beca(codigo, fechaOtorgamiento, importe);
                universidad.AgregarBeca(beca);
                Mostrar(grillaBecas, universidad.ObtenerBecas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaBeneficiarios.Rows.Count == 0) throw new Exception("No hay beneficiarios en la grilla");
                var benefViejo = grillaBeneficiarios.SelectedRows[0].DataBoundItem as Beneficiario;

                string inputPagoMensual = Interaction.InputBox("Ingrese el importe", "Pago de la cuota");

                if (!decimal.TryParse(inputPagoMensual, out decimal pagoMensual)) throw new Exception("El pago mensual debe ser numerico");

                if (benefViejo is Ingresante)
                {
                    Ingresante benef = new Ingresante(benefViejo.Legajo, benefViejo.Nombre, benefViejo.Apellido, benefViejo.Dni, pagoMensual);
                    universidad.ModificarBeneficiario(benef);

                    decimal importe = decimal.Parse(grillaBecas.SelectedRows[0].Cells[2].Value.ToString());
                    pagoMensual = universidad.PagarCuota(benef, importe);

                    MessageBox.Show($"La cuota (con beneficio) tiene el valor de {benef.PagoMensual - pagoMensual - importe}");


                }
                else if (benefViejo is Grado)
                {
                    Grado benef = new Grado(benefViejo.Legajo, benefViejo.Nombre, benefViejo.Apellido, benefViejo.Dni, pagoMensual);
                    universidad.ModificarBeneficiario(benef);

                    decimal importe = decimal.Parse(grillaBecas.SelectedRows[0].Cells[2].Value.ToString());
                    pagoMensual = universidad.PagarCuota(benef, importe);

                    MessageBox.Show($"La cuota (con beneficio) tiene el valor de {benef.PagoMensual - pagoMensual - importe}");

                }
                else
                {
                    Posgrado benef = new Posgrado(benefViejo.Legajo, benefViejo.Nombre, benefViejo.Apellido, benefViejo.Dni, pagoMensual);
                    universidad.ModificarBeneficiario(benef);
                    decimal importe = decimal.Parse(grillaBecas.SelectedRows[0].Cells[2].Value.ToString());
                    pagoMensual = universidad.PagarCuota(benef, importe);

                    MessageBox.Show($"La cuota (con beneficio) tiene el valor de {benef.PagoMensual - pagoMensual - importe}");

                }
                Mostrar(grillaBeneficiarios, universidad.ObtenerBeneficiarios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarBeca_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaBeneficiarios.Rows.Count == 0) throw new Exception("No hay beneficiarios en la grilla");
                if (grillaBecas.Rows.Count == 0) throw new Exception("No hay becas en la grilla");

                var beneficiario = grillaBeneficiarios.SelectedRows[0].DataBoundItem as Beneficiario;
                var beca = grillaBecas.SelectedRows[0].DataBoundItem as Beca;

                universidad.AsignarBecaABeneficiario(beca, beneficiario);
                Mostrar(grillaBecaDelBeneficiario, universidad.ObtenerBecaDelBeneficiario(beneficiario));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarBeca_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaBeneficiarios.Rows.Count == 0) throw new Exception("No hay beneficiarios en la grilla");
                if (grillaBecas.Rows.Count == 0) throw new Exception("No hay becas en la grilla");

                var beneficiario = grillaBeneficiarios.SelectedRows[0].DataBoundItem as Beneficiario;

                universidad.QuitarBeca(beneficiario);
                Mostrar(grillaBecaDelBeneficiario, universidad.ObtenerBecaDelBeneficiario(beneficiario));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaBeneficiarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grillaBeneficiarios.Rows.Count > 0)
                {
                    var beneficiario = grillaBeneficiarios.SelectedRows[0].DataBoundItem as Beneficiario;
                    Mostrar(grillaBecaDelBeneficiario, universidad.ObtenerBecaDelBeneficiario(beneficiario));
                }
            }
            catch (Exception) { }
        }
    }
}
