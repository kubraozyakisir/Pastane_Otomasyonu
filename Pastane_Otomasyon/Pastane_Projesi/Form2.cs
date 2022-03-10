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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-BQVRHU9\\SQLEXPRESS;DataBase=PastaneProjesi;Integrated Security=true");

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From KullaniciGirisi where MusteriAd=@p1 and KullaniciSifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into KullaniciGirisi(MusteriAd,KullaniciSifre,EMail,Telefon) values(@MusteriAd,@KullaniciSifre,@EMail,@Telefon)", baglanti);
            cmd.Parameters.AddWithValue("@MusteriAd", textBox4.Text);
            cmd.Parameters.AddWithValue("@KullaniciSifre", textBox3.Text);
            cmd.Parameters.AddWithValue("@EMail", textBox5.Text);
            cmd.Parameters.AddWithValue("@Telefon", textBox6.Text);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Kullanıcı Kaydı Başarılı.");
                groupBox2.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı Kaydı Başarısız.");
            }
            baglanti.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
