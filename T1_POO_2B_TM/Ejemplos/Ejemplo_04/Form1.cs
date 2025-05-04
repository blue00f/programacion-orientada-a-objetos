namespace Ejemplo_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Ejecutar(Operacion pO)
        {
            try
            {
                textBox3.Text = pO.Calcular(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();

            }
            catch (Exception ex)
            {

                textBox3.Text = "Error";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {   //No lo podemos hacer pues Operacion es una clase abstracta
            //Operacion o = new Operacion();
            comboBox1.Items.Add(new MyItem(new Suma()));
            comboBox1.Items.Add(new MyItem(new Resta()));
            comboBox1.Items.Add(new MyItem(new Producto()));
            comboBox1.Items.Add(new MyItem(new Potencia()));
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyItem mi = (MyItem)comboBox1.SelectedItem;
            Ejecutar(mi.GetOperacion);
            textBox4.Text = $"Familia: {mi.GetOperacion.Familia}";
            textBox5.Text = $"Nombre: {mi.GetOperacion.Nombre}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(null, null);
        }
    }
}
