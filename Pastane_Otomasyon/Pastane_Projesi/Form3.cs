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

namespace Pastane_Projesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-BQVRHU9\\SQLEXPRESS;DataBase=PastaneProjesi;Integrated Security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update  AdminGiris set Password=@sifre where AdminAdSoyad=@k and AdminEposta=@e", baglanti);
            komut.Parameters.AddWithValue("@k",textBox1.Text);
            komut.Parameters.AddWithValue("@sifre",textBox2.Text);
            komut.Parameters.AddWithValue("@e",textBox3.Text);
            int y= komut.ExecuteNonQuery();
            string ad=textBox1.Text.ToString();
         
            if (y>0)
            {
                MessageBox.Show("Sayın "+ad+" şifreniz güncellenmiştir.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya e-posta yanlış.");
            }
            baglanti.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
