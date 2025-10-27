namespace InstitucionComercial_V1.Entidades
{
    internal class CobroNormal : Cobro
    {
        public CobroNormal(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte, Cliente pCliente) : base(pCodigo, pNombre, pFechaVencimiento, pImporte, pCliente)
        {
        }

        public override decimal CalcularRecargo(decimal pImporte, int pDiasRetraso)
        {
            if (pDiasRetraso > 0) this.Recargo = (pImporte * 0.01m) * pDiasRetraso;
            else this.Recargo = 0;

            if (this.Importe + this.Recargo > 10000)
            {
                Funcion_AlertaImporteAlto();
            }
            return this.Recargo;
        }
    }
}
