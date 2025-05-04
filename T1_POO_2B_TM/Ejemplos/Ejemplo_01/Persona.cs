using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    internal class Persona : IDisposable
    {
        #region "Constructores"
        public Persona() { MessageBox.Show("SE EJECUTÓ EL CONSTRUCTOR PÚBLICO SON PARÁMETROS"); }
        public Persona(string pNombre) : this() { Nombre = pNombre;}
        public Persona(string pNombre, string pApellido) : this(pNombre) 
        { Apellido = pApellido; }
        public Persona(string pNombre, string pApellido, byte pEdad) : this(pNombre, pApellido)
        {
            Edad = pEdad;
        }
        #endregion
        #region "Propiedades"

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private byte edad;

        public byte Edad
        {
            //get { return edad; }
            get => edad;
            set 
            {
              
                //2. desencadenamiento del evento
                if (value >= 18) MayorDeEdad?.Invoke(this, new MayorDeEdadEventArgs(value));
               
                if (value>0 && value<151) edad = value;           
            }
        }




        #endregion
        #region "Métodos"

        public string RetornaDatos() => $"{Apellido}, {Nombre} {Edad}";

        //public string RetornaDatos()
        //{
        //    return $"{apellido}, {nombre} {edad}";
        //}
        public void Dispose()
        {//Liberar los recursos no administrados como por ejemplo la conexión
         //a una base de dato o un archivo abierto.
           
            GC.SuppressFinalize(this);
            MessageBox.Show("Se ejecutó el Dispose");
        }



        #endregion
        #region "Eventos"
        //1. Declarar el evento
        public event EventHandler<MayorDeEdadEventArgs>? MayorDeEdad;
        #endregion
        #region "Destructor"
        ~Persona()
        {
            MessageBox.Show("Se ejecutó el destructor !!!");
        }
        #endregion

    }
}
