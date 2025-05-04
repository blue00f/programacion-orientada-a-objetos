using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora1
{
    internal class Persona : ICloneable
    {
        #region "Propiedades"
        private List<Auto> listaAutos;
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region "Constructor y Finalizador"
        public Persona(string pDNI, string pNombre, string pApellido)
        {
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
            listaAutos = new List<Auto>();
        }
        ~Persona()
        {
            MessageBox.Show($"La persona con DNI {this.DNI} fue liberado de la memoria");
        }
        #endregion

        #region "Metodos"
        public void AgregarAuto(Auto pAuto)
        {
            if (listaAutos.Any(x => x.Patente == pAuto.Patente)) throw new Exception("La persona ya tiene este auto!");
            if (pAuto.Duenio() != null) throw new Exception("Este auto ya tiene dueño!");
            listaAutos.Add(pAuto);
            pAuto.AsignarDuenio(this);
        }
        public void BorrarAuto(Auto pAuto)
        {
            Auto a = BuscarAutoExistente(pAuto);
            if(a != null) listaAutos.Remove(pAuto);
        }
        public void ModificarAuto(Auto pAutoViejo, Auto pAutoNuevo)
        {
            Auto a = BuscarAutoExistente(pAutoViejo);
            if(a != null)
            {
                Auto aAux = BuscarAutoExistente(pAutoNuevo);
                if(aAux == null)
                {
                    a.Patente = pAutoNuevo.Patente;
                    a.Marca = pAutoNuevo.Marca;
                    a.Modelo = pAutoNuevo.Modelo;
                    a.Anio = pAutoNuevo.Anio;
                    a.Precio = pAutoNuevo.Precio;
                }
            }
        }
        private Auto BuscarAutoExistente(Auto pAuto)
        {
            return listaAutos.Find(x => x.Patente == pAuto.Patente);
        }

        public List<Auto> Lista_de_autos()
        {
            //List<Auto> listaAux = new List<Auto>();
            //listaAutos.ForEach(x => listaAux.Add(x.CloneTipado()));
            //return listaAux;
            return listaAutos.ToList();
        }

        public int Cantidad_de_autos()
        {
            return listaAutos.Count;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Persona CloneTipado() => (Persona)this.Clone();
        #endregion
    }
}
