using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora1
{
    internal class Auto : ICloneable
    {
        #region "Propiedades"
        public Persona PersonaDuenio;
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public decimal Precio { get; set; }
        #endregion

        #region "Constructor y Finalizador"
        public Auto(string pPatente, string pMarca, string pModelo, string pAnio, decimal pPrecio)
        {
            Patente = pPatente;
            Marca = pMarca;
            Modelo = pModelo;
            Anio = pAnio;
            Precio = pPrecio;
            PersonaDuenio = null;
        }
        ~Auto()
        {
            MessageBox.Show($"La patente {this.Patente} fue liberado de la memoria");
        }
        #endregion

        #region "Metodos"

        public void AsignarDuenio(Persona pPersona)
        {
            if (PersonaDuenio != null) throw new Exception("El auto ya tiene dueño!");
            PersonaDuenio = pPersona;
        }

        public Persona Duenio()
        {
            return PersonaDuenio;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Auto CloneTipado() => (Auto)this.Clone();
        #endregion
    }
}
