using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ActividadIntegradora_02.Entidades
{
    internal abstract class Inversor : ICloneable
    {
        protected List<CompraAccion> acciones;
        private static int legajoIncremental = 1;
        public int Legajo { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }

        public Inversor(string pNombre, string pApellido, string pDni)
        {
            Legajo = legajoIncremental++;
            Nombre = pNombre;
            Apellido = pApellido;
            Dni = pDni;
            acciones = new List<CompraAccion>();
        }
        ~Inversor()
        {
            MessageBox.Show("GC liberó los recursos del inversor!");
        }

        public bool ComprarAccion(Accion pAccion, int pCantidad, List<Inversor> pInversores)
        {
            bool rdo = false;
            int totalCompradas = pInversores
                .SelectMany(i => i.acciones)
                .Where(a => a.Accion.Codigo == pAccion.Codigo)
                .Sum(a => a.CantidadComprada);

            if (totalCompradas + pCantidad <= pAccion.CantidadEmitida)
            {
                rdo = true;
                var compraExistente = acciones.Find(a => a.Accion.Codigo == pAccion.Codigo);
                if (compraExistente != null)
                {
                    compraExistente.CantidadComprada += pCantidad;
                }
                else
                {
                    acciones.Add(new CompraAccion(pAccion, pCantidad));
                }
            }
            
            return rdo;
        }
        public bool VenderAccion(string pCodigoAccion, int pCantidad)
        {
            bool rdo = false;

            var compraExistente = acciones.Find(a => a.Accion.Codigo == pCodigoAccion);
            if (compraExistente != null && compraExistente.CantidadComprada >= pCantidad)
            {
                rdo = true;
                compraExistente.CantidadComprada -= pCantidad;
                if (compraExistente.CantidadComprada == 0) acciones.Remove(compraExistente);
            }
            return rdo;
        }
        public abstract decimal CalcularComision(decimal pMonto);

        public List<CompraAccion> ObtenerCompraAcciones()
        {
            List<CompraAccion> aux = new List<CompraAccion>();
            acciones.ForEach(c => aux.Add(c.CloneTipado()));
            return aux;
        }

        public static bool ValidarDni(string pDni)
        {
            bool rdo = false;
            if (pDni.Length == 8) rdo = true;
            return rdo;
        }
        public object Clone() => this.MemberwiseClone();
        public Inversor CloneTipado() => (Inversor)this.Clone();


        internal class InversorASC : IComparer<Inversor>
        {
            public int Compare(Inversor x, Inversor y)
            {
                int rdo = x.Legajo.CompareTo(y.Legajo);
                if (rdo == 0) rdo = x.Nombre.CompareTo(y.Nombre);
                if (rdo == 0) rdo = x.Apellido.CompareTo(y.Apellido);
                if (rdo == 0) rdo = x.Dni.CompareTo(y.Dni);
                return rdo;
            }
        }
        internal class InversorDESC : IComparer<Inversor>
        {
            public int Compare(Inversor x, Inversor y) => (new InversorASC()).Compare(x, y) * -1;
        }
    }
}
