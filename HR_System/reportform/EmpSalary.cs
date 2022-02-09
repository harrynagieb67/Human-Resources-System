using CrystalDecisions.CrystalReports.Engine;
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

namespace HR_System.reportform
{
    public partial class EmpSalary : UserControl
    {
        MySqlCommand cmd = new MySqlCommand();
        ReportDocument crypt = new ReportDocument();
        MySqlDataAdapter sda = new MySqlDataAdapter();
        public EmpSalary()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void EmpSalary_Load(object sender, EventArgs e)
        {
            crypt.Load(@"F:\junk\desktop_apps\HR_System\HR_System\reports\empsalary.rpt");

            try
            {


                String query1 = "select * from Employee ;";

                Console.WriteLine(query1);
                DataSet dt1 = new DataSet();
                cmd = DBHelper.runquery2(query1);

                if (cmd != null)
                {
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt1, "Employee");
                }
                //foreach (DataRow r in dt1.Rows)
                //{
                //    //    dataGridView1.Rows.Add(r["name"].ToString());
                //}

                crypt.SetDataSource(dt1);
                crystalReportViewer1.ReportSource = crypt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
