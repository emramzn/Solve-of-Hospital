using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem_odevi
{
    class dataBase
    {
        static string conString = @"Data Source=DESKTOP-KP1PN0G\BASE_SQL;Initial Catalog=hastane;Integrated Security=True";

        public  static SqlConnection baglan()
        {
            SqlConnection veriBaglan = new SqlConnection(conString);
            try
            {
                veriBaglan.Open();
                

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Bulundu ->  " + hata.Message);
               
            }

            return veriBaglan;



        }




    }
}
