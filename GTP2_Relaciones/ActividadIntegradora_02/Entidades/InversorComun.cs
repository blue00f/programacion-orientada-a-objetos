using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class InversorComun : Inversor
    {
        private bool disposed = false;
        public InversorComun(string pNombre, string pApellido, string pDni) : base(pNombre, pApellido, pDni) { }
        public override decimal CalcularComision(decimal pMonto)
        {
            return pMonto * 0.01m;
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    MessageBox.Show("Dispose liberó los recursos administrados de InversorComun!");
                }
                MessageBox.Show("Dispose liberó los recursos no administrados de InversorComun!");
                disposed = true;
            }
            base.Dispose(disposing);
        }
        ~InversorComun()
        {
            Dispose(false);
            MessageBox.Show("GC liberó los recursos de InversorComun!");
        }
    }
}
