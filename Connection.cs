using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace $safeprojectname$
{
   public class Connection
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=123456;database=lms");
        public MySqlConnection ActiveCon() {

            if (con.State == ConnectionState.Closed) {

                con.Open();
            }

            return con;

        }
    }
}
