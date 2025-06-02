using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using Ejemplo_05_Banco.Servicios;
using Ejemplo_05_Banco.Entidades;
namespace Ejemplo_05_Banco
{
    /*
    Enunciado:

    Nos solicitan desarrollar un programa que nos permita administrar las cuentas de un banco.
    Dado ese escenario bancario nos manifiestan la necesidad de desarrollar un sistema para 
    administrar las cuentas de los clientes. Nos manifiestan que poseen dos tipos de cuentas: 
    las cuentas corrientes y las cajas de ahorro. El banco también posee titulares de cuenta.
    Una cuenta puede poseer más de un titular y estos pueden tener más de una cuenta. 
    Las cuentas se identifican por un número y los titulares por su número de DNI.
    De los titulares también se desea saber su nombre y apellido.De las cuentas deseamos conocer 
    su saldo.
    En las cuentas del banco se pueden realizar depósitos, extracciones y transferencias de una 
    cuenta a otra. Un aspecto significativo es que las cuentas corrientes poseen una característica 
    que es la de poder girar dinero en descubierto.El límite de descubierto es una característica 
    de cada cuenta corriente.
    Respete la herencia y el polimorfismo necesario para resolver el ejercicio.
    Desarrolle al menos un evento que Ud.desee, que sea útil al programa y que pueda observarse 
    cómo funciona.
    Utilice una estructura try…Catch para interceptar algún error.
    Utilizar 4 grillas:

        1. Grilla de Clientes / Titulares con los botones Agregar, Borrar y Modificar
        2. Grilla de Cuentas con los botones Agregar, Borrar y Modificar
        3. Grilla de Cuentas del titular seleccionado en la Grilla1.
        4. Grilla de Titulares de la cuenta seleccionada en la Grilla2.

    Para asignar una cuenta a un titular se utiliza un botón Asignar.

    Agregar los botones Depositar, Extraer y Transferir.Esta última operación toma de la Grilla 3 
    la cuenta de origen de los fondos y de la Grilla 2 la cuenta de destino de los fondos.
*/




    public partial class Form1 : Form
    {
        ValidaDNI validadorDNI;
        ValidaCuenta validadorCuenta;
        Banco banco;
        public Form1()
        {
            InitializeComponent();
            validadorDNI = new ValidaDNI();
            validadorCuenta = new ValidaCuenta();
            banco = new Banco();
            banco.SaldoInsuficiente += Banco_SaldoInsuficiente;
        }
        private void Banco_SaldoInsuficiente(object sender, EventArgs e)
        {
            var cuenta = (Cuenta)sender;
            MessageBox.Show($"La cuenta {cuenta.Numero} tiene un saldo insuficiente para realizar la operación", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is DataGridView)
                {
                    ((DataGridView)control).MultiSelect = false;
                    ((DataGridView)control).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            comboBox1.Items.Add(new MyItem(new CA()));
            comboBox1.Items.Add(new MyItem(new CC()));
            comboBox1.SelectedIndex = 0;

        }
        private void Mostrar(DataGridView pDGV, object pO)
        { pDGV.DataSource = null; pDGV.DataSource = pO; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dni = Interaction.InputBox("Ingrese el DNI del cliente", "DNI", "00000000");
                Cliente cliente = new Cliente() { DNI = dni };
                if (!validadorDNI.Valida(cliente)) throw new Exception("El DNI no valida !!!");
                if (banco.ExisteDNICliente(cliente)) throw new Exception("Ya existe un cliente con ese DNI !!!");
                cliente.Nombre = Interaction.InputBox("Ingrese el nombre del cliente", "Nombre", "Nombre");
                cliente.Apellido = Interaction.InputBox("Ingrese el apellido del cliente", "Apellido", "Apellido");
                banco.AgregarCliente(cliente);
                Mostrar(dataGridView1, banco.ObtenerClientes());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay clientes para borrar !!!");
                var cliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                banco.BorrarCliente(cliente);
                Mostrar(dataGridView1, banco.ObtenerClientes());
                Mostrar(dataGridView2, banco.ObtenerCuentas());
                if (dataGridView1.Rows.Count > 0) { Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente)); }
                else { Mostrar(dataGridView3, null); }
                if (dataGridView2.Rows.Count > 0) { Mostrar(dataGridView4, banco.ObtenerTitularesCuenta(ObtieneAnonymusToCuentaGrilla2_3(dataGridView2))); }
                else { Mostrar(dataGridView4, null); }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay clientes para modificar !!!");
                var cliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                cliente.Nombre = Interaction.InputBox("Nombre: ", "Modificando...", cliente.Nombre);
                cliente.Apellido = Interaction.InputBox("Apellido: ", "Modificando...", cliente.Apellido);
                banco.ModificarCliente(cliente);
                Mostrar(dataGridView1, banco.ObtenerClientes());
                Mostrar(dataGridView2, banco.ObtenerCuentas());
                if (dataGridView1.Rows.Count > 0) { Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente)); }
                else { Mostrar(dataGridView3, null); }
                if (dataGridView2.Rows.Count > 0) { Mostrar(dataGridView4, banco.ObtenerTitularesCuenta(ObtieneAnonymusToCuentaGrilla2_3(dataGridView2))); }
                else { Mostrar(dataGridView4, null); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var numero = Interaction.InputBox("Ingrese el número del cuenta", "NUMERO DE CUENTA", "00000000");
                Cuenta cta = (comboBox1.SelectedItem as MyItem).GetCuenta.CloneTipado();
                cta.Numero = numero;
                if (!validadorCuenta.Valida(cta)) throw new Exception("la cuenta debe ser numérica !!!");
                if (banco.ExisteNumeroCuenta(cta)) throw new Exception("Ya existe una cuenta con ese número !!!");
                //Vemos si cta es una cta cte. En caso afirmativo cargamos el descubierto
                if (cta is CC)
                {
                    var descubierto = Interaction.InputBox("Ingrese el descubierto", "Descubierto", "0");
                    if (!Information.IsNumeric(descubierto)) throw new Exception("El descubierto debe ser un valor numérico");
                    ((CC)cta).Descubierto = Convert.ToDecimal(descubierto);
                }
                banco.AgregarCuenta(cta);
                Mostrar(dataGridView2, banco.ObtenerCuentas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay clientes a quien asignarles !!!");
                if (dataGridView2.Rows.Count == 0) throw new Exception("No hay cuentas para asignar !!!");
                var cliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                Cuenta? cuenta = ObtieneAnonymusToCuentaGrilla2_3(dataGridView2);
                if (cuenta == null) throw new Exception("No hay cuentas para asignar !!!");
                //var cuenta = new CA() { Numero = dataGridView2.SelectedRows[0].Cells[0].Value.ToString() };
                banco.AgregarCuentaACliente(cliente, cuenta);
                Mostrar(dataGridView1, banco.ObtenerClientes());
                Mostrar(dataGridView2, banco.ObtenerCuentas());
                if (dataGridView1.Rows.Count > 0) Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));
                if (dataGridView2.Rows.Count > 0) Mostrar(dataGridView4, banco.ObtenerTitularesCuenta(cuenta));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private Cuenta? ObtieneAnonymusToCuentaGrilla2_3(DataGridView pDGV)
        {
            //Obtengo el objeto anónimo de la fila de la grilla 2
            var o = pDGV.SelectedRows[0].DataBoundItem;
            //Obtengo el tipo del objeto o
            var t = o.GetType();
            // a ese tipo le solicito sus propiedades y el la propiedad que se 
            // encuentra en la posición 2 esta Tipo que contiene al objeto original
            var z = t.GetProperties();
            // Ontengo el objeto original
            var w = z[2].GetValue(o);
            var cuenta = (Cuenta)w;
            return cuenta;
        }
        //Igual al la función anterior pero en una línea
        //private Cuenta? ObtenerCuentaDesdeGrilla2() => dataGridView2.SelectedRows[0].DataBoundItem?.GetType().GetProperties()[2].GetValue(dataGridView2.SelectedRows[0].DataBoundItem) as Cuenta;

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                    Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));
            }
            catch (Exception)
            {


            }
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                    Mostrar(dataGridView4, banco.ObtenerTitularesCuenta(ObtieneAnonymusToCuentaGrilla2_3(dataGridView2)));
            }
            catch (Exception)
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.Rows.Count == 0) throw new Exception("No hay cuentas para depositar !!!");
                Cuenta? cuenta = ObtieneAnonymusToCuentaGrilla2_3(dataGridView3);
                var importe = Interaction.InputBox("Ingrese el importe a depositar", "Deposito", "0");
                if (!Information.IsNumeric(importe)) throw new Exception("El importe debe ser numérico");
                banco.Depositar(cuenta, Convert.ToDecimal(importe));
                Mostrar(dataGridView2, banco.ObtenerCuentas());
                if (dataGridView1.Rows.Count > 0) Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.Rows.Count == 0) throw new Exception("No hay cuentas para extraer !!!");
                Cuenta? cuenta = ObtieneAnonymusToCuentaGrilla2_3(dataGridView3);
                var importe = Interaction.InputBox("Ingrese el importe a extraer", "Extracción", "0");
                if (!Information.IsNumeric(importe)) throw new Exception("El importe debe ser numérico");
                banco.Extraer(cuenta, Convert.ToDecimal(importe));
                Mostrar(dataGridView2, banco.ObtenerCuentas());
                if (dataGridView1.Rows.Count > 0) Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.Rows.Count == 0) throw new Exception("No hay cuentas de origen para transferir !!!");
                if (dataGridView3.Rows.Count == 0) throw new Exception("No hay cuentas de destino para transferir !!!");
                Cuenta? cuentaOrigen = ObtieneAnonymusToCuentaGrilla2_3(dataGridView3);
                Cuenta? cuentaDestino = ObtieneAnonymusToCuentaGrilla2_3(dataGridView2);
                var importe = Interaction.InputBox("Ingrese el importe a transferir", "Transferencia", "0");
                if (!Information.IsNumeric(importe)) throw new Exception("El importe debe ser numérico");
                banco.Transferir(cuentaOrigen, cuentaDestino, Convert.ToDecimal(importe));
                Mostrar(dataGridView2, banco.ObtenerCuentas());
                if (dataGridView1.Rows.Count > 0) Mostrar(dataGridView3, banco.ObtenerCuentasCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
