using Ejemplo_Delegado_2;
using Microsoft.VisualBasic;

namespace Ejemplo_Delegado_1
{
    public partial class Form1 : Form
    {
        //Delegado personalizado
        public delegate string MyDelegate(string pS);
        MyDelegate miDelegado;
        //Func<string, string> miDelegado;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1_Click(null, null);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Asigna(new Decorador1());
        }


        private void radioButton2_Click(object sender, EventArgs e)
        {
            Asigna(new Decorador2());
        }


        private void radioButton3_Click(object sender, EventArgs e)
        {
            Asigna(new Decorador3());
        }

        private void Asigna(Decorador pD)
        {
            miDelegado = pD.Decorar;
            textBox1_TextChanged(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = miDelegado(textBox1.Text);
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            Asigna(new Decorador4());
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Asigna(new Decorador5());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>() { "Hola", "Chau", "Primavera", "Verano" };
            //MessageBox.Show((s.Exists(x => x=="Hola").ToString()));
            MessageBox.Show(($"¿Hola existe en la lista? : {s.Exists(Prueba)}"));
            // La siguiente línea es equivalente a la anterior, pero usando una función anónima
            //MessageBox.Show(($"¿Hola existe en la lista? : {s.Exists(x => x == "Hola")}"));
            MessageBox.Show(($"¿Invierno existe en la lista? : {s.Exists(PruebaBis)}"));
           
        }

        private bool Prueba(string x) => x == "Hola";
        private bool PruebaBis(string x) => x == "Invierno";
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>() { "Hola", "Chau", "Primavera", "Verano" };
            //MessageBox.Show(s.Find(x => x=="Hola"));
            MessageBox.Show(s.Find(Prueba2));
        }
        private bool Prueba2(string x) => x == "Hola";


        private void Action1() => MessageBox.Show("Hola");
        private void Action2() => MessageBox.Show("Chau");
        private void button3_Click(object sender, EventArgs e)
        {
            Action accion;
            var r = MessageBox.Show("¿Está entrando?", "", MessageBoxButtons.YesNoCancel);
            if (r == DialogResult.Yes)
                accion = Action1;
            else if (r == DialogResult.No) accion = Action2;
            else { accion = Action1; accion += Action2; }
            ;//MULTIDIFUSION 

            accion();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            Asigna(new Decorador6());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //miDelegado = checkBox1.Checked ? AgregaAsteriscos : AgregaPipe;

            miDelegado = checkBox1.Checked ? x => $"*** {x} ***" : x => $"||| {x} |||";
            MessageBox.Show(miDelegado(Interaction.InputBox("Ingrese un texto: ")));
        }
        //private string AgregaAsteriscos(string pTexto) => $"*** {pTexto} ***";
        //private string AgregaPipe(string pTexto) => $"||| {pTexto} |||";
    }
}
