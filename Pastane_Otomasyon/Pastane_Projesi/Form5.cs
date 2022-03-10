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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-BQVRHU9\\SQLEXPRESS;DataBase=PastaneProjesi;Integrated Security=true"); 

        private void button4_Click(object sender, EventArgs e)
        {
            //DateTime KullanimTarihi;

            baglanti.Open();
            string UrunAdi = comboBox1.Text;
            SqlCommand cmd = new SqlCommand("Select *from Urun where UrunAdi like  '%" + comboBox1.Text + "%'", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                panel1.Visible = true;
                if (dr["UrunAdi"].ToString() == UrunAdi)
                {
                    string no = (dr["UrunNo"].ToString());
                    label15.Text = no;
                    string Urunad = (dr["UrunAdi"].ToString());
                    textBox5.Text = Urunad;
                    string money = (dr["UrunFiyat"].ToString());
                    textBox4.Text = money;
                    DateTime date1 = Convert.ToDateTime(dr["KullanimTarihi"]);
                    maskedTextBox4.Text = date1.ToString();
                    string date2 = (dr["UretimTarihi"].ToString());
                    maskedTextBox3.Text = date2.ToString();
                    string satici = (dr["SaticiNo"].ToString());
                    comboBox2.Text = satici;
                    openFileDialog1.FileName = (dr["Fotograf"].ToString());
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    //textBox3.Text = openFileDialog1.FileName;


                }

            }
            baglanti.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            panel1.Visible = false;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from Urun", baglanti);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["UrunAdi"]);
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label2.Text = label15.Text;
            label4.Text = textBox4.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        public decimal fiyat;
        public decimal adet;
        public decimal toplam;
        private void button3_Click(object sender, EventArgs e)
        {
            toplam = Convert.ToDecimal(label7.Text);
            if (toplam == 0)
            {
                MessageBox.Show("Siparişiniz bulunmamaktadır.");
            }
            else
            {
                MessageBox.Show("Siparişiniz alınmıştır.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDecimal(textBox4.Text);
            adet = Convert.ToDecimal(numericUpDown1.Value);
            decimal toplam = fiyat * adet;
            label7.Text = Convert.ToString(toplam);
            
        }

    }
}
