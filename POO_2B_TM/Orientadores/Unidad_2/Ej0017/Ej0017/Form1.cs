using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Ej0017
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

        private void button1_Click(object sender, EventArgs e)
        {
            string S = "";
            this.textBox1.Clear();
            // Mediante reflection solicitamos ver todo lo que el objeto instanciado posee
            Type t = typeof(Acceso);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                                 BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] miembros = t.GetMembers(flags);
            S += "El tipo " + t.Name + " tiene " + miembros.Length + " miembros\n\r\n\r\n\r";
            foreach (var miembro in miembros)
            {
                string acceso = "";
                string estatico = "";
                var metodo = miembro as MethodBase;
                if (metodo != null)
                {
                    if (metodo.IsPublic)
                        acceso = " Public";
                    else if (metodo.IsPrivate)
                        acceso = " Private";
                    else if (metodo.IsFamily)
                        acceso = " Protected";
                    else if (metodo.IsAssembly)
                        acceso = " Internal";
                    else if (metodo.IsFamilyOrAssembly)
                        acceso = " Protected Internal ";
                    if (metodo.IsStatic)
                        estatico = " Static";
                }
                S += "Nombre: " + miembro.Name + " - Tipo: " + miembro.MemberType + " - acceso: " + acceso + " " + estatico + " - Declarado por: " + miembro.DeclaringType + "\n\r\n\r\n\r";
            }
            textBox1.Text=S;
        }
    }
    public class Acceso { }
}
