using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Agenda
    {
        List<Persona> lp;
        public Agenda() => lp = new List<Persona>();

        public void AgregarPersona(Persona pPersona)
        {
            Persona? p = BuscarPersonaExistente(pPersona);
            if (p == null)
                lp.Add(pPersona.CloneTipado());
        }
        private Persona? BuscarPersonaExistente(Persona pPersona)
        {
            return lp.Find(x => x.DNI == pPersona.DNI);
        }
        public void EliminarPersona(Persona pPersona)
        {
            Persona? p = BuscarPersonaExistente(pPersona);
            if (p != null)
                lp.Remove(p);
        }
        public void ModificarPersona(Persona pPersonaAnterior, Persona pPersonaNueva)
        {
            Persona? p = BuscarPersonaExistente(pPersonaAnterior);
            if (p != null)
            {
                Persona? pAux = BuscarPersonaExistente(pPersonaNueva);
                if (pAux == null || pPersonaAnterior.DNI==pPersonaNueva.DNI)
                {
                    p.DNI = pPersonaNueva.DNI;
                    p.Nombre = pPersonaNueva.Nombre;
                    p.Apellido = pPersonaNueva.Apellido;
                }
            }
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> lpAux = new List<Persona>();
            lp.ForEach(x => lpAux.Add(x.CloneTipado()));
            return lpAux;
        }
        public void AgregarContactoPersona(Persona pPersona, Contacto pContacto)
        {
            Persona? p = BuscarPersonaExistente(pPersona);
            if (p != null)
                p.AgregarContacto(pContacto.CloneTipado());
        }
        public void BorrarContactoPersona(Persona pPersona, Contacto pContacto)
        {
            Persona? p = BuscarPersonaExistente(pPersona);
            if (p != null)
                p.EliminarContacto(pContacto);
        }
        public void ModicarContactoPersona(Persona pPersona, Contacto pContactoAnterior, Contacto pContactoNuevo)
        {
            Persona? p = BuscarPersonaExistente(pPersona);
            if (p != null)
                p.ModificarContacto(pContactoAnterior,pContactoNuevo);
        }
    }
}
