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
    public partial class attendview : /*Form*/ UserControl
    {
        public attendview()
        {
            InitializeComponent();
        }

        bool change = true;
        private void employee_mousedoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                id.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                this.dgview.Visible = false;
                year.Focus();
                change = true;
            }

        }
        private void attendview_Load(object sender, EventArgs e)
        {
            searchfn();
            id.Visible = false;
            search.SelectedIndex =0;

        }

        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;

        void searchfn()
        {
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

        void searchfn(int lx, int ly, int dw, int dh, String colname, String colsize)
        {
            this.dgview.Location = new System.Drawing.Point(lx, ly);
            this.dgview.Size = new System.Drawing.Size(dw, dh);

            String[] clsize = colsize.Split(',');

            for (int i = 0; i < clsize.Length; i++)
            {
                if (int.Parse(clsize[i]) != 0)
                {
                    dgview.Columns[i].Width = int.Parse(clsize[i]);

                }
                else
                {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                }

            }
            String[] clname = colname.Split(',');
            for (int i = 0; i < clname.Length; i++)
            {
                this.dgview.Columns[i].HeaderText = clname[i];
                this.dgview.Columns[i].Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search.SelectedIndex == 0) {
                id.Visible = false;
            
            }
            if (search.SelectedIndex != 0)
            {
                id.Visible = true;
                id.Clear();

            }
        }

        MySqlCommand cmd=new MySqlCommand();
        MySqlDataAdapter sda = new MySqlDataAdapter();
        private void id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (id.Text.Length != 0)
                {
                    if (search.SelectedIndex == 1)
                    {
                        this.dgview.Visible = true;
                        dgview.BringToFront();
                        searchfn(240,240,400,200, "id ,first_name","100,0");
                        this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_mousedoubleClick);
                        String query = "Select Id, first_name from hr_system.employee where id like " + '"' + id.Text + "%" + '"' + ";";
                        
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
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void load_data(String condition) {
            try
            {
                String query = "select et.Employee_ID,e.first_name,et.year,et.month,et.TotalDays,et.WorkingDays" +
                    ",et.PresentDays,et.AbsentDays,et.leaveDays from " +
                    "hr_system.employeeAttendence as et ,employee e where et.Employee_ID=e.ID " +
                    "and " + condition ;

                Console.WriteLine(query);

                cmd = DBHelper.runquery2(query);
                DataTable dset = new DataTable();
                if (cmd != null)
                {
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dset);
                }
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dset.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = row["Employee_ID"].ToString();
                    dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[n].Cells[1].Value = row["first_name"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = row["year"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = row["month"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = row["TotalDays"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = row["WorkingDays"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = row["PresentDays"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = row["AbsentDays"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = row["leaveDays"].ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgview.Rows.Count > 0)
                {
                    id.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    this.dgview.Visible = false;
                    year.Focus();
                }
                else
                {
                    this.dgview.Visible = false;
                }
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (search.SelectedIndex == 0)
            {
                load_data("et.year = " + '"' + year.Text + '"' + " and et.month = " + '"' + month.Text + '"' + ';');
            }

            if (search.SelectedIndex == 1)
            {
                load_data("et.Employee_ID = "+int.Parse(id.Text)+" and et.year = " + '"' + year.Text + '"' + " and et.month = " + '"' + month.Text + '"' + ';');
            }
        }
    }
}
