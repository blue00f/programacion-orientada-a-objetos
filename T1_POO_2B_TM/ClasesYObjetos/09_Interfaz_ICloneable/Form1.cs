using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icloneable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona _p1 = new Persona() { Nombre = "Juan" };
            Persona _p3 = new Persona() { Nombre = "Sebastian" };
            _p1.Jefe = _p3;
            Persona _p2 = (Persona)_p1.Clone();
            _p2.Nombre = "Ana";
            _p2.Jefe.Nombre = "Laura";

        }
    }

    public class Persona : ICloneable
    {
        public string Nombre { get; set; }
        public Persona Jefe { get; set; }

        public object Clone()
        {
            // Clonación superficioal
            return this.MemberwiseClone();
        }
        public Persona DeepClone()
        {
            return RecuDeepClone(this);

        }
        private Persona RecuDeepClone(Persona pPersona)
        {
            Persona _aux = (Persona)pPersona.Clone();
            if (pPersona.Jefe != null) _aux.Jefe = RecuDeepClone(pPersona.Jefe);
            return _aux;
        }
    }
}
