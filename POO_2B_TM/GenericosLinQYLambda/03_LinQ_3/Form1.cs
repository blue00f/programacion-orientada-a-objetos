namespace LinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        IEnumerable<int> ie = null;
        string s = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1_Click(null, null);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ie = from x in i where x % 2 == 0 && x > numericUpDown1.Value orderby x ascending select x; Mostrar();
            }
            else
            {
                ie = from x in i where x % 2 == 0 && x > numericUpDown1.Value orderby x descending select x; Mostrar();
            }
        }
        private void Mostrar()
        {
            s = "";
            ie.ToList().ForEach(x => s += $"{x} ");
            textBox1.Text = s;
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ie = from x in i where x % 2 != 0 && x > numericUpDown1.Value orderby x ascending select x; Mostrar();
            }
            else
            {
                ie = from x in i where x % 2 != 0 && x > numericUpDown1.Value orderby x descending select x; Mostrar();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            EligeFuncion();
        }

        private void EligeFuncion()
        {
            if (radioButton1.Checked) radioButton1_Click(null, null);
            else radioButton2_Click(null, null);
        }


        private void radioButton3_Click(object sender, EventArgs e)
        {
            EligeFuncion();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            EligeFuncion();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
