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
using System.Data.SqlClient;

namespace Donem_odevi
{
    public partial class YatanHastaEkrani : DevExpress.XtraEditors.XtraForm
    {
        public YatanHastaEkrani()
        {
            InitializeComponent();
        }
        SqlConnection yatanHastaBul = dataBase.baglan();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YatanHastaEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutoda = new SqlCommand("select hastaTc,adi,soyadi,yatisBolumu,yatisOda,doktorAd from hastaYatis where  hastaTc='" + textEdit3.Text + "'", yatanHastaBul);
                komutoda.ExecuteNonQuery();
                SqlDataReader readOda = komutoda.ExecuteReader();

                if (readOda.Read())
                {
                    label7.Text = readOda["adi"].ToString();
                    label9.Text = readOda["hastaTc"].ToString();
                    label8.Text = readOda["soyadi"].ToString();
                    label15.Text = readOda["yatisBolumu"].ToString();
                    label14.Text = readOda["yatisOda"].ToString();
                    label13.Text = readOda["doktorAd"].ToString();
                }
                readOda.Close();


            }
            catch (Exception err)
            {

                MessageBox.Show("Hata : "+err.Message);

                    
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}