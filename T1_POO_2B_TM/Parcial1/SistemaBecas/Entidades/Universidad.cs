using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBecas.Entidades
{
    internal class Universidad
    {
        List<Beneficiario> beneficiarios;
        List<Beca> becas;

        public Universidad()
        {
            beneficiarios = new List<Beneficiario>();
            becas = new List<Beca>();
        }

        public void AgregarBeneficiario(Beneficiario pBeneficiario) => beneficiarios.Add(pBeneficiario.CloneTipado());

        public void BorrarBeneficiario(Beneficiario pBeneficiario)
        {
            var benef = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            if (benef == null) throw new Exception("El beneficiario a borrar no existe");

            beneficiarios.Remove(benef);
        }

        public void ModificarBeneficiario(Beneficiario pBeneficiario)
        {
            var beneficiario = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            if (beneficiario == null) throw new Exception("El beneficiario a modificar no existe");
            beneficiario.Nombre = pBeneficiario.Nombre;
            beneficiario.Apellido = pBeneficiario.Apellido;
            beneficiario.Dni = pBeneficiario.Dni;
            beneficiario.PagoMensual = pBeneficiario.PagoMensual;
        }

        public void AgregarBeca(Beca pBeca) => becas.Add(pBeca.CloneTipado());

        public void AsignarBecaABeneficiario(Beca pBeca, Beneficiario pBeneficiario)
        {
            var beca = becas.Find(x => x.Codigo == pBeca.Codigo);
            var beneficiario = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            if (beneficiario.MostrarBeca() != null) throw new Exception("El beneficiario ya tiene una beca");

            beca.AsignarBeneficiario(beneficiario);
            beneficiario.AsignarBeca(beca);
        }
        public void QuitarBeca(Beneficiario pBeneficiario)
        {
            var beneficiario = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            beneficiario.QuitarBeca();
        }
        public decimal PagarCuota(Beneficiario pBeneficiario, decimal pImporte)
        {
            var beneficiario = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            decimal pago = pBeneficiario.PagoMensual;
            pago = beneficiario.CalcularBeneficio(pBeneficiario.PagoMensual, pImporte);

            return pago;
        }
        public List<Beneficiario> ObtenerBeneficiarios()
        {
            List<Beneficiario> aux = new List<Beneficiario>();
            foreach(var b in beneficiarios)
            {
                aux.Add(b.CloneTipado());
            }
            return aux;
        }
        public List<Beca> ObtenerBecas()
        {
            List<Beca> aux = new List<Beca>();
            foreach(var b in becas)
            {
                aux.Add(b.CloneTipado());
            }
            return aux;
        }
        public List<Beca> ObtenerBecaDelBeneficiario(Beneficiario pBeneficiario)
        {
            var beneficiario = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            List<Beca> aux = new List<Beca>();

            if (beneficiario.MostrarBeca() != null) aux.Add(beneficiario.MostrarBeca());

            return aux;
        }

        public decimal ObtenerImporteDelBeneficiario(Beneficiario pBeneficiario)
        {
            var beneficiario = beneficiarios.Find(x => x.Legajo == pBeneficiario.Legajo);
            if (beneficiario == null) throw new Exception("El beneficiario no existe");
            decimal importeBeca = beneficiario.MostrarBeca().Importe;
            return importeBeca;
        }

        public bool ValidarCodigoBecaRepetido(string pCodigoBeca)
        {
            bool rdo = false;
            var beca = becas.Find(x => x.Codigo == pCodigoBeca);
            if (beca != null) rdo = true;
            return rdo;
        }
        public bool ValidarLegajoRepetido(string pLegajo)
        {
            bool rdo = false;
            var beneficiario = beneficiarios.Find(x => x.Legajo == pLegajo);
            if (beneficiario != null) rdo = true;
            return rdo;
        }
    }
}
