using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo07
{
    internal class DatosEventArgs : EventArgs
    {
        Persona px, py;
        int pv;
        public DatosEventArgs(Persona pX,Persona pY, int pV) { px=pX; py=pY;pv=pV; }
        public string Info => $"X: {px.Nombre} {px.Apellido} {px.Edad}  --  Y: {py.Nombre} {py.Apellido} {py.Edad}  -- Valor Retornado: {pv}";
    }
}
