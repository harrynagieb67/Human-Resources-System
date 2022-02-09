using HR_System.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System.dapartment
{
    class dept_control
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static List<String> retrivedeptcodes() {
            String que = "select department.Code from department;";
            cmd=DBHelper.runquery2(que);
            DataTable dst = new DataTable();
            List<String> s = new List<String>();
            if (cmd != null) {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dst);
            }
            foreach (DataRow dr in dst.Rows) {
                s.Add(dr["Code"].ToString());
            }

            return s;
        }
    }
}
