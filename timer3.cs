using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value < 50)
            {
                label1.BackColor = Color.Green;
            }

            if (progressBar1.Value > 50 && progressBar1.Value < 75)
            {
                label1.BackColor = Color.Orange;
            }

            if (progressBar1.Value > 75)
            {
                label1.BackColor = Color.Red;
            }

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            
            if(progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Green;
            }

            if(progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Red;
            }

            if(progressBar2.Value == 75)
            {
                timer3.Start();
            }

            if(progressBar2.Value == 100)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;

            if(progressBar3.Value % 10 == 0)
            {
                label3.BackColor = Color.Beige;
            }

            if(progressBar3.Value % 10 != 0)
            {
                label3.BackColor = Color.Cyan;
            }

            if(progressBar3.Value == 100)
            {
                timer3.Stop();
            }
        }
    }
}
