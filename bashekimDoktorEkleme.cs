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
    public partial class bashekimDoktorEkleme : Form
    {
        public bashekimDoktorEkleme()
        {
            InitializeComponent();
        }
        SqlConnection doktorVeri = dataBase.baglan();
        private void bashekimDoktorEkleme_Load(object sender, EventArgs e)
        {

            SqlCommand komutCombo = new SqlCommand();
            komutCombo.CommandText = "select bolumAd from bolumler ";
            komutCombo.Connection = doktorVeri;
            komutCombo.CommandType = CommandType.Text;

            SqlDataReader dataRead;
            dataRead = komutCombo.ExecuteReader();
            while (dataRead.Read())
            {
                comboBox1.Items.Add(dataRead["bolumAd"]);
                comboBox3.Items.Add(dataRead["bolumAd"]);

            }
            
            dataRead.Close();

           


        }
        string bolumID = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand komut2 = new SqlCommand("SELECT  bolumid from bolumler where bolumAd='" + comboBox1.Text + "'",doktorVeri);
            komut2.ExecuteNonQuery();
            SqlDataReader readBolum = komut2.ExecuteReader();

            if (readBolum.Read())
            {
                bolumID = readBolum["bolumid"].ToString();
            }
            readBolum.Close();


            string doktorAl = "select doktorTc,doktorAdiSoyadi from doktorlar where bolumid='" + bolumID + "'";
            SqlDataAdapter adabtr = new SqlDataAdapter(doktorAl, doktorVeri);
            DataTable tablolar = new DataTable();
            adabtr.Fill(tablolar);
            dataGridView1.DataSource = tablolar;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
        void gridGuncelle()
        {

            string hastaGetir = "select doktorTc,doktorAdiSoyadi from doktorlar where bolumid='" +bolumID + "'";
            SqlDataAdapter adabtr = new SqlDataAdapter(hastaGetir, doktorVeri);
            DataTable tablolar = new DataTable();
            adabtr.Fill(tablolar);
            dataGridView1.DataSource = tablolar;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string doktorGuncelle = "UPDATE doktorlar set  doktorAdiSoyadi='" + textBox2.Text + "' where doktorTc='" + textBox1.Text + "'";
                SqlCommand doktorGuncel = new SqlCommand(doktorGuncelle, doktorVeri);
                int durum=doktorGuncel.ExecuteNonQuery();
                if (durum!=1)
                {
                    MessageBox.Show("Güncelleme Başarısız!!!");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    gridGuncelle();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("hata : " + ex.Message);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {



            try
            {


                string bolumidYeni = "";
                SqlCommand komut2 = new SqlCommand("SELECT  bolumid from bolumler where bolumAd='" + comboBox3.Text + "'", doktorVeri);
                komut2.ExecuteNonQuery();
                SqlDataReader readBolum = komut2.ExecuteReader();

                if (readBolum.Read())
                {
                    bolumidYeni = readBolum["bolumid"].ToString();
                }
                readBolum.Close();



                //---------------------------------------
                string randevuAl = "INSERT INTO doktorlar(doktorTc,doktorAdiSoyadi,bolumid) VALUES('" + textBox6.Text + "','" + textBox5.Text + "','" + bolumidYeni + "')";

                SqlCommand doktorEkleKomut = new SqlCommand(randevuAl, doktorVeri);

                int sonuc = doktorEkleKomut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Doktor Ekleme Başarısız");
                }
                else
                {
                    MessageBox.Show("Doktor Ekleme Onaylandı");
                    //this.Close();
                }


                string kullaniciEkle = "INSERT INTO giris_bilgileri(personelTcNo,AdiSoyadi,Kullanici_Adi,Sifre,yetki) VALUES('" + textBox6.Text + "','" + textBox5.Text + "','" + textBox9.Text+ "','"+textBox8.Text+"','"+comboBox2.Text+"')";

                SqlCommand doktorKullaniciEkle = new SqlCommand(kullaniciEkle, doktorVeri);

                int durumSonu = doktorKullaniciEkle.ExecuteNonQuery();
                if (durumSonu != 1)
                {
                    MessageBox.Show("Doktor kullanıcı Ekleme Başarısız");
                }
                else
                {
                    MessageBox.Show("Doktor kullanıcı Ekleme Onaylandı");
                    //this.Close();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("hata : " + hata.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = textBox5.Text;
        }

        private void bashekimDoktorEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bashekimDoktorEkleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            doktorVeri.Close();
        }
    }
}
