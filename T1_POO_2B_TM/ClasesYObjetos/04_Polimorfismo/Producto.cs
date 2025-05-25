using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_04
{
    internal class Producto : Operacion
    {
        public override decimal Calcular(decimal a, decimal b) => a * b;
        public override string Nombre => $"{base.Nombre} de Producto";
    
    }
}
