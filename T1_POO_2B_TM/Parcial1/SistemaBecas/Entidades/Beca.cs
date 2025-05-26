using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBecas.Entidades
{
    internal class Beca : ICloneable
    {
        public string Codigo { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public decimal Importe { get; set; }
        private Beneficiario Beneficiario { get; set; }

        public Beca(string pCodigo, DateTime pFechaOtorgamiento, decimal pImporte)
        {
            Codigo = pCodigo;
            FechaOtorgamiento = pFechaOtorgamiento;
            Importe = pImporte;
        }

        public void AsignarBeneficiario(Beneficiario pBeneficiario)
        {
            Beneficiario = pBeneficiario;
        }

        public object Clone() => this.MemberwiseClone();
        public Beca CloneTipado() => (Beca)this.Clone();
    }
}
