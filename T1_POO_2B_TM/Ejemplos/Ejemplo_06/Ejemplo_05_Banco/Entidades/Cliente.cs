using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class Cliente : ICloneable
    {
        List<Cuenta> lcta;
        public Cliente() => lcta = new List<Cuenta>();
        
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void AgregarCuenta(Cuenta pCuenta) => lcta.Add(pCuenta);
        public void BorrarCuenta(Cuenta pCuenta) => lcta.Remove(pCuenta);
        public void BorrarCuentas() => lcta.Clear();
        public void ModificarCuenta(Cuenta pCuenta)
        {
            int i = lcta.IndexOf(pCuenta);
            if (i != -1) lcta[i] = pCuenta;
        }
        public List<Cuenta> ObtenerCuentas() => lcta;
      
        public object Clone() => this.MemberwiseClone() as Cliente;     
        public Cliente CloneTipado() => (Cliente)this.Clone();  
      


    }
}
