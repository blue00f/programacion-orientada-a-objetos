namespace InstitucionComercial_V1.Entidades
{
    internal class Institucion
    {
        List<Cliente> clientes;
        List<Cobro> cobros;
        public Institucion()
        {
            clientes = new List<Cliente>();
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
            if (cliente != null) cliente.Nombre = pCliente.Nombre;
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> aux = new List<Cliente> ();
            foreach (var cliente in clientes)
            {
                aux.Add(cliente.CloneTipado());
            }
            return aux;
        }
        public bool ValidarLegajoRepetido(string pLegajo)
        {
            bool rdo = false;
            var cliente = clientes.Find(x => x.Legajo == pLegajo);
            if (cliente != null) rdo = true;
            return rdo;
        }


        public void AgregarCobro(Cobro pCobro, Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            if (cliente != null)
            {
                pCobro.AsignarCliente(cliente);
                cliente.AsignarCobro(pCobro);
                cobros.Add(pCobro);
            }
        }
        public void PagarCobro(Cobro pCobro, Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            cliente.QuitarCobro(pCobro);
        }
        public List<Cobro> ObtenerCobrosDelCliente(Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            return cliente.ObtenerCobros();
        }
        public List<Cobro> ObtenerCobrosPagadosDelCliente(Cliente pCliente)
        {
            var cliente = clientes.Find(x => x.Legajo == pCliente.Legajo);
            return cliente.ObtenerCobrosPagados();
        }
        public bool ValidarCodigoRepetido(string pCodigo)
        {
            bool rdo = false;
            var cobro = cobros.Find(x => x.Codigo == pCodigo);
            if (cobro != null) rdo = true;
            return rdo;
        }

        public List<object> ObtenerConsultaDeCobro()
        {
            var aux = new List<object>();
            foreach (var c in clientes)
            {
                var cobrosPagados = c.ObtenerCobrosPagados();
                if (cobrosPagados.Count == 0) break;
                var consulta = from cli in cobrosPagados
                               select new
                               {
                                   Cliente = cli.Nombre,
                                   ImporteTotal = cli.Importe + cli.Recargo,
                               };
                consulta.ToList<object>();
                aux.AddRange(consulta.Cast<object>());
            }
            return aux;
        }
    }
}
