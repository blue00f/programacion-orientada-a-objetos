namespace Ejercicio_Lambda
{
    public partial class Form1 : Form
    {
        List<int> numeros;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            lstNumeros.Items.Clear();
            foreach (int n in numeros)
            {
                lstNumeros.Items.Add(n);
            }
        }

        private void btnFiltrarPares_Click(object sender, EventArgs e)
        {
            lstPares.Items.Clear();
            var consulta = numeros.Where(n => n %2 == 0).ToList();
            foreach (int n in consulta)
            {
                lstPares.Items.Add(n);
            }
        }
    }
}
