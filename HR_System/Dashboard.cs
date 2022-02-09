using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HR_System.Advertisment;
using HR_System.Applicant;
using HR_System.da_layer;
using HR_System.Employee;
using HR_System.Exam_Section;
using HR_System.Helper;
using HR_System.reportform;

namespace HR_System
{
    public partial class Dashboard : Form
    {
        public static String traveluser { get; set;}
        public Dashboard()
        {
            InitializeComponent();
            label4.Text = traveluser;

            upload_data();
            
            // DBHelper.Establishconn();
            // listView1.Items.Add(dvr.Tables[0].ToString());
            //foreach (DataRow dr in dvr.Rows) {

            //    vs.Add(dr["Name"].ToString());
            //}
            //for (int i = 0; i < vs.Count; i++)
            //{
            //    listView1.Items.Add(vs[i]);
            //}
        }


        public void upload_data() {
            DataTable dvr = emp_cont.retriveallemp();

            foreach (DataRow dr in dvr.Rows)
            {
                ListViewItem b = new ListViewItem(dr["ID"].ToString());
                b.SubItems.Add(dr["First_name"].ToString());
                b.SubItems.Add(dr["Last_name"].ToString());
                b.SubItems.Add(dr["SSN"].ToString());
                b.SubItems.Add(dr["Salary"].ToString());
                b.SubItems.Add(dr["Hire_Date"].ToString());
                b.SubItems.Add(dr["Title"].ToString());
                b.SubItems.Add(dr["Insurance"].ToString());
                b.SubItems.Add(dr["Department_code"].ToString());
                listView1.Items.Add(b);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void movesisdepanel(Button btn) {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;

        }

        private void addusercontrol(Control uc) {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movesisdepanel(button3);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movesisdepanel(button4);
            Uc_Advertisment uca = new Uc_Advertisment();
            addusercontrol(uca);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            movesisdepanel(button5);
            UC_Applicant ua = new UC_Applicant();
            addusercontrol(ua);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            movesisdepanel(button6);
            UC_NewPaper pap = new UC_NewPaper();
            addusercontrol(pap);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            movesisdepanel(button7);
            //UC_Employee uce = new UC_Employee();
            //addusercontrol(uce);
            try
            {
                generalMenu uc = new generalMenu();
                //uc.TopLevel = false;
                //uc.AutoScroll = true;
                //panelcenter.Controls.Clear();
                //panelcenter.Controls.Add(uc);
                addusercontrol(uc);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //generalMenu gm = new generalMenu();
            //gm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            movesisdepanel(button8);
            Uc_Settings us = new Uc_Settings();
            addusercontrol(us);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            movesisdepanel(button5);
            //UC_Applicant ucs = new UC_Applicant();
            //addusercontrol(ucs);
            try
            {
                reportcontrol rp = new reportcontrol();
                addusercontrol(rp);
                //userreport uc = new userreport();
                //uc.TopLevel = false;
                //uc.AutoScroll = true;
                //panelcenter.Controls.Clear();
                //panelcenter.Controls.Add(uc);
                //uc.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            movesisdepanel(button8);
            Uc_Settings ucse = new Uc_Settings();
            addusercontrol(ucse);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
