namespace EventoEstatico
{
    public partial class Form1 : Form
    {
        Sensor sensor;
        public Form1()
        {
            InitializeComponent();
            Sensor.AlertaTemperaturaAlta += Sensor_AlertaTemperaturaAlta;
            Sensor.AlertaTemperaturaBaja += Sensor_AlertaTemperaturaBaja;
        }
        private void Sensor_AlertaTemperaturaAlta(object? sender, EventArgs e) => MessageBox.Show("La temperatura es alta", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private void Sensor_AlertaTemperaturaBaja(object? sender, EventArgs e) => MessageBox.Show("La temperatura es baja", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private void btnCrearSensor_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                if (nombre.Length == 0) throw new Exception("El nombre del sensor está vacio!");
                sensor = new Sensor(nombre);
                lstTemperaturas.Items.Add(sensor.MostrarTemperatura());
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizarTemp_Click(object sender, EventArgs e)
        {
            try
            {
                double temperatura;
                if (!double.TryParse(txtTemperatura.Text, out temperatura)) throw new Exception("La temperatura debe ser un número!");
                if (sensor == null) throw new Exception("No se ha creado un sensor!");
                sensor.ActualizarTemperatura(temperatura);
                lstTemperaturas.Items.Add(sensor.MostrarTemperatura());
                txtTemperatura.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnResetearTemp_Click(object sender, EventArgs e)
        {
            if (sensor != null)
            {
                sensor.ResetearTemperatura();
                lstTemperaturas.Items.Add(sensor.MostrarTemperatura());
                txtTemperatura.Text = "";
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) => Application.Exit();
    }
}
