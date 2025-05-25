namespace Ejemplo08
{
    public partial class Form1 : Form
    {
        Producto p;
        Producto[] ps;
        Producto[] ps2;
        string[] v = { "Código: ", "Descripción: ", "Precio: " };
        string[] v1 = { "País: ", "Empresa: ", "Producto: ","DV: ","Pass: " };
        public Form1()
        {
            InitializeComponent();
            p=new Producto("7792345432120", "Cuaderno Universitario", 1250, 1);

            ps= new Producto[] { new Producto("8412584512541", "Cuaderno Universitario", 1250,1),
                                 new Producto("7812344321207", "Bolígrafo", 500,1),
                                 new Producto("7498765242015", "Goma", 250,1)};

            ps2= new Producto[] { new Producto("8412584512541", "Cuaderno Universitario", 1250,2),
                                 new Producto("7812344321207", "Bolígrafo", 500,2),
                                 new Producto("7498765242015", "Goma", 250,2)};

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int c = 0;
            foreach (string s in p)
            {
                textBox1.Text+=$"{v[c]}{s}{Environment.NewLine}";
                c++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach (Producto x in ps)
            {
                int c = 0;
                foreach (string s in x)
                {
                    textBox2.Text+=$"{v[c]}{s}{Environment.NewLine}";
                    c++;
                }
                textBox2.Text+=$"{Environment.NewLine}";
                textBox2.Text+=$"***************{Environment.NewLine}";
                textBox2.Text+=$"{Environment.NewLine}";
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            foreach (Producto x in ps2)
            {
                int c = 0;
                foreach (string s in x)
                {
                    textBox3.Text+=$"{v1[c]}{s}{Environment.NewLine}";
                    c++;
                }
                textBox3.Text+=$"{Environment.NewLine}";
                textBox3.Text+=$"***************{Environment.NewLine}";
                textBox3.Text+=$"{Environment.NewLine}";
            }
        }
    }
}
