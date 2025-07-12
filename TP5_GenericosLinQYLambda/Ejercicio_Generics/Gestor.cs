using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Generics
{
    internal class Gestor<T> where T : class, ICloneableTipado<T>
    {
        private List<T> items;
        public Gestor()
        {
            items = new List<T>();
        }

        public void Agregar(T item) => items.Add(item);
        public List<T> ObtenerItems()
        {
            List<T> itemsAux = new List<T>();
            foreach (T i in items)
            {
                itemsAux.Add(i.CloneTipado());
            }
            return itemsAux;
        }

        // Uso de delegados Func y Predicate para realizar un filtrado de datos
        public List<T> Filtrar<K>(Func<T, K> selector, Predicate<K> condicion)
        {
            List<T> res = new List<T>();
            foreach (var item in items)
            {
                K propiedad = selector(item);
                if (condicion(propiedad))
                {
                    res.Add(item);
                }
            }
            return res;
        }
    }
}
