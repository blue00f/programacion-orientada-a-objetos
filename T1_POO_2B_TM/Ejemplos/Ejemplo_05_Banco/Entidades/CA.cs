using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_Banco.Entidades
{
    internal class CA : Cuenta
    {
        
        public CA() : base()
        {
            //this.Saldo = 0;
        }
        public override string GetNombre => "Caja de Ahorro";
        public override bool Extraer(decimal pImporte)
        {
           //todo: Implementar Extraer en CA
            throw new NotImplementedException();
        }
        public override string ToString() => this.GetNombre;
    }
}
