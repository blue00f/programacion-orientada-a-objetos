using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_03.Entidades
{
    internal class ProductoEnumerator : IEnumerator
    {
        private string[] partes;
        private int pos = -1;
        public ProductoEnumerator(Producto pProducto)
        {
            partes = pProducto.Id.Split("-");
        }
        public object Current => partes[pos];

        public bool MoveNext()
        {
            pos++;
            return pos < partes.Length;
        }

        public void Reset() => pos = -1;
    }
}
