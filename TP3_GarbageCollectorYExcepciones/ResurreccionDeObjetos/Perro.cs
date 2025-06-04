using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurreccionDeObjetos
{
    internal class Perro
    {
        public string Raza { get; set; }
        public string ColorDelPelaje { get; set; }
        private Refugio Refugio;
        public Perro(string pRaza, string pColorDelPelaje, Refugio pRefugio)
        {
            Raza = pRaza;
            ColorDelPelaje = pColorDelPelaje;
            Refugio = pRefugio;
        }
        public override string ToString() => $"El perro es de raza {this.Raza} y su color de pelaje es {this.ColorDelPelaje}. Su refugio es {this.Refugio.Nombre}";
        ~Perro()
        {
            Refugio.UltimoPerroRescatado = this;
            MessageBox.Show("Finalizador ejecutado! Se revivió al perro!");
        }
    }
}
