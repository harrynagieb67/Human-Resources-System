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
    public partial class reportcontrol : UserControl
    {
        public reportcontrol()
        {
            InitializeComponent();

        }
        private void addusercontrol(Control uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                userreport ur = new userreport();
                addusercontrol(ur);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EmpSalary es = new EmpSalary();
            addusercontrol(es);
        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            empattend es = new empattend();
            addusercontrol(es);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            empreport es = new empreport();
            addusercontrol(es);
        }
    }
}
