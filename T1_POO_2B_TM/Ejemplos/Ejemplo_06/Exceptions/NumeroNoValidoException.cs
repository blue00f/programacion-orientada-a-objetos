using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejemplo_06.Exceptions
{
    internal class NumeroNoValidoException : Exception
    {
        string valor;
        object objeto;
        public NumeroNoValidoException(string pValor, object pObject)
        { valor = pValor; objeto = pObject; }

        public override string Message => $"El valor ingresado no es válido !!!{Environment.NewLine}" +
                                          $"Se ingresó: {valor}";
        public object Origen => objeto;
    }
}
