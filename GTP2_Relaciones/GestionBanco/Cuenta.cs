using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanco
{
    internal abstract class Cuenta
    {
        public event EventHandler<OperacionErroneaEventArgs> ErrorOperacion;
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public bool Depositar(decimal pImporte)
        {
            bool rta = false;
            if (pImporte > 0)
            {
                Saldo += pImporte;
                rta = true;
            }
            DesencadenaEvento("Error en la operación depositar!",pImporte, rta, null);
            return rta;
        }
        public abstract bool Extraer(decimal pImporte);
        public bool Transferir(decimal pImporte, Cuenta pCuentaDestino, int pNumeroCuentaDestino)
        {
            bool rta = false;
            if (Extraer(pImporte) && pImporte > 0) rta = pCuentaDestino.Depositar(pImporte);
            DesencadenaEvento("Error en la operación transferir!", pImporte, rta, pCuentaDestino);
            return rta;
        }
        private void DesencadenaEvento(string pMensaje, decimal pImporte, bool rta, Cuenta pCuentaDestino)
        {
            if (rta == false) ErrorOperacion?.Invoke(this, new OperacionErroneaEventArgs(pMensaje, pImporte, this, pCuentaDestino));
        }

    }
}
