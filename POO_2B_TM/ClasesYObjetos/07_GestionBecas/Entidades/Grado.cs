using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial.Entidades
{
    internal class Grado : Alumno
    {
        public Grado() : base()
        {

        }
        public Grado(string pLegajo, string pNombre, string pApellido, string pDni) : this()
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apeliido = pApellido;
            Dni = pDni;
        }


        public override decimal CuotaNeta() => (ObtenerCuota().Importe - ObtenerBeca().Importe) * 0.95m;

    }
}
