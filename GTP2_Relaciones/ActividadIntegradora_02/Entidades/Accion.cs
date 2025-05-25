using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class Accion : ICloneable, IEnumerable<string>
    {
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public decimal CotizacionActual { get; set; }
        public int CantidadEmitida { get; set; }

        public Accion(string pCodigo, string pDenominacion, decimal pCotizacionActual, int pCantidadEmitida)
        {
            Codigo = pCodigo;
            Denominacion = pDenominacion;
            CotizacionActual = pCotizacionActual;
            CantidadEmitida = pCantidadEmitida;
        }
        ~Accion()
        {
            MessageBox.Show("GC liberó los recursos de acción!");
        }

        public static bool ValidarCodigo(string pCodigo)
        {
            bool rdo = false;
            string formatoCodigo = @"^[A-Z]{4}-\d{4}-[A-Z]\d[A-Z]\d$";
            if (Regex.IsMatch(pCodigo, formatoCodigo)) rdo = true;
            return rdo;
        }

        public object Clone() => this.MemberwiseClone();
        public Accion CloneTipado() => (Accion)this.Clone();

        public IEnumerator<string> GetEnumerator()
        {
            string[] partes = Codigo.Split("-");
            foreach (var parte in partes) yield return parte;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        internal class AccionASC : IComparer<Accion>
        {
            public int Compare(Accion x, Accion y)
            {
                int rdo = x.Codigo.CompareTo(y.Codigo);
                if (rdo == 0) rdo = x.Denominacion.CompareTo(y.Denominacion);
                if (rdo == 0) rdo = x.CotizacionActual.CompareTo(y.CotizacionActual);
                if (rdo == 0) rdo = x.CantidadEmitida.CompareTo(y.CotizacionActual);
                return rdo;
            }
        }
        internal class AccionDESC : IComparer<Accion>
        {
            public int Compare(Accion x, Accion y) => (new AccionASC()).Compare(x, y) * -1;
        }
    }
}
