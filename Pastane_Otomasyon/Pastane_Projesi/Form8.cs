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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-BQVRHU9\\SQLEXPRESS;DataBase=PastaneProjesi;Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update  KullaniciGirisi set KullaniciSifre=@sifre where MusteriAd=@k and EMail=@e", baglanti);
            komut.Parameters.AddWithValue("@k", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.Parameters.AddWithValue("@e", textBox3.Text);
            int y = komut.ExecuteNonQuery();
            string ad = textBox1.Text;
            if (y > 0)
            {
                MessageBox.Show("Sayın " + ad + " şifreniz güncellenmiştir.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya e-posta yanlış.");
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
