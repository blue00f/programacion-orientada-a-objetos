using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionComercial.Entidades
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
