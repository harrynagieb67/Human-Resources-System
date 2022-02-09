using HR_System.Helper;
using HR_System.sd_layer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_System.sd_layer;

namespace HR_System.da_layer
{
    class userDa
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static USersIN retreiveuser(String username) {
            String query = "Select * from hr_system.users where username=(@username) limit 1";
            cmd = DBHelper.runquery(query, username);
            USersIN auser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    String uname = dr["username"].ToString();
                    String password = dr["Password"].ToString();

                    Console.WriteLine(uname + password);
                    auser = new USersIN(uname, password);
                }
                if (auser == null)
                {
                    String uname = "null";
                    String pass = "null";
                    auser = new USersIN(uname, pass);
                }

            }
            return auser;
        }
        public static DataTable retriveallusers()
        {
            String query = "Select * from hr_system.users";
            cmd = DBHelper.runquery2(query);
            DataTable dset = new DataTable();
            if (cmd != null) {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dset);
            }

            Console.WriteLine("haaaaaaaaaaaaaaaaaaaaa");
            return dset;
        }
        
    }
}
