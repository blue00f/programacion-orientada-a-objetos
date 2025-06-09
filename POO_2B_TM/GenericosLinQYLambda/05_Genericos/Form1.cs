namespace Generico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 10;
        int b = 20;
        Auto a1, a2;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Before Swap: a = {a}, b = {b}");
            Swap.SwapValues<int>(ref a, ref b); // Example usage of the Swap class
            MessageBox.Show($"After Swap: a = {a}, b = {b}"); // This will not show swapped values because the swap method is not called correctly

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1 = new Auto() { Patente = "AB-123-JS", Marca = "Toyota", Modelo = "Corolla", Axo = 2020 };
            a2 = new Auto() { Patente = "CD-456-KL", Marca = "Honda", Modelo = "Civic", Axo = 2021 };
            MessageBox.Show($"Before Swap:{Environment.NewLine}a1 = {a1}{Environment.NewLine}a2 = {a2}");
            Swap.SwapValues<Auto>(ref a1, ref a2); // Example usage of the Swap class with Auto objects
            MessageBox.Show($"After Swap:{Environment.NewLine}a1 = {a1}{Environment.NewLine}a2 = {a2}");

        }
    }
}
