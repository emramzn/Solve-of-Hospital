using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace Donem_odevi
{
    public partial class GenelDanismanİslemleriEkrani1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GenelDanismanİslemleriEkrani1()
        {
            InitializeComponent();
        }
        SqlConnection duyuruBase = dataBase.baglan();
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            HastaArama2 hastaİslem = new HastaArama2();
            //hastaİslem.MdiParent = this;
            hastaİslem.Show();
        }

        private void GenelDanismanİslemleriEkrani1_Load(object sender, EventArgs e)
        {
            string duyuruCek = "select duyuru from duyuru";
            SqlCommand komutduyuru = new SqlCommand(duyuruCek, duyuruBase);
            komutduyuru.ExecuteNonQuery();

            SqlDataReader isReading = komutduyuru.ExecuteReader();

            if (isReading.Read())
            {
                listBox1.Items.Add(isReading["duyuru"].ToString());

            }
            isReading.Close();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            HastaIslemleriEkrani hastaIslemEkran1 = new HastaIslemleriEkrani();
           // HastaIslemleriEkrani hastaIslemEkran1 = new HastaIslemleriEkrani();
            hastaIslemEkran1.MdiParent = this;
            hastaIslemEkran1.Show();
          
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            RandevuEkrani1 randevuAl = new RandevuEkrani1();
            randevuAl.MdiParent = this;
            randevuAl.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            YatanHastaEkrani yatanHasta1 = new YatanHastaEkrani();
            yatanHasta1.Show();
        }

      
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            hemsireBolumGorevleri hemsireBolumGorev1 = new hemsireBolumGorevleri();
            hemsireBolumGorev1.MdiParent = this;
            hemsireBolumGorev1.Show();

        }

        

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            AmeliyatHaneEkrani ameliyatEkran1 = new AmeliyatHaneEkrani();
            ameliyatEkran1.MdiParent = this;
            ameliyatEkran1.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            vezneIslemleri1 vezneIslemi = new vezneIslemleri1();
            vezneIslemi.MdiParent = this;
            vezneIslemi.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            PoliKlinikler poliKlinik1 = new PoliKlinikler();
            poliKlinik1.MdiParent = this;
            poliKlinik1.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barMdiChildrenListItem1_ListItemClick(object sender, ListItemClickEventArgs e)
        {

            
            
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            string message = "Sistemden Çıkış Yapıyorsunuz Devam Etmek ister Misiniz?";

            var result = MessageBox.Show(message, "SİSTEMDEN ÇIKIŞ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                main_page giris = new main_page();
                giris.Show();
            }
        }
    }
}