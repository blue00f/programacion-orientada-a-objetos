using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    internal class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Axo { get; set; }

        public override string ToString() => $"{Patente} {Marca} {Modelo} {Axo}";
    }
}
