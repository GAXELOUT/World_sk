using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_sk
{
    class Helper
    {
        public static SqlConnection Get_con()
        {
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            c.Open();
            return c;
        }

    }
}
