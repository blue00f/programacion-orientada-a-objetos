using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Persona : ICloneable
    {

        List<Contacto> lc;
        public Persona() => lc = new List<Contacto>();
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void AgregarContacto(Contacto pContacto)
        {
          
            if (BuscarContactoExistente(pContacto) == null)
                lc.Add(pContacto.CloneTipado());

        }

        private Contacto? BuscarContactoExistente(Contacto pContacto)
        {
            return lc.Find(x => x.Valor == pContacto.Valor && x.Descripcion == pContacto.Descripcion);
        }

        public void EliminarContacto(Contacto pContacto)
        {
            Contacto? c = BuscarContactoExistente(pContacto);
            if (c!= null)
                lc.Remove(c);
        }
        public void ModificarContacto(Contacto pContactoAnterior, Contacto pContactoNuevo)
        {
            Contacto? c = BuscarContactoExistente(pContactoAnterior);
            if (c != null)
            {
                Contacto? cAux = BuscarContactoExistente(pContactoNuevo);
                if (cAux == null)
                {
                    c.Valor = pContactoNuevo.Valor;
                    c.Descripcion = pContactoNuevo.Descripcion;
                }
            }
        }
        public List<Contacto> ObtenerContactos()
        {
            List<Contacto> lcAux = new List<Contacto>();
            lc.ForEach(x => lcAux.Add(x.CloneTipado()));
            return lcAux;
        }

        public object Clone()
        {
            var pAux = this.MemberwiseClone();
            //Verifica si la persona que clonamos tiene Contactos y se los agrega
            if (lc.Count > 0)
            { 
                lc.ForEach(x => ((Persona)pAux).AgregarContacto(x));
            }
            return pAux;
        }
        public Persona CloneTipado() => (Persona)this.Clone();
    }
}
