using Ejemplo_05_Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Interfaces
{
    internal interface IValidar<T> 
    {
        bool Valida(T pObjeto);
    }
   
}
