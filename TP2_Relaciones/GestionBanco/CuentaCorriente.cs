using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanco
{
    internal class CuentaCorriente : Cuenta, ICloneable
    {
        public event EventHandler<OperacionErroneaEventArgs> ErrorOperacion;
        public decimal Descubierto { get; set; }
        public CuentaCorriente(int pNumero, decimal pSaldo, decimal pDescubierto)
        {
            Numero = pNumero;
            Saldo = pSaldo;
            Descubierto = pDescubierto;
        }
        public object Clone() => MemberwiseClone();
        public CuentaCorriente CloneTipado() => Clone() as CuentaCorriente;
        public override bool Extraer(decimal pImporte)
        {
            bool rta = false;
            if(pImporte > 0 && pImporte <= Saldo + Descubierto)
            {
                Saldo -= pImporte;
                rta = true;
            }
            if (rta == false) ErrorOperacion?.Invoke(this, new OperacionErroneaEventArgs("Error en la operación extraer!", pImporte, this, null));
            return rta;
        }
    }
}
