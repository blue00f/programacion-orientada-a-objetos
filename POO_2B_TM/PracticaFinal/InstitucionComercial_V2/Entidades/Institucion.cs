namespace InstitucionComercial_V2.Entidades
{
    internal class Institucion
    {
        public event EventHandler ImporteAlto;
        private List<Cliente> clientes;
        private List<Cobro> todosLosCobrosPendientes;
        private List<Cobro> todosLosCobrosPagados;

        public Institucion()
        {
            clientes = new List<Cliente>();
            todosLosCobrosPendientes = new List<Cobro>();
            todosLosCobrosPagados = new List<Cobro>();
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
        public bool ValidarLegajoRepetido(string pLegajo)
        {
            bool rdo = true;
            var cliente = clientes.Find(x => x.Legajo == pLegajo);
            if (cliente != null) rdo = false;
            return rdo;
        }



        public bool AgregarCobro(Cobro pCobro, Cliente pCliente)
        {
            todosLosCobrosPendientes.Add(pCobro);
            pCobro.AsignarCliente(pCliente);
            return pCliente.AsignarCobro(pCobro);
        }
        public void PagarCobro(Cobro pCobro, Cliente pCliente)
        {
            pCliente.PagarCobro(pCobro);
            decimal importeTotal = 0;

            importeTotal = CalcularImporteTotal(pCobro);
            if (importeTotal > 10000)
            {
                ImporteAlto.Invoke(this, null);
            }
            todosLosCobrosPagados.Add(pCobro);
        }

        private static decimal CalcularImporteTotal(Cobro pCobro)
        {
            decimal importeTotal;
            if (pCobro is CobroNormal)
            {
                importeTotal = pCobro.CalcularImporteConRetraso((DateTime.Now - pCobro.FechaVencimiento).Days) + pCobro.Importe;
            }
            else
            {
                importeTotal = pCobro.CalcularImporteConRetraso((DateTime.Now - pCobro.FechaVencimiento).Days) + pCobro.Importe;
            }

            return importeTotal;
        }

        public List<Cobro> ObtenerCobroDelCliente(Cliente pCliente) => pCliente.ObtenerCobros();
        public List<Cobro> ObtenerCobrosPagadosDelCliente(Cliente pCliente) => pCliente.ObtenerCobrosPagados();
        public List<object> ObtenerTodosLosCobros()
        {
            var datos = todosLosCobrosPagados;
            var consulta = (from c in datos select new
            {
                Nombre = c.Cliente.Nombre,
                ImporteTotal = CalcularImporteTotal(c)
            }).ToList<object>();

            return consulta;
        }
        public bool ValidarCodigoRepetido(string pCodigo)
        {
            bool rdo = true;
            var cobro = todosLosCobrosPendientes.Find(x => x.Codigo == pCodigo);
            if (cobro != null) rdo = false;
            return rdo;
        }
        public bool ValidarDosCobros(Cliente pCliente)
        {
            bool rdo = true;
            if (pCliente.ObtenerCobros().Count == 2) rdo = false;
            return rdo;
        }
    }
}
