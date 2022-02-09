
namespace HR_System.Employee
{
    partial class empattend
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.working = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.present = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.absent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.leave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(217, 137);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(206, 30);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_KeyDown);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(658, 140);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 30);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // year
            // 
            this.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.year.Location = new System.Drawing.Point(218, 206);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(205, 29);
            this.year.TabIndex = 5;
            this.year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.year_KeyDown);
            // 
            // month
            // 
            this.month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "Janauary",
            "Febrauary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month.Location = new System.Drawing.Point(658, 206);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(205, 29);
            this.month.TabIndex = 7;
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Month:";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(218, 280);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(206, 30);
            this.total.TabIndex = 9;
            this.total.KeyDown += new System.Windows.Forms.KeyEventHandler(this.total_KeyDown);
            this.total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.total_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Days:";
            // 
            // working
            // 
            this.working.Location = new System.Drawing.Point(658, 278);
            this.working.Name = "working";
            this.working.Size = new System.Drawing.Size(206, 30);
            this.working.TabIndex = 11;
            this.working.KeyDown += new System.Windows.Forms.KeyEventHandler(this.working_KeyDown);
            this.working.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.working_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Working Days:";
            // 
            // present
            // 
            this.present.Location = new System.Drawing.Point(178, 349);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(140, 30);
            this.present.TabIndex = 13;
            this.present.TextChanged += new System.EventHandler(this.present_TextChanged);
            this.present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.present_KeyDown);
            this.present.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empattend_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Present Days:";
            // 
            // absent
            // 
            this.absent.Location = new System.Drawing.Point(497, 349);
            this.absent.Name = "absent";
            this.absent.Size = new System.Drawing.Size(134, 30);
            this.absent.TabIndex = 15;
            this.absent.TextChanged += new System.EventHandler(this.absent_TextChanged);
            this.absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.absent_KeyDown);
            this.absent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empattend_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Absent Days:";
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(814, 349);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(155, 30);
            this.leave.TabIndex = 17;
            this.leave.TextChanged += new System.EventHandler(this.leave_TextChanged);
            this.leave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empattend_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Leave Days:";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(338, 421);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(133, 39);
            this.update.TabIndex = 51;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(178, 421);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 39);
            this.save.TabIndex = 52;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(498, 421);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(133, 39);
            this.delete.TabIndex = 53;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // empattend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.update);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.absent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.present);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.working);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "empattend";
            this.Size = new System.Drawing.Size(1030, 578);
            this.Load += new System.EventHandler(this.empattend_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empattend_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox working;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox present;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox absent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox leave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}