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

namespace HR_System.users
{
    public partial class newuser : Form
    {
        MySqlCommand cmd = null;
        MySqlDataAdapter sda;
        public newuser()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            button3.Enabled = false;
            fillcombobox();
            upload_data();
        }

        private void fillcombobox() {
            String query1 = "select * from hr_system.rules;";
            cmd = DBHelper.runquery2(query1);

            DataTable dst = new DataTable();
            List<String> s = new List<String>();
            if (cmd != null)
            {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dst);
            }
            foreach (DataRow dr in dst.Rows)
            {
                s.Add(dr["rulename"].ToString());
            }

            for (int i = 0; i < s.Count; i++)
            {
                comboBox1.Items.Add(s[i]);
            }
        }

        private void emptytexts() {
            username.Text = "";
            fname.Text = "";
            password.Text = "";
            emailtext.Text = "";
            addres.Text = "";
            comboBox1.Text = "";
        
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newuser_Load(object sender, EventArgs e)
        {

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
                    fname.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                    username.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                    dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                    password.Text = listView1.SelectedItems[0].SubItems[5].Text.ToString();
                    comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
                    addres.Text = listView1.SelectedItems[0].SubItems[6].Text.ToString();
                    emailtext.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
                    button3.Enabled = true; ;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (fname.Text == "" || username.Text == "" || addres.Text == "" || password.Text == "" || dateTimePicker1.Text == "" ||email.Text=="" || comboBox1.SelectedItem == "")
            {
                MessageBox.Show("Error , Enter information first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataTable dt = new DataTable();
                Console.WriteLine(fname.Text + username.Text );
                try
                {
                    MySqlConnection conn1;
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = "127.0.0.1";
                    builder.UserID = "root";
                    builder.Database = "hr_system";
                    builder.SslMode = MySqlSslMode.None;
                    conn1 = new MySqlConnection(builder.ToString());
                    conn1.Open();
                    MySqlCommand ms = new MySqlCommand();
                    ms = conn1.CreateCommand();
                    ms.CommandText = "Select * from hr_system.users where username= " + '"' + username.Text + '"' + " and Name=" + '"' + fname.Text + '"' +";";
                    Console.WriteLine(ms.CommandText.ToString());
                    ms.ExecuteNonQuery();
                    MySqlDataAdapter sda2 = new MySqlDataAdapter(ms);

                    sda2.Fill(dt);
                    conn1.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("User is already Exists");
                        emptytexts();
                        return;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                listView1.Items.Clear();
                int no = 0;
                try
                {


                    String query = "insert into hr_system.users (username,Name,Password,address,email,Hire_date) " +
                                          "values(" + '"' + username.Text + '"' + ", " + '"' + fname.Text + '"' + "," + '"' + password.Text + '"' + "," +'"'+ addres.Text +'"' + "," +
                                         '"' + emailtext.Text +'"'+ "," + '"' + dateTimePicker1.Text + '"' + ");";

                    Console.WriteLine(query);
                    DBHelper.runquery2(query);

                    string query1= "insert into hr_system.userrules (username,rulename) values("+'"' + username.Text +'"'+ ","+'"' + comboBox1.Text+'"' + ") ;";
                    Console.WriteLine(query1);
                    DBHelper.runquery2(query1);
                    emptytexts();
                    upload_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Database = "hr_system";
            builder.SslMode = MySqlSslMode.None;
            conn = new MySqlConnection(builder.ToString());
            try
            {
                conn.Open();
                MySqlCommand ms = new MySqlCommand();
                ms = conn.CreateCommand();

                ms.CommandText = "delete from hr_system.users where username=@user ; ";
                ms.CommandType = CommandType.Text;
                ms.Parameters.AddWithValue("@user", username.Text);
                listView1.Items.Clear();
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
            conn.Close();
        }
    }
}
