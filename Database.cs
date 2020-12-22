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

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-09RBHLIG\\MSSQLSERVER01;Initial Catalog=Employees;Integrated Security=True");

        private void temizle()
        {
            txtPersonelAd.Text = " ";
            txtPersonelSoyad.Text = " ";
            txtPersonelSehir.Text = " ";
            txtPersonelMaas.Text = " ";
            txtPersonelMeslek.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtPersonelAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'employeesDataSet.Employees' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Employees (PersonelAd, PersonelSoyad, PersonelSehir,PersonelMaas, PersonelDurum, PersonelMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            //command.Parameters.AddWithValue("@p1", txtPersonelid.Text);
            command.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            command.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtPersonelSehir.Text);
            command.Parameters.AddWithValue("@p4", txtPersonelMaas.Text);
            command.Parameters.AddWithValue("@p5", label8.Text);
            command.Parameters.AddWithValue("@p6", txtPersonelMeslek.Text);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Personel Eklendi!!!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void btnTemizlik_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtPersonelid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtPersonelAd.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtPersonelSehir.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtPersonelMaas.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txtPersonelMeslek.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }

            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commantDlt = new SqlCommand("delete from Employees where Personelid = @k1", connection);

            commantDlt.Parameters.AddWithValue("@k1", txtPersonelid.Text);
            commantDlt.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Kayıt Silindi!!!");
        }
    }
}
