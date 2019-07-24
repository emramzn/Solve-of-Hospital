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
    public partial class RandevuAlt_Carsmb_3__ : Form
    {
        public RandevuAlt_Carsmb_3__()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection randevuBase = dataBase.baglan();
        private void RandevuTamamlaText_Click(object sender, EventArgs e)
        {
            try
            {
                string randevuSaati = "";
                if (radioButton1.Checked)
                {
                    randevuSaati = "10.00";
                }
                else if (radioButton2.Checked)
                {
                    randevuSaati = "10.15";
                }
                else if (radioButton3.Checked)
                {
                    randevuSaati = "10.30";
                }
                else if (radioButton4.Checked)
                {
                    randevuSaati = "10.45";
                }
                else
                {
                    MessageBox.Show("lütfen Randevu Saatini Seçin");
                }
                string randevuAl = "INSERT INTO randevuTbl(Tarih,ranSaat,hastaAdi,hastaSoyadi,hastaTc,doktor) VALUES('" + label9.Text.ToString() + "','" + randevuSaati + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + label7.Text + "')";

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

        private void RandevuAlt_Carsmb_3___FormClosed(object sender, FormClosedEventArgs e)
        {
            randevuBase.Close();
        }

        private void RandevuAlt_Carsmb_3___Load(object sender, EventArgs e)
        {

        }
    }
}
