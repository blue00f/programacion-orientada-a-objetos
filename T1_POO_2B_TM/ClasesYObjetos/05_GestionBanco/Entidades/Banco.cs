using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class Banco
    {
        public event EventHandler SaldoInsuficiente;
        List<Cliente> lcli;
        List<Cuenta> lcta;
        public Banco()
        {
            lcli = new List<Cliente>();
            lcta = new List<Cuenta>();
        }
        public void AgregarCliente(Cliente pCliente) { lcli.Add(pCliente.CloneTipado()); }
        public void AgregarCuenta(Cuenta pCuenta) 
        { lcta.Add(pCuenta.CloneTipado());
            if (lcta.Last() is CA) ((CA)lcta.Last()).SaldoInsuficiente += F_SaldoInsuficiente;
            else { ((CC)lcta.Last()).SaldoInsuficiente += F_SaldoInsuficiente; }
        }
        private void F_SaldoInsuficiente(object sender, EventArgs e)
        { 
            var cta = ((Cuenta)sender).CloneTipado();
            SaldoInsuficiente?.Invoke(cta, e);
        }
        public void BorrarCliente(Cliente pCliente)
        {
            var cliente = lcli.Find(c => c.DNI == pCliente.DNI);

            if (cliente != null)
            {
                // El cliente recorre todas sus cuentas y se borra como titular de ellas
                foreach (var cta in cliente.ObtenerCuentas())
                {
                    cta.BorrarCliente(cliente);
                }
                cliente.BorrarCuentas();
                lcli.Remove(cliente);
            }
        }
        public void BorrarCuenta(Cuenta pCuenta)
        {
            var cuenta = lcta.Find(c => c.Numero == pCuenta.Numero);
            if (cuenta != null) lcta.Remove(cuenta);
            // todo: Verificar que la cuenta no figure como cuenta de un cliente (ver for each de borrar cliente)
        }
        public void ModificarCliente(Cliente pCliente)
        {
            var cliente = lcli.Find(c => c.DNI == pCliente.DNI);
            if (cliente != null)
            {
                cliente.Nombre = pCliente.Nombre;
                cliente.Apellido = pCliente.Apellido;
            }
        } 
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lcliAux = new List<Cliente>();
            lcli.ForEach(cli => lcliAux.Add(cli.CloneTipado()));
            return lcliAux;
        }
        public List<Object> ObtenerCuentas()
        {
            var rdo = from cta in lcta
                      select new {Número = cta.Numero,Saldo = cta.Saldo, Descripción = cta.CloneTipado() ,Descubierto = cta is CC ? (cta as CC).Descubierto.ToString() : "--"};
            return rdo.ToList<object>();
        }
        public bool ExisteDNICliente(Cliente pCliente) => lcli.Exists(c => c.DNI == pCliente.DNI); 
        public bool ExisteNumeroCuenta(Cuenta pCuenta) => lcta.Exists(c => c.Numero == pCuenta.Numero);

        public void AgregarCuentaACliente(Cliente pCliente, Cuenta pCuenta)
        {
            try
            {

                var cli = lcli.Find(c => c.DNI == pCliente.DNI);
                var cta = lcta.Find(c => c.Numero == pCuenta.Numero);
                if (cli != null && cta != null)
                {
                    if (cli.ObtenerCuentas().Exists(c => c.Numero == cta.Numero)) throw new Exception("La cuenta ya esta asignada !!!");
                
                    cli.AgregarCuenta(cta);
                    cta.AgregarCliente(cli);
                }
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }
        public List<object> ObtenerCuentasCliente(Cliente pCliente)
        {
            
            var cli = lcli.Find(c => c.DNI == pCliente.DNI);
            if (cli == null) throw new Exception("El cliente no existe !!!");
            var rdo = from cta in cli.ObtenerCuentas()
                      select new { Número = cta.Numero, Saldo = cta.Saldo, Tipo = cta.CloneTipado(), Descubierto = cta is CC ? (cta as CC).Descubierto.ToString() : "--" };
         
            return rdo.ToList<object>();
        }
        public List<object> ObtenerTitularesCuenta(Cuenta pCuenta)
        {
            var cta = lcta.Find(c => c.Numero == pCuenta.Numero);
            if (cta == null) throw new Exception("La cuenta no existe !!!");
            var rdo = from cli in cta.ObtenerClientes()
                      select new { DNI = cli.DNI, Nombre = cli.Nombre, Apellido = cli.Apellido };
            return rdo.ToList<object>();
        }
        public void Depositar(Cuenta pCuenta, decimal pImporte)
        {
            var cta = lcta.Find(c => c.Numero == pCuenta.Numero);
            if (cta == null) throw new Exception("La cuenta no existe !!!");
            cta.Depositar(pImporte);
        }
        public void Extraer(Cuenta pCuenta, decimal pImporte)
        {
            var cta = lcta.Find(c => c.Numero == pCuenta.Numero);
            if (cta == null) throw new Exception("La cuenta no existe !!!");
            cta.Extraer(pImporte);
        }
        public void Transferir(Cuenta pCuentaOrigen, Cuenta pCuentaDestino, decimal pImporte)
        {
            var ctaOrigen = lcta.Find(c => c.Numero == pCuentaOrigen.Numero);
            var ctaDestino = lcta.Find(c => c.Numero == pCuentaDestino.Numero);
            if (ctaOrigen == null) throw new Exception("La cuenta origen no existe !!!");
            if (ctaDestino == null) throw new Exception("La cuenta destino no existe !!!");
            ctaOrigen.Transferir(pImporte, ctaDestino);
        }
    }
}
