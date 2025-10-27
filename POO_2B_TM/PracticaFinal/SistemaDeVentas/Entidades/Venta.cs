using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Eventos;

namespace SistemaDeVentas.Entidades
{
    internal class Venta
    {
        public event EventHandler<StockBajoEventArgs> StockBajo;
        private List<Cliente> clientes;
        private List<Producto> productos;

        public Venta()
        {
            clientes = new List<Cliente>();
            productos = new List<Producto>();
        }

        #region "ABM Cliente y Producto"
        public void AgregarCliente(Cliente pCliente) => clientes.Add(pCliente.CloneTipado());
        public void BorrarCliente(string pIdCliente)
        {
            var cliente = clientes.Find(x => x.Id == pIdCliente);
            if (cliente == null) throw new Exception("El cliente a borrar no existe");
            clientes.Remove(cliente);
        }
        public void ModificarCliente(Cliente pClienteModificado)
        {
            var cliente = clientes.Find(x => x.Id == pClienteModificado.Id);
            if (cliente == null) throw new Exception("El cliente a modificar no existe");

            cliente.Nombre = pClienteModificado.Nombre;
            cliente.Apellido = pClienteModificado.Apellido;
        }
        public void AgregarProducto(Producto pProducto) => productos.Add(pProducto.CloneTipado());
        public void BorrarProducto(string pCodigoProducto)
        {
            var producto = productos.Find(x => x.Codigo == pCodigoProducto);
            if (producto == null) throw new Exception("El producto a borrar no existe");
            productos.Remove(producto);
        }
        public void ModificarProducto(Producto pProductoModificado)
        {
            var producto = productos.Find(x => x.Codigo == pProductoModificado.Codigo);
            if (producto == null) throw new Exception("El produco a modificar no existe");

            producto.Nombre = pProductoModificado.Nombre;
            producto.Stock = pProductoModificado.Stock;
            producto.Precio = pProductoModificado.Precio;
        }
        #endregion
        
        public void AsignarCompraACliente(string pIdCliente, string pCodigoProducto, int pCantidadAComprar)
        {
            var cliente = clientes.Find(x => x.Id == pIdCliente);
            if (cliente == null) throw new Exception("El cliente no existe");
            var producto = productos.Find(x => x.Codigo == pCodigoProducto);
            if (producto == null) throw new Exception("El producto no existe");

            if (pCantidadAComprar > producto.Stock) throw new Exception("La cantidad supera el stock del producto");

            cliente.ComprarProducto(pCantidadAComprar, producto.Precio * pCantidadAComprar);
            producto.Stock -= pCantidadAComprar;
            if (producto.Stock < 10) StockBajo?.Invoke(this, new StockBajoEventArgs(producto.Nombre, producto.Stock));

        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> aux = new List<Cliente>();

            foreach(var c in clientes)
            {
                aux.Add(c.CloneTipado());
            }
            return aux;
        }
        public List<Producto> ObtenerProductos()
        {
            List<Producto> aux = new List<Producto>();
            foreach(var p in productos)
            {
                aux.Add(p.CloneTipado());
            }
            return aux;
        }
        public List<Compra> ObtenerComprasCliente(string pIdCliente)
        {
            var cliente = clientes.Find(x => x.Id == pIdCliente);
            if (cliente == null) throw new Exception("El cliente no existe");
            return cliente.ObtenerCompras();
        }
    }
}
