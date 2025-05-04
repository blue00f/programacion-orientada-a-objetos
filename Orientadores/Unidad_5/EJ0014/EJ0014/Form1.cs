using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> nombres = new List<string> { "Juan","María","Mariana","Pedro" };
            IEnumerable<string> Z = from N in nombres where N[0] == 'M' select N;
            foreach (string S in Z)
            {
                this.listBox1.Items.Add(S);
            }
        }
    }
}
