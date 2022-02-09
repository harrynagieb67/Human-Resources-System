using HR_System.userdata;
using HR_System.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System
{
    public partial class Uc_Settings : UserControl
    {
        public Uc_Settings()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Personal_Designation pd = new Personal_Designation()) {
                pd.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Branch bs = new Branch()) {
                bs.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Functional_Designation fd = new Functional_Designation()) {
                fd.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Category cat = new Category()) {
                cat.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (newuser nu = new newuser()) {
                nu.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (changepass cp = new changepass()) {
                cp.ShowDialog();
            }
        }
    }
}
