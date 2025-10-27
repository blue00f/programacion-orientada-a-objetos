namespace InstitucionComercial_V2.Entidades
{
    internal class CobroEspecial : Cobro
    {
        public CobroEspecial(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte) : base(pCodigo, pNombre, pFechaVencimiento, pImporte)
        {
        }

        public override decimal CalcularImporteConRetraso(int pDiasDeRetraso)
        {
            return 1000 * pDiasDeRetraso;
        }
    }
}
