
namespace HR_System.users
{
    partial class newuser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name:";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(135, 26);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(200, 32);
            this.fname.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(135, 140);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 32);
            this.password.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Hire Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Role:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(647, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 31);
            this.comboBox1.TabIndex = 36;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 285);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1098, 363);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hire Date";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Role";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Password";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Address";
            this.columnHeader7.Width = 180;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(258, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 39);
            this.button3.TabIndex = 41;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(119, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "User Name:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(135, 84);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 32);
            this.username.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(549, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Address:";
            // 
            // addres
            // 
            this.addres.Location = new System.Drawing.Point(647, 163);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(397, 96);
            this.addres.TabIndex = 46;
            this.addres.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(977, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 39);
            this.button4.TabIndex = 47;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(53, 194);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(67, 23);
            this.email.TabIndex = 49;
            this.email.Text = "Email:";
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(135, 191);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(200, 32);
            this.emailtext.TabIndex = 48;
            // 
            // newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1135, 660);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "newuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newuser";
            this.Load += new System.EventHandler(this.newuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox addres;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailtext;
    }
}