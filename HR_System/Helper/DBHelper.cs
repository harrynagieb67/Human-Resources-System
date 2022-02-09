using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HR_System.Helper
{
    class DBHelper
    {

        private static DataTable dt;
        private static MySqlConnection conn;
        private static MySqlCommand cmd = null;
        private static MySqlDataAdapter sda;


        public static void Establishconn()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "127.0.0.1";
                builder.UserID = "root";
                builder.Database = "hr_system";
                builder.SslMode = MySqlSslMode.None;
                conn = new MySqlConnection(builder.ToString());
                MessageBox.Show("database connected successful", "connection", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed");

            }
        }

        public static MySqlCommand runquery(String query,String username)
        {
            try
            {
                if (conn != null)
                {
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return cmd;
        }

        public static MySqlCommand runquery2(String query)
        {
            try
            {
                if (conn != null)
                {
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteReader();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return cmd;
        }
    }
}
