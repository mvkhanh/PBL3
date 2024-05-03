using System.Drawing;

namespace PBL
{
    partial class ViewThemBaiKiemTra
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
            this.panelUser = new System.Windows.Forms.Panel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.lbTriangle = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btQLBKT = new PBL.Controller.RoundButton();
            this.btQLBH = new PBL.Controller.RoundButton();
            this.btQLHV = new PBL.Controller.RoundButton();
            this.btTK = new PBL.Controller.RoundButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.roundButton3 = new PBL.Controller.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjTextBox3 = new PBL.Controller.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rjTextBox2 = new PBL.Controller.RJTextBox();
            this.roundButton2 = new PBL.Controller.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new PBL.Controller.RJTextBox();
            this.panelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.roundButton1 = new PBL.Controller.RoundButton();
            this.roundButton4 = new PBL.Controller.RoundButton();
            this.rjTextBox4 = new PBL.Controller.RJTextBox();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.btQLBKT.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btQLBH.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btQLHV.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btTK.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(450, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1123, 811);
            this.panel3.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.roundButton3, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.rjTextBox3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rjTextBox2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.roundButton2, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.rjTextBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.rjTextBox4, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1121, 809);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // roundButton3
            // 
            this.roundButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton3.BorderRadius = 10;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(711, 710);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(258, 65);
            this.roundButton3.TabIndex = 12;
            this.roundButton3.Text = "Tiếp tục";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1115, 161);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm bài kiểm tra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(173, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 10;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(566, 453);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "Nhập tên danh mục";
            this.rjTextBox3.Size = new System.Drawing.Size(424, 60);
            this.rjTextBox3.TabIndex = 9;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(173, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giảng Viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 10;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(566, 324);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "Nhập tên giảng viên";
            this.rjTextBox2.Size = new System.Drawing.Size(424, 60);
            this.rjTextBox2.TabIndex = 9;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // roundButton2
            // 
            this.roundButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton2.BorderRadius = 10;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(151, 710);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(258, 65);
            this.roundButton2.TabIndex = 11;
            this.roundButton2.Text = "Quay Lại";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(173, 461);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh Mục";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(173, 590);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới thiệu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(566, 195);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Nhập tên bài học";
            this.rjTextBox1.Size = new System.Drawing.Size(424, 60);
            this.rjTextBox1.TabIndex = 9;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.roundButton1);
            this.panelInfo.Controls.Add(this.roundButton4);
            this.panelInfo.Location = new System.Drawing.Point(1629, 204);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(171, 124);
            this.panelInfo.TabIndex = 23;
            this.panelInfo.Visible = false;
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
            this.roundButton1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(3, 3);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(165, 55);
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
            this.roundButton4.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.Black;
            this.roundButton4.Location = new System.Drawing.Point(3, 64);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(161, 55);
            this.roundButton4.TabIndex = 1;
            this.roundButton4.Text = "Đăng xuất";
            this.roundButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton4.TextColor = System.Drawing.Color.Black;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderRadius = 10;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(566, 582);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "Nhập nội dung giới thiệu";
            this.rjTextBox4.Size = new System.Drawing.Size(424, 60);
            this.rjTextBox4.TabIndex = 9;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // FormThemBaiKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2064, 1156);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormThemBaiKiemTra";
            this.Text = "FormThemBaiHoc";
            this.Load += new System.EventHandler(this.FormThemBaiHoc_Load);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label lbTriangle;
        private Controller.RoundButton btTK;
        private Controller.RoundButton btQLHV;
        private Controller.RoundButton btQLBH;
        private Controller.RoundButton btQLBKT;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controller.RoundButton roundButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controller.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label label3;
        private Controller.RJTextBox rjTextBox2;
        private Controller.RoundButton roundButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controller.RJTextBox rjTextBox1;
        private System.Windows.Forms.FlowLayoutPanel panelInfo;
        private Controller.RoundButton roundButton1;
        private Controller.RoundButton roundButton4;
        private Controller.RJTextBox rjTextBox4;
    }
}