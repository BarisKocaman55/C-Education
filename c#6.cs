using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            int fiyat = 8;
            int tutar;

            if(number > 0 && number <= 20)
            {
                tutar = (fiyat * number) - ((fiyat * number * 20) / 100);
                label8.Text = tutar + " TL";
            }

            if(number > 20 && number <= 40)
            {
                tutar = (fiyat * number) - ((fiyat * number * 40) / 100);
                label8.Text = tutar + " TL";
            }

            if(number > 40)
            {
                tutar = (fiyat * number) - ((fiyat * number * 50) / 100);
                label8.Text = tutar + " TL";
            }
         
        }
    }
}
