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
    public partial class randevuAlt_Pzrts_2__ : Form
    {
        public randevuAlt_Pzrts_2__()
        {
            InitializeComponent();
        }
        SqlConnection randevuBase = dataBase.baglan();
        private void RandevuTamamlaText_Click(object sender, EventArgs e)
        {
            try
            {
                string randevuSaati = "";
                if (radioButton1.Checked)
                {
                    randevuSaati = "09.00";
                }
                else if (radioButton2.Checked)
                {
                    randevuSaati = "09.15";
                }
                else if (radioButton3.Checked)
                {
                    randevuSaati = "09.30";
                }
                else if (radioButton4.Checked)
                {
                    randevuSaati = "09.45";
                }
                else
                {
                    MessageBox.Show("lütfen Randevu Saatini Seçin");
                }
                string randevuAl = "INSERT INTO randevuTbl(Tarih,ranSaat,hastaAdi,hastaSoyadi,hastaTc,doktor) VALUES('" + label8.Text.ToString() + "','" + randevuSaati + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + label7.Text + "')";

                SqlCommand randevuKomut = new SqlCommand(randevuAl, randevuBase);

                int sonuc = randevuKomut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Randevu Talebiniz Başarısız");
                }
                else
                {
                    MessageBox.Show("Randevu Talebiniz Onaylandı");
                    this.Close();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void randevuAlt_Pzrts_2___Load(object sender, EventArgs e)
        {

        }
    }
}
