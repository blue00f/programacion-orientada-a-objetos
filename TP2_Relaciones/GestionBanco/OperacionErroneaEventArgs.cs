using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanco
{
    internal class OperacionErroneaEventArgs : EventArgs
    {
        string mensaje;
        decimal importe;
        Cuenta cuentaO, cuentaD;
        public OperacionErroneaEventArgs(string pMensaje, decimal pImporte, Cuenta pCuentaO, Cuenta pCuentaD)
        {
            mensaje = pMensaje;
            importe = pImporte;
            cuentaO = pCuentaO;
            cuentaD = pCuentaD;
        }
        public string Mensaje => mensaje;
        public decimal Importe => importe;
        public Cuenta CuentaOrigen => cuentaO;
        public Cuenta CuentaDestino => cuentaD;
    }
}
