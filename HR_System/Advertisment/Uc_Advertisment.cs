using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System.Advertisment
{
    public partial class Uc_Advertisment : UserControl
    {
        public Uc_Advertisment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (adding_nsource ans = new adding_nsource()) {
                ans.ShowDialog();
            }
        }
    }
}
