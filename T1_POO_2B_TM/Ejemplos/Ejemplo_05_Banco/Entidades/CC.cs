using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class CC : Cuenta
    {
        public override string GetNombre => "Cuenta Corriente";
        public decimal Descubierto { get; set; }

        public override bool Extraer(decimal pImporte)
        {
            //todo: Implementar Extraer en CC
            throw new NotImplementedException();
        }
        public override string ToString() => this.GetNombre;

    }
}
