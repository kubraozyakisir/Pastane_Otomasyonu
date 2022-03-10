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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-BQVRHU9\\SQLEXPRESS;DataBase=PastaneProjesi;Integrated Security=true"); 

        public void Listele()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select *from Satici", baglanti);
            SqlDataAdapter goruntule = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            goruntule.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Satici set SaticiAdSoyad=@SaticiAdSoyad,SaticiAdres=@SaticiAdres,Saticiİl=@Saticiİl,Saticiİlce=@Saticiİlce where SaticiNo=@SaticiNo",baglanti);
            cmd.Parameters.AddWithValue("SaticiNo", textBox1.Tag);
            cmd.Parameters.AddWithValue("SaticiAdSoyad", textBox1.Text);
            cmd.Parameters.AddWithValue("SaticiAdres", richTextBox1.Text);
            cmd.Parameters.AddWithValue("Saticiİl", comboBox1.Text);
            cmd.Parameters.AddWithValue("Saticiİlce", comboBox2.Text);
            int x = cmd.ExecuteNonQuery();
            if (x>0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from Satici where SaticiNo=@SaticiNo", baglanti);
            cmd.Parameters.AddWithValue("SaticiNo", textBox1.Tag);            
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {

                MessageBox.Show("Silme Başarılı Bir Şekilde Gerçekleşmiştir.");
                baglanti.Close();
                Listele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Satici(SaticiAdSoyad,SaticiAdres,Saticiİl,Saticiİlce) values(@SaticiAdSoyad,@SaticiAdres,@Saticiİl,@Saticiİlce)", baglanti);
            cmd.Parameters.AddWithValue("SaticiAdSoyad", textBox1.Text);
            cmd.Parameters.AddWithValue("SaticiAdres", richTextBox1.Text);
            cmd.Parameters.AddWithValue("Saticiİl", comboBox1.Text);
            cmd.Parameters.AddWithValue("Saticiİlce", comboBox2.Text);

           int x= cmd.ExecuteNonQuery();
            if (x>0)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            textBox1.Tag = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            richTextBox1.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            comboBox2.Text = row.Cells[4].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
