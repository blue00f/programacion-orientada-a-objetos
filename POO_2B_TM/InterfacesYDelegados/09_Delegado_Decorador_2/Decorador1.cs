using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Delegado_2
{
    public class Decorador1 : Decorador
    {
        public override string Decorar(string pTexto) => $"*** {pTexto} ***";
        
    }
}
