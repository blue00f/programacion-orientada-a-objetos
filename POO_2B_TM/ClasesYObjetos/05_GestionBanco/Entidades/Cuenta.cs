using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Ejemplo_05_Banco.Entidades
{
    internal abstract class Cuenta : ICloneable
    {
        protected List<Cliente> ltit;
       
        protected Cuenta() => ltit = new List<Cliente>();
        public string Numero { get; set; }
        public abstract string GetNombre { get; }
        public decimal Saldo { get; set; }
        public void AgregarCliente(Cliente pCliente) => ltit.Add(pCliente);
        public void BorrarCliente(Cliente pCliente) => ltit.Remove(pCliente);
        public void ModificarCliente(Cliente pCliente)
        {
            int i = ltit.IndexOf(pCliente);
            if (i != -1) ltit[i] = pCliente;
        }
        public List<Cliente> ObtenerClientes() => ltit;
        public void Depositar(decimal pImporte) => Saldo += pImporte;
        public abstract bool Extraer(decimal pImporte);
        public void Transferir(decimal pImporte, Cuenta pCuentaDestino)
        {
            if (Extraer(pImporte)) pCuentaDestino.Depositar(pImporte);
        }
        
        public Cuenta CloneTipado() => (Cuenta)this.Clone();

        public object Clone()
        {

            Cuenta ctaAux = this is CA ? new CA() : new CC();
            ctaAux.Numero = this.Numero;
            ctaAux.Saldo = this.Saldo;
            if (this is CC) ((CC)ctaAux).Descubierto = ((CC)this).Descubierto;
            return ctaAux;

        }
    }
}
