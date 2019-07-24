using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Donem_odevi
{
    public partial class HastaArama2 : DevExpress.XtraEditors.XtraForm
    {
        public HastaArama2()
        {
            InitializeComponent();
        }

            SqlConnection hastaArama = dataBase.baglan();
      
   

        private void button1_Click(object sender, EventArgs e)
        {
            adText.Clear();
            tcText.Clear();
            //dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
                
        }

        private void HastaArama2_FormClosed(object sender, FormClosedEventArgs e)
        {
            hastaArama.Close();
        }

       
        
        private void adRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            adText.Enabled = true;
            tcText.Enabled = false;
        }

        private void adText_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string aramaSorgusu = "";
                aramaSorgusu = "SELECT * FROM hastalarTablosu where Adi like '" + adText.Text + "%'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dataBase.baglan();
                cmd.CommandText = aramaSorgusu;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
              
                DataSet seta = new DataSet();
                
                adapter.Fill(seta,"hastalarTablosu");
                dataGridView1.DataSource = seta.Tables["hastalarTablosu"];
            }
            catch (Exception err )
            {

                MessageBox.Show(err.Message);
            }
        }

        private void tcRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            tcText.Enabled = true;
            adText.Enabled = false;
        }

       
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string aramaSorgusu = "";
                aramaSorgusu = "SELECT * FROM hastalarTablosu where hastaTc like '" + tcText.Text + "'";


                SqlDataAdapter adapter = new SqlDataAdapter(aramaSorgusu, hastaArama);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HastaArama2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}