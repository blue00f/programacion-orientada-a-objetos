using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo08
{
    internal class Enumerador1Producto : IEnumerator
    {
        Producto producto;
        string current;
        int cont;
        public Enumerador1Producto(Producto pProducto) { producto=pProducto;Reset(); }
        public object Current => current;

        public bool MoveNext()
        {
            bool rta = true;
            if (cont==0) { current=producto.Codigo; cont++; }
            else if (cont==1) { current=producto.Descripcion; cont++; }
            else if (cont==2) { current=producto.Precio.ToString(); cont++; }
            else { rta=false; }

            return rta;
        }

        public void Reset()
        {
            current="";cont=0;
        }
    }
}
