using Microsoft.VisualBasic;

namespace Ejemplo_01
{
    public partial class Form1 : Form
    {
        Persona p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Persona();
            //3. Suscripción del evento
            p.MayorDeEdad += F_MayorDeEdad;
        }



        private void F_MayorDeEdad(object sender, MayorDeEdadEventArgs e) => MessageBox.Show($"Es mayor de edad{Environment.NewLine}" +
                                                                                             $"Edad: {e.Edad}{Environment.NewLine}" +
                                                                                             $"Antiguedad: {e.Antiguedad}");

        private void button2_Click(object sender, EventArgs e)
        {
            p.Nombre = Interaction.InputBox("Nombre: ");
            p.Apellido = Interaction.InputBox("Apellido: ");
            p.Edad = Convert.ToByte(Interaction.InputBox("Edad: "));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{p.Nombre} {p.Apellido} {p.Edad}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.RetornaDatos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (p is IDisposable) p.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p = new Persona(Interaction.InputBox("Ingrese el Nombre:"));
            //3. Suscripción del evento
            p.MayorDeEdad += F_MayorDeEdad;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p = new Persona(Interaction.InputBox("Ingrese el Nombre:"),
                            Interaction.InputBox("Ingrese el Apellido:"));
            //3. Suscripción del evento
            p.MayorDeEdad += F_MayorDeEdad;
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            p= new Persona(Interaction.InputBox("Ingrese el Nombre:"),
                           Interaction.InputBox("Ingrese el Apellido:"),
                           Convert.ToByte(Interaction.InputBox("Ingrese la Edad:")));
            //3. Suscripción del evento
            p.MayorDeEdad += F_MayorDeEdad;
            p.Edad = p.Edad;

        }
    }
}
