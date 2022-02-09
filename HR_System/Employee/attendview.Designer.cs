
namespace HR_System.Employee
{
    partial class attendview
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
            this.search = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // search
            // 
            this.search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search.FormattingEnabled = true;
            this.search.Items.AddRange(new object[] {
            "All ",
            "Employee ID"});
            this.search.Location = new System.Drawing.Point(310, 77);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(173, 29);
            this.search.TabIndex = 1;
            this.search.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.year.Location = new System.Drawing.Point(678, 77);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(173, 29);
            this.year.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year :";
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
            this.month.Location = new System.Drawing.Point(678, 127);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(173, 29);
            this.month.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month :";
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(434, 224);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(133, 39);
            this.view.TabIndex = 54;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 343);
            this.dataGridView1.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Year";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Month";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Days";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Working Days";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Present Days";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Absent Days";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Leave Days";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(310, 127);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(173, 30);
            this.id.TabIndex = 56;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_KeyDown);
            // 
            // attendview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1199, 660);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "attendview";
            this.Text = "attendview";
            this.Load += new System.EventHandler(this.attendview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox search;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox id;
    }
}