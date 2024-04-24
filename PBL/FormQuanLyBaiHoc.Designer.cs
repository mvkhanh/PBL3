namespace PBL
{
    partial class FormQuanLyBaiHoc
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundButton7 = new PBL.Controller.RoundButton();
            this.roundButton6 = new PBL.Controller.RoundButton();
            this.roundButton5 = new PBL.Controller.RoundButton();
            this.roundButton4 = new PBL.Controller.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new PBL.Controller.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên",
            "Giảng Viên"});
            this.comboBox1.Location = new System.Drawing.Point(465, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roundButton7);
            this.panel1.Controls.Add(this.roundButton6);
            this.panel1.Controls.Add(this.roundButton5);
            this.panel1.Controls.Add(this.roundButton4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 52);
            this.panel1.TabIndex = 6;
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.White;
            this.roundButton7.BackgroundColor = System.Drawing.Color.White;
            this.roundButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton7.BorderRadius = 0;
            this.roundButton7.BorderSize = 0;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.ForeColor = System.Drawing.Color.Black;
            this.roundButton7.Location = new System.Drawing.Point(925, 7);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(150, 40);
            this.roundButton7.TabIndex = 4;
            this.roundButton7.Text = "Quản Lý Bài Kiểm Tra";
            this.roundButton7.TextColor = System.Drawing.Color.Black;
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.White;
            this.roundButton6.BackgroundColor = System.Drawing.Color.White;
            this.roundButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton6.BorderRadius = 0;
            this.roundButton6.BorderSize = 0;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.ForeColor = System.Drawing.Color.Black;
            this.roundButton6.Location = new System.Drawing.Point(769, 7);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(150, 40);
            this.roundButton6.TabIndex = 3;
            this.roundButton6.Text = "Quản Lý Bài Học";
            this.roundButton6.TextColor = System.Drawing.Color.Black;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.White;
            this.roundButton5.BackgroundColor = System.Drawing.Color.White;
            this.roundButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton5.BorderRadius = 0;
            this.roundButton5.BorderSize = 0;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.ForeColor = System.Drawing.Color.Black;
            this.roundButton5.Location = new System.Drawing.Point(613, 7);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(150, 40);
            this.roundButton5.TabIndex = 2;
            this.roundButton5.Text = "Quản Lý Học Viên";
            this.roundButton5.TextColor = System.Drawing.Color.Black;
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.White;
            this.roundButton4.BackgroundColor = System.Drawing.Color.White;
            this.roundButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton4.BorderRadius = 0;
            this.roundButton4.BorderSize = 0;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.ForeColor = System.Drawing.Color.Black;
            this.roundButton4.Location = new System.Drawing.Point(457, 7);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(150, 40);
            this.roundButton4.TabIndex = 1;
            this.roundButton4.Text = "Thống Kê";
            this.roundButton4.TextColor = System.Drawing.Color.Black;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUser,
            this.Date,
            this.Editor,
            this.Category,
            this.view,
            this.Detail,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 438);
            this.dataGridView1.TabIndex = 11;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Tên";
            this.NameUser.MinimumWidth = 6;
            this.NameUser.Name = "NameUser";
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày Đăng";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Editor
            // 
            this.Editor.HeaderText = "Giảng Viên";
            this.Editor.MinimumWidth = 6;
            this.Editor.Name = "Editor";
            // 
            // Category
            // 
            this.Category.HeaderText = "Danh Mục";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            // 
            // view
            // 
            this.view.HeaderText = "Lượt xem";
            this.view.MinimumWidth = 6;
            this.view.Name = "view";
            // 
            // Detail
            // 
            this.Detail.HeaderText = "";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detail.Text = "Delete";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(721, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng Hợp Bài Học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(208, 71);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Nhập tên bài học";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox1.TabIndex = 9;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // FormQuanLyBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1164, 606);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "FormQuanLyBaiHoc";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Controller.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private Controller.RoundButton roundButton7;
        private Controller.RoundButton roundButton6;
        private Controller.RoundButton roundButton5;
        private Controller.RoundButton roundButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn view;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}