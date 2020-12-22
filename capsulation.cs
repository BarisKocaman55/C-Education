using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car mercedes = new Car();
            mercedes.renk = "Mavi";
            mercedes.hiz = 170;
            mercedes.motor = 12245.56;
            mercedes.fiyat = 100000;
            mercedes.durum = 's';
            mercedes.setYıl(2010);
            int yil = mercedes.getYıl();

            label1.Text = mercedes.renk;
            label2.Text = mercedes.hiz.ToString();
            label3.Text = mercedes.motor.ToString();
            label4.Text = mercedes.fiyat.ToString();
            label5.Text = mercedes.durum.ToString();
            label6.Text = yil.ToString();
        }
    }
}
