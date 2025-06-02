using Ejemplo_05_Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Servicios
{
    internal class MyItem
    {
        Cuenta cta;
        public MyItem(Cuenta pCta)
        {
            cta = pCta;
        }
        public Cuenta GetCuenta => cta;

        public override string ToString() => cta.GetNombre; 
    }
}
