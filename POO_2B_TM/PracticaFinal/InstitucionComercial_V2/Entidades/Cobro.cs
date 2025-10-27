namespace InstitucionComercial_V2.Entidades
{
    internal abstract class Cobro : ICloneable
    {
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
        public void AsignarCliente(Cliente pCliente) => Cliente = pCliente;

        public abstract decimal CalcularImporteConRetraso(int pDiasDeRetraso);

        public object Clone() => this.MemberwiseClone();
        public Cobro? CloneTipado() => this.Clone() as Cobro;


        internal class ImporteASC : IComparer<Cobro>
        {
            public int Compare(Cobro? x, Cobro? y) => x.Importe.CompareTo(y.Importe);
        }
        internal class ImporteDESC : IComparer<Cobro>
        {
            public int Compare(Cobro? x, Cobro? y) => (new ImporteASC().Compare(x, y)) * -1;
        }
    }
}
