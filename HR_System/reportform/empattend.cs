using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class empattend : UserControl
    {
        MySqlCommand cmd = new MySqlCommand();
        ReportDocument crypt = new ReportDocument();
        MySqlDataAdapter sda = new MySqlDataAdapter();
        public empattend()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void empattend_Load(object sender, EventArgs e)
        {
            crypt.Load(@"F:\junk\desktop_apps\HR_System\HR_System\reports\empattend.rpt");

            try
            {


                String query1 = "select  * from employeeAttendence ;";
                
                Console.WriteLine(query1);
                DataSet dt1 = new DataSet();
                cmd = DBHelper.runquery2(query1);
                
                if (cmd != null)
                {
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt1, "employeeAttendence");
                    
                }
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

        private void btex_Click(object sender, EventArgs e)
        {
            ExportOptions export;
            DiskFileDestinationOptions disdestop = new DiskFileDestinationOptions();
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Pdf files |* .pdf ";
            //sf.Filter = "Excel |*.xls";
            if (sf.ShowDialog() == DialogResult.OK) {
                disdestop.DiskFileName = sf.FileName;
            }
            export = crypt.ExportOptions;
            {
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.PortableDocFormat;
               //export.ExportFormatType = ExportFormatType.Excel;
                export.ExportDestinationOptions = disdestop;
                export.ExportFormatOptions = new PdfFormatOptions();
              //  export.ExportFormatOptions = new ExcelFormatOptions();
            }
            crypt.Export();

        }
    }
}
 