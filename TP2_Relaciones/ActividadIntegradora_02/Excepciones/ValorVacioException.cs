using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Excepciones
{
    internal class ValorVacioException : Exception
    {
        string valor;
        public ValorVacioException(string pValor) => valor = pValor;
        public override string Message => $"La propiedad {valor} no puede estar vacío!";
    }
}
