using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class CompraAccion : ICloneable, IDisposable
    {
        public Accion Accion { get; set; }
        public int CantidadComprada { get; set; }
        private bool disposed = false;

        public CompraAccion(Accion pAccion, int pCantidadComprada)
        {
            Accion = pAccion;
            CantidadComprada = pCantidadComprada;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    MessageBox.Show("Dispose liberó los recursos administrados de CompraAccion!");
                }
                MessageBox.Show("Dispose liberó los recursos no administrados de CompraAccion!");
                disposed = true;
            }
        }
        ~CompraAccion()
        {
            Dispose(false);
            MessageBox.Show("GC liberó los recursos de CompraAccion");
        }

        public object Clone() => this.MemberwiseClone();
        public CompraAccion CloneTipado() => (CompraAccion)this.Clone();
    }
}
