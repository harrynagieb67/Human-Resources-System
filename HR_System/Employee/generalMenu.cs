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
    public partial class generalMenu : UserControl /*Form*/
    {
        public generalMenu()
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
        private void addORUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                

                UC_Employee uc = new UC_Employee();
                //uc.MdiParent = this;
                //uc.StartPosition = FormStartPosition.CenterScreen;
                uc.Show();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                }
        }

        private void generalMenu_Load(object sender, EventArgs e)
        {
           // IsMdiContainer = true;
        }


        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                empattend uc = new empattend();
                //uc.MdiParent = this;
                //uc.StartPosition = FormStartPosition.CenterScreen;
                uc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void attendanceViewToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void salaryProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalaryEmp uc = new SalaryEmp();
                //uc.MdiParent = this;
                //uc.StartPosition = FormStartPosition.CenterScreen;
                uc.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                UC_Employee ur = new UC_Employee();
                addusercontrol(ur);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                empattend ur = new empattend();
                addusercontrol(ur);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                attendview uc = new attendview();
                //uc.MdiParent = this;
                //uc.StartPosition = FormStartPosition.CenterScreen;
                addusercontrol(uc);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SalaryEmp uc = new SalaryEmp();
                //uc.MdiParent = this;
                //uc.StartPosition = FormStartPosition.CenterScreen;
                addusercontrol(uc);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
