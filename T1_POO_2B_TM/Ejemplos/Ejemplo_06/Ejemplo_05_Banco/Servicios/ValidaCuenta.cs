using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo_05_Banco.Entidades;
using Ejemplo_05_Banco.Interfaces;
using Microsoft.VisualBasic;

namespace Ejemplo_05_Banco.Servicios
{
    internal class ValidaCuenta : IValidar<Cuenta>
    {
        public bool Valida(Cuenta pObjeto)
        {
            return Information.IsNumeric(pObjeto.Numero);
        }
    }
   
}
