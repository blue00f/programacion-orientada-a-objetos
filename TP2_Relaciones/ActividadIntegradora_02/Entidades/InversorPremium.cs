using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class InversorPremium : Inversor
    {
        private bool disposed = false;
        public InversorPremium(string pNombre, string pApellido, string pDni) : base(pNombre, pApellido, pDni) { }
        public override decimal CalcularComision(decimal pMonto)
        {
            decimal montoFinal;
            if (pMonto <= 20000) montoFinal = pMonto * 0.01m;
            else
            {
                decimal excedente = pMonto - 20000;
                montoFinal = 20000 * 0.01m + excedente * 0.5m;
            }
            return montoFinal;
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    MessageBox.Show("Dispose liberó los recursos administrados de InversorPremium!");
                }
                MessageBox.Show("Dispose liberó los recursos no administrados de InversorPremium!");
                disposed = true;
            }
            base.Dispose(disposing);
        }
        ~InversorPremium()
        {
            Dispose(false);
            MessageBox.Show("GC liberó los recursos de InversorPremium!");
        }
    }
}
