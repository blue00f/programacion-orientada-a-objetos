using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_07
{
    internal class Auto
    {
        public Auto(string pPatente,string pMArca, string pModelo, int pAxo) 
        { Patente = pPatente; Marca = pMArca;Modelo = pModelo;Axo = pAxo; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Axo{ get; set; }

        internal class PatenteASC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => x.Patente.CompareTo(y.Patente);
           
        }
        internal class PatenteDESC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => (new PatenteASC()).Compare(x,y) * -1;

        }
        internal class ModeloASC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => x.Modelo.CompareTo(y.Modelo);

        }
        internal class ModeloDESC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => (new ModeloASC()).Compare(x,y) * -1;

        }
        internal class MarcaASC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y)
            {

                int rdo = x.Marca.CompareTo(y.Marca);
                if (rdo == 0) rdo = x.Modelo.CompareTo(y.Modelo);
                return rdo;
            }
        }
        internal class MarcaDESC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => (new MarcaASC()).Compare(x, y) * -1;

        }
        internal class AxoASC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => x.Axo.CompareTo(y.Axo);

        }
        internal class AxoDESC : IComparer<Auto>
        {
            public int Compare(Auto x, Auto y) => (new AxoASC()).Compare(x,y) * -1;

        }
    }
}
