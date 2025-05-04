using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{

    internal class Contacto : ICloneable
    {
  
       
        public string? Valor { get; set; }
        public string? Descripcion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Contacto CloneTipado() => (Contacto)this.Clone();
        
    }
}
