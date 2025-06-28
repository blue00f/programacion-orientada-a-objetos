using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IEnumerable
{
    internal class Cancion : ICloneable
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }

        public Cancion(string pNombre, string pArtista, TimeSpan pDuracion)
        {
            Nombre = pNombre;
            Artista = pArtista;
            Duracion = pDuracion;
        }

        public object Clone() => this.MemberwiseClone();
        public Cancion? CloneTipado() => Clone() as Cancion;

        public override string ToString() => $"{this.Nombre} - {this.Artista} ({this.Duracion})";
    }
}
