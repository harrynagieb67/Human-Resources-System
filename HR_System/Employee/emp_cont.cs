using HR_System.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HR_System.Employee
{
    class emp_cont
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;


        public static DataTable retriveallemp()
        {
            String query = "Select * from hr_system.employee";
            cmd = DBHelper.runquery2(query);
            DataTable dset = new DataTable();
            if (cmd != null)
            {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dset);
            }

            Console.WriteLine("haaaaaaaaaaaaaaaaaaaaa");
            return dset;
        }

        public static DataTable Retriveoneemp(String father,String name,int ssn) {
                try
                {
                String query = "Select * from hr_system.employee where " +
                    "last_name= "+'"'+"@father"+'"'+" and " +
                    "first_name="+'"'+"@name"+'"'+
                    " and SSN=@ssn;";
                    cmd.Parameters.AddWithValue("@father", father);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@ssn", ssn);
                cmd = DBHelper.runquery2(query);
                Console.WriteLine(query);
                if (cmd != null)
                    {
                    Console.WriteLine("we get something");
                        sda = new MySqlDataAdapter(cmd);
                        sda.Fill(dt);
                    }

                foreach (DataRow dr in dt.Rows) {
                    Console.WriteLine(dr["last_name"].ToString());
                }
                return dt;

                }
                catch (Exception ex) {
                MessageBox.Show(ex.Message);
                }
            return dt;
        }
    }
}
