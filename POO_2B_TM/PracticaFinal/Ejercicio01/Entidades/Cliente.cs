using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Entidades
{
    internal class Cliente : ICloneable
    {
        List<Cobro> cobrosPendientes;
        List<Cobro> cobrosPagados;
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public Cliente(string pLegado, string pNombre)
        {
            Legajo = pLegado;
            Nombre = pNombre;
            cobrosPendientes = new List<Cobro>();
            cobrosPagados = new List<Cobro>();
        }

        public bool AsignarCobro(Cobro pCobro)
        {
            bool rdo = false;
            if (cobrosPendientes.Count < 2) cobrosPendientes.Add(pCobro);
            else rdo = true;
            return rdo;
        }
        public void QuitarCobro(Cobro pCobro)
        {
            var cobro = cobrosPendientes.Find(x => x.Codigo == pCobro.Codigo);
            cobro.Recargo = pCobro.Recargo;
            if (cobro != null)
            {
                cobrosPagados.Add(cobro);
                cobrosPendientes.Remove(cobro);
            }
        }
        public List<Cobro> ObtenerCobros()
        {
            List<Cobro> aux = new List<Cobro>();
            foreach (var cobro in cobrosPendientes)
            {
                aux.Add(cobro.CloneTipado());
            }
            return aux;
        }
        public List<Cobro> ObtenerCobrosPagados()
        {
            var consulta = from cobro in cobrosPagados select cobro.CloneTipado();
            return consulta.ToList<Cobro>();
        }

        public object Clone() => this.MemberwiseClone();
        public Cliente CloneTipado() => (Cliente)this.Clone();
    }
}
