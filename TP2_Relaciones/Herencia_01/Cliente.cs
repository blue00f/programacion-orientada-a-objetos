using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_01
{
    internal class Cliente : Persona
    {
        public int Legajo { get; set; }

        // El uso de base() permite reutilizar el constructor de Persona(pNombre, pApellido)
        // de esa forma el constructor de Cliente solo se encarga de inicializar los valores especificos del cliente.
        public Cliente(string pNombre, string pApellido, int pLegajo) : base(pNombre, pApellido) => Legajo = pLegajo;

        // El uso de this hace referencia al Legajo definido en esta clase
        // el uso de base hace referencia al Nombre y Apellido definidos en la clase base Persona.
        public override string MostrarInfo() => $"{this.Legajo}: {base.Nombre} {base.Apellido}";

        // En este caso no se puede utilizar el base() para el finalizador.
        // Lo que ocurre es que primero se libera el recurso de Persona y luego el recurso de Cliente.
        ~Cliente() => MessageBox.Show("GC liberó el recurso de un cliente!");
    }
}
