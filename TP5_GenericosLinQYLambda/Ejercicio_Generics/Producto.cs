using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Generics
{
    internal class Producto : ICloneable, ICloneableTipado<Producto>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Producto (string pCodigo, string pNombre, decimal pPrecio)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Precio = pPrecio;
        }

        public object Clone() => this.MemberwiseClone();
        public Producto? CloneTipado() => this.Clone() as Producto;
    }
}
