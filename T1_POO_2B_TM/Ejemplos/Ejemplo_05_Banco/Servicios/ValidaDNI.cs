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
    internal class ValidaDNI : IValidar<Cliente>
    {
        public bool Valida(Cliente pObjeto)
        {
            bool resultado = false;
            if (pObjeto.DNI.Length == 8 && Information.IsNumeric(pObjeto.DNI)) resultado = true;         
            return resultado;
        }
    }
}
