using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial.Entidades
{
    internal abstract class Alumno :ICloneable
    {
        Beca beca;
        Cuota cuota;
        public Alumno()
        { beca = null;cuota = null; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apeliido { get; set; }
        public string Dni { get; set; }
        public void AsignarBeca(Beca pBeca)=> beca = pBeca;
        public void BorrarBeca() => beca = null;
        public Beca ObtenerBeca() => beca!=null ? beca.CloneTipado(): null;
        public void AsignarCuota(Cuota pCuota) => cuota = pCuota.CloneTipado();
        public Cuota ObtenerCuota() => cuota.CloneTipado();
        public object Clone() => MemberwiseClone();
        public Alumno CloneTipado() => (Alumno)Clone();
        public abstract decimal CuotaNeta();
    }
}
