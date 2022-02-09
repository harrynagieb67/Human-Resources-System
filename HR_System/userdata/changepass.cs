using HR_System.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System.userdata
{
    public partial class changepass : Form
    {
        MySqlCommand cmd = null;
        MySqlDataAdapter sda;
        public changepass()
        {
            InitializeComponent();
            upload_data();
        }
        private void emptytexts()
        {
            username.Text = "";
            old.Text = "";
            newpass.Text = "";
            confirm.Text = "";

        }
        public void upload_data()
        {
            String query = "select users.username,users.Name,users.Password,users.address,users.email,users.hire_date,userrules.rulename from hr_system.users,userrules where users.username=userrules.username;";
            cmd = DBHelper.runquery2(query);
            DataTable dset = new DataTable();
            if (cmd != null)
            {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dset);
            }

            foreach (DataRow dr in dset.Rows)
            {
                ListViewItem b = new ListViewItem(dr["username"].ToString());
                b.SubItems.Add(dr["Name"].ToString());
                b.SubItems.Add(dr["Hire_Date"].ToString());
                b.SubItems.Add(dr["email"].ToString());
                b.SubItems.Add(dr["rulename"].ToString());
                b.SubItems.Add(dr["Password"].ToString());
                b.SubItems.Add(dr["address"].ToString());
                listView1.Items.Add(b);
            }

        }

        private void changepass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newpass.Text != confirm.Text) {
                MessageBox.Show("Invalid , Password must match to confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySqlConnection conn;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Database = "hr_system";
            builder.SslMode = MySqlSslMode.None;
            conn = new MySqlConnection(builder.ToString());
            if (username.Text == "" ||  old.Text == "" || newpass.Text == "" || confirm.Text == "" )
            {
                MessageBox.Show("Error , Enter information first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                listView1.Items.Clear();
                try
                {
                    conn.Open();
                    MySqlCommand ms = new MySqlCommand();
                    ms = conn.CreateCommand();

                    ms.CommandText = "Update hr_system.users set " +
                                          " password=@pass " +
                                          " where username=@uname ; ";
                    ms.CommandType = CommandType.Text;
                    ms.Parameters.AddWithValue("@uname", username.Text);
                    ms.Parameters.AddWithValue("@pass", newpass.Text);
                    Console.WriteLine(ms.CommandText.ToString());
                    ms.ExecuteNonQuery();
                    conn.Close();
                    upload_data();
                    emptytexts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }

            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    old.Text = listView1.SelectedItems[0].SubItems[5].Text.ToString();
                    username.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (username.Text.Length > 0)
                {
                    old.Focus();
                }
                else {
                    username.Focus();
                }
            }
        }
    }
}
