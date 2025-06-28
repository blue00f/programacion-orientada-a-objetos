using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ICloneable
{
    internal class Producto : ICloneable
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Producto (string pNombre, decimal pPrecio, int pStock)
        {
            Nombre = pNombre;
            Precio = pPrecio;
            Stock = pStock;
        }
        public object Clone() => this.MemberwiseClone();
        public Producto? CloneTipado() => Clone() as Producto;
        public string MostrarInfo() => $"Nombre: {this.Nombre}, Stock: {this.Stock}, Precio: {this.Precio}";
    }
}
