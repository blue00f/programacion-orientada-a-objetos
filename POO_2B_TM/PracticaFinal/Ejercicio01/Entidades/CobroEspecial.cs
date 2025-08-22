using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Entidades
{
    internal class CobroEspecial : Cobro
    {
        public CobroEspecial(string pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte, Cliente pCliente) : base(pCodigo, pNombre, pFechaVencimiento, pImporte, pCliente)
        {
        }

        public override decimal CalcularRecargo(decimal pImporte, int pDiasRetraso)
        {
            if (pDiasRetraso > 0)
            {
                decimal recargoPorDiaDeRetraso = 1000;
                this.Recargo = pDiasRetraso * recargoPorDiaDeRetraso;
            }
            else
            {
                this.Recargo = 0;
            }

            if (this.Importe + this.Recargo > 10000)
            {
                Funcion_AlertaImporteAlto();
            }
            return this.Recargo;
        }
    }
}
