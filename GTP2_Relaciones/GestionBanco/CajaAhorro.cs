using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanco
{
    internal class CajaAhorro : Cuenta, ICloneable
    {
        public event EventHandler<OperacionErroneaEventArgs> ErrorOperacion;

        public CajaAhorro(int pNumero, decimal pSaldo)
        {
            Numero = pNumero;
            Saldo = pSaldo;
        }

        public object Clone() => MemberwiseClone();
        public CajaAhorro CloneTipado() => Clone() as CajaAhorro;
        public override bool Extraer(decimal pImporte)
        {
            bool rta = false;
            if (pImporte > 0 && pImporte <= Saldo)
            {
                Saldo -= pImporte;
                rta = true;
            }
            if (rta == false) ErrorOperacion?.Invoke(this, new OperacionErroneaEventArgs("Error en la operación extraer!", pImporte, this, null));
            return rta;
        }
    }
}
