using System.Drawing;

namespace PBL
{
    partial class FormThemBaiHoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new PBL.Controller.RJTextBox();
            this.rjTextBox2 = new PBL.Controller.RJTextBox();
            this.rjTextBox3 = new PBL.Controller.RJTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton2 = new PBL.Controller.RoundButton();
            this.roundButton3 = new PBL.Controller.RoundButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundButton1 = new PBL.Controller.RoundButton();
            this.roundButton4 = new PBL.Controller.RoundButton();
            this.panelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lbTriangle = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.btTK = new PBL.Controller.RoundButton();
            this.btQLHV = new PBL.Controller.RoundButton();
            this.btQLBH = new PBL.Controller.RoundButton();
            this.btQLBKT = new PBL.Controller.RoundButton();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm bài học";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 127);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(4, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 127);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giảng Viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(4, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 127);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh Mục";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(4, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 127);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nội dung";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(415, 37);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Nhập tên bài học";
            this.rjTextBox1.Size = new System.Drawing.Size(375, 53);
            this.rjTextBox1.TabIndex = 9;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 10;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(415, 164);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "Nhập tên giảng viên";
            this.rjTextBox2.Size = new System.Drawing.Size(375, 53);
            this.rjTextBox2.TabIndex = 9;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 10;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(415, 291);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "Nhập tên danh mục";
            this.rjTextBox3.Size = new System.Drawing.Size(375, 53);
            this.rjTextBox3.TabIndex = 9;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(413, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(92, 542);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(225, 62);
            this.roundButton2.TabIndex = 11;
            this.roundButton2.Text = "Quay Lại";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton3.BorderRadius = 20;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(501, 542);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(225, 62);
            this.roundButton3.TabIndex = 12;
            this.roundButton3.Text = "Thêm";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2064, 1075);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(622, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 639);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.roundButton3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.roundButton2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(819, 639);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(622, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 100);
            this.panel2.TabIndex = 1;
            // 
            // roundButton1
            // 
            this.roundButton1.AutoSize = true;
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 5;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(3, 3);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(161, 40);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Trang cá nhân";
            this.roundButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.White;
            this.roundButton4.BackgroundColor = System.Drawing.Color.White;
            this.roundButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton4.BorderRadius = 5;
            this.roundButton4.BorderSize = 0;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.ForeColor = System.Drawing.Color.Black;
            this.roundButton4.Location = new System.Drawing.Point(3, 49);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(166, 40);
            this.roundButton4.TabIndex = 1;
            this.roundButton4.Text = "Đăng xuất";
            this.roundButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton4.TextColor = System.Drawing.Color.Black;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.MintCream;
            this.panelInfo.Controls.Add(this.roundButton1);
            this.panelInfo.Controls.Add(this.roundButton4);
            this.panelInfo.Location = new System.Drawing.Point(1890, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(171, 100);
            this.panelInfo.TabIndex = 20;
            this.panelInfo.Visible = false;
            // 
            // panelUser
            // 
            this.panelUser.AutoSize = true;
            this.panelUser.Controls.Add(this.userPicture);
            this.panelUser.Controls.Add(this.lbTriangle);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUser.Location = new System.Drawing.Point(1946, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(118, 81);
            this.panelUser.TabIndex = 15;
            this.panelUser.Click += new System.EventHandler(this.userPicture_Click);
            this.panelUser.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.panelUser.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // lbTriangle
            // 
            this.lbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriangle.Location = new System.Drawing.Point(78, 0);
            this.lbTriangle.Name = "lbTriangle";
            this.lbTriangle.Size = new System.Drawing.Size(37, 81);
            this.lbTriangle.TabIndex = 13;
            this.lbTriangle.Text = "▼";
            this.lbTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTriangle.Click += new System.EventHandler(this.userPicture_Click);
            this.lbTriangle.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.lbTriangle.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = global::PBL.Properties.Resources.profile_user;
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPicture.Location = new System.Drawing.Point(0, 1);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(80, 80);
            this.userPicture.TabIndex = 14;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.userPicture_Click);
            this.userPicture.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.userPicture.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // btTK
            // 
            this.btTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTK.BackColor = System.Drawing.Color.White;
            this.btTK.BackgroundColor = System.Drawing.Color.White;
            this.btTK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btTK.BorderRadius = 0;
            this.btTK.BorderSize = 0;
            this.btTK.FlatAppearance.BorderSize = 0;
            this.btTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTK.ForeColor = System.Drawing.Color.Black;
            this.btTK.Location = new System.Drawing.Point(992, 5);
            this.btTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(177, 60);
            this.btTK.TabIndex = 16;
            this.btTK.Text = "Thống Kê";
            this.btTK.TextColor = System.Drawing.Color.Black;
            this.btTK.UseVisualStyleBackColor = false;
            // 
            // btQLHV
            // 
            this.btQLHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btQLHV.BackColor = System.Drawing.Color.White;
            this.btQLHV.BackgroundColor = System.Drawing.Color.White;
            this.btQLHV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btQLHV.BorderRadius = 0;
            this.btQLHV.BorderSize = 0;
            this.btQLHV.FlatAppearance.BorderSize = 0;
            this.btQLHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLHV.ForeColor = System.Drawing.Color.Black;
            this.btQLHV.Location = new System.Drawing.Point(1177, 5);
            this.btQLHV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQLHV.Name = "btQLHV";
            this.btQLHV.Size = new System.Drawing.Size(225, 60);
            this.btQLHV.TabIndex = 17;
            this.btQLHV.Text = "Quản Lý Học Viên";
            this.btQLHV.TextColor = System.Drawing.Color.Black;
            this.btQLHV.UseVisualStyleBackColor = false;
            // 
            // btQLBH
            // 
            this.btQLBH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btQLBH.BackColor = System.Drawing.Color.White;
            this.btQLBH.BackgroundColor = System.Drawing.Color.White;
            this.btQLBH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btQLBH.BorderRadius = 0;
            this.btQLBH.BorderSize = 0;
            this.btQLBH.FlatAppearance.BorderSize = 0;
            this.btQLBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLBH.ForeColor = System.Drawing.Color.Black;
            this.btQLBH.Location = new System.Drawing.Point(1410, 5);
            this.btQLBH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQLBH.Name = "btQLBH";
            this.btQLBH.Size = new System.Drawing.Size(225, 60);
            this.btQLBH.TabIndex = 18;
            this.btQLBH.Text = "Quản Lý Bài Học";
            this.btQLBH.TextColor = System.Drawing.Color.Black;
            this.btQLBH.UseVisualStyleBackColor = false;
            // 
            // btQLBKT
            // 
            this.btQLBKT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btQLBKT.BackColor = System.Drawing.Color.White;
            this.btQLBKT.BackgroundColor = System.Drawing.Color.White;
            this.btQLBKT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btQLBKT.BorderRadius = 0;
            this.btQLBKT.BorderSize = 0;
            this.btQLBKT.FlatAppearance.BorderSize = 0;
            this.btQLBKT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLBKT.ForeColor = System.Drawing.Color.Black;
            this.btQLBKT.Location = new System.Drawing.Point(1643, 5);
            this.btQLBKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQLBKT.Name = "btQLBKT";
            this.btQLBKT.Size = new System.Drawing.Size(271, 60);
            this.btQLBKT.TabIndex = 19;
            this.btQLBKT.Text = "Quản Lý Bài Kiểm Tra";
            this.btQLBKT.TextColor = System.Drawing.Color.Black;
            this.btQLBKT.UseVisualStyleBackColor = false;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::PBL.Properties.Resources._2024_04_24_15_24_54_Untitled___Figma;
            this.logoPicture.Location = new System.Drawing.Point(4, 14);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(395, 53);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 20;
            this.logoPicture.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.logoPicture);
            this.panelHeader.Controls.Add(this.btQLBKT);
            this.panelHeader.Controls.Add(this.btQLBH);
            this.panelHeader.Controls.Add(this.btQLHV);
            this.panelHeader.Controls.Add(this.btTK);
            this.panelHeader.Controls.Add(this.panelUser);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2064, 81);
            this.panelHeader.TabIndex = 7;
            // 
            // FormThemBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(2064, 1156);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormThemBaiHoc";
            this.Text = "FormThemBaiHoc";
            this.Load += new System.EventHandler(this.FormThemBaiHoc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controller.RJTextBox rjTextBox1;
        private Controller.RJTextBox rjTextBox2;
        private Controller.RJTextBox rjTextBox3;
        private System.Windows.Forms.Button button1;
        private Controller.RoundButton roundButton2;
        private Controller.RoundButton roundButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel panelInfo;
        private Controller.RoundButton roundButton1;
        private Controller.RoundButton roundButton4;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label lbTriangle;
        private Controller.RoundButton btTK;
        private Controller.RoundButton btQLHV;
        private Controller.RoundButton btQLBH;
        private Controller.RoundButton btQLBKT;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel panelHeader;
    }
}