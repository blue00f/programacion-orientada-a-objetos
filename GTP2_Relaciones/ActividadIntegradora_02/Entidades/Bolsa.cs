using ActividadIntegradora_02.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Entidades
{
    internal class Bolsa : IDisposable
    {
        public event EventHandler<CambioCotizacionEventArgs> CambioCotizacion;
        List<Inversor> inversores;
        List<Accion> acciones;
        private bool disposed = false;
        public Bolsa()
        {
            inversores = new List<Inversor>();
            acciones = new List<Accion>();
        }

        public void AgregarInversor(Inversor pInversor) => inversores.Add(pInversor.CloneTipado());
        public void BorrarInversor(Inversor pInversor)
        {
            var inversor = inversores.Find(i => i.Legajo == pInversor.Legajo);
            if (inversor.ObtenerCompraAcciones().Count > 0) throw new Exception("No se puede borrar un inversor que posee acciones!");
            if (inversor != null) inversores.Remove(inversor);
        }
        public void ModificarInversor(Inversor pInversor)
        {
            var inversor = inversores.Find(i => i.Legajo == pInversor.Legajo);
            if (inversor != null)
            {
                inversor.Nombre = pInversor.Nombre;
                inversor.Apellido = pInversor.Apellido;
            }
        }

        public void AgregarAccion(Accion pAccion) => acciones.Add(pAccion.CloneTipado());
        public void BorrarAccion(Accion pAccion)
        {
            var inversor = inversores.Find(i => i.ObtenerCompraAcciones().Find(c => c.Accion.Codigo == pAccion.Codigo) != null);
            if (inversor != null) throw new Exception("No se puede eliminar una acción asociada con un inversor!");

            var accion = acciones.Find(a => a.Codigo == pAccion.Codigo);
            if (accion != null) acciones.Remove(accion);
        }
        public void ModificarAccion(Accion pAccion)
        {
            var accion = acciones.Find(a => a.Codigo == pAccion.Codigo);
            if (accion != null)
            {
                if (accion.CotizacionActual != pAccion.CotizacionActual) CambioCotizacion?.Invoke(this, new CambioCotizacionEventArgs(pAccion.CotizacionActual));
                accion.Denominacion = pAccion.Denominacion;
                accion.CotizacionActual = pAccion.CotizacionActual;
                accion.CantidadEmitida = pAccion.CantidadEmitida;
            }
        }

        public bool ComprarAccion(Inversor pInversor, Accion pAccion, int pCantidad)
        {
            bool rdo = pInversor.ComprarAccion(pAccion, pCantidad, inversores);
            if (!rdo) throw new Exception("La compra supera la cantidad emitida de la acción!");
            return rdo;
        }
        public bool VenderAccion(Inversor pInversor, string pCodigoAccion, int pCantidad)
        {
            bool rdo = pInversor.VenderAccion(pCodigoAccion, pCantidad);
            if (!rdo) throw new Exception("No se pudo realizar la venta de acciones!");
            return rdo;
        }

        public object ObtenerInversores()
        {
            var rdo = from inv in inversores
                      select new
                      {
                          Legajo = inv.Legajo,
                          Nombre = inv.Nombre,
                          Apellido = inv.Apellido,
                          DNI = inv.Dni,
                          Tipo = inv is InversorComun ? "Común" : "Premium",
                          Objeto = inv
                      };
            return rdo.ToList<object>();
        }
        public List<Accion> ObtenerAcciones()
        {
            List<Accion> aux = new List<Accion>();
            acciones.ForEach(a => aux.Add(a.CloneTipado()));
            return aux;
        }

        public List<object> ObtenerAccionesDelInversor(Inversor pInversor)
        {
            var inv = inversores.Find(i => i.Legajo == pInversor.Legajo);
            if (inv == null) throw new Exception("El inversor no existe");

            var rdo = from acc in inv.ObtenerCompraAcciones()
                      select new
                      {
                          Codigo = acc.Accion.Codigo,
                          Denominacion = acc.Accion.Denominacion,
                          Cotizacion = acc.Accion.CotizacionActual,
                          Emisiones = acc.Accion.CantidadEmitida,
                          Comprados = acc.CantidadComprada,
                          Valor = acc.CantidadComprada * acc.Accion.CotizacionActual
                      };
            return rdo.ToList<object>();
        }
        public bool ValidarAccionRepetido(string pCodigo)
        {
            bool rdo = false;
            var accion = acciones.Find(x => x.Codigo == pCodigo);
            if (accion == null) rdo = true;
            return rdo;
        }
        public bool ValidarInversorRepetido(string pDni)
        {
            bool rdo = false;
            var inversor = inversores.Find(x => x.Dni == pDni);
            if (inversor == null) rdo = true;
            return rdo;
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
                    MessageBox.Show("Dispose liberó los recursos administrados de Bolsa!");
                }
                MessageBox.Show("Dispose liberó los recursos no administrados de Bolsa!");
                disposed = true;
            }
        }
        ~Bolsa()
        {
            Dispose(false);
            MessageBox.Show("GC liberó los recursos de Bolsa");
        }
    }
}
