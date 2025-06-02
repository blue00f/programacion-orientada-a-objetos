using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
    class ClaseNodo { } // Clase concreta
    class ClaseNodoGenerica<T> { } // Clase genérica

    // Clase genérica que hereda de una clase concreta
    class NodoConcreto<T> : ClaseNodo { }

    // Clase genética que hereda de una clase genérica cerrada(pues al parámetro de tipo se le indica que es int)
    class NodoCerrado<T> : ClaseNodoGenerica<int> { }

    // Clase genérica que hereda de una clase genérica abierta.
    // Si se le asigna un tipo a NodoAbierto, el mismo será utilizado por ClaseNodoGenérica.
   class NodoAbierto<T> : ClaseNodoGenerica<T> {  }
}
