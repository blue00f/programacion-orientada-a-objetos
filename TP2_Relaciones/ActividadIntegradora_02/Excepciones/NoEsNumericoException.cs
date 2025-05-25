using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradora_02.Excepciones
{
    internal class NoEsNumericoException : Exception
    {
        string campo;
        string valorIngresado;
        public NoEsNumericoException(string pCampo, string pValorIngresado)
        {
            campo = pCampo;
            valorIngresado = pValorIngresado;
        }
        public override string Message => $"El valor ingresado {valorIngresado} ingresado en el campo {campo} no es numérico!";
    }
}
