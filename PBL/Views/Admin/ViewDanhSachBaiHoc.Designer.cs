namespace PBL
{
    partial class ViewDanhSachBaiHoc
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lbTriangle = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundButton3 = new PBL.Controller.RoundButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new PBL.Controller.RoundTextBox();
            this.panelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.roundButton1 = new PBL.Controller.RoundButton();
            this.roundButton2 = new PBL.Controller.RoundButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.roundButton6 = new PBL.Controller.RoundButton();
            this.btQLBKT = new PBL.Controller.RoundButton();
            this.btQLBH = new PBL.Controller.RoundButton();
            this.btQLHV = new PBL.Controller.RoundButton();
            this.btTK = new PBL.Controller.RoundButton();
            this.panelHeader.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.roundButton6);
            this.panelHeader.Controls.Add(this.btQLBKT);
            this.panelHeader.Controls.Add(this.btQLBH);
            this.panelHeader.Controls.Add(this.btQLHV);
            this.panelHeader.Controls.Add(this.btTK);
            this.panelHeader.Controls.Add(this.panelUser);
            this.panelHeader.Controls.Add(this.logoPicture);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2064, 81);
            this.panelHeader.TabIndex = 6;
            // 
            // panelUser
            // 
            this.panelUser.AutoSize = true;
            this.panelUser.Controls.Add(this.lbTriangle);
            this.panelUser.Controls.Add(this.userPicture);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUser.Location = new System.Drawing.Point(1940, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(124, 81);
            this.panelUser.TabIndex = 8;
            this.panelUser.Click += new System.EventHandler(this.userPicture_Click);
            this.panelUser.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.panelUser.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // lbTriangle
            // 
            this.lbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriangle.Location = new System.Drawing.Point(84, -1);
            this.lbTriangle.Name = "lbTriangle";
            this.lbTriangle.Size = new System.Drawing.Size(37, 81);
            this.lbTriangle.TabIndex = 7;
            this.lbTriangle.Text = "▼";
            this.lbTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTriangle.Click += new System.EventHandler(this.userPicture_Click);
            this.lbTriangle.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.lbTriangle.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = global::PBL.Properties.Resources.Profile;
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPicture.Location = new System.Drawing.Point(0, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(80, 80);
            this.userPicture.TabIndex = 9;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.userPicture_Click);
            this.userPicture.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.userPicture.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::PBL.Properties.Resources.Logo;
            this.logoPicture.Location = new System.Drawing.Point(4, 14);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(395, 53);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roundButton3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rjTextBox1);
            this.panel2.Location = new System.Drawing.Point(232, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1652, 93);
            this.panel2.TabIndex = 14;
            // 
            // roundButton3
            // 
            this.roundButton3.AutoSize = true;
            this.roundButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton3.BorderRadius = 10;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(851, 10);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(169, 53);
            this.roundButton3.TabIndex = 11;
            this.roundButton3.Text = "Tìm";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên",
            "Giảng Viên"});
            this.comboBox1.Location = new System.Drawing.Point(618, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.rjTextBox1.Location = new System.Drawing.Point(208, 10);
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
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.MintCream;
            this.panelInfo.Controls.Add(this.roundButton1);
            this.panelInfo.Controls.Add(this.roundButton2);
            this.panelInfo.Location = new System.Drawing.Point(1890, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(171, 100);
            this.panelInfo.TabIndex = 0;
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
            this.roundButton1.Size = new System.Drawing.Size(165, 40);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Trang cá nhân";
            this.roundButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.White;
            this.roundButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton2.BorderRadius = 5;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(3, 49);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(161, 40);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "Đăng xuất";
            this.roundButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(233, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1650, 723);
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
            this.Detail.Text = "Detail";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.37791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.527132F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.18206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81794F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2064, 1075);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(232, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1652, 153);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách bài học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 237);
            this.panel1.TabIndex = 16;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 185);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(131, 29);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Lượt xem";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 150);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(140, 29);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Danh mục";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(146, 29);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Giảng viên";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ngày đăng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 29);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tên bài học";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sắp xếp theo";
            // 
            // roundButton6
            // 
            this.roundButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButton6.BackColor = System.Drawing.Color.White;
            this.roundButton6.BackgroundColor = System.Drawing.Color.White;
            this.roundButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton6.BorderRadius = 0;
            this.roundButton6.BorderSize = 0;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton6.ForeColor = System.Drawing.Color.Black;
            this.roundButton6.Location = new System.Drawing.Point(960, 13);
            this.roundButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(225, 60);
            this.roundButton6.TabIndex = 30;
            this.roundButton6.Text = "Quản Lý Giảng Viên";
            this.roundButton6.TextColor = System.Drawing.Color.Black;
            this.roundButton6.UseVisualStyleBackColor = false;
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
            this.btQLBKT.Location = new System.Drawing.Point(1659, 13);
            this.btQLBKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQLBKT.Name = "btQLBKT";
            this.btQLBKT.Size = new System.Drawing.Size(271, 60);
            this.btQLBKT.TabIndex = 29;
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
            this.btQLBH.Location = new System.Drawing.Point(1426, 13);
            this.btQLBH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQLBH.Name = "btQLBH";
            this.btQLBH.Size = new System.Drawing.Size(225, 60);
            this.btQLBH.TabIndex = 28;
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
            this.btQLHV.Location = new System.Drawing.Point(1193, 13);
            this.btQLHV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQLHV.Name = "btQLHV";
            this.btQLHV.Size = new System.Drawing.Size(225, 60);
            this.btQLHV.TabIndex = 27;
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
            this.btTK.Location = new System.Drawing.Point(775, 14);
            this.btTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(177, 60);
            this.btTK.TabIndex = 26;
            this.btTK.Text = "Thống Kê";
            this.btTK.TextColor = System.Drawing.Color.Black;
            this.btTK.UseVisualStyleBackColor = false;
            // 
            // ViewDanhSachBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2064, 1156);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewDanhSachBaiHoc";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormQuanLyBaiHoc_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lbTriangle;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Controller.RoundTextBox rjTextBox1;
        private System.Windows.Forms.FlowLayoutPanel panelInfo;
        private Controller.RoundButton roundButton1;
        private Controller.RoundButton roundButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn view;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private Controller.RoundButton roundButton3;
        private Controller.RoundButton roundButton6;
        private Controller.RoundButton btQLBKT;
        private Controller.RoundButton btQLBH;
        private Controller.RoundButton btQLHV;
        private Controller.RoundButton btTK;
    }
}