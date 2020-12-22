using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int result = 2*num1 + 2*num2;
            textBox3.Text = result.ToString();
        }
    }
}
