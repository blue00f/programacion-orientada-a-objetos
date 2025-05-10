using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
    las cuentas corrientes y las cajas de ahorro. El banco tambi�n posee titulares de cuenta.
    Una cuenta puede poseer m�s de un titular y estos pueden tener m�s de una cuenta. 
    Las cuentas se identifican por un n�mero y los titulares por su n�mero de DNI.
    De los titulares tambi�n se desea saber su nombre y apellido.De las cuentas deseamos conocer 
    su saldo.
    En las cuentas del banco se pueden realizar dep�sitos, extracciones y transferencias de una 
    cuenta a otra. Un aspecto significativo es que las cuentas corrientes poseen una caracter�stica 
    que es la de poder girar en dinero en descubierto.El l�mite de descubierto es una caracter�stica 
    de cada cuenta corriente.
    Respete la herencia y el polimorfismo necesario para resolver el ejercicio.
    Desarrolle al menos un evento que Ud.desee, que sea �til al programa y que pueda observarse 
    c�mo funciona.
    Utilice una estructura try�Catch para interceptar alg�n error.
    Utilizar 4 grillas:

        1. Grilla de Clientes / Titulares con los botones Agregar, Borrar y Modificar
        2. Grilla de Cuentas con los botones Agregar, Borrar y Modificar
        3. Grilla de Cuentas del titular seleccionado en la Grilla1.
        4. Grilla de Titulares de la cuenta seleccionada en la Grilla2.

    Para asignar una cuenta a un titular se utiliza un bot�n Asignar.

    Agregar los botones Depositar, Extraer y Transferir.Esta �ltima operaci�n toma de la Grilla 3 
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
                //Todo: Verificar si se actualiza Grilla 2,3,4

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
                //Todo: Verificar si se actualiza Grilla 2,3,4

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var numero = Interaction.InputBox("Ingrese el n�mero del cuenta", "NUMERO DE CUENTA", "00000000");
                Cuenta cta = (comboBox1.SelectedItem as MyItem).GetCuenta.CloneTipado();
                cta.Numero = numero;
                if (!validadorCuenta.Valida(cta)) throw new Exception("la cuenta debe ser num�rica !!!");
                if (banco.ExisteNumeroCuenta(cta)) throw new Exception("Ya existe una cuenta con ese n�mero !!!");
                //Vemos si cta es una cta cte. En caso afirmativo cargamos el descubierto
                if (cta is CC)
                {
                    var descubierto = Interaction.InputBox("Ingrese el descubierto", "Descubierto", "0");
                    if (!Information.IsNumeric(descubierto)) throw new Exception("El descubierto debe ser un valor num�rico");
                    ((CC)cta).Descubierto = Convert.ToDecimal(descubierto);
                }
                banco.AgregarCuenta(cta);
                Mostrar(dataGridView2, banco.ObtenerCuentas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Obtengo el objeto an�nimo de la fila de la grilla 2
            var o = dataGridView2.SelectedRows[0].DataBoundItem;
            //Obtengo el tipo del objetop o
            var t = o.GetType();
            // a ese tipo le solicito sus propiedades y el la propiedad que se 
            // encuentra en la posici�n 2 esta Tipo que contiene al objeto original
            var z = t.GetProperties();
            // Ontengo el objeto original
            var w = z[2].GetValue(o);

            var nCuenta = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();



        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                Cuenta? cuenta = ObtieneAnonymusToCuentaGrilla2();
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

        private Cuenta? ObtieneAnonymusToCuentaGrilla2()
        {
            //Obtengo el objeto an�nimo de la fila de la grilla 2
            var o = dataGridView2.SelectedRows[0].DataBoundItem;
            //Obtengo el tipo del objetop o
            var t = o.GetType();
            // a ese tipo le solicito sus propiedades y el la propiedad que se 
            // encuentra en la posici�n 2 esta Tipo que contiene al objeto original
            var z = t.GetProperties();
            // Ontengo el objeto original
            var w = z[2].GetValue(o);
            var cuenta = (Cuenta)w;
            return cuenta;
        }

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
                if(dataGridView2.Rows.Count>0)
                    Mostrar(dataGridView4, banco.ObtenerTitularesCuenta(ObtieneAnonymusToCuentaGrilla2()));
            }
            catch (Exception)
            {

           
            }
        }
    }
}
