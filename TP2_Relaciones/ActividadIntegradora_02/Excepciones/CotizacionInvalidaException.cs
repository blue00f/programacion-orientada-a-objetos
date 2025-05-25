using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Excepciones
{
    internal class CotizacionInvalidaException : Exception
    {
        decimal cotizacion;
        public CotizacionInvalidaException(decimal pCotizacion) => cotizacion = pCotizacion;
        public override string Message => $"La cotización {cotizacion} es incorrecta y debe ser un valor positivo!";
    }
}
