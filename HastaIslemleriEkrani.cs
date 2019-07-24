using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Donem_odevi
{

    public partial class HastaIslemleriEkrani : DevExpress.XtraEditors.XtraForm
    {
        public HastaIslemleriEkrani()
        {
            InitializeComponent();

        }
        SqlConnection connecting = dataBase.baglan();
        private void button1_Click(object sender, EventArgs e)
        {


           /// HastaKayit yeniHasta;
            string cinsiyet="belirtilmedi";
            if (Erkek_radioBtn.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (Kadin_RadioBtn.Checked)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                MessageBox.Show("cinsiyet seçin.");
            }
           


           
            try
            {

                if (TC_text.Text.Length != 11)
                {
                    MessageBox.Show("T.C Kimlik No 11 Karakter olmalı!!");
                }
                else
                {



                    string kayitEkleme = "INSERT INTO hastalarTablosu(" +
                   "hastaTc,Adi,soyadi," +
                   "babaAd,cinsiyet,dogumIl," +
                   "dogumIlce,dogumYili,evAdres," +
                   "isAdres,yakinAdres,telefonEv," +
                   "telefonIs," +

                   "telefonCep,telefonDiger," +
                   "kimlikTuru,seriNo,kayitIli," +
                   "kayitIlce,kimlikMahalle,kimlikCildNo," +
                   "aileSiraNo," +

                   "siraNo,kimlikVerildigiYer,kimlikVerilmeTarihi," +
                   "uyruk,medeniHali,kanGrubu,ogrenimDurumu,calismaDurumu," +
                   "meslegi,mail,acilYakinAd,acilYakinTel,kayitTarihi," +

                   "basvuruBolumu,doktoru,vezneIslemi)VALUES('" + TC_text.Text + "','" + Adi_text.Text + "'," +
                   "'" + Soyadi_text.Text + "','" + BabaAdi_text.Text + "','" + cinsiyet + "','" + DogumYeriIL_combo.Text + "'," +
                   "'" + DogumYeriIlce_combo.Text + "','" + dogumtarihiText.Text + "','" + adresEv_text.Text + "','" + AdresIs.Text + "'," +
                   "'" + AdresYakin.Text + "','" + telefonEv_text.Text + "','" + telefonIs_text.Text + "'," +
                   "'" + telefonCep_text.Text + "','" + telefonDiger_text.Text + "','" + kimlikTuru_text.Text + "'" +
                   ",'" + seriNo_text.Text + "','" + kayitIlı_combo.Text + "','" + kayitliIclesi_combo.Text + "','" + mahalle_text.Text + "'" +
                   ",'" + cildNo_text.Text + "','" + aileSiraNo_text.Text + "','" + siraNo_text.Text + "','" + verildigiYer_text.Text + "'," +
                   "'" + verilisTarihiText.Text + "','" + uyruk_combo.Text + "','" + medeniHal_text.Text + "','" + kanGrubu_text.Text + "'," +
                   "'" + ogrenimDurumu_text.Text + "','" + calismaDurumu_text.Text + "','" + meslegi_Text.Text + "','" + eMail_text.Text + "'," +
                   "'" + acilAdi_text.Text + "','" + acilTelefon_text.Text + "','" + hastaneKayitTarihi.Text + "','" + Bolumu_combo.Text + "'," +
                   "'" + doktoru_combo.Text + "','" + vezneIslemi_text.Text + "')";


                    SqlCommand komutVeriEkleme = new SqlCommand(kayitEkleme, connecting);

                    int sonuc = komutVeriEkleme.ExecuteNonQuery();


                    if (sonuc == 1)
                    {
                        MessageBox.Show("KAYIT EKLEME İŞLEMİ BAŞARILI");
                    }
                    /*
                    if (sonuc!=1)
                    {
                        MessageBox.Show("Ekleme Başarısız");
                    }




                    }



                    */

                }

            }
            catch (Exception ex  )
            {

                MessageBox.Show("(*)Lütfen Gereken Alanları Doldurun."+ ex.Message);
            }


            

            



        }
        string bolum_id;
        private void Bolumu_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(poliklinikCombo.SelectedItem.ToString());
            string secim = Bolumu_combo.SelectedItem.ToString();
            string sorgu = "SELECT bolumid from bolumler where bolumAd ='" + secim + "'";

            SqlCommand okuma = new SqlCommand(sorgu, connecting);
            okuma.ExecuteNonQuery();
            SqlDataReader readeOn = okuma.ExecuteReader();

            if (readeOn.Read())
            {
                bolum_id = readeOn["bolumid"].ToString();
            }

            readeOn.Close();

            //MessageBox.Show("" + bolum_id);
            doktoru_combo.Text = null;
            doktoru_combo.Items.Clear(); // bolum seçildikten sonra öncekii doktor seçenekleri kaldırıldı bölüme göre doktor eklendi.
            SqlCommand komutCombo = new SqlCommand();
            komutCombo.CommandText = "select doktorAdiSoyadi from doktorlar where bolumid='" + bolum_id + "'";
            komutCombo.Connection =connecting ;
            komutCombo.CommandType = CommandType.Text;

            SqlDataReader dataRead;
            dataRead = komutCombo.ExecuteReader();
            while (dataRead.Read())
            {
                doktoru_combo.Items.Add(dataRead["doktorAdiSoyadi"]);


            }

            dataRead.Close();



        }

        private void HastaIslemleriEkrani_Load(object sender, EventArgs e)
        {
           /* if (radioButton1.Checked)
            {
                vezneIslemi_text.Visible = false;
                label46.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                vezneIslemi_text.Visible = true;
                label46.Visible = true;
            }
           */
            SqlCommand komutCombo = new SqlCommand();
            komutCombo.CommandText = "select bolumAd from bolumler ";
            komutCombo.Connection = connecting;
            komutCombo.CommandType = CommandType.Text;

            SqlDataReader dataRead;
            dataRead = komutCombo.ExecuteReader();
            while (dataRead.Read())
            {
                Bolumu_combo.Items.Add(dataRead["bolumAd"]);

                
           
            }
            dataRead.Close();
         }

        private void HastaIslemleriEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            connecting.Close();
        }
    }
}