using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Donem_odevi
{

    
    public  class ClassRandevu
    {
        public static string tarih { get; set; } 
        public static string doktor { get; set; }
        public ClassRandevu()
        {
           
            
        }
        public string saatBak(string tarih1,string doktor1,string zamansaat)
        {
           
            SqlConnection connect = dataBase.baglan();
            tarih = tarih1;
            doktor = doktor1;

          
            string str2 = "select count(hastaTc) from randevuTbl Where doktor ='" + doktor1.ToString() + "' and Tarih ='" + tarih1.ToString() + "' and ranSaat ='" + zamansaat + "'";
            
            SqlCommand hastaBul = new SqlCommand(str2, connect);
            hastaBul.ExecuteNonQuery();
           
            int sayi = Convert.ToInt32(hastaBul.ExecuteScalar());
           
            return sayi.ToString();
            connect.Close();

            
        }
    }
}
