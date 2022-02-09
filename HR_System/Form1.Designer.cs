
namespace HR_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.passwordbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.namebox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1063, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Here";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(205, 224);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(214, 60);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "forget Passsword?";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(486, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 28);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(484, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 28);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.AutoCompleteCustomSource.AddRange(new string[] {
            "*"});
            this.passwordbox.Location = new System.Drawing.Point(306, 170);
            this.passwordbox.Multiline = true;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(213, 31);
            this.passwordbox.TabIndex = 5;
            this.passwordbox.Text = "admin1234";
            this.passwordbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordbox_KeyDown);
            this.passwordbox.Validating += new System.ComponentModel.CancelEventHandler(this.password_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(306, 116);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(213, 30);
            this.namebox.TabIndex = 0;
            this.namebox.Text = "admin1";
            this.namebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.namebox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namebox_KeyDown);
            this.namebox.Validating += new System.ComponentModel.CancelEventHandler(this.name_Validating);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1473, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(354, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "Human Resources Managment System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 568);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1422, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1448, 824);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

