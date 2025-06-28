using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IEnumerable
{
    internal class Playlist : IEnumerable
    {
        private List<Cancion> canciones;
        public Playlist()
        {
            canciones = new List<Cancion>();
        }
        public void Agregar(Cancion pCancion) => canciones.Add(pCancion);
        public List<Cancion> ObtenerCanciones()
        {
            List<Cancion> lista = new List<Cancion>();
            foreach(var c in canciones)
            {
                lista.Add(c.CloneTipado());
            }
            return lista;
        }
        public IEnumerator GetEnumerator()
        {
            return new PlaylistEnumerator(canciones);
        }
    }
}
