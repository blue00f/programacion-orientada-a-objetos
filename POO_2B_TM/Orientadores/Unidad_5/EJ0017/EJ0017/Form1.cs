using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<int, bool> myFunc = x => x == int.Parse(this.textBox1.Text);
            bool result = myFunc(int.Parse(this.textBox2.Text)); // retorna verdadero o falso
            MessageBox.Show(result.ToString());
        }
    }
}
