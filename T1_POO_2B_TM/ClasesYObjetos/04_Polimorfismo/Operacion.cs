using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_04
{
    internal abstract class Operacion
    {

        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public string Familia => "Aritmética";
        public virtual string Nombre { get { return "Operacion Aritmética"; } }
        public abstract decimal Calcular(decimal a, decimal b);

    }
}
