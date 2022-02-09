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
    public partial class SalaryEmp : /*Form*/ UserControl
    {
        public SalaryEmp()
        {
            InitializeComponent();
        }
        float salary = 0;
        float workdays = 0;
        float present = 0;
        float leave = 0;
        float perday = 0;
        float netsalary = 0;

        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter sda = new MySqlDataAdapter();
        private void SalaryEmp_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            try {
                String query = "select * from employeeattendence where year= " + '"' + Year.Text + '"' + " and month= " + '"' + Month.Text + '"' + ";";

                Console.WriteLine(query);

                cmd = DBHelper.runquery2(query);
                DataTable dset = new DataTable();
                if (cmd != null)
                {
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dset);
                }
                if (dset.Rows.Count > 0)
                {
                    foreach (DataRow row in dset.Rows)
                    {
                        int i = 0;
                        String query1 = "select e.salary,ea.WorkingDays,ea.PresentDays,ea.leaveDays from EmployeeAttendence as ea, Employee as e " +
                            " where ea.year=" + '"' + Year.Text + '"' + " and ea.month = " + '"' + Month.Text + '"' +
                            " and ea.Employee_ID = e.ID and ea.Employee_ID = " + int.Parse(row["Employee_ID"].ToString()) + " ;";

                        Console.WriteLine(query1);
                        DataTable dt1 = new DataTable();
                        cmd = DBHelper.runquery2(query1);

                        if (cmd != null)
                        {
                            sda = new MySqlDataAdapter(cmd);
                            sda.Fill(dt1);
                        }
                        salary = float.Parse(dt1.Rows[i]["salary"].ToString());
                        workdays = float.Parse(dt1.Rows[i]["WorkingDays"].ToString());
                        present = float.Parse(dt1.Rows[i]["PresentDays"].ToString());
                        leave = float.Parse(dt1.Rows[i]["leaveDays"].ToString());
                        perday = (salary / 12) / workdays;
                        netsalary = (perday * present) - (perday * leave);

                        String query2 = "select *  from Employee_salary where " +
                            "Employee_ID = " + int.Parse(row["Employee_ID"].ToString()) + " and year = " + '"' + Year.Text + '"' + "and month = " +
                            '"' + Month.Text + '"' +" ;";

                        DataTable dt2 = new DataTable();
                        Console.WriteLine(query2);
                        cmd = DBHelper.runquery2(query2);
                        if (cmd != null) {
                            sda = new MySqlDataAdapter(cmd);
                            sda.Fill(dt2);
                        }
                        if (dt2.Rows.Count > 0) {
                            return;
                        }

                        String query3 = "insert into Employee_salary (Employee_ID , year , month , netsalary) " +
                            "values (" + int.Parse(row["Employee_ID"].ToString()) + " , " + '"' + Year.Text + '"' + "," +
                            '"' + Month.Text + '"' + " , " + netsalary + " ) ;";

                        Console.WriteLine(query3);
                        cmd = DBHelper.runquery2(query3);

                        i++;
                    }
                    MessageBox.Show("Salary Generated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.Rows.Clear();

                    loaddata();
                }
                else {
                    dataGridView1.Rows.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
             
        }

        void loaddata() {
            String query1 = "select es.Employee_ID,es.year,es.month,es.netsalary,e.first_name from Employee_salary as es," +
                "employee as e where e.ID=es.Employee_ID";

            Console.WriteLine(query1);
            DataTable dt1 = new DataTable();
            cmd = DBHelper.runquery2(query1);

            if (cmd != null)
            {
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt1);
            }
            if (dt1.Rows.Count > 0) {
                foreach (DataRow row in dt1.Rows) {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = row["Employee_ID"].ToString();
                    dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[n].Cells[1].Value = row["first_name"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = row["year"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = row["month"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = row["netsalary"].ToString();
                }
            }


        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                String query1 = "select es.Employee_ID,es.year,es.month,es.netsalary,e.first_name from Employee_salary as es," +
                    "employee as e where e.ID=es.Employee_ID and es.year = " + '"' + Year.Text + '"' + " and es.month = " + '"' + Month.Text + '"' + " ; ";

                Console.WriteLine(query1);
                DataTable dt1 = new DataTable();
                cmd = DBHelper.runquery2(query1);

                if (cmd != null)
                {
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt1);
                }
                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow row in dt1.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = row["Employee_ID"].ToString();
                        dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                        dataGridView1.Rows[n].Cells[1].Value = row["first_name"].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = row["year"].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = row["month"].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = row["netsalary"].ToString();
                    }
                }
                else {
                    dataGridView1.Rows.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
    }
}
