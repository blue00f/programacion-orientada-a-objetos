using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionComercial.Entidades
{
    internal class CobroNormal : Cobro
    {
        public CobroNormal(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte) : base(pCodigo, pNombre, pFechaVencimiento, pImporte)
        {
        }

        public override decimal CalcularImporteConRetraso(int pDiasDeRetraso)
        {
            return this.Importe * 0.01m * pDiasDeRetraso;
        }
    }
}
