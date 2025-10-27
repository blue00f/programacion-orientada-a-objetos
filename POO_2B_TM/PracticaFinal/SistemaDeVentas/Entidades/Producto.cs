using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Entidades
{
    internal class Producto : ICloneable
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }

        public Producto(string pCodigo, string pNombre, int pStock, decimal pPrecio)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Stock = pStock;
            Precio = pPrecio;
        }
        public object Clone() => this.MemberwiseClone();
        public Producto CloneTipado() => (Producto)this.Clone();
    }
}
