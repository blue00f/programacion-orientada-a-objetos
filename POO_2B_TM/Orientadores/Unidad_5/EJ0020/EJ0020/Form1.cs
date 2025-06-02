using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };
            IEnumerable<int> query =
                numbers.Where((number, index) => number <= index * 10);

            foreach (int number in query)
            {
                listBox1.Items.Add(number);
            }
        }
    }
}
