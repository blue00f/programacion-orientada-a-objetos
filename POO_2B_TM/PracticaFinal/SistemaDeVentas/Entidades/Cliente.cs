using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Entidades
{
    internal class Cliente : ICloneable
    {
        private List<Compra> compras;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente(string pId, string pNombre, string pApellido)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            compras = new List<Compra>();
        }

        public void ComprarProducto(int pCantidad, decimal pPrecio)
        {
            Compra c = new Compra(pCantidad, pPrecio);
            compras.Add(c.CloneTipado());
        }

        public List<Compra> ObtenerCompras()
        {
            List<Compra> aux = new List<Compra>();
            foreach(Compra c in compras)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }

        public object Clone() => this.MemberwiseClone();
        public Cliente CloneTipado() => (Cliente)this.Clone();

        ~Cliente() => MessageBox.Show("GC liberó los recursos de Cliente");
    }
}
