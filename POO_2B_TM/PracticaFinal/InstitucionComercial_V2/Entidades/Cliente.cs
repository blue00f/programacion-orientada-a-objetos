namespace InstitucionComercial_V2.Entidades
{
    internal class Cliente : ICloneable
    {
        private List<Cobro> cobros;
        private List<Cobro> cobrosPagados;
        public string Legajo { get; set; }
        public string Nombre { get; set; }

        public Cliente(string pLegajo, string pNombre)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            cobros = new List<Cobro>();
            cobrosPagados = new List<Cobro>();
        }
        public object Clone() => this.MemberwiseClone();
        public Cliente? CloneTipado() => this.Clone() as Cliente;

        public bool AsignarCobro(Cobro pCobro)
        {
            bool rdo = true;
            if (cobros.Count == 2) rdo = false;
            else cobros.Add(pCobro);
            return rdo;
        }
        public void PagarCobro(Cobro pCobro)
        {
            var cobro = cobros.Find(x => pCobro.Codigo == x.Codigo);
            if (cobro != null)
            {
                cobros.Remove(cobro);
                cobrosPagados.Add(cobro);
            }
        }


        public List<Cobro> ObtenerCobros()
        {
            List<Cobro> aux = new List<Cobro>();
            foreach (var c in cobros)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }
        public List<Cobro> ObtenerCobrosPagados()
        {
            List<Cobro> aux = new List<Cobro>();
            foreach (var c in cobrosPagados)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }
    }
}
