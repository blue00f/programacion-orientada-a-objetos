using Microsoft.VisualBasic;
using System.Text;

namespace GestionBanco
{
    public partial class Form1 : Form
    {
        Banco banco;
        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            banco.ErrorOperacion += DesencadenaEvento;
        }
        private void DesencadenaEvento(object sender, OperacionErroneaEventArgs e)
        {
            string s = e.CuentaDestino == null ? "-" : e.CuentaDestino.Numero.ToString();
            MessageBox.Show(
                $"Mensaje: {e.Mensaje}" +
                $"{Environment.NewLine}Cuenta origen: {e.CuentaOrigen.Numero}" +
                $"{Environment.NewLine}Cuenta destino: {s}" +
                $"{Environment.NewLine}Importe: {e.Importe}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Mostrar(DataGridView pDgv, object pObj)
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pObj;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grillaClientes.MultiSelect = false;
            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaCuentas.MultiSelect = false;
            grillaCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTodasLasCuentas.MultiSelect = false;
            grillaTodasLasCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int dni;
                if (!int.TryParse(Interaction.InputBox("Ingrese el DNI", "Alta cliente"), out dni)) throw new Exception("El DNI debe ser numérico");

                string nombre = Interaction.InputBox("Ingrese el nombre", "Alta cliente");
                string apellido = Interaction.InputBox("Ingrese el apellido", "Alta cliente");
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacio!");

                Cliente c = new Cliente(dni, nombre, apellido);
                if (banco.DniExistente(c)) throw new Exception("El DNI ya existe!");
                banco.AgregarCliente(c);
                Mostrar(grillaClientes, banco.RetornaClientes());
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes para borrar!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                banco.BorrarCliente(cliente);
                Mostrar(grillaClientes, banco.RetornaClientes());
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
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
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes para modificar!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                int dni;
                if (!int.TryParse(Interaction.InputBox("Ingrese el DNI", "Modificando cliente", cliente.Dni.ToString()), out dni)) throw new Exception("El DNI debe ser numérico");

                string nombre = Interaction.InputBox("Ingrese el nombre", "Modificando cliente", cliente.Nombre);
                string apellido = Interaction.InputBox("Ingrese el apellido", "Modificando cliente", cliente.Apellido);
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacio!");

                Cliente clienteNuevo = new Cliente(dni, nombre, apellido);
                banco.ModificarCliente(cliente, clienteNuevo);

                Mostrar(grillaClientes, banco.RetornaClientes());
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAsignarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay cliente seleccionado!");
                int numeroCuenta;
                decimal saldo, descubierto = 0;

                if (!int.TryParse(Interaction.InputBox("Ingrese el numero de cuenta", "Datos cuenta"), out numeroCuenta)) throw new Exception("El numero de la cuenta debe ser numérico!");
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el saldo", "Datos cuenta"), out saldo)) throw new Exception("El saldo debe ser numérico!");

                if (radCuentaCorriente.Checked)
                {
                    if (!decimal.TryParse(Interaction.InputBox("Ingrese el descubierto", "Datos cuenta"), out descubierto)) throw new Exception("El descubierto debe ser numérico!");
                }

                Cuenta cuenta = radCajaAhorro.Checked ? new CajaAhorro(numeroCuenta, saldo) : new CuentaCorriente(numeroCuenta, saldo, descubierto);
                if (banco.CuentaExistente(cuenta)) throw new Exception("EL numero de la cuenta ya existe!");

                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                banco.AgregarCuentaACliente(cliente, cuenta);
                Mostrar(grillaCuentas, banco.RetornaCuentasCliente(cliente));
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaCuentas.Rows.Count == 0) throw new Exception("No hay cuentas para borrar!");

                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                Cuenta cuenta;
                int numeroCuenta = (int)grillaCuentas.SelectedRows[0].Cells[0].Value;
                decimal saldo = (decimal)grillaCuentas.SelectedRows[0].Cells[1].Value;

                if (grillaCuentas.SelectedRows[0].Cells[2].Value.ToString() == "-")
                {
                    cuenta = new CajaAhorro(numeroCuenta, saldo);
                }
                else
                {
                    decimal descubierto = Convert.ToDecimal(grillaCuentas.SelectedRows[0].Cells[2].Value);
                    cuenta = new CuentaCorriente(numeroCuenta, saldo, descubierto);
                }

                banco.BorrarCuenta(cliente, cuenta);
                Mostrar(grillaCuentas, banco.RetornaCuentasCliente(cliente));
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaCuentas.Rows.Count == 0) throw new Exception("No hay cuentas para modificar!");
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes en la grilla!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                int numeroCuentaViejo = (int)grillaCuentas.SelectedRows[0].Cells[0].Value;
                decimal saldoViejo = (decimal)grillaCuentas.SelectedRows[0].Cells[1].Value;
                decimal descubiertoViejo;

                Cuenta cuentaVieja, cuentaNueva;
                int numeroCuenta;
                decimal saldo, descubierto = 0;

                if (!int.TryParse(Interaction.InputBox("Ingrese el numero de cuenta", "Modificando cuenta", numeroCuentaViejo.ToString()), out numeroCuenta)) throw new Exception("El número de cuenta debe ser numerico!");
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el saldo", "Modificando cuenta", saldoViejo.ToString()), out saldo)) throw new Exception("El saldo debe ser numerico!");

                if (grillaCuentas.SelectedRows[0].Cells[2].Value.ToString() == "-")
                {
                    cuentaVieja = new CajaAhorro(numeroCuentaViejo, saldoViejo);
                    cuentaNueva = new CajaAhorro(numeroCuenta, saldo);
                }
                else
                {
                    descubiertoViejo = Convert.ToDecimal(grillaCuentas.SelectedRows[0].Cells[2].Value);
                    if (!decimal.TryParse(Interaction.InputBox("Ingrese el descubierto", "Modificando cuenta", descubiertoViejo.ToString()), out descubierto)) throw new Exception("El descubierto debe ser numerico!");
                    cuentaVieja = new CuentaCorriente(numeroCuentaViejo, saldoViejo, descubiertoViejo);
                    cuentaNueva = new CuentaCorriente(numeroCuenta, saldo, descubierto);
                }

                banco.ModificarCuenta(cliente, cuentaVieja, cuentaNueva);

                Mostrar(grillaClientes, banco.RetornaClientes());
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
                Mostrar(grillaCuentas, banco.RetornaCuentasCliente(cliente));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay un cliente seleccionado!");
                if (grillaCuentas.Rows.Count == 0) throw new Exception("No hay una cuenta seleccionada!");
                decimal importe;
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el importe a depositar", "Depósito"), out importe)) throw new Exception("El importe debe ser numérico!");
                if (importe <= 0) throw new Exception("El importe debe ser mayor a cero!");

                int numeroCuenta = Convert.ToInt32(grillaCuentas.SelectedRows[0].Cells[0].Value);
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                banco.Depositar(cliente.Dni, numeroCuenta, importe);

                Mostrar(grillaCuentas, banco.RetornaCuentasCliente(cliente));
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay un cliente seleccionado!");
                if (grillaCuentas.Rows.Count == 0) throw new Exception("No hay una cuenta seleccionada!");
                decimal importe;
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el importe a extraer", "Extracción"), out importe)) throw new Exception("El importe debe ser numérico!");
                if (importe <= 0) throw new Exception("El importe de extracción debe ser mayor a cero!");

                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                int numeroCuenta = Convert.ToInt32(grillaCuentas.SelectedRows[0].Cells[0].Value);
                banco.Extraer(cliente.Dni, numeroCuenta, importe);

                Mostrar(grillaCuentas, banco.RetornaCuentasCliente(cliente));
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay un cliente seleccionado!");
                if (grillaCuentas.Rows.Count == 0) throw new Exception("No hay una cuenta de origen seleccionada!");
                if (grillaTodasLasCuentas.Rows.Count == 0) throw new Exception("No hay una cuenta de destino seleccionada!");

                decimal importe;
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el importe a transferir", "Transferencia"), out importe)) throw new Exception("El importe debe ser numérico!");
                if (importe <= 0) throw new Exception("El importe a transferir debe ser mayor a cero!");

                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                int numeroCuentaO = Convert.ToInt32(grillaCuentas.SelectedRows[0].Cells[0].Value);
                int numeroCuentaD = Convert.ToInt32(grillaTodasLasCuentas.SelectedRows[0].Cells[0].Value);

                banco.Transferir(cliente.Dni, numeroCuentaO, numeroCuentaD, importe);

                Mostrar(grillaCuentas, banco.RetornaCuentasCliente(cliente));
                Mostrar(grillaTodasLasCuentas, banco.RetornaTodasLasCuentasDelBanco());
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
                    Mostrar(grillaCuentas, banco.RetornaCuentasCliente(grillaClientes.SelectedRows[0].DataBoundItem as Cliente));
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
