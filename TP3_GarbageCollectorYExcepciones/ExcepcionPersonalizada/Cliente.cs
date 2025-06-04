using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionPersonalizada
{
    internal class Cliente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Cliente(string pCodigo, string pNombre, string pApellido)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Apellido = pApellido;
        }

        public static bool ValidaFormatoCodigo(string pCodigo)
        {
            bool rdo = false;
            if (pCodigo.Length == 4)
            {
                if (pCodigo[0] >= 'A' && pCodigo[0] <= 'Z')
                {
                    if (Information.IsNumeric(pCodigo.Substring(1, 3))) rdo = true;
                }
            }

            return rdo;
        }

        public override string ToString()
        {
            return $"{Codigo}-{Nombre}-{Apellido}";
        }
    }
}
