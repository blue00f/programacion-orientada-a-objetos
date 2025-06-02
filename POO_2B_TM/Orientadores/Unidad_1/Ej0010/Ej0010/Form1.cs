using System;
using System.Windows.Forms;

namespace Ej0010
{
    public partial class Form1 : Form
    {
        AlmacenaString AS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AS = new AlmacenaString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AS[int.Parse(this.textBox4.Text)] = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AS[int.Parse(this.textBox3.Text)]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox2.Clear();
            for (int x=0; x < 10; x++)
            {
                this.textBox2.Text += AS[x] + "\r\n";
            }
        }
    }
    class AlmacenaString
    {
        // Se declara un arrar para almacenar 10 string.
        private string[] ArrString = new string[10];
        // Se define el indizador.
        public string this[int i]
        {
            get { return ArrString[i]; }
            set { ArrString[i] = value; }
        }   
    }
}
