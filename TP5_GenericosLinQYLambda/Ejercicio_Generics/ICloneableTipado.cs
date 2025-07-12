using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Generics
{
    internal interface ICloneableTipado<T>
    {
        T? CloneTipado();
    }
}
