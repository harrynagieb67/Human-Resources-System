using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using HR_System.Helper;
using HR_System.sd_layer;
using HR_System.da_layer;
using System.Diagnostics;
using System.Threading;

namespace HR_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.BringToFront();

            DBHelper.Establishconn();

            //Runlaragonthread();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void generatesound() {
            SpeechSynthesizer speaking = new SpeechSynthesizer();
            speaking.Speak("developed by ahmed nagieb");
        }
        public async void RunProcessAsyncInfiniteLoop()
        {
            var task1 = Task.Run(() => generatesound());

            await task1;
        }

        public async void Runlaragonthread()
        {
            var task1 = Task.Run(() => open_laragon());

            await task1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Runlaragonthread();
            if (checkform())
            {

                String username = namebox.Text;
                String password = passwordbox.Text;

                USersIN auser = userDa.retreiveuser(username);
                try
                {
                    if (auser.Password.Equals(password))
                    {
                        Dashboard.traveluser = namebox.Text;
                        using (Dashboard ds = new Dashboard())
                        {
                            //this.Hide();
                            RunProcessAsyncInfiniteLoop();
                            ds.ShowDialog();

                        }
                    }

                    else
                    {
                        MessageBox.Show("Login Failed.Please try again", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        namebox.Text = "";
                        passwordbox.Text = "";
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error");
                }

            }


        }
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //static extern IntPtr setparent(IntPtr hchild, IntPtr hparent);

        private void open_laragon() {
            //OpenFileDialog od = new OpenFileDialog();
            //if (od.ShowDialog() == DialogResult.OK)
            //{
            //    Process proc = Process.Start(od.FileName);
            //    proc.WaitForInputIdle();

            //    while (proc.MainWindowHandle == IntPtr.Zero)
            //    {
            //        Thread.Sleep(100);
            //        proc.Refresh();
            //    }
            //    setparent(proc.MainWindowHandle, this.panel1.Handle);
            //}
            Process fapp = new Process();
            try
            {
                fapp.StartInfo.FileName = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Laragon\Laragon.lnk";
                fapp.Start();


                Thread.Sleep(1500);
                //fapp.WaitForExit();
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.ContainerControl = this;
            
        }


        private bool checkname() {
            bool status = true;
            if (namebox.Text == "")
            {
                errorProvider1.SetError(namebox, "Please Enter Your Name");
                status = false;
            }
            else {
                errorProvider1.SetError(namebox, "");
                String traveluser = namebox.Text;
            }
            return status;
        }

        private bool checkpass()
        {
            bool status = true;
            if (passwordbox.Text == "")
            {
                errorProvider1.SetError(passwordbox, "Please Enter Your Your Password");
                status = false;
            }
            else
            {
                errorProvider1.SetError(passwordbox, "");
            }
            return status;
        }

        private bool checkform()
        {
            bool chname = checkname();
            bool chpass = checkpass();
            bool mainst ;
            if (chname&&chpass)
            {
              mainst = true;
            }
            else
            {
                mainst = false;
            }
            return mainst;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            checkname();

        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            checkpass();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (passwordbox.PasswordChar == '*') {
                button5.BringToFront();
                passwordbox.PasswordChar = '\0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (passwordbox.PasswordChar == '\0')
            {
                button3.BringToFront();
                passwordbox.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void namebox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (namebox.Text.Length > 0) { passwordbox.Focus(); }
                else { namebox.Focus(); }
            }
        }

        private void passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (passwordbox.Text.Length > 0) { button1.Focus(); }
                else { passwordbox.Focus(); }
            }
        }
    }
}
