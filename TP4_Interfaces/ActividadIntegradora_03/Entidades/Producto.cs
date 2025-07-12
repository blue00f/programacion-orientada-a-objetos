using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_03.Entidades
{
    internal class Producto : ICloneable, IEnumerable
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Producto (string pId, string pDescripcion, decimal pPrecio, int pStock)
        {
            Id = pId;
            Descripcion = pDescripcion;
            Precio = pPrecio;
            Stock = pStock;
        }

        public object Clone() => MemberwiseClone();
        public Producto? CloneTipado() => Clone() as Producto;

        public IEnumerator GetEnumerator()
        {
            return new ProductoEnumerator(this);
        }

        internal class IdASC : IComparer<Producto>
        {
            public int Compare(Producto? x, Producto? y) => x.Id.CompareTo(y.Id);
        }
        internal class IdDESC : IComparer<Producto>
        {
            public int Compare(Producto? x, Producto? y) => (new IdASC()).Compare(x, y) * -1;
        }
        internal class PrecioASC : IComparer<Producto>
        {
            public int Compare(Producto? x, Producto? y) => x.Precio.CompareTo(y.Precio);
        }
        internal class PrecioDESC : IComparer<Producto>
        {
            public int Compare(Producto? x, Producto? y) => (new PrecioASC()).Compare(x, y) * -1;
        }
    }
}
