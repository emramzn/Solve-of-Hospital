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

namespace Donem_odevi
{
    public partial class main_page : Form
    {
        
        public main_page()
        {
            InitializeComponent();
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string poliklinik { get; set; }

        SqlConnection baglanti = dataBase.baglan();
        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void main_page_Load(object sender, EventArgs e)
        {
          
        }

        private void main_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            baglanti.Close();
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string yetkigiris = "", personeltcNO = "";
            string sorguone = "select yetki,personelTcNo from giris_bilgileri where Kullanici_Adi = '" + this.kullanici_.Text + "'and sifre = '" + this.sifre_.Text + "'";
            SqlCommand sorgula = new SqlCommand(sorguone, baglanti);
            sorgula.ExecuteNonQuery();
            SqlDataReader yetkiOku = sorgula.ExecuteReader();


            if (yetkiOku.Read())
            {
                yetkigiris = yetkiOku["yetki"].ToString();
                personeltcNO = yetkiOku["personelTcNo"].ToString();

            }

            yetkiOku.Close();

            SqlCommand sorgula2 = new SqlCommand("select count(Kullanici_Adi) from giris_bilgileri where Kullanici_Adi = '" + this.kullanici_.Text + "'and sifre='" + this.sifre_.Text + "'", baglanti);
            int sayisi = Convert.ToInt32(sorgula2.ExecuteScalar());

            if (yetkigiris == "DKR" && sayisi == 1)
            {
                this.Hide();
                Doktor_Sayfası dok = new Doktor_Sayfası();
                dok.label13.Text = personeltcNO;
                dok.Show();


            }
            else if (yetkigiris == "DNM" && sayisi == 1)
            {
                this.Hide();
                GenelDanismanİslemleriEkrani1 gd = new GenelDanismanİslemleriEkrani1();
                gd.Show();


            }
            else if (yetkigiris == "BSK" && sayisi == 1)
            {
                this.Hide();
                Baş_Hekim bh = new Baş_Hekim();
                bh.Show();

            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı Lütfen Kayıt olun");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kullanici__TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
