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
    public partial class AmeliyatHaneEkrani : DevExpress.XtraEditors.XtraForm
    {
        public AmeliyatHaneEkrani()
        {
            InitializeComponent();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            AmeliyatHaneEkrani amd = new AmeliyatHaneEkrani();
            amd.Show();
        }
        SqlConnection ameliyatVerileri = dataBase.baglan();
        private void AmeliyatHaneEkrani_Load(object sender, EventArgs e)
        {
            string veriSorgula = "select * from ameliyathane";

            try
            {
                SqlDataAdapter adapterAmeliyat = new SqlDataAdapter(veriSorgula, ameliyatVerileri);
                DataTable tabloAmeliyat = new DataTable();
                adapterAmeliyat.Fill(tabloAmeliyat);
                dataGridView1.DataSource = tabloAmeliyat;
                dataGridView1.Columns[1].HeaderText = "Kullanım Zaman Aralığı";
                dataGridView1.Columns[2].HeaderText = "Ameliyathane Adı";
                dataGridView1.Columns[3].HeaderText = "Kullanan Doktor";
                dataGridView1.Columns[4].HeaderText = "Hasta Adı";
                dataGridView1.Columns[5].HeaderText = "Hasta Soyadı";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 140;
                dataGridView1.Columns[5].Width = 120;

            }
            catch (Exception hata)
            {

                MessageBox.Show("hata:" + hata.Message);
            }


        }
    }
}