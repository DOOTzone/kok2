using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(a + b);
            label2.Text = Convert.ToString(a - b);
            label3.Text = Convert.ToString(a * b);
            label4.Text = (a / b).ToString("F3");
        }
    }
}
