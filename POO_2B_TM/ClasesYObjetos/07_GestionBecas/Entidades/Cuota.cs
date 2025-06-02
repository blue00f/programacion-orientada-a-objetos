using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial.Entidades
{
    internal class Cuota : ICloneable
    {
        public decimal Importe { get; set; }

        public object Clone() => MemberwiseClone();
        public Cuota CloneTipado() => (Cuota)Clone();
    }
}
