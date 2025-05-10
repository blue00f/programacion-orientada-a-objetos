using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class Banco
    {
        List<Cliente> lcli;
        List<Cuenta> lcta;
        public Banco()
        {
            lcli = new List<Cliente>();
            lcta = new List<Cuenta>();
        }
        public void AgregarCliente(Cliente pCliente) { lcli.Add(pCliente.CloneTipado());int x = 0; }
        public void AgregarCuenta(Cuenta pCuenta) { lcta.Add(pCuenta.CloneTipado()); int x = 0; }
        public void BorrarCliente(Cliente pCliente)
        {
            var cliente = lcli.Find(c => c.DNI == pCliente.DNI);
            if(cliente !=null) lcli.Remove(cliente);
            // todo: Verificar que el cliente no figure como titular de una cuenta
        }
        public void BorrarCuenta(Cuenta pCuenta)
        {
            var cuenta = lcta.Find(c => c.Numero == pCuenta.Numero);
            if (cuenta != null) lcta.Remove(cuenta);
        }
        public void ModificarCliente(Cliente pCliente)
        {
            var cliente = lcli.Find(c => c.DNI == pCliente.DNI);
            if (cliente != null)
            {
                cliente.Nombre = pCliente.Nombre;
                cliente.Apellido = pCliente.Apellido;
            }
            // todo: verificar que los datos del titular se hayan modificado en las cuentas.
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
                      select new {Número = cta.Numero,Saldo = cta.Saldo, Tipo = cta.CloneTipado() ,Descubierto = cta is CC ? (cta as CC).Descubierto.ToString() : "--"};
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
    }
}
