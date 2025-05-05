using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanco
{
    internal class Cliente : ICloneable
    {
        public event EventHandler<OperacionErroneaEventArgs> ErrorOperacion;
        List<Cuenta> cuentas;
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente(int pDni, string pNombre, string pApellido)
        {
            Dni = pDni;
            Nombre = pNombre;
            Apellido = pApellido;
            cuentas = new List<Cuenta>();
        }

        public void AgregarCuenta(Cuenta pCuenta)
        {
            // Mala práctica, es poco escalable si hay más tipos de cuenta
            if (pCuenta is CajaAhorro)
            {
                CajaAhorro auxCA = ((CajaAhorro)pCuenta).CloneTipado();
                auxCA.ErrorOperacion += DesencadenaEvento;
                cuentas.Add(auxCA);
            }
            else
            {
                CuentaCorriente auxCC = ((CuentaCorriente)pCuenta).CloneTipado();
                auxCC.ErrorOperacion += DesencadenaEvento;
                cuentas.Add(auxCC);
            }
        }

        public void BorrarCuenta(Cuenta pCuenta)
        {
            var cuenta = BuscarCuenta(pCuenta);
            if (cuenta != null) cuentas.Remove(cuenta);
        }

        public void ModificarCuenta(Cuenta pCuentaVieja, Cuenta pCuentaNueva)
        {
            var cuentaOriginal = BuscarCuenta(pCuentaVieja);
            if(cuentaOriginal != null)
            {
                var cuentaNueva = BuscarCuenta(pCuentaNueva);
                if(cuentaNueva == null || cuentaOriginal.Numero == cuentaNueva.Numero)
                {
                    cuentaOriginal.Numero = pCuentaNueva.Numero;
                    cuentaOriginal.Saldo = pCuentaNueva.Saldo;
                    if (pCuentaVieja is CuentaCorriente) ((CuentaCorriente)cuentaOriginal).Descubierto = ((CuentaCorriente)pCuentaNueva).Descubierto;
                }
            }
        }
        public Cuenta BuscarCuenta(Cuenta pCuenta)
        {
            return cuentas.Find(c => c.Numero == pCuenta.Numero);
        }

        public List<Cuenta> RetornaCuentas()
        {
            List<Cuenta> aux = new List<Cuenta>();
            foreach(var c in cuentas)
            {
                aux.Add(c is CajaAhorro ? (c as CajaAhorro).CloneTipado() : (c as CuentaCorriente).CloneTipado());
            }
            return aux;
        }
        private Cuenta RetornaCuentaPorNumero(int pNumeroCuenta) => cuentas.Find(c => c.Numero == pNumeroCuenta);
        private void DesencadenaEvento(object sender, OperacionErroneaEventArgs e)
        {
            ErrorOperacion?.Invoke(this, e);
        }
        public bool Depositar(int pNumeroCuenta, decimal pImporte)
        {
            cuentas.Find(c => c.Numero == pNumeroCuenta).Depositar(pImporte);
            return true;
        }
        public void Extraer(int pNumeroCuenta, decimal pImporte)
        {
            cuentas.Find(c => c.Numero == pNumeroCuenta).Extraer(pImporte);
        }
        public void Transferir(int pNumeroCuentaOrigen, int pNumeroCuentaDestino, Cliente pClienteDestino, decimal pImporte)
        {
            cuentas.Find(c => c.Numero == pNumeroCuentaOrigen).Transferir(pImporte, pClienteDestino.RetornaCuentaPorNumero(pNumeroCuentaDestino), pNumeroCuentaDestino);
        }
        public object Clone() => MemberwiseClone();
        public Cliente CloneTipado()
        {
            Cliente aux = (Cliente)Clone();
            return aux;
        }
    }
}
