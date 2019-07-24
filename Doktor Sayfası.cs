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
    public partial class Doktor_Sayfası : Form
    {
        public Doktor_Sayfası()
        {
            InitializeComponent();
        }
        SqlConnection doktorBaglaBase = dataBase.baglan();
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox9.Clear();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void kayitSil(string HastaTc)
        {
            string sql = "DELETE FROM randevuTbl WHERE hastaTc=@tc";
            SqlCommand komut = new SqlCommand(sql, doktorBaglaBase);
            komut.Parameters.AddWithValue("@tc", HastaTc);
            komut.ExecuteNonQuery();
            gridGuncelle();
        }
        void gridGuncelle()
        {

            string hastaGetir = "select Tarih,ranSaat,hastaTc,hastaAdi,hastaSoyadi from randevuTbl where doktor='" + label14.Text + "'";
            SqlDataAdapter adabtr = new SqlDataAdapter(hastaGetir, doktorBaglaBase);
            DataTable tablolar = new DataTable();
            adabtr.Fill(tablolar);
            hastaBilgiGrid.DataSource = tablolar;

        }
        private void Doktor_Sayfası_Load(object sender, EventArgs e)
        {   string duyuruCek = "select duyuru from duyuru";
            SqlCommand komutduyuru = new SqlCommand(duyuruCek, doktorBaglaBase);
            komutduyuru.ExecuteNonQuery();

            SqlDataReader isReading = komutduyuru.ExecuteReader();

            if (isReading.Read())
            {
                duyuruList.Items.Add(isReading["duyuru"].ToString());
              
            }
            isReading.Close();



            string gecici = "", doktorSorgu = "SELECT doktorAdiSoyadi,bolumid from doktorlar where doktorTc='"+label13.Text.ToString() + "'";
            
            
            SqlCommand komut1 = new SqlCommand(doktorSorgu, doktorBaglaBase);
            komut1.ExecuteNonQuery();

            SqlDataReader isRead = komut1.ExecuteReader();

            if (isRead.Read())
            {
                label14.Text = isRead["doktorAdiSoyadi"].ToString();
                gecici = isRead["bolumid"].ToString();
               
            }
           
            isRead.Close();

            
            SqlCommand komut2 = new SqlCommand("select bolumAd from bolumler where bolumid='" + gecici.ToString()+"'",doktorBaglaBase);
            komut2.ExecuteNonQuery();
            SqlDataReader readBolum = komut2.ExecuteReader();

            if (readBolum.Read())
            {
                label15.Text = readBolum["bolumAd"].ToString();
            }
            readBolum.Close();


            string hastaGetir = "select Tarih,ranSaat,hastaTc,hastaAdi,hastaSoyadi from randevuTbl where doktor='" + label14.Text + "'";
            SqlDataAdapter adabtr = new SqlDataAdapter(hastaGetir, doktorBaglaBase);
            DataTable tablolar = new DataTable();
            adabtr.Fill(tablolar);
            hastaBilgiGrid.DataSource = tablolar;
            
        }

        private void Doktor_Sayfası_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void Doktor_Sayfası_FormClosed(object sender, FormClosedEventArgs e)
        {
            doktorBaglaBase.Close(); 
        }
        private void hastaBilgiGrid_Click(object sender, EventArgs e)
        {
        }
        private void hastaBilgiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = hastaBilgiGrid.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = hastaBilgiGrid.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = hastaBilgiGrid.CurrentRow.Cells[4].Value.ToString();
            textBox9.Text = hastaBilgiGrid.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = hastaBilgiGrid.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                

                string hastaTedaviEkle = "INSERT INTO hastaTedaviSonuclari(hastaTc,adi,soyadi,bolumu,doktoru,bulgular)VALUES('" + textBox1.Text + "','" + textBox7.Text + "','"+textBox2.Text+"','"+label15.Text+"','"+label14.Text+"','"+textBox5.Text+"')";

                SqlCommand bulgular = new SqlCommand(hastaTedaviEkle, doktorBaglaBase);
                int durum = bulgular.ExecuteNonQuery();
                
                if (durum != 1)
                {
                    MessageBox.Show("Bulgular kaydı başarısız.");
                }
                else
                {
                    MessageBox.Show("Bulgular Kaydı başarılı.");
                    kayitSil(hastaBilgiGrid.CurrentRow.Cells[2].Value.ToString());
                    temizle();
                  
                }


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Visible = true;

                string hastaOdaEkle = "INSERT INTO hastaYatis(hastaTc,adi,soyadi,yatisBolumu,yatisOda,doktorAd)VALUES('" + textBox1.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + label15.Text + "','" + comboBox1.Text + "','" + label14.Text + "')";

                SqlCommand bulgular = new SqlCommand(hastaOdaEkle, doktorBaglaBase);
                int durum = bulgular.ExecuteNonQuery();

                if (durum != 1)
                {
                    MessageBox.Show("Hasta Yatışa Alındı.");
                    
                    comboBox1.Visible = false;
                }
             

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
    }
}
