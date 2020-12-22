using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSonraki.Text = "Basla";
        }

        int soruno = 0, dogruno = 0, yanlısno = 0;
        

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            numSoru.Text = soruno.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnSonraki.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnc.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Text = "Sonraki";

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnc.Text = "1922";
                btnD.Text = "1923";

                label1.Text = "1923";

            }

            if(soruno == 2)
            {
                richTextBox1.Text = "Hangi İlimiz Ege Bölgesinde BUlunmaz ?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnc.Text = "Muğla";
                btnD.Text = "Manisa";

                label1.Text = "Balıkesir";
            }

            if(soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar Hangi Yazarımıza Aittir ?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnc.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri";

                label1.Text = "Sait Faik";
            }

            if(soruno == 4)
            {
                numSoru.Text = "3";
                MessageBox.Show("Dogru Sayısı : " + dogruno + "\n" + "Yanlış Sayısı : " + yanlısno);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label2.Text = btnA.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnD.Enabled = false;
            if (label2.Text == label1.Text)
            {
                dogruno++;
                numDogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlısno++;
                numYanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label2.Text = btnB.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnD.Enabled = false;

            if (label2.Text == label1.Text)
            {
                dogruno++;
                numDogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlısno++;
                numYanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            label2.Text = btnc.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnD.Enabled = false;

            if (label2.Text == label1.Text)
            {
                dogruno++;
                numDogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlısno++;
                numYanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label2.Text = btnD.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnD.Enabled = false;

            if (label2.Text == label1.Text)
            {
                dogruno++;
                numDogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlısno++;
                numYanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void lblSoru_Click(object sender, EventArgs e)
        {

        }
    }
}