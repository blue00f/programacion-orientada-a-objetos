using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo08
{
    internal class Enumerador2Producto : IEnumerator
    {
        Producto producto;
        string current;
        int cont;
        public Enumerador2Producto(Producto pProducto) { producto=pProducto; Reset(); }
        public object Current => current;

        public bool MoveNext()
        {
            //0123456789012
            //7792345098764
            bool rta = true;
            if (cont==0) { current=producto.Codigo.Substring(0,3); cont++; }
            else if (cont==1) { current=producto.Codigo.Substring(3, 4); cont++; }
            else if (cont==2) { current=producto.Codigo.Substring(7, 5); cont++; }
            else if (cont==3) { current=producto.Codigo.Substring(12, 1); cont++; }
            else if (cont==4) 
            {
                //int par = 0;int impar=0;
                int total=0;int temp = 0;
                for (int x = 0; x<12; x++)
                {
                    //if (x%2==0) par+=Convert.ToInt32(producto.Codigo[x].ToString()); 
                    //else impar+=Convert.ToInt32(producto.Codigo[x].ToString());
                    if (x % 2 == 0) total += Convert.ToInt32(producto.Codigo[x].ToString());
                    else total+=(Convert.ToInt32(producto.Codigo[x].ToString())) * 3;
                }
                //total=par + (impar*3);
                do
                {
                    temp+=10;
                    if (temp>=total) break;
                } while (true);

                current= (temp - total) == Convert.ToInt32(producto.Codigo[12].ToString()) ? "OK" : "NO";
                cont++; 
            
            }
            else { rta=false; }

            return rta;
        }

        public void Reset()
        {
            current=""; cont=0;
        }
    }
}

