using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class CC : Cuenta
    {
        public CC() : base() { }
        public event EventHandler SaldoInsuficiente;
        public override string GetNombre => "Cuenta Corriente";
        public decimal Descubierto { get; set; }

        public override bool Extraer(decimal pImporte)
        {
            bool rdo = false;
            if (pImporte <= Saldo + Descubierto) { rdo = true; Saldo -= pImporte; }
            else { SaldoInsuficiente?.Invoke(this, EventArgs.Empty); }
            return rdo;
        }
        public override string ToString() => this.GetNombre;

      


    }
}
