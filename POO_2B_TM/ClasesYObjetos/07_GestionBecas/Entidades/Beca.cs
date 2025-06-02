using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial.Entidades
{
    internal class Beca : ICloneable
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }

        public object Clone() => MemberwiseClone();
        public Beca CloneTipado() => (Beca)Clone();
    }
}
