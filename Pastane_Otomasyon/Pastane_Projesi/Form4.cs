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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-BQVRHU9\\SQLEXPRESS;DataBase=PastaneProjesi;Integrated Security=true"); 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void Listele()
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select *from Urun", baglanti);
            SqlDataAdapter goruntule = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            goruntule.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from Satici", baglanti);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SaticiNo"]);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Urun(UrunAdi,UrunFiyat," +
                "KullanimTarihi,UretimTarihi,SaticiNo,Fotograf) values(@UrunAdi,@UrunFiyat," +
                "@KullanimTarihi,@UretimTarihi,@SaticiNo,@Fotograf)", baglanti);
            cmd.Parameters.AddWithValue("UrunAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("UrunFiyat", textBox2.Text);
            cmd.Parameters.AddWithValue("KullanimTarihi", Convert.ToDateTime(maskedTextBox1.Text));
            cmd.Parameters.AddWithValue("UretimTarihi", Convert.ToDateTime(maskedTextBox2.Text));
            cmd.Parameters.AddWithValue("SaticiNo", comboBox1.Text);
            cmd.Parameters.AddWithValue("Fotograf", textBox3.Text);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {

                MessageBox.Show("Ekleme Başarılı Bir Şekilde Gerçekleşmiştir.");
                baglanti.Close();
                Listele();
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox3.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Urun set UrunAdi=@UrunAdi,UrunFiyat=@UrunFiyat," +
                "KullanimTarihi=@KullanimTarihi,UretimTarihi=@UretimTarihi,SaticiNo=@SaticiNo,Fotograf=@Fotograf where UrunNo=@UrunNo", baglanti);
            cmd.Parameters.AddWithValue("UrunNo", label7.Text);
            cmd.Parameters.AddWithValue("UrunAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("UrunFiyat", textBox2.Text);
            cmd.Parameters.AddWithValue("KullanimTarihi", Convert.ToDateTime(maskedTextBox1.Text));
            cmd.Parameters.AddWithValue("UretimTarihi", Convert.ToDateTime(maskedTextBox2.Text));
            cmd.Parameters.AddWithValue("SaticiNo", comboBox1.Text);
            cmd.Parameters.AddWithValue("Fotograf", textBox3.Text);
            int y = cmd.ExecuteNonQuery();
            if (y > 0)
            {

                MessageBox.Show("Güncelleme Başarılı Bir Şekilde Gerçekleşmiştir.");
                baglanti.Close();
                Listele();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from Urun where UrunNo=@UrunNo", baglanti);
            cmd.Parameters.AddWithValue("UrunNo", label7.Text);
            int z = cmd.ExecuteNonQuery();
            if (z > 0)
            {

                MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Gerçekleşmiştir.");
                baglanti.Close();
                Listele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız.");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.CurrentRow;

            label7.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            maskedTextBox1.Text = row.Cells[3].Value.ToString();
            maskedTextBox2.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[5].Value.ToString();
            openFileDialog1.FileName = row.Cells[6].Value.ToString();
            textBox3.Text = openFileDialog1.FileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
