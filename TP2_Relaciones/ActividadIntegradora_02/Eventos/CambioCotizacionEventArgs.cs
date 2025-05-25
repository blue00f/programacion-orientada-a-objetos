using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Eventos
{
    internal class CambioCotizacionEventArgs : EventArgs
    {
        public decimal CotizacionActual { get; set; }
        public CambioCotizacionEventArgs(decimal pCotizacionActual) => CotizacionActual = pCotizacionActual;
    }
}
