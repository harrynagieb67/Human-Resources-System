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
    public partial class empreport : UserControl
    {
        MySqlCommand cmd = new MySqlCommand();
        ReportDocument crypt = new ReportDocument();
        MySqlDataAdapter sda = new MySqlDataAdapter();
        public empreport()
        {
            InitializeComponent();
        }

        private void empreport_Load(object sender, EventArgs e)
        {
            crypt.Load(@"F:\junk\desktop_apps\HR_System\HR_System\reports\empdetail.rpt");

            try
            {
                DataSet dt1 = new DataSet();
                String query2 = "select  * from Employee ;";
                cmd = DBHelper.runquery2(query2);
                if (cmd != null)
                {
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt1, "Employee");

                }
                //foreach (DataRow r in dt1.Rows)
                //{
                //    //    dataGridView1.Rows.Add(r["name"].ToString());
                //}
                //foreach (DataTable dr in dt1.Tables) {
                //    Console.WriteLine(dr.Rows[0]["year"].ToString());
                //}
                //dataGridView1.DataSource = dt1;
                crypt.SetDataSource(dt1);
                crystalReportViewer1.ReportSource = crypt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
