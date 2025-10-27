using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Eventos
{
    internal class StockBajoEventArgs : EventArgs
    {
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public StockBajoEventArgs(string pNombre, int pStock)
        {
            Nombre = pNombre;
            Stock = pStock;
        }
    }
}
