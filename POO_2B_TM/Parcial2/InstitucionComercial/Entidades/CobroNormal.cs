using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Entidades
{
    internal class CobroNormal : Cobro
    {
        public CobroNormal(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte) : base(pCodigo, pNombre, pFechaVencimiento, pImporte)
        {
        }

        public override decimal CalcularRecargo(int pDiasDeRetraso)
        {
            decimal recargo = 0;
            if (pDiasDeRetraso > 0) recargo = this.Importe * 0.01m * pDiasDeRetraso;
            return recargo;
        }
    }
}
