using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCliente
{
    public partial class ClienteForm : Form
    {
        Cliente cliente;

        public ClienteForm()
        {
            InitializeComponent();
        }
        
        private void Log(string texto)
        {
            // Invoke nos permite ejecutar un delegado en el tread de la UI. 
            // El problema radica en que no es seguro interactuar con los controles
            // de Windows Forms desde múltiples threads. Y en este ejemplo, el 
            // método Log se está llamando desde eventos que se disparan desde
            // threads creados en el objeto Cliente.
            // Ver: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls
            Invoke((Action)delegate
            {
                txtLog.AppendText($"{DateTime.Now.ToLongTimeString()} - {texto}");
                txtLog.AppendText("\n");
            });
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            // Creo una instancia de Cliente y me suscribo a los eventos
            cliente = new Cliente();
            cliente.ConexionTerminada += Cliente_ConexionTerminada;
            cliente.DatosRecibidos += Cliente_DatosRecibidos;
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

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Primero intento parsear el texto ingreasado a txtPuerto.
            // Si no es un entero muestro un mensaje de error y no hago nada más.
            int puerto;
            if (!int.TryParse(txtPuerto.Text, out puerto))
            {
                MessageBox.Show("El puerto ingresado no es válido", Text);
                return;
            }

            // Obtengo la IP ingresada en txtIP
            string ip = txtIP.Text;

            // Me conecto con los datos ingresados
            cliente.Conectar(ip, puerto);
            Log($"El cliente se conectó al servidor IP = {cliente.RemoteEndPoint.Address}, Puerto = {cliente.RemoteEndPoint.Port}");

            // Actualizo la GUI
            UpdateUI();
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            // Envío lo que está escrito en la caja de texto del mensaje
            cliente.EnviarDatos(txtMensaje.Text);
        }

        private void UpdateUI()
        {
            // Como este método se llama desde threads distintos al de la GUI 
            // necesitamos usar Invoke para poder acceder a los controles del form.
            Invoke((Action)delegate
            {
                // Habilito la posiblidad de conexión si el cliente está desconectado
                txtIP.Enabled = txtPuerto.Enabled = btnConectar.Enabled = !cliente.Conectado;

                // Habilito la posibilidad de enviar mensajes si el cliente está conectado
                txtMensaje.Enabled = btnEnviarMensaje.Enabled = cliente.Conectado;

                if (cliente.Conectado)
                {
                    Text = $"Cliente (IP = {cliente.LocalEndPoint.Address}, Puerto = {cliente.LocalEndPoint.Port})";
                }
                else
                {
                    Text = "Cliente";
                }
            });
        }
    }
}