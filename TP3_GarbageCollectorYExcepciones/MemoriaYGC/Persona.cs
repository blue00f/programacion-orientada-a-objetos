﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaYGC
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona(string pNombre, string pApellido)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }
    }
}
