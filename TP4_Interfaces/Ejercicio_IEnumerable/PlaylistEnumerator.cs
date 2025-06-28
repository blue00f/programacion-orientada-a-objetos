using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IEnumerable
{
    internal class PlaylistEnumerator : IEnumerator
    {
        private List<Cancion> canciones;
        private int posicion = -1;

        public PlaylistEnumerator(List<Cancion> pCanciones)
        {
            canciones = pCanciones;
        }
        public object Current
        {
            get
            {
                if (posicion < 0 || posicion >= canciones.Count) throw new Exception("Error");
                return canciones[posicion];
            }
        }

        public bool MoveNext()
        {
            posicion++;
            return posicion < canciones.Count;
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
