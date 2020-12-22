using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "baris55_99" && textBox2.Text == "1a2b3c4d99")
            {
                MessageBox.Show("Login Succesfully!!!");
            }

            if(textBox1.Text != "baris55_99" && textBox2.Text == "1a2b3c4d99")
            {
                MessageBox.Show("Username incorrect!!!");
            }

            if(textBox1.Text == "baris55_99" && textBox2.Text != "1a2b3c4d99")
            {
                MessageBox.Show("Password incorrect!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt16(textBox3.Text);
            if(number == 5)
            {
                label4.Text = "True";
            }

            else
            {
                label4.Text = "False";
            }
        }
    }
}
