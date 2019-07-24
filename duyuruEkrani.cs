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
    public partial class duyuruEkrani : Form
    {
        public duyuruEkrani()
        {
            InitializeComponent();
        }
        SqlConnection duyuruBase = dataBase.baglan();
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                
                string duyuruEkle = "INSERT INTO duyuru(duyuru)VALUES('"+textBox1.Text+"')";

                SqlCommand duyurukomutu = new SqlCommand(duyuruEkle, duyuruBase);
                int durum = duyurukomutu.ExecuteNonQuery();

                if (durum != 1)
                {
                    MessageBox.Show("Duyuru Gönderimi Başarısız.");
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Duyuru Gönderimi başarılı.");
                    this.Close();

                }


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void duyuruEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            duyuruBase.Close();
        }
    }
}
