
namespace HR_System.userdata
{
    partial class changepass
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 269);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1098, 363);
            this.listView1.TabIndex = 39;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "User Name:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(160, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 32);
            this.username.TabIndex = 44;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(596, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Old Password:";
            // 
            // old
            // 
            this.old.Location = new System.Drawing.Point(752, 45);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(200, 32);
            this.old.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "New Password:";
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(449, 119);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(200, 32);
            this.newpass.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Confirm Password:";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(449, 174);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(200, 32);
            this.confirm.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(791, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 52;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(942, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 39);
            this.button4.TabIndex = 53;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1135, 660);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.old);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "changepass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "changepass";
            this.Load += new System.EventHandler(this.changepass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}