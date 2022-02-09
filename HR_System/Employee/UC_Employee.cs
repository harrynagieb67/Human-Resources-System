using ExcelDataReader;
using HR_System.da_layer;
using HR_System.dapartment;
using HR_System.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HR_System.Employee
{
    public partial class UC_Employee : UserControl /*Form*/
    {
        Bitmap bit;
        public UC_Employee()
        {
            InitializeComponent();
            upload_data();
            List<String> dvr = dept_control.retrivedeptcodes();
            for (int i = 0; i < dvr.Count; i++)
            {
                dept_select.Items.Add(dvr[i]);
            }
        }
        public void upload_data()
        {
            
            DataTable dvr = emp_cont.retriveallemp();

            foreach (DataRow dr in dvr.Rows)
            {
                ListViewItem b = new ListViewItem(dr["ID"].ToString());
                b.SubItems.Add(dr["First_name"].ToString());
                b.SubItems.Add(dr["Last_name"].ToString());
                b.SubItems.Add(dr["Dob"].ToString());
                b.SubItems.Add(dr["SSN"].ToString());
                b.SubItems.Add(dr["Salary"].ToString());
                b.SubItems.Add(dr["Mobile"].ToString());
                b.SubItems.Add(dr["Hire_Date"].ToString());
                b.SubItems.Add(dr["Title"].ToString());
                b.SubItems.Add(dr["Email"].ToString());
                b.SubItems.Add(dr["Insurance"].ToString());
                b.SubItems.Add(dr["Insurance_Number"].ToString());
                b.SubItems.Add(dr["Insurance_date"].ToString());
                b.SubItems.Add(dr["Department_code"].ToString());
                b.SubItems.Add(dr["Address"].ToString());
                listView1.Items.Add(b);
                
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            lbinn.Visible = false;
            lbind.Visible = false;
            indate.Visible = false;
            innimber.Visible = false;
            comboBox1.SelectedIndex = 1;
            dept_select.SelectedIndex = 0;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Refered_by rf = new Refered_by()) {
                rf.ShowDialog();
            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            String path = fil.FileName.ToString();
            excelread(path);
        }

        public void excelread(String path) {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach (DataTable table in tables) {
                //dataGridView1.DataSource = table;
            }
        
        }
        private void emptytexts() {
            fname_text.Text = "";
            lname_text.Text = "";
            ssn_text.Text = "";
            salary_text.Text = "";
            title_text.Text = "";
            dobtxt.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            indate.Value = DateTime.Now;
            phone.Text = "";
            addtxt.Text = "";
            emailtxt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fname_text.Text == "" || lname_text.Text == "" || ssn_text.Text == "" || salary_text.Text == "" || title_text.Text == "" || dept_select.SelectedItem == "")
            {
                MessageBox.Show("Error , Enter information first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(fname_text, "Enter first name ");
                errorProvider1.SetError(lname_text, "Enter last name ");
                errorProvider1.SetError(ssn_text, "Enter SSN ");
                errorProvider1.SetError(salary_text, "Enter Salary");
                errorProvider1.SetError(title_text, "Enter Title ");
                errorProvider1.SetError(dept_select, "select department");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                Console.WriteLine(lname_text.Text + fname_text.Text + Int32.Parse(ssn_text.Text));
                if (comboBox1.SelectedItem.ToString() == "yes" && innimber.Text == "") {
                    errorProvider1.SetError(innimber, "Enter Insurance number");
                    return;
                }
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
                    ms.CommandText = "Select * from hr_system.employee where last_name= "+'"'+lname_text.Text+'"'+" and first_name="+'"'+fname_text.Text+'"'+" and SSN="+Int32.Parse(ssn_text.Text)+";";
                    Console.WriteLine(ms.CommandText.ToString());
                    ms.ExecuteNonQuery();
                    MySqlDataAdapter sda2 = new MySqlDataAdapter(ms);
                    
                    sda2.Fill(dt);
                    conn1.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Employee is already Exists");
                        emptytexts();
                        return;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                listView1.Items.Clear();
                try
                {
                    String query = "insert into hr_system.employee (First_name,last_name,SSN,dob,Salary,Hire_Date,Title,mobile,Email,Insurance,Insurance_Number,Insurance_date,Department_code,Address) " +
                                          "values(" + '"' + fname_text.Text + '"' + ", " + '"' + lname_text.Text + '"' + "," + ssn_text.Text + "," +"'"+dobtxt.Text+"'"+"," +  salary_text.Text + "," +
                                         "'" + dateTimePicker2.Text + "'," + '"' + title_text.Text + '"' + "," +'"'+phone.Text+'"'+","+'"'+emailtxt.Text+'"'+","+ '"'+comboBox1.SelectedItem.ToString()+'"' + "," +int.Parse(innimber.Text)+","+"'"+indate.Text+"'" +","+ '"' + dept_select.SelectedItem.ToString() + '"' +"," +'"'+addtxt.Text+'"'+ ");";

                    Console.WriteLine(query);
                    DBHelper.runquery2(query);


                    emptytexts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            upload_data();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Database = "hr_system";
            builder.SslMode = MySqlSslMode.None;
            conn = new MySqlConnection(builder.ToString());
            
            if (fname_text.Text == "" || lname_text.Text == "" ||id_text.Text=="" || ssn_text.Text == "" || salary_text.Text == "" || title_text.Text == "" || dept_select.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(fname_text, "Enter first name ");
                errorProvider1.SetError(lname_text, "Enter last name ");
                errorProvider1.SetError(ssn_text, "Enter SSN ");
                errorProvider1.SetError(salary_text, "Enter Salary");
                errorProvider1.SetError(title_text, "Enter Title ");
                errorProvider1.SetError(dept_select, "select department");
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
                    if (comboBox1.SelectedItem.ToString() != "no")
                    {
                        if (innimber.Text == "" || indate.Text == "") {
                            errorProvider1.SetError(innimber, "Enter Insurance number");
                            errorProvider1.SetError(indate, "Enter Insurance Date ");
                            return;
                        }
                        ms.CommandText = "Update hr_system.employee set First_name=@fname , last_name=@lname , SSN=@ssn , Salary=@sal , " +
                                              "Hire_Date=@hir , Title=@tit , Insurance=@ins , mobile=@mob  , Address=@add , Email=@em , Dob=@birth , Insurance_Number=@innm , Insurance_date=@dt , Department_Code=@cod" +
                                              " where ID=@id ; ";
                        ms.CommandType = CommandType.Text;
                        ms.Parameters.AddWithValue("@fname", fname_text.Text);
                        ms.Parameters.AddWithValue("@lname", lname_text.Text);
                        ms.Parameters.AddWithValue("@ssn", ssn_text.Text);
                        ms.Parameters.AddWithValue("@sal", Double.Parse(salary_text.Text));
                        ms.Parameters.AddWithValue("@hir", dateTimePicker2.Text);
                        ms.Parameters.AddWithValue("@tit", title_text.Text);
                        ms.Parameters.AddWithValue("@ins", comboBox1.SelectedItem.ToString());
                        ms.Parameters.AddWithValue("@innm", int.Parse(innimber.Text));
                        ms.Parameters.AddWithValue("@dt", indate.Text);
                        ms.Parameters.AddWithValue("@mob", phone.Text);
                        ms.Parameters.AddWithValue("@Email", emailtxt.Text);
                        ms.Parameters.AddWithValue("@add", addtxt);
                        ms.Parameters.AddWithValue("@birth", dobtxt.Text);
                        ms.Parameters.AddWithValue("@cod", dept_select.SelectedItem.ToString());
                        ms.Parameters.AddWithValue("@id", id_text.Text);
                    }
                    else {
                        ms.CommandText = "Update hr_system.employee set First_name=@fname , last_name=@lname , SSN=@ssn , Salary=@sal , " +
                                                  "Hire_Date=@hir , Title=@tit , Insurance=@ins , mobile=@mob  , Address=@add , Email=@em , Dob=@birth  , Insurance_Number=@innm , Insurance_date=@dt  , Department_Code=@cod" +
                                                  " where ID=@id ; ";
                        ms.CommandType = CommandType.Text;
                        ms.Parameters.AddWithValue("@fname", fname_text.Text);
                        ms.Parameters.AddWithValue("@lname", lname_text.Text);
                        ms.Parameters.AddWithValue("@ssn", ssn_text.Text);
                        ms.Parameters.AddWithValue("@sal", Double.Parse(salary_text.Text));
                        ms.Parameters.AddWithValue("@hir", dateTimePicker2.Text);
                        ms.Parameters.AddWithValue("@tit", title_text.Text);
                        ms.Parameters.AddWithValue("@ins", comboBox1.SelectedItem.ToString());
                        ms.Parameters.AddWithValue("@innm", null);
                        ms.Parameters.AddWithValue("@dt", null);
                        ms.Parameters.AddWithValue("@mob", phone.Text);
                        ms.Parameters.AddWithValue("@Email", emailtxt.Text);
                        ms.Parameters.AddWithValue("@add", addtxt);
                        ms.Parameters.AddWithValue("@birth", dobtxt.Text);
                        ms.Parameters.AddWithValue("@cod", dept_select.SelectedItem.ToString());
                        ms.Parameters.AddWithValue("@id", id_text.Text);
                    }
                    Console.WriteLine(ms.CommandText.ToString());
                    ms.ExecuteNonQuery();
                    conn.Close();
                    upload_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }

            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    id_text.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                    fname_text.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                    lname_text.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                    dobtxt.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
                    ssn_text.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
                    salary_text.Text = listView1.SelectedItems[0].SubItems[5].Text.ToString();
                    phone.Text = listView1.SelectedItems[0].SubItems[6].Text.ToString();
                    dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text.ToString();
                    
                    title_text.Text = listView1.SelectedItems[0].SubItems[8].Text.ToString();
                    emailtxt.Text = listView1.SelectedItems[0].SubItems[9].Text.ToString();

                    comboBox1.SelectedItem = listView1.SelectedItems[0].SubItems[10].Text.ToString();
                    innimber.Text = listView1.SelectedItems[0].SubItems[11].Text.ToString();
                    indate.Text = listView1.SelectedItems[0].SubItems[12].Text.ToString();
                    dept_select.Text = listView1.SelectedItems[0].SubItems[13].Text.ToString();
                    addtxt.Text = listView1.SelectedItems[0].SubItems[14].Text.ToString();

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
                if (fname_text.Text == "" || lname_text.Text == "" || id_text.Text == "" || ssn_text.Text == "" || salary_text.Text == "" || title_text.Text == "" || dept_select.SelectedItem.ToString() == "") {
                    MessageBox.Show("Error , Select user to delete first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                conn.Open();
                MySqlCommand ms = new MySqlCommand();
                ms = conn.CreateCommand();

                ms.CommandText = "delete from hr_system.employee where ID=@id ; ";
                ms.CommandType = CommandType.Text;
                ms.Parameters.AddWithValue("@id", id_text.Text);
                listView1.Items.Clear();
                Console.WriteLine(ms.CommandText.ToString());
                ms.ExecuteNonQuery();
                conn.Close();
                upload_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try {
                DataTable dt = emp_cont.retriveallemp();
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("First_name like '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv.Table;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // id_text.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                // fname_text.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                // lname_text.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                // // 
                // ssn_text.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                // salary_text.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                // 
                // dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                // title_text.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                // comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                // 
                //// 
                // dept_select.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                // 




                id_text.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fname_text.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lname_text.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dobtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                ssn_text.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                salary_text.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                title_text.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                innimber.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                indate.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                addtxt.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                emailtxt.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                phone.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

                dept_select.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try 
            {
                if (dataGridView1.RowCount == 0) {
                    MessageBox.Show("Choose Employee First");
                    return;
                }
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bit = new Bitmap(dataGridView1.Width+1000,dataGridView1.Height);
                dataGridView1.DrawToBitmap(bit,new Rectangle(0,0,dataGridView1.Width+1000,dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;

            }
            catch (Exception ex) {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try {
                e.Graphics.DrawImage(bit, 0, 0);
            }
            catch (Exception ex) {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "yes")
            {
                lbinn.Visible = true;
                lbind.Visible = true;
                indate.Visible = true;
                innimber.Visible = true;
            }
            else {
                lbinn.Visible = false;
                lbind.Visible = false;
                indate.Visible = false;
                innimber.Visible = false;
            }
        }
    }
}
