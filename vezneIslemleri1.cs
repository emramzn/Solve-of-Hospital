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
    public partial class vezneIslemleri1 : DevExpress.XtraEditors.XtraForm
    {
        public vezneIslemleri1()
        {
            InitializeComponent();
        }
        SqlConnection vezneBilgiBase = dataBase.baglan();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        void DataGuncelleme()
        {
            SqlCommand komutUpdate = new SqlCommand();
            komutUpdate.Connection = vezneBilgiBase;
            komutUpdate.CommandText = "select hastaTc,Adi,soyadi,doktoru,kayitTarihi,vezneIslemi from hastalarTablosu where basvuruBolumu='"+BolumSecCombo.Text+"'";
            SqlDataAdapter dataAdab = new SqlDataAdapter(komutUpdate);
            DataSet dataSets = new DataSet();
            dataAdab.Fill(dataSets, "hastalarTablosu");
            dataGridView1.DataSource = dataSets.Tables["hastalarTablosu"];
            
        }

        private void vezneIslemleri1_Load(object sender, EventArgs e)
        {
    
        }
      
        private void BolumSecCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            string sorgu;
            try
            {


                SqlCommand cmd = new SqlCommand("select count(hastaTc) from hastalarTablosu where basvuruBolumu='" + this.BolumSecCombo.Text + "'", vezneBilgiBase);
                int parameters = Convert.ToInt32(cmd.ExecuteScalar());



                if (parameters == 0)
                {
                    MessageBox.Show("Bu Bölümde Kayıtlı Hasta Yok");
                    dataGridView1.DataSource = null;
                }
                else
                {
                    
                 sorgu = "SELECT hastaTc,Adi,soyadi,doktoru,kayitTarihi,vezneIslemi FROM hastalarTablosu WHERE basvuruBolumu='" + this.BolumSecCombo.Text + "'";
                 SqlDataAdapter adapter = new SqlDataAdapter(sorgu, vezneBilgiBase);
                 DataTable table = new DataTable();
                   
                 adapter.Fill(table);
                 dataGridView1.DataSource = table;

                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            
      
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tcBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            adBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            islemBox.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ucretBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void vezneIslemleri1_Load_1(object sender, EventArgs e)
        {
            SqlCommand komutCombo = new SqlCommand();
            komutCombo.CommandText = "select bolumAd from bolumler";
            komutCombo.Connection = vezneBilgiBase;
            komutCombo.CommandType = CommandType.Text;

            SqlDataReader dataRead;
            dataRead = komutCombo.ExecuteReader();
            while (dataRead.Read())
            {
                BolumSecCombo.Items.Add(dataRead["bolumAd"]);
            }


            dataRead.Close();
        }

        private void vezneIslemleri1_FormClosed(object sender, FormClosedEventArgs e)
        {
            vezneBilgiBase.Close();
        }

        private void UcretAlBtn_Click(object sender, EventArgs e)
        {
            //veznedar üçreti alınca borç sıfırlanacak

            SqlCommand komut = new SqlCommand();
            komut.Connection = vezneBilgiBase;
            komut.CommandText = "UPDATE hastalarTablosu set vezneIslemi=0 where hastaTc='" + tcBox.Text + "'";
            komut.ExecuteNonQuery();

            MessageBox.Show("Ücret Alındı.");

            DataGuncelleme();



        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
    }
}