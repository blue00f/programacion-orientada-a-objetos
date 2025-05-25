using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class CA : Cuenta 
    {
        public event EventHandler SaldoInsuficiente;
        public CA() : base() { }

        public override string GetNombre => "Caja de Ahorro";
        public override bool Extraer(decimal pImporte)
        {
            bool rdo = false;
            if (pImporte <= Saldo) { rdo = true; Saldo -= pImporte; }
            else { SaldoInsuficiente?.Invoke(this, EventArgs.Empty); }
                return rdo;
        }
        public override string ToString() => this.GetNombre;

       
    }
}
