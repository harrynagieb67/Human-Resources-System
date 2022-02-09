using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System.Exam_Section
{
    public partial class UC_NewPaper : UserControl
    {
        public UC_NewPaper()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Add_Test adt = new Add_Test()) {
                adt.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Add_Result adr = new Add_Result()) {
                adr.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            String path = fil.FileName.ToString();
            pictureBox1.ImageLocation = path;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
