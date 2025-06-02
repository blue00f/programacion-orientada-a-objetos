using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBecas.Entidades
{
    internal abstract class Beneficiario : ICloneable
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public decimal PagoMensual { get; set; }
        private Beca Beca { get; set; }

        public Beneficiario(string pLegajo, string pNombre, string pApellido, string pDni, decimal pPagoMensual)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apellido = pApellido;
            Dni = pDni;
            PagoMensual = pPagoMensual;
        }

        public void AsignarBeca(Beca pBeca)
        {
            Beca = pBeca;
        }
        public void QuitarBeca()
        {
            Beca = null;
        }

        public Beca? MostrarBeca()
        {
            return Beca;
        }

        public abstract decimal CalcularBeneficio(decimal pPagoMensual, decimal pImporte);

        public object Clone() => this.MemberwiseClone();
        public Beneficiario CloneTipado() => (Beneficiario)this.Clone();
    }
}
