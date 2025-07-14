using Ejercicio_Servidor.Eventos;
using System.Net;

namespace Ejercicio_Servidor
{
    public partial class Form1 : Form
    {
        Servidor servidor;
        public Form1()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            Invoke((Action)delegate
            {
                grillaClientes.DataSource = null;
                grillaClientes.DataSource = servidor.ObtenerClientesConectados();
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaClientes.MultiSelect = false;
            grillaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            servidor = new Servidor(8050);
            servidor.NuevaConexion += Servidor_NuevaConexion;
            servidor.DatosRecibidos += Servidor_DatosRecibidos;
            servidor.ConexionTerminada += Servidor_ConexionTerminada;
            servidor.Escuchar();
        }
        private void Log(string pTexto)
        {
            Invoke((Action)delegate
            {
                txtLog.AppendText($"{Environment.NewLine}{DateTime.Now.ToLongTimeString()} - {pTexto}");
            });
        }
        private void Servidor_NuevaConexion(object sender, ServidorEventArgs e)
        {
            Log($"Se ha conectado un nuevo cliente {e.EndPoint.Address}:{e.EndPoint.Port}");
            Mostrar();
        }
        private void Servidor_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            Log($"@{e.EndPoint.Address}:{e.EndPoint.Port} - {e.DatosRecibidos}");
            Mostrar();

            string[] partes = e.DatosRecibidos.Split(new char[] { '|' }, 2);


            if (partes[0] == "TODOS")
            {
                servidor.EnviarDatos(e.EndPoint, e.DatosRecibidos);
            }
            else
            {
                var ip = IPAddress.Parse(partes[0].Split(':')[0]);
                var port = int.Parse(partes[0].Split(':')[1]);
                var destino = new IPEndPoint(ip, port);
                string mensaje = partes[1];
                servidor.EnviarDatosA(destino, e.DatosRecibidos);
            }
        }
        private void Servidor_ConexionTerminada(object sender, ServidorEventArgs e)
        {
            Log($"Se ha desconectado el cliente {e.EndPoint.Address}:{e.EndPoint.Port}");
            Mostrar();
        }
        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            servidor.EnviarDatos(txtMensaje.Text);
        }

        private void btnEnviarMensajeAUnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClientes.Rows.Count == 0) throw new Exception("No hay clientes conectados!");
                var cliente = grillaClientes.SelectedRows[0].DataBoundItem as ClienteInfo;
                servidor.EnviarDatosA(cliente.EndPoint, txtMensaje.Text);
                Log($"Mensaje enviado a {cliente.EndPoint}: {txtMensaje.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
