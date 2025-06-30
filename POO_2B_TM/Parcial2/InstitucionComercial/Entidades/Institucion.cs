using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Entidades
{
    internal class Institucion
    {
        public event EventHandler AlertaImporteAlto;
        private List<Cliente> clientes;
        private List<Cobro> cobros;
        private List<Cobro> cobrosPendientes;
        private List<Cobro> cobrosPagados;

        public Institucion()
        {
            clientes = new List<Cliente>();
            cobrosPendientes = new List<Cobro>();
            cobrosPagados = new List<Cobro>();
            cobros = new List<Cobro>();
        }

        public void AgregarCliente(Cliente pCliente) => clientes.Add(pCliente);
        public void BorrarCliente(Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            if (cliente != null) clientes.Remove(cliente);
        }
        public void ModificarCliente(Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            if (cliente != null)
            {
                cliente.Nombre = pCliente.Nombre;
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> aux = new List<Cliente>();
            foreach (var c in clientes)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }

        public void AgregarCobro(Cobro pCobro, Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            cliente.AsignarCobro(pCobro);
            pCobro.AsignarCliente(cliente);

            cobrosPendientes.Add(pCobro);
            cobros.Add(pCobro);
        }
        public void PagarCobro(Cobro pCobro, Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            cliente.PagarCobro(pCobro);

            var cobro = cobros.Find(x => x.Codigo == pCobro.Codigo);
            cobrosPendientes.Remove(cobro);
            cobrosPagados.Add(cobro);
            cobros.Remove(cobro);

            if(cobro.CalcularRecargo((DateTime.Now - cobro.FechaVencimiento).Days) + cobro.Importe > 10000) AlertaImporteAlto.Invoke(this, null);
        }
        public List<Cobro> ObtenerCobrosPendienteDeUnCliente(Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            return cliente.ObtenerCobrosPendientes();
        }
        public List<Cobro> ObtenerCobrosPagadosDeUnCliente(Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);

            var datos = cliente.ObtenerCobrosPagados();
            var consulta = (from c in datos select c);
            return consulta.ToList();
        }
        public List<object> ObtenerTodosLosCobrosPagados()
        {
            var datos = cobrosPagados;
            var consulta = from c in datos
                           select new
                           {
                               Cliente = c.Cliente.Nombre,
                               ImporteTotal = c.Importe + c.CalcularRecargo((DateTime.Now - c.FechaVencimiento).Days),
                           };
            return consulta.ToList<object>();
        }


        public bool ValidarLegajoRepetido(string pLegajo)
        {
            bool rdo = true;
            var cliente = clientes.Find(x => x.Legajo == pLegajo);
            if (cliente != null) rdo = false;
            return rdo;
        }
        public bool ValidarCodigoRepetido(string pCodigo)
        {
            bool rdo = true;
            var cobro = cobros.Find(x => x.Codigo == pCodigo);
            if (cobro != null) rdo = false;
            return rdo;
        }
        public bool ValidarDosCobrosPendientes(Cliente pCliente)
        {
            bool rdo = true;
            if (pCliente.ObtenerCobrosPendientes().Count == 2) rdo = false;
            return rdo;
        }
    }
}
