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
    public partial class RandevuAltEkran1 : Form
    {
        public RandevuAltEkran1()
        {
            InitializeComponent();
        }
        SqlConnection randevuBase = dataBase.baglan();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Eksiksiz Doldurun");
            }
            else
            {
                try
                {
                    string randevuSaati = "";
                    if (radioButton1.Checked)
                    {
                        randevuSaati = "08.00";
                    }
                    else if (radioButton2.Checked)
                    {
                        randevuSaati = "08.15";
                    }
                    else if (radioButton3.Checked)
                    {
                        randevuSaati = "08.30";
                    }
                    else if (radioButton4.Checked)
                    {
                        randevuSaati = "08.45";
                    }
                    else if (!radioButton1.Checked || !radioButton2.Checked || !radioButton3.Checked || !radioButton4.Checked)
                    {
                        MessageBox.Show("lütfen Randevu Saatini Seçin");

                    }
                    else
                    {


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
                }

                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }


            }
            
        }

        private void RandevuAltEkran1_FormClosed(object sender, FormClosedEventArgs e)
        {
            randevuBase.Close();
        }

        private void RandevuAltEkran1_Load(object sender, EventArgs e)
        {
            
            string str1 = "select ranSaat from randevuTbl where doktor='" + label7.Text + "' and Tarih='" + label8.Text + "'";
            SqlCommand komut1 = new SqlCommand(str1,randevuBase);

            SqlDataReader randevuOku = komut1.ExecuteReader();
            while (randevuOku.Read())
            {
              
                switch (randevuOku["ranSaat"].ToString())
                {
                    case "08.00":
                        radioButton1.Enabled = false;
                        break;
                    case "08.15":
                        radioButton2.Enabled = false;
                        break;
                    case "08.30":
                        radioButton3.Enabled = false;
                        break;
                    case "08.45":
                        radioButton4.Enabled = false;
                        break;
                    default:
                        break;
                }
              
            }
            
           

        }
    }
}
