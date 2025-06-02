using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBecas.Entidades
{
    internal class Posgrado : Beneficiario
    {
        public Posgrado(string pLegajo, string pNombre, string pApellido, string pDni, decimal pPagoMensual) : base(pLegajo, pNombre, pApellido, pDni, pPagoMensual) { }
        public override decimal CalcularBeneficio(decimal pPagoMensual, decimal pImporte) => (pPagoMensual-pImporte) * 0.01m;
    }
}

