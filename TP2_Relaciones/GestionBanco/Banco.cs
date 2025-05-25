using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanco
{
    internal class Banco
    {
        public event EventHandler<OperacionErroneaEventArgs> ErrorOperacion;

        List<Cliente> clientes;
        public Banco() { clientes = new List<Cliente>(); }
        private void DesencadenaEvento(object sender, OperacionErroneaEventArgs e)
        {
            ErrorOperacion?.Invoke(this, e);
        }
        public void AgregarCliente(Cliente pCliente)
        {
            var c = pCliente.CloneTipado();
            c.ErrorOperacion += DesencadenaEvento;
            clientes.Add(c);
        }
        public void BorrarCliente(Cliente pCliente)
        {
            var cliente = BuscarCliente(pCliente);
            if (cliente != null) clientes.Remove(cliente);
        }
        public void ModificarCliente(Cliente pClienteViejo, Cliente pClienteNuevo)
        {
            var clienteOriginal = BuscarCliente(pClienteViejo);
            if(clienteOriginal != null)
            {
                var clienteModificado = BuscarCliente(pClienteNuevo);
                if(clienteModificado == null || clienteOriginal.Dni == clienteModificado.Dni)
                {
                    clienteOriginal.Dni = pClienteNuevo.Dni;
                    clienteOriginal.Nombre = pClienteNuevo.Nombre;
                    clienteOriginal.Apellido = pClienteNuevo.Apellido;
                }
            }
        }
        public Cliente BuscarCliente(Cliente pCliente)
        {
            return clientes.Find(c => c.Dni == pCliente.Dni);
        }


        public void AgregarCuentaACliente(Cliente pCliente, Cuenta pCuenta)
        {
            Cliente c = clientes.Find(c => c.Dni == pCliente.Dni);
            c.AgregarCuenta(pCuenta is CajaAhorro ? (pCuenta as CajaAhorro).CloneTipado() : (pCuenta as CuentaCorriente).CloneTipado());
        }
        public void BorrarCuenta(Cliente pCliente, Cuenta pCuenta)
        {
            pCliente.BorrarCuenta(pCuenta);
        }
        public void ModificarCuenta(Cliente pCliente, Cuenta pCuentaVieja, Cuenta pCuentaNueva)
        {
            pCliente.ModificarCuenta(pCuentaVieja, pCuentaNueva);
        }

        public void Depositar(int pNumeroCliente, int pNumeroCuenta, decimal pImporte)
        {
            clientes.Find(c => c.Dni == pNumeroCliente).Depositar(pNumeroCuenta, pImporte);
        }
        public void Extraer(int pNumeroCliente, int pNumeroCuenta, decimal pImporte)
        {
            clientes.Find(c => c.Dni == pNumeroCliente).Extraer(pNumeroCuenta, pImporte);
        }
        public void Transferir(int pNumeroClienteOrigen, int pNumeroCuentaOrigen, int pNumeroCuentaDestino, decimal pImporte)
        {
            var clienteOrigen = clientes.Find(c => c.Dni == pNumeroClienteOrigen);
            var clienteDestino = clientes.Find(c => c.RetornaCuentas().Exists(cu => cu.Numero == pNumeroCuentaDestino));
            clienteOrigen.Transferir(pNumeroCuentaOrigen, pNumeroCuentaDestino, clienteDestino, pImporte);
        }


        public bool DniExistente(Cliente pCliente)
        {
            return clientes.Exists(c => c.Dni == pCliente.Dni);
        }
        public bool CuentaExistente(Cuenta pCuenta)
        {
            bool rta = false;

            foreach (var c in clientes)
            {
                if (c.RetornaCuentas().Exists(c => c.Numero == pCuenta.Numero)) { rta = true; break; }
            }

            return rta;
        }
        public List<Cliente> RetornaClientes()
        {
            return (from c in clientes select c.CloneTipado()).ToList<Cliente>();
        }
        // Devuelve una lista de objetos anónimos
        public List<object> RetornaCuentasCliente(Cliente pCliente)
        {
            return (from c in clientes.Find(cli => pCliente.Dni == cli.Dni).RetornaCuentas()
                    select new
                    {
                        Numero = c.Numero,
                        Saldo = c.Saldo,
                        Descubierto = (c is CajaAhorro) ? "-" : ((CuentaCorriente)c).Descubierto.ToString(),
                        Tipo = (c is CajaAhorro) ? "Caja de ahorro" : "Cuenta corriente"
                    }).ToList<object>();
        }
        public List<object> RetornaTodasLasCuentasDelBanco()
        {
            return (from c in clientes
                    from cu in c.RetornaCuentas()
                    select new
                    {
                        Numero = cu.Numero,
                        Saldo = cu.Saldo,
                        Descubierto = (cu is CajaAhorro) ? "-" : ((CuentaCorriente)cu).Descubierto.ToString(),
                        Tipo = (cu is CajaAhorro) ? "Caja de ahorro" : "Cuenta corriente"
                    }).ToList<object>();
        }
    }
}
