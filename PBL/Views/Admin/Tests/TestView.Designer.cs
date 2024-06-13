namespace PBL
{
    partial class TestView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPageQuestionList = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lbPart = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPart7 = new PBL.Controller.RoundButton();
            this.btnPart6 = new PBL.Controller.RoundButton();
            this.btnFinish = new FontAwesome.Sharp.IconButton();
            this.btnPart5 = new PBL.Controller.RoundButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnPart4 = new PBL.Controller.RoundButton();
            this.btnPart3 = new PBL.Controller.RoundButton();
            this.btnPart2 = new PBL.Controller.RoundButton();
            this.btnPart1 = new PBL.Controller.RoundButton();
            this.tabPageTestDetail = new System.Windows.Forms.TabPage();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnAddAudio = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTeacherName = new System.Windows.Forms.ComboBox();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbRegist = new System.Windows.Forms.Label();
            this.lbIntroduction = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbParticipant = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnQuestions = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtDescription = new PBL.Controller.RoundTextBox();
            this.regist = new PBL.Resources.Components.RJDatePicker();
            this.txtName = new PBL.Controller.RoundTextBox();
            this.txtPaticipant = new PBL.Controller.RoundTextBox();
            this.txtId = new PBL.Controller.RoundTextBox();
            this.tabPageTestList = new System.Windows.Forms.TabPage();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageQuestionList.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tabPageTestDetail.SuspendLayout();
            this.tabPageTestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageQuestionList
            // 
            this.tabPageQuestionList.Controls.Add(this.panelMain);
            this.tabPageQuestionList.Controls.Add(this.panelLeft);
            this.tabPageQuestionList.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuestionList.Name = "tabPageQuestionList";
            this.tabPageQuestionList.Size = new System.Drawing.Size(961, 448);
            this.tabPageQuestionList.TabIndex = 2;
            this.tabPageQuestionList.Text = "Question List";
            this.tabPageQuestionList.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.lbPart);
            this.panelMain.Controls.Add(this.panelBtn);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(83, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(878, 448);
            this.panelMain.TabIndex = 1;
            // 
            // lbPart
            // 
            this.lbPart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPart.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPart.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbPart.Location = new System.Drawing.Point(3, 0);
            this.lbPart.Name = "lbPart";
            this.lbPart.Size = new System.Drawing.Size(1300, 43);
            this.lbPart.TabIndex = 4;
            this.lbPart.Text = "Part";
            this.lbPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnNext);
            this.panelBtn.Controls.Add(this.btnPrevious);
            this.panelBtn.Location = new System.Drawing.Point(3, 46);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(877, 46);
            this.panelBtn.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 24;
            this.btnNext.Location = new System.Drawing.Point(720, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnPrevious.IconColor = System.Drawing.Color.Black;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 24;
            this.btnPrevious.Location = new System.Drawing.Point(73, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(103, 30);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnPart7);
            this.panelLeft.Controls.Add(this.btnPart6);
            this.panelLeft.Controls.Add(this.btnFinish);
            this.panelLeft.Controls.Add(this.btnPart5);
            this.panelLeft.Controls.Add(this.btnBack);
            this.panelLeft.Controls.Add(this.btnPart4);
            this.panelLeft.Controls.Add(this.btnPart3);
            this.panelLeft.Controls.Add(this.btnPart2);
            this.panelLeft.Controls.Add(this.btnPart1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(83, 448);
            this.panelLeft.TabIndex = 2;
            // 
            // btnPart7
            // 
            this.btnPart7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart7.BackColor = System.Drawing.Color.Transparent;
            this.btnPart7.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPart7.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart7.BorderRadius = 8;
            this.btnPart7.BorderSize = 2;
            this.btnPart7.FlatAppearance.BorderSize = 0;
            this.btnPart7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart7.Location = new System.Drawing.Point(3, 362);
            this.btnPart7.Name = "btnPart7";
            this.btnPart7.Size = new System.Drawing.Size(77, 30);
            this.btnPart7.TabIndex = 6;
            this.btnPart7.Text = "Part 7";
            this.btnPart7.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart7.UseVisualStyleBackColor = false;
            this.btnPart7.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnPart6
            // 
            this.btnPart6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart6.BackColor = System.Drawing.Color.Transparent;
            this.btnPart6.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPart6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart6.BorderRadius = 8;
            this.btnPart6.BorderSize = 2;
            this.btnPart6.FlatAppearance.BorderSize = 0;
            this.btnPart6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart6.Location = new System.Drawing.Point(3, 312);
            this.btnPart6.Name = "btnPart6";
            this.btnPart6.Size = new System.Drawing.Size(77, 30);
            this.btnPart6.TabIndex = 5;
            this.btnPart6.Text = "Part 6";
            this.btnPart6.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart6.UseVisualStyleBackColor = false;
            this.btnPart6.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.AutoSize = true;
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnFinish.IconColor = System.Drawing.Color.White;
            this.btnFinish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinish.IconSize = 24;
            this.btnFinish.Location = new System.Drawing.Point(3, 412);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(77, 30);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnPart5
            // 
            this.btnPart5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart5.BackColor = System.Drawing.Color.Transparent;
            this.btnPart5.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPart5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart5.BorderRadius = 8;
            this.btnPart5.BorderSize = 2;
            this.btnPart5.FlatAppearance.BorderSize = 0;
            this.btnPart5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart5.Location = new System.Drawing.Point(3, 262);
            this.btnPart5.Name = "btnPart5";
            this.btnPart5.Size = new System.Drawing.Size(77, 30);
            this.btnPart5.TabIndex = 4;
            this.btnPart5.Text = "Part 5";
            this.btnPart5.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart5.UseVisualStyleBackColor = false;
            this.btnPart5.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 24;
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPart4
            // 
            this.btnPart4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart4.BackColor = System.Drawing.Color.Transparent;
            this.btnPart4.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPart4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart4.BorderRadius = 8;
            this.btnPart4.BorderSize = 2;
            this.btnPart4.FlatAppearance.BorderSize = 0;
            this.btnPart4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart4.Location = new System.Drawing.Point(3, 212);
            this.btnPart4.Name = "btnPart4";
            this.btnPart4.Size = new System.Drawing.Size(77, 30);
            this.btnPart4.TabIndex = 3;
            this.btnPart4.Text = "Part 4";
            this.btnPart4.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart4.UseVisualStyleBackColor = false;
            this.btnPart4.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnPart3
            // 
            this.btnPart3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart3.BackColor = System.Drawing.Color.Transparent;
            this.btnPart3.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPart3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart3.BorderRadius = 8;
            this.btnPart3.BorderSize = 2;
            this.btnPart3.FlatAppearance.BorderSize = 0;
            this.btnPart3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart3.Location = new System.Drawing.Point(3, 162);
            this.btnPart3.Name = "btnPart3";
            this.btnPart3.Size = new System.Drawing.Size(77, 30);
            this.btnPart3.TabIndex = 2;
            this.btnPart3.Text = "Part 3";
            this.btnPart3.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart3.UseVisualStyleBackColor = false;
            this.btnPart3.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnPart2
            // 
            this.btnPart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart2.BackColor = System.Drawing.Color.Transparent;
            this.btnPart2.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPart2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart2.BorderRadius = 8;
            this.btnPart2.BorderSize = 2;
            this.btnPart2.FlatAppearance.BorderSize = 0;
            this.btnPart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart2.Location = new System.Drawing.Point(3, 112);
            this.btnPart2.Name = "btnPart2";
            this.btnPart2.Size = new System.Drawing.Size(77, 30);
            this.btnPart2.TabIndex = 1;
            this.btnPart2.Text = "Part 2";
            this.btnPart2.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart2.UseVisualStyleBackColor = false;
            this.btnPart2.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnPart1
            // 
            this.btnPart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPart1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPart1.BorderRadius = 8;
            this.btnPart1.BorderSize = 0;
            this.btnPart1.FlatAppearance.BorderSize = 0;
            this.btnPart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPart1.ForeColor = System.Drawing.Color.White;
            this.btnPart1.Location = new System.Drawing.Point(3, 62);
            this.btnPart1.Name = "btnPart1";
            this.btnPart1.Size = new System.Drawing.Size(77, 30);
            this.btnPart1.TabIndex = 0;
            this.btnPart1.Text = "Part 1";
            this.btnPart1.TextColor = System.Drawing.Color.White;
            this.btnPart1.UseVisualStyleBackColor = false;
            this.btnPart1.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // tabPageTestDetail
            // 
            this.tabPageTestDetail.Controls.Add(this.btnPlay);
            this.tabPageTestDetail.Controls.Add(this.btnAddAudio);
            this.tabPageTestDetail.Controls.Add(this.label1);
            this.tabPageTestDetail.Controls.Add(this.cbbTeacherName);
            this.tabPageTestDetail.Controls.Add(this.lbTeacherName);
            this.tabPageTestDetail.Controls.Add(this.lbBirth);
            this.tabPageTestDetail.Controls.Add(this.lbRegist);
            this.tabPageTestDetail.Controls.Add(this.lbIntroduction);
            this.tabPageTestDetail.Controls.Add(this.lbName);
            this.tabPageTestDetail.Controls.Add(this.lbParticipant);
            this.tabPageTestDetail.Controls.Add(this.lbId);
            this.tabPageTestDetail.Controls.Add(this.btnQuestions);
            this.tabPageTestDetail.Controls.Add(this.btnCancel);
            this.tabPageTestDetail.Controls.Add(this.btnSave);
            this.tabPageTestDetail.Controls.Add(this.txtDescription);
            this.tabPageTestDetail.Controls.Add(this.regist);
            this.tabPageTestDetail.Controls.Add(this.txtName);
            this.tabPageTestDetail.Controls.Add(this.txtPaticipant);
            this.tabPageTestDetail.Controls.Add(this.txtId);
            this.tabPageTestDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTestDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestDetail.Name = "tabPageTestDetail";
            this.tabPageTestDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestDetail.Size = new System.Drawing.Size(961, 448);
            this.tabPageTestDetail.TabIndex = 1;
            this.tabPageTestDetail.Text = "Test detail";
            this.tabPageTestDetail.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.AutoSize = true;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 20;
            this.btnPlay.Location = new System.Drawing.Point(761, 160);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(69, 30);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAddAudio
            // 
            this.btnAddAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAudio.AutoSize = true;
            this.btnAddAudio.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAudio.FlatAppearance.BorderSize = 0;
            this.btnAddAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAudio.ForeColor = System.Drawing.Color.White;
            this.btnAddAudio.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            this.btnAddAudio.IconColor = System.Drawing.Color.White;
            this.btnAddAudio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAudio.IconSize = 32;
            this.btnAddAudio.Location = new System.Drawing.Point(761, 106);
            this.btnAddAudio.Name = "btnAddAudio";
            this.btnAddAudio.Size = new System.Drawing.Size(151, 38);
            this.btnAddAudio.TabIndex = 29;
            this.btnAddAudio.Text = "Add MP3 File";
            this.btnAddAudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAudio.UseVisualStyleBackColor = false;
            this.btnAddAudio.Click += new System.EventHandler(this.btnAddAudio_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(758, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Audio:";
            // 
            // cbbTeacherName
            // 
            this.cbbTeacherName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTeacherName.FormattingEnabled = true;
            this.cbbTeacherName.Location = new System.Drawing.Point(48, 305);
            this.cbbTeacherName.Name = "cbbTeacherName";
            this.cbbTeacherName.Size = new System.Drawing.Size(221, 24);
            this.cbbTeacherName.TabIndex = 28;
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbTeacherName.Location = new System.Drawing.Point(45, 280);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(79, 18);
            this.lbTeacherName.TabIndex = 27;
            this.lbTeacherName.Text = "Publish by:";
            // 
            // lbBirth
            // 
            this.lbBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbBirth.Location = new System.Drawing.Point(760, 263);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(80, 18);
            this.lbBirth.TabIndex = 21;
            this.lbBirth.Text = "Questions:";
            // 
            // lbRegist
            // 
            this.lbRegist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRegist.AutoSize = true;
            this.lbRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegist.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbRegist.Location = new System.Drawing.Point(43, 102);
            this.lbRegist.Name = "lbRegist";
            this.lbRegist.Size = new System.Drawing.Size(90, 18);
            this.lbRegist.TabIndex = 12;
            this.lbRegist.Text = "Publish Day:";
            // 
            // lbIntroduction
            // 
            this.lbIntroduction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIntroduction.AutoSize = true;
            this.lbIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntroduction.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbIntroduction.Location = new System.Drawing.Point(309, 106);
            this.lbIntroduction.Name = "lbIntroduction";
            this.lbIntroduction.Size = new System.Drawing.Size(122, 18);
            this.lbIntroduction.TabIndex = 2;
            this.lbIntroduction.Text = "Test Introduction:";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbName.Location = new System.Drawing.Point(309, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 18);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Test Name:";
            // 
            // lbParticipant
            // 
            this.lbParticipant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbParticipant.AutoSize = true;
            this.lbParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParticipant.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbParticipant.Location = new System.Drawing.Point(43, 195);
            this.lbParticipant.Name = "lbParticipant";
            this.lbParticipant.Size = new System.Drawing.Size(166, 18);
            this.lbParticipant.TabIndex = 0;
            this.lbParticipant.Text = "Number Of Participants:";
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbId.Location = new System.Drawing.Point(43, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(59, 18);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Test ID:";
            // 
            // btnQuestions
            // 
            this.btnQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestions.AutoSize = true;
            this.btnQuestions.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuestions.FlatAppearance.BorderSize = 0;
            this.btnQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestions.ForeColor = System.Drawing.Color.White;
            this.btnQuestions.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnQuestions.IconColor = System.Drawing.Color.White;
            this.btnQuestions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuestions.IconSize = 32;
            this.btnQuestions.Location = new System.Drawing.Point(761, 284);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(123, 45);
            this.btnQuestions.TabIndex = 22;
            this.btnQuestions.Text = "Add/Edit";
            this.btnQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuestions.UseVisualStyleBackColor = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.Location = new System.Drawing.Point(495, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(312, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderRadius = 0;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(312, 121);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(429, 210);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // regist
            // 
            this.regist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.regist.BorderSize = 0;
            this.regist.Enabled = false;
            this.regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.regist.Location = new System.Drawing.Point(48, 121);
            this.regist.MinimumSize = new System.Drawing.Size(0, 35);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(221, 35);
            this.regist.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.regist.TabIndex = 24;
            this.regist.TextColor = System.Drawing.Color.White;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(312, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(429, 31);
            this.txtName.TabIndex = 23;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtPaticipant
            // 
            this.txtPaticipant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaticipant.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaticipant.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPaticipant.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPaticipant.BorderRadius = 0;
            this.txtPaticipant.BorderSize = 2;
            this.txtPaticipant.Enabled = false;
            this.txtPaticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaticipant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaticipant.Location = new System.Drawing.Point(46, 215);
            this.txtPaticipant.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaticipant.Multiline = false;
            this.txtPaticipant.Name = "txtPaticipant";
            this.txtPaticipant.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPaticipant.PasswordChar = false;
            this.txtPaticipant.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPaticipant.PlaceholderText = "";
            this.txtPaticipant.Size = new System.Drawing.Size(221, 31);
            this.txtPaticipant.TabIndex = 23;
            this.txtPaticipant.Texts = "0";
            this.txtPaticipant.UnderlinedStyle = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderRadius = 0;
            this.txtId.BorderSize = 2;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(46, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
            this.txtId.Size = new System.Drawing.Size(221, 31);
            this.txtId.TabIndex = 23;
            this.txtId.Texts = "0";
            this.txtId.UnderlinedStyle = false;
            // 
            // tabPageTestList
            // 
            this.tabPageTestList.Controls.Add(this.btnEdit);
            this.tabPageTestList.Controls.Add(this.btnSearch);
            this.tabPageTestList.Controls.Add(this.btnDelete);
            this.tabPageTestList.Controls.Add(this.btnAddNew);
            this.tabPageTestList.Controls.Add(this.txtSearch);
            this.tabPageTestList.Controls.Add(this.dataGridView1);
            this.tabPageTestList.Controls.Add(this.lbSearch);
            this.tabPageTestList.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestList.Name = "tabPageTestList";
            this.tabPageTestList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestList.Size = new System.Drawing.Size(961, 448);
            this.tabPageTestList.TabIndex = 0;
            this.tabPageTestList.Text = "Test List";
            this.tabPageTestList.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 32;
            this.btnEdit.Location = new System.Drawing.Point(829, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 46);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "  Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.Location = new System.Drawing.Point(711, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(829, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddNew.IconColor = System.Drawing.Color.White;
            this.btnAddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNew.IconSize = 32;
            this.btnAddNew.Location = new System.Drawing.Point(829, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(115, 46);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(672, 33);
            this.txtSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(191)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(24, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Black;
            this.lbSearch.Location = new System.Drawing.Point(21, 3);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(96, 16);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Search Test:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTestList);
            this.tabControl1.Controls.Add(this.tabPageTestDetail);
            this.tabControl1.Controls.Add(this.tabPageQuestionList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 477);
            this.tabControl1.TabIndex = 2;
            // 
            // TestView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(969, 477);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestView";
            this.Text = "Tests";
            this.tabPageQuestionList.ResumeLayout(false);
            this.tabPageQuestionList.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.tabPageTestDetail.ResumeLayout(false);
            this.tabPageTestDetail.PerformLayout();
            this.tabPageTestList.ResumeLayout(false);
            this.tabPageTestList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageQuestionList;
        private System.Windows.Forms.TabPage tabPageTestDetail;
        private System.Windows.Forms.ComboBox cbbTeacherName;
        private System.Windows.Forms.Label lbTeacherName;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbRegist;
        private System.Windows.Forms.Label lbIntroduction;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbParticipant;
        private System.Windows.Forms.Label lbId;
        private FontAwesome.Sharp.IconButton btnQuestions;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private Controller.RoundTextBox txtDescription;
        private Resources.Components.RJDatePicker regist;
        private Controller.RoundTextBox txtName;
        private Controller.RoundTextBox txtPaticipant;
        private Controller.RoundTextBox txtId;
        private System.Windows.Forms.TabPage tabPageTestList;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.Panel panelLeft;
        private Controller.RoundButton btnPart7;
        private Controller.RoundButton btnPart6;
        private Controller.RoundButton btnPart5;
        private Controller.RoundButton btnPart4;
        private Controller.RoundButton btnPart3;
        private Controller.RoundButton btnPart2;
        private Controller.RoundButton btnPart1;
        private System.Windows.Forms.Panel panelBtn;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private FontAwesome.Sharp.IconButton btnFinish;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lbPart;
        private FontAwesome.Sharp.IconButton btnAddAudio;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPlay;
    }
}