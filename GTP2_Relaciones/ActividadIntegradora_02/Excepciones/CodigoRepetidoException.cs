using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Excepciones
{
    internal class CodigoRepetidoException : Exception
    {
        string codigo;
        public CodigoRepetidoException(string pCodigo) => codigo = pCodigo;
        public override string Message => $"El código {codigo} está repetido!";
    }
}
