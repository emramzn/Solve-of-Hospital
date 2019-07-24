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
    public partial class hemsireBolumGorevleri : DevExpress.XtraEditors.XtraForm
    {
        public hemsireBolumGorevleri()
        {
            InitializeComponent();
        }
        SqlConnection baseBaglanti = dataBase.baglan();
        private void hemsireBolumGorevleri_Load(object sender, EventArgs e)
        {
                    
                    

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
            string sorguBolum="SELECT hemsireAdi,hemsireSoyadi FROM hemsirelerTbl WHERE hemsireAdi="+bol.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(sorguBolum, baseBaglanti);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

    */
        }

        private void hemsireBolumGorevleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseBaglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorguBolum;
            if (bolumCombo.Text == null || hemsrAdText.Text == null)
            {
                MessageBox.Show("Arama Alanlarını Eksiksiz Doldurun.");
            }
            else
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("select count(personelNoHemsr) from hemsirelerTbl where hemsireAdi='" + this.hemsrAdText.Text + "'", baseBaglanti);
                    int parameters = Convert.ToInt32(cmd.ExecuteScalar());



                    if (parameters == 0)
                    {
                        MessageBox.Show("kayıt yok veya Eksik Alan Girişi");
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        
                        if (hemsrAdText.Text == null)
                        {
                            MessageBox.Show("Hemşire Adını Giriniz.");
                        }
                        else
                        {
                            sorguBolum = "SELECT * FROM hemsirelerTbl WHERE gorevbolumu='" + this.bolumCombo.Text + "' and hemsireAdi='" + this.hemsrAdText.Text + "'";
                            SqlDataAdapter adapter = new SqlDataAdapter(sorguBolum, baseBaglanti);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;

                        }




                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
          
        }
    }
}