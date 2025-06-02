using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploServidor
{
    public partial class ServidorForm : Form
    {
        Servidor servidor;

        public ServidorForm()
        {
            InitializeComponent();
        }

        private void Log(string texto)
        {
            // Invoke nos permite ejecutar un delegado en el tread de la UI. 
            // El problema radica en que no es seguro interactuar con los controles
            // de Windows Forms desde múltiples threads. Y en este ejemplo, el 
            // método Log se está llamando desde eventos que se disparan desde
            // threads creados en el objeto Servidor.
            // Ver: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls
            Invoke((Action)delegate
            {
                txtLog.AppendText($"{DateTime.Now.ToLongTimeString()} - {texto}");
                txtLog.AppendText("\n");
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializo el servidor estableciendo el puerto donde escuchar
            servidor = new Servidor(8050);

            // Me suscribo a los eventos
            servidor.NuevaConexion += Servidor_NuevaConexion;
            servidor.ConexionTerminada += Servidor_ConexionTerminada;
            servidor.DatosRecibidos += Servidor_DatosRecibidos;

            // Comienzo la escucha
            servidor.Escuchar();
        }

        private void Servidor_NuevaConexion(object sender, ServidorEventArgs e)
        {
            //  Muestro quién se conectó
            Log($"Se ha conectado un nuevo cliente desde la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}");
        }

        private void Servidor_ConexionTerminada(object sender, ServidorEventArgs e)
        {
            // Muestro con quién se terminó la conexión
            Log($"Se ha desconectado el cliente de la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}");
        }

        private void Servidor_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            // Muestro quién envió el mensaje
            Log($"Nuevo mensaje desde el cliente de la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}");

            //  Muestro el mensaje recibido
            Log(e.DatosRecibidos);
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            servidor.EnviarDatos(txtMensaje.Text);
        }
    }
}
