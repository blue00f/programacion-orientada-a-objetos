using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionPersonalizada
{
    internal class FormatoErroneoCodigoException : Exception
    {
        string codigo;
        public FormatoErroneoCodigoException(string pCodigo)
        {
            codigo = pCodigo;
        }
        public override string Message => $"El código ingresado {codigo} tiene un formato inválido!";
    }
}
