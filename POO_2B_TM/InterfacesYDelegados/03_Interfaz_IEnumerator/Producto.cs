using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo08
{
    internal class Producto : IEnumerable
    {
        public Producto(string pCodigo,string pDescripcion,decimal pPrecio,int pQueEnumerador) { Codigo=pCodigo; Descripcion=pDescripcion; Precio=pPrecio;QueEnumerador=pQueEnumerador; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int QueEnumerador { get; set; }


        public IEnumerator GetEnumerator()
        {
            IEnumerator ie = null;
            if (QueEnumerador==1) ie=new Enumerador1Producto(this);
            else ie=new Enumerador2Producto(this);
            return ie;
        }
    }
}
