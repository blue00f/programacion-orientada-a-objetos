using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Entidades
{
    internal class Compra : ICloneable
    {
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Compra(int pCantidad, decimal pPrecio)
        {
            Cantidad = pCantidad;
            Precio = pPrecio;
        }
        public object Clone() => this.MemberwiseClone();
        public Compra CloneTipado() => (Compra)this.Clone();
        ~Compra() => MessageBox.Show("GC liberó los recursos de Compra");
    }
}
