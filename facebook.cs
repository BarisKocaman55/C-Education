using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp26
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection connection2 = new SqlConnection("Data Source=LAPTOP-09RBHLIG\\MSSQLSERVER01;Initial Catalog=facebook;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection2.Open();
            SqlCommand command2 = new SqlCommand("update facebooks set şifre=@a1", connection2);
            command2.Parameters.AddWithValue("@a1", textBox3.Text);
            command2.ExecuteNonQuery();

            connection2.Close();
        }

    }
}
