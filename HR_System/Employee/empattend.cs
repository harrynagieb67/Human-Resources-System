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

namespace HR_System.Employee
{
    public partial class empattend : /*Form*/ UserControl
    {
        public empattend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validation())
                {
                    String query = "select * from hr_system.employeeAttendence where Employee_ID=" + Int32.Parse(id.Text) + " and year=" +
                        '"' + year.Text + '"' + " and month=" + '"' + month.Text + '"' + ";";
                    Console.WriteLine(query);
                    cmd = DBHelper.runquery2(query);
                    DataTable dprop = new DataTable();
                    if (cmd != null)
                    {
                        sda = new MySqlDataAdapter(cmd);
                        sda.Fill(dprop);
                    }
                    if (dprop.Rows.Count > 0)
                    {
                        MessageBox.Show("Error , this entry is already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emptytexts();
                        return;
                    }

                    String query1 = "insert into hr_system.employeeAttendence (Employee_ID,month,year,TotalDays,AbsentDays,PresentDays,leavedays,workingdays) " +
                                                 "values(" + Int32.Parse(id.Text) + ", " + '"' + month.Text + '"' + "," + '"' + year.Text + '"' + "," + float.Parse(total.Text) + "," +
                                                  float.Parse(absent.Text) + "," + float.Parse(present.Text) + "," + float.Parse(leave.Text) + "," + float.Parse(working.Text) + ");";
                    MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(query1);
                    DBHelper.runquery2(query1);


                    emptytexts();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void emptytexts()
        {
            id.Text = "";
            name.Text = "";
            month.Text = "";
            year.Text = "";
            present.Text = "";
            absent.Text = "";
            working.Text = "";
            leave.Text = "";
            total.Text = "";
            year.Text = "";
            month.Text = "";
            save.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.') {
                e.Handled = true;
            }
        }

        private void total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void working_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void empattend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;

        void search() {
            dgview = new DataGridView();
            dgviewcol1 = new DataGridViewTextBoxColumn();
            dgviewcol2 = new DataGridViewTextBoxColumn();

            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcol1, this.dgviewcol2, });
            this.dgview.Name = "dgview";
            dgview.Visible = false;
            this.dgviewcol1.Visible = false;
            this.dgviewcol2.Visible = false;
            this.dgview.AllowUserToAddRows = false;
            this.dgview.RowHeadersVisible = false;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(dgview);
            this.dgview.ReadOnly = true;
            dgview.BringToFront();
       
        }

        void search(int lx,int ly,int dw,int dh,String colname,String colsize) {
            this.dgview.Location = new System.Drawing.Point(lx, ly);
            this.dgview.Size = new System.Drawing.Size(dw, dh);

            String[] clsize = colsize.Split(',');

            for (int i = 0; i < clsize.Length; i++) {
                if (int.Parse(clsize[i]) != 0)
                {
                    dgview.Columns[i].Width = int.Parse(clsize[i]);

                }
                else {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                }
            
            }
            String[] clname = colname.Split(',');
            for (int i = 0; i < clname.Length; i++) {
                this.dgview.Columns[i].HeaderText = clname[i];
                this.dgview.Columns[i].Visible = true;
            }
        }
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter sda = new MySqlDataAdapter(); 
        private void empattend_Load(object sender, EventArgs e)
        {
            search();
            this.ActiveControl = id;
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void present_TextChanged(object sender, EventArgs e)
        {

        }

        private void absent_TextChanged(object sender, EventArgs e)
        {

        }

        private void leave_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (id.Text.Length > 0)
                {
                    this.dgview.Visible = true;
                    dgview.BringToFront();
                    search(240, 240, 400, 200, "id ,first_name", "100,0");
                    this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_mousedoubleClick);

                    String query = "Select Id, first_name from hr_system.employee where id like " + '"' + id.Text  + "%"+'"'+";";
                    Console.WriteLine(query);
                    cmd = DBHelper.runquery2(query);
                    DataTable dset = new DataTable();
                    if (cmd != null)
                    {
                        sda = new MySqlDataAdapter(cmd);
                        sda.Fill(dset);
                    }
                    dgview.Rows.Clear();
                    foreach (DataRow row in dset.Rows)
                    {
                        int n = dgview.Rows.Add();
                        dgview.Rows[n].Cells[0].Value = row["id"].ToString();
                        dgview.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                        dgview.Rows[n].Cells[1].Value = row["first_name"].ToString();

                    }
                }
                else
                {
                    dgview.Visible = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        bool change = true;
        private void employee_mousedoubleClick(object sender, MouseEventArgs e) {
            if (change) {
                change = false;
                id.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                name.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                this.dgview.Visible = false;
                year.Focus();
                change = true;
            }
        
        }

        private void id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (dgview.Rows.Count > 0)
                {
                    id.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    name.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgview.Visible = false;
                    year.Focus();
                }
                else {
                    this.dgview.Visible = false;
                }
            }
        }

        private void year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (year.SelectedIndex != -1)
                {
                    month.Focus();
                }
                else {
                    year.Focus();
                }
            }
        }

        private void total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                working.Focus();
            }
        }

        private void working_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                present.Focus();
            }
        }

        private void present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                absent.Focus();
            }
        }

        private void absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                leave.Focus();
            }
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from hr_system.employeeAttendence where Employee_ID=" + Int32.Parse(id.Text) + " and year=" +
                    '"' + year.Text + '"' + " and month=" + '"' + month.Text + '"' + ";";
            Console.WriteLine(query);
            cmd = DBHelper.runquery2(query);
            DataTable dprop = new DataTable();
            if (cmd != null)
            {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dprop);
            }
            if (dprop.Rows.Count > 0)
            {
                total.Text = dprop.Rows[0]["TotalDays"].ToString();
                working.Text = dprop.Rows[0]["WorkingDays"].ToString();
                absent.Text = dprop.Rows[0]["absentDays"].ToString();
                present.Text = dprop.Rows[0]["PresentDays"].ToString();
                leave.Text = dprop.Rows[0]["leaveDays"].ToString();
                save.Enabled = false;
                update.Enabled = true;
                delete.Enabled = true;
            }
            else {
                total.Text ="";
                working.Text = "";
                absent.Text = "";
                present.Text = "";
                leave.Text = "";
                save.Enabled = true;
                update.Enabled = false;
                delete.Enabled = false;
            }
        }
        private bool validation() {
            bool result = false;
            if (String.IsNullOrEmpty(id.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(id, "id is Required");

            }
            else if (String.IsNullOrEmpty(year.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(year, "select year");
            }
            else if (String.IsNullOrEmpty(month.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(month, "select month");
            }
            else if (String.IsNullOrEmpty(total.Text))
            {

                errorProvider1.Clear();
                errorProvider1.SetError(total, "total days is required");
            }
            else if (String.IsNullOrEmpty(working.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(working, "working days is required");

            }
            else if (String.IsNullOrEmpty(present.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(present, "present days is required");
            }
            else {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes) {

                String query1 = "UPDATE hr_system.employeeAttendence set TotalDays=" + float.Parse(total.Text) +" , WorkingDays="+float.Parse(working.Text)+" , PresentDays="+
                    float.Parse(present.Text)+" , AbsentDays="+float.Parse(absent.Text) +" , leaveDays="+float.Parse(leave.Text)+" where Employee_ID="+int.Parse(id.Text)+
                    " and month="+month.Text+" and year="+year.Text+" ; ";
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(query1);
                DBHelper.runquery2(query1);


                emptytexts();

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {

                String query1 = "Delete from hr_system.employeeAttendence "+
                     " where Employee_ID=" + int.Parse(id.Text) +
                    " and month=" + month.Text + " and year=" + year.Text + " ; ";
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(query1);
                DBHelper.runquery2(query1);


                emptytexts();

            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            try
            {
                attendview uc = new attendview();
                //uc.MdiParent = this;
                //uc.StartPosition = FormStartPosition.CenterScreen;
                uc.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
    }
}
