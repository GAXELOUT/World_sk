using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_sk
{
    static class User
    {
        public static string login;
        public static string password;
        public static string rol;

        public static bool CheckUser(string l, string p)
        {
            var a = Helper.Get_con();
            SqlCommand command = new SqlCommand("CheckUser", a);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@login",l));
            command.Parameters.Add(new SqlParameter("@password",p));
            try
            {
                    string result = (string)command.ExecuteScalar();
                    login = l;
                    password = p;
                    rol = result;
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
