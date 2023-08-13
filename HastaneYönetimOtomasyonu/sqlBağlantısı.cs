using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HastaneYönetimOtomasyonu
{
    internal class sqlBağlantısı
    {
        public SqlConnection bağlanti()
        {
            SqlConnection bağlan = new SqlConnection("Data Source=mkumru\\MSSQLSERVER01;Initial Catalog=HastaneProje;Integrated Security=True");
            bağlan.Open();
            return bağlan;
        } 
    }
}
