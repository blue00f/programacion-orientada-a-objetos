using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ActividadIntegradora_03.Entidades
{
    internal class Gestor
    {
        private List<Producto> productos;

        public Gestor()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto pProducto) => productos.Add(pProducto);
        public void BorrarProducto(Producto pProducto)
        {
            var p = productos.Find(x => x.Id == pProducto.Id);
            productos.Remove(p);
        }
        public void ModificarProducto(Producto pProducto)
        {
            var p = productos.Find(x => x.Id == pProducto.Id);
            if (p != null)
            {
                p.Descripcion = pProducto.Descripcion;
                p.Precio = pProducto.Precio;
                p.Stock = pProducto.Stock;
            }
        }
        public List<Producto> ObtenerProductos()
        {
            List<Producto> aux = new List<Producto>();
            foreach (var p in productos)
            {
                aux.Add(p.CloneTipado());
            }
            return aux;
        }

        static public bool ValidarIdProducto(string pId)
        {
            bool rdo = true;
            string formato = @"^\d{3}-[A-Z]\d{2}-[A-Z]{2}\d{3}-\d{2}/\d{2}/\d{4}$";
            if (!Regex.IsMatch(pId, formato)) rdo = false;
            return rdo;
        }
        public bool ValidarProductoRepetido(string pId)
        {
            bool rdo = true;
            var p = productos.Find(x => x.Id == pId);
            if (p != null) rdo = false;
            return rdo;
        }
    }
}
