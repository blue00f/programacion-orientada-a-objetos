using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Entidades
{
    internal abstract class Cobro : ICloneable
    {
        private decimal importeTotal;
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public Cliente Cliente { get; set; }
        public Cobro(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            FechaVencimiento = pFechaVencimiento;
            Importe = pImporte;
        }
        abstract public decimal CalcularRecargo(int pDiasDeRetraso);

        public void AsignarCliente(Cliente pCliente) => this.Cliente = pCliente;

        public object Clone() => this.MemberwiseClone();
        public Cobro? CloneTipado() => this.Clone() as Cobro;


        internal class ImporteASC : IComparer<Cobro>
        {
            public int Compare(Cobro? x, Cobro? y)
            {
                x.importeTotal = x.CalcularRecargo((DateTime.Now - x.FechaVencimiento).Days) + x.Importe;
                y.importeTotal = y.CalcularRecargo((DateTime.Now - y.FechaVencimiento).Days) + y.Importe;
                return x.importeTotal.CompareTo(y.importeTotal);
            }
        }
        internal class ImporteDESC : IComparer<Cobro>
        {
            public int Compare(Cobro? x, Cobro? y) 
            {
                return (new ImporteASC().Compare(x, y) * -1);
            }
        }
    }
}
