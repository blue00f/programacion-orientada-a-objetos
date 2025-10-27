namespace InstitucionComercial_V1.Entidades
{
    internal abstract class Cobro : ICloneable
    {
        public event EventHandler AlertaImporteAlto;
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public decimal Recargo { get; set; }
        public Cliente Cliente { get; set; }

        public Cobro(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte, Cliente pCliente)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            FechaVencimiento = pFechaVencimiento;
            Importe = pImporte;
            Cliente = pCliente;
        }

        public void AsignarCliente(Cliente pCliente)
        {
            this.Cliente = pCliente;
        }

        abstract public decimal CalcularRecargo(decimal pImporte, int pDiasRetraso);

        protected void Funcion_AlertaImporteAlto()
        {
            AlertaImporteAlto?.Invoke(this, null);
        }
        public object Clone() => this.MemberwiseClone();
        public Cobro CloneTipado() => (Cobro)this.Clone();

        internal class ImporteASC : IComparer<Cobro>
        {
            public int Compare(Cobro? x, Cobro? y)
            {
                decimal importeTotalX = x.Importe + x.Recargo;
                decimal importeTotalY = y.Importe + y.Recargo;
                return importeTotalX.CompareTo(importeTotalY);
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
