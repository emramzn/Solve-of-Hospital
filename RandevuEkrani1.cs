using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Donem_odevi
{
    public partial class RandevuEkrani1 : DevExpress.XtraEditors.XtraForm
    {
        public RandevuEkrani1()
        {
            InitializeComponent();
        }
        public string doktorAdi { get; set; }
        public string tarih { get; set; }

        SqlConnection randevuAl = dataBase.baglan();
        private void button21_Click(object sender, EventArgs e)
        {
            RandevuAltEkran1 altEkran = new RandevuAltEkran1();
            
            altEkran.label7.Text = doktorlarCombo.Text.ToString();
            altEkran.label8.Text = randevuZamaniPicker.Text.ToString();
            altEkran.Show();
            

        }



        private void doktorlarCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ata = randevuZamaniPicker.Value.DayOfWeek.ToString();
            if (ata == "Monday")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;

            }

            else if (ata == "Tuesday")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;


            }
            else if (ata == "Wednesday")
            {
                
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;

            }
            else if (ata == "Thursday")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = true;
                groupBox5.Enabled = false;

            }
            else if (ata == "Friday")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = true;

            }
            else 
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;

            }
        }
    
        private void RandevuEkrani1_Load(object sender, EventArgs e)
        {


            SqlCommand komutCombo = new SqlCommand();
            komutCombo.CommandText = "select bolumAd from bolumler ";
            komutCombo.Connection = randevuAl;
            komutCombo.CommandType = CommandType.Text;

            SqlDataReader dataRead;
            dataRead = komutCombo.ExecuteReader();
            while (dataRead.Read())
            {
                poliklinikCombo.Items.Add(dataRead["bolumAd"]);
               
                
            }
           

            dataRead.Close();
            

        }

        string bolum_id; // bolum seçildikten sonra bölüme göre doktor bilgisini tutmak için global değişken.
        private void poliklinikCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(poliklinikCombo.SelectedItem.ToString());
            string secim = poliklinikCombo.SelectedItem.ToString();
            string sorgu = "SELECT bolumid from bolumler where bolumAd ='"+secim+"'";

            SqlCommand okuma = new SqlCommand(sorgu,randevuAl);
            okuma.ExecuteNonQuery();
            SqlDataReader readeOn = okuma.ExecuteReader();

            if (readeOn.Read())
            {
                bolum_id = readeOn["bolumid"].ToString();
            }

            readeOn.Close();

            doktorlarCombo.Text = null;
            doktorlarCombo.Items.Clear(); // bolum seçildikten sonra öncekii doktor seçenekleri kaldırıldı bölüme göre doktor eklendi.
            SqlCommand komutCombo = new SqlCommand();
            komutCombo.CommandText = "select doktorAdiSoyadi from doktorlar where bolumid='"+bolum_id+"'";
            komutCombo.Connection = randevuAl;
            komutCombo.CommandType = CommandType.Text;

            SqlDataReader dataRead;
            dataRead = komutCombo.ExecuteReader();
            while (dataRead.Read())
            {
                doktorlarCombo.Items.Add(dataRead["doktorAdiSoyadi"]);
            }
            
            dataRead.Close();


            this.doktorAdi = doktorlarCombo.Text.ToString();
            this.tarih = randevuZamaniPicker.Text.ToString();



        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void RandevuEkrani1_FormClosed(object sender, FormClosedEventArgs e)
        {
            randevuAl.Close();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button20_Click(object sender, EventArgs e)
        {
            randevuAlt_Pzrts_2__ ran2 = new randevuAlt_Pzrts_2__();
            ran2.label7.Text = doktorlarCombo.Text.ToString();
            ran2.label8.Text = randevuZamaniPicker.Text.ToString();
            ran2.Show();
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            RandevuAlt_pzrts_3__ ran3 = new RandevuAlt_pzrts_3__();
            ran3.label7.Text = doktorlarCombo.Text.ToString();
            ran3.label8.Text = randevuZamaniPicker.Text.ToString();
            ran3.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            RandevuAlt_pzrts_4__ ran4 = new RandevuAlt_pzrts_4__();
            ran4.label7.Text = doktorlarCombo.Text.ToString();
            ran4.label9.Text = randevuZamaniPicker.Text.ToString();
            ran4.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            RandevuAlt_pzrts_5__ ran5 = new RandevuAlt_pzrts_5__();
            ran5.label7.Text = doktorlarCombo.Text.ToString();
            ran5.label9.Text = randevuZamaniPicker.Text.ToString();
            ran5.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            RandevuAlt_pzrts_6__ ran6 = new RandevuAlt_pzrts_6__();
            ran6.label7.Text = doktorlarCombo.Text.ToString();
            ran6.label9.Text = randevuZamaniPicker.Text.ToString();
            ran6.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RandevuAlt_pzrts_7__ ran7 = new RandevuAlt_pzrts_7__();
            ran7.label7.Text = doktorlarCombo.Text.ToString();
            ran7.label9.Text = randevuZamaniPicker.Text.ToString();
            ran7.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_1__ ransal = new RandevuAlt_Sali_1__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_2__ ransal1 = new RandevuAlt_Sali_2__();
            ransal1.label7.Text = doktorlarCombo.Text.ToString();
            ransal1.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_3__ ransal = new RandevuAlt_Sali_3__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_4__ ransal = new RandevuAlt_Sali_4__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_5__ ransal = new RandevuAlt_Sali_5__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_6__ ransal = new RandevuAlt_Sali_6__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RandevuAlt_Sali_7__ ransal = new RandevuAlt_Sali_7__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_1__ ransal = new RandevuAlt_Carsmb_1__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_2__ ransal = new RandevuAlt_Carsmb_2__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_3__ ransal = new RandevuAlt_Carsmb_3__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_4__ ransal = new RandevuAlt_Carsmb_4__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_5__ ransal = new RandevuAlt_Carsmb_5__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_6__ ransal = new RandevuAlt_Carsmb_6__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            RandevuAlt_Carsmb_7__ ransal = new RandevuAlt_Carsmb_7__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label9.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_1__ ransal = new RandevuAlt_persembe_1__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_2__ ransal = new RandevuAlt_persembe_2__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_3__ ransal = new RandevuAlt_persembe_3__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_4__ ransal = new RandevuAlt_persembe_4__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_5__ ransal = new RandevuAlt_persembe_5__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_6__ ransal = new RandevuAlt_persembe_6__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RandevuAlt_persembe_7__ ransal = new RandevuAlt_persembe_7__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            RandevuALt_Cuma_1__ ransal = new RandevuALt_Cuma_1__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            RandevuALt_Cuma_2__ ransal = new RandevuALt_Cuma_2__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            RandevuALt_Cuma_3__ ransal = new RandevuALt_Cuma_3__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            RandevuALt_Cuma_4__ ransal = new RandevuALt_Cuma_4__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RandevuALt_Cuma_5__ ransal = new RandevuALt_Cuma_5__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            RandevuALt_Cuma_6__ ransal = new RandevuALt_Cuma_6__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            RandevuALt_Cuma_7__ ransal = new RandevuALt_Cuma_7__();
            ransal.label7.Text = doktorlarCombo.Text.ToString();
            ransal.label8.Text = randevuZamaniPicker.Text.ToString(); ;
            ransal.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}