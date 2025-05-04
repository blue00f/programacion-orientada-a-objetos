using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_04
{
    internal class MyItem
    {
        Operacion operacion;
        public MyItem(Operacion pOperacion) => operacion = pOperacion;
        public Operacion GetOperacion => operacion;

        public override string ToString() => $"{operacion.GetType().Name}";

    }
}
