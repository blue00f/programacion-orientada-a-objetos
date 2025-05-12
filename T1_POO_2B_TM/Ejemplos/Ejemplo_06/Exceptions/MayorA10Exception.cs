using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_06.Exceptions
{
    internal class MayorA10Exception : Exception
    {
        int numero;
        object objeto;
        public MayorA10Exception(int pNumero,object pObject) 
        {numero = pNumero;objeto = pObject; }

        public override string Message => $"En número no puede ser superior a 10 !!!{Environment.NewLine}" +
                                          $"El valor cargado es: {numero}";
        public object Origen => objeto;
    }
}
