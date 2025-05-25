using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class InversorComun : Inversor
    {
        public InversorComun(string pNombre, string pApellido, string pDni) : base(pNombre, pApellido, pDni) { }
        public override decimal CalcularComision(decimal pMonto)
        {
            return pMonto * 0.01m;
        }
    }
}
