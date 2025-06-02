using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ0016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate int del(int i);
        private void button1_Click(object sender, EventArgs e)
        {       
                del myDelegate = x => x * x;
                MessageBox.Show(myDelegate(5).ToString());          
        }
    }
}
