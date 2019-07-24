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
    public partial class Kullanıcı_Ekle : Form
    {
        SqlConnection con = dataBase.baglan();
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }
        void temizle()
        {
            adı_txt.Text = "";
            soyadı_txt.Text = "";
            kuladı_txt.Text = "";
            sifre_txt.Text = "";
            yetki_combobox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO giris_bilgileri( Adi,Soyadi,Kullanici_Adi,sifre,yetki) VALUES('" + adı_txt.Text + "','" + soyadı_txt.Text + "','" + kuladı_txt.Text + "','" + sifre_txt.Text + "','" + yetki_combobox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            temizle();
            MessageBox.Show("Başarıyla kaydedildi.");
            this.Hide();
        }

        private void kuladi_btn_Click(object sender, EventArgs e)
        {
            string a= adı_txt.Text.ToLower();
            string b = soyadı_txt.Text.ToLower();
            kuladı_txt.Text = a + b;
            
        }
    }
}
