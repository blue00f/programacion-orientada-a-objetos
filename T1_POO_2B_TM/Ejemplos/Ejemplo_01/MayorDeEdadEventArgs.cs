using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    internal class MayorDeEdadEventArgs : EventArgs
    {
        private byte edad;
        public MayorDeEdadEventArgs(byte pEdad) => Edad = pEdad;

        public byte Edad { get => edad; init => edad = value; }
        public byte Antiguedad { get => (byte)(Edad - 18); }

    }
}