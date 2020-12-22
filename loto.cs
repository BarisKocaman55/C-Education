using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] array = new int[4];
            for(int i = 0; i < 4; i++)
            {
                array[i] = random.Next(1, 10);
            }

            label1.Text = array[0].ToString();
            label2.Text = array[1].ToString();
            label3.Text = array[2].ToString();
            label4.Text = array[3].ToString();
            //
            if(textBox1.Text == array[0].ToString())
            {
                textBox1.BackColor = Color.LawnGreen;
            }

            if (textBox1.Text != array[0].ToString())
            {
                textBox1.BackColor = Color.Red;
            }
            //
            if (textBox2.Text == array[1].ToString())
            {
                textBox2.BackColor = Color.LawnGreen;
            }

            if (textBox2.Text != array[1].ToString())
            {
                textBox2.BackColor = Color.Red;
            }
            //
            if (textBox3.Text == array[2].ToString())
            {
                textBox3.BackColor = Color.LawnGreen;
            }
            
            if (textBox3.Text != array[2].ToString())
            {
                textBox3.BackColor = Color.Red;
            }
            //
            if (textBox4.Text == array[3].ToString())
            {
                textBox4.BackColor = Color.LawnGreen;
            }

            if (textBox4.Text != array[3].ToString())
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
