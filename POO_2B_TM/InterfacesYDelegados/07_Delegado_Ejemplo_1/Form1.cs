using Microsoft.VisualBasic;

namespace Delegado_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int Calculo(int a, int b);
        Calculo s =null;
        //public Func<int,int,int> s; // Func<T1, T2, TResult> es un delegado genérico que toma dos parámetros y devuelve un resultado.
        
      
        private void Form1_Load(object sender, EventArgs e)
        {
            s = null; // Inicializamos el delegado con la función Sumar.
        }

        private int Sumar(int num1, int num2) => num1 + num2;
        private int Restar(int num1, int num2) => num1 - num2;
        private int Multiplicar(int num1, int num2) => num1 * num2;
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Interaction.InputBox("num1: "));
            int num2 = Convert.ToInt32(Interaction.InputBox("num2: "));

            if (s != null)
            {
                foreach (Calculo metodo in s.GetInvocationList())
                {
                    int resultado = metodo(num1, num2);
                    MessageBox.Show($"{metodo.Method.Name}: {resultado}");
                }
            }
            else
            {
                MessageBox.Show("No hay funciones suscritas.");
            }
        }

        private void button2_Click(object sender, EventArgs e) => s = Sumar;
        

        private void button3_Click(object sender, EventArgs e) => s = Restar;
        

        private void button4_Click(object sender, EventArgs e) => s = Multiplicar;
        

        private void button5_Click(object sender, EventArgs e)
        {
            s+= Sumar;
            s+= Restar;
            s+= Multiplicar;
        }
    }
    
}
