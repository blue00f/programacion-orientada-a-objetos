using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoEstatico
{
    internal class Sensor
    {
        // El primer evento estático se dispara cuando la temperatura ingresada es menor que 0
        public static event EventHandler? AlertaTemperaturaBaja;
        // El segundo evento estático se dispara cuando la temperatura ingresada es mayor que 30
        public static event EventHandler? AlertaTemperaturaAlta;
        private string Nombre;
        private double Temperatura;

        public Sensor(string pNombre)
        {
            Nombre = pNombre;
            Temperatura = 20.0;
        }
        public void ActualizarTemperatura(double pTemperatura)
        {
            Temperatura = pTemperatura;
            if (pTemperatura > 30) AlertaTemperaturaAlta?.Invoke(null, null);
            if (pTemperatura < 0) AlertaTemperaturaBaja?.Invoke(null, null);
        }
        public string MostrarTemperatura()
        {
            return $"{Nombre} Temperatura: {Temperatura}°C";
        }
        public void ResetearTemperatura()
        {
            Temperatura = 20.0;
        }
    }
}
