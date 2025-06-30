using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Entidades
{
    internal class Cliente : ICloneable
    {
        private List<Cobro> cobrosPendientes;
        private List<Cobro> cobrosPagados;
        public string Legajo { get; set; }
        public string Nombre { get; set; }

        public Cliente(string pLegajo, string pNombre)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            cobrosPendientes = new List<Cobro>();
            cobrosPagados = new List<Cobro>();
        }

        public void AsignarCobro(Cobro pCobro) => cobrosPendientes.Add(pCobro);
        public void PagarCobro(Cobro pCobro)
        {
            var cobro = cobrosPendientes.Find(x => x.Codigo == pCobro.Codigo);
            if (cobro != null)
            {
                cobrosPendientes.Remove(cobro);
                cobrosPagados.Add(cobro);
            }
        }
        public List<Cobro> ObtenerCobrosPendientes()
        {
            List<Cobro> aux = new List<Cobro>();
            foreach (var c in cobrosPendientes)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }
        public List<Cobro> ObtenerCobrosPagados()
        {
            List<Cobro> aux = new List<Cobro>();
            foreach (var c in cobrosPagados)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }

        public object Clone() => this.MemberwiseClone();
        public Cliente? CloneTipado() => this.Clone() as Cliente;
    }
}
