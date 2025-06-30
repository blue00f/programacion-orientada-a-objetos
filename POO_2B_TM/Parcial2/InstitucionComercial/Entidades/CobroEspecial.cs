using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Entidades
{
    internal class CobroEspecial : Cobro
    {
        public CobroEspecial(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte) : base(pCodigo, pNombre, pFechaVencimiento, pImporte)
        {
        }

        public override decimal CalcularRecargo(int pDiasDeRetraso)
        {
            decimal recargo = 0;
            if (pDiasDeRetraso > 0) recargo = pDiasDeRetraso * 1000;
            return recargo;
        }
    }
}
