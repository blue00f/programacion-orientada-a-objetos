using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Excepciones
{
    internal class FormatoCodigoInvalidoException : Exception
    {
        string formato = "[ABCD-1234-D5-F6]";
        string formatoIngresado;
        public FormatoCodigoInvalidoException(string pFormatoIngresado) => formatoIngresado = pFormatoIngresado;
        public override string Message => $"El código ingresado {formatoIngresado} no coincide con el formato establecido {formato}";
    }
}
