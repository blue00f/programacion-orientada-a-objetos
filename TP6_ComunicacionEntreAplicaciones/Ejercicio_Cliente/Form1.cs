using Ejercicio_Cliente.Eventos;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Ejercicio_Cliente
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxDestinatario.SelectedIndex = 0;

            cliente = new Cliente();
            cliente.ConexionTerminada += Cliente_ConexionTerminada;
            cliente.DatosRecibidos += Cliente_DatosRecibidos;
        }
        private void Log(string pTexto)
        {
            Invoke((Action)delegate
            {
                txtLog.AppendText($"{Environment.NewLine}{DateTime.Now.ToLongTimeString()} - {pTexto}");
            });
        }
        private void Cliente_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            Log($"El servidor envió el siguiente mensaje: {e.DatosRecibidos}");
        }
        private void Cliente_ConexionTerminada(object sender, EventArgs e)
        {
            Log("Finalizó la conexión");
            UpdateUI();
        }
        private void UpdateUI()
        {
            Invoke((Action)delegate
            {
                txtIp.Enabled = txtPuerto.Enabled = btnConectar.Enabled = !cliente.Conectado;
                txtMensaje.Enabled = btnEnviarMensaje.Enabled = cliente.Conectado;

                if (cliente.Conectado) Text = $"{cliente.Nombre} ({cliente.LocalEndPoint.Address.MapToIPv4()}:{cliente.LocalEndPoint.Port})";
                else Text = "Cliente";
            });
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre", "Cliente");
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacío!");
                cliente.Nombre = nombre;
                int puerto;
                if (!int.TryParse(txtPuerto.Text, out puerto)) throw new Exception("El puerto no es válido!");

                string ip = txtIp.Text;
                cliente.Conectar(ip, puerto);
                Log($"{cliente.Nombre} se conectó al servidor {cliente.RemoteEndPoint.Address.MapToIPv4()}:{cliente.RemoteEndPoint.Port}");
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            string destinatario = cbxDestinatario.Text;
            string mensaje = txtMensaje.Text;
            string mensajeFormateado = $"{destinatario}|{mensaje}";
            cliente.EnviarDatos(mensajeFormateado);
        }
    }
}
