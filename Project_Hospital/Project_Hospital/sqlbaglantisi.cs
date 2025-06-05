using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Project_Hospital
{
    class sqlbaglantisi //Class name
    {
        public SqlConnection baglanti()//Method name
        {
            // Corrected the method to return a SqlConnection object
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-NI2OJAE\\MSSQLSERVER01;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
     
    }
}
