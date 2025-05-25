using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class CompraAccion : ICloneable
    {
        public Accion Accion { get; set; }
        public int CantidadComprada { get; set; }

        public CompraAccion(Accion pAccion, int pCantidadComprada)
        {
            Accion = pAccion;
            CantidadComprada = pCantidadComprada;
        }

        public object Clone() => this.MemberwiseClone();
        public CompraAccion CloneTipado() => (CompraAccion)this.Clone();
    }
}
