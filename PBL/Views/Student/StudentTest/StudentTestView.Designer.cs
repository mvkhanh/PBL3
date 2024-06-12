using System.Drawing;

namespace PBL
{
    partial class StudentTestView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTestList = new System.Windows.Forms.TabPage();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageTestDetail = new System.Windows.Forms.TabPage();
            this.iconCheck = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbTestCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.numLimitTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbYes = new System.Windows.Forms.RadioButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnFullTest = new FontAwesome.Sharp.IconButton();
            this.btnPractice = new FontAwesome.Sharp.IconButton();
            this.cbPart7 = new System.Windows.Forms.CheckBox();
            this.cbPart6 = new System.Windows.Forms.CheckBox();
            this.cbPart5 = new System.Windows.Forms.CheckBox();
            this.cbPart4 = new System.Windows.Forms.CheckBox();
            this.cbPart3 = new System.Windows.Forms.CheckBox();
            this.cbPart2 = new System.Windows.Forms.CheckBox();
            this.cbPart1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTestName = new System.Windows.Forms.Label();
            this.tabPageTestResult = new System.Windows.Forms.TabPage();
            this.panelAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new RoundPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSearch = new PBL.Controller.RoundTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.roundPanel1 = new RoundPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.skip = new FontAwesome.Sharp.IconButton();
            this.lbSkip = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.wrong = new FontAwesome.Sharp.IconButton();
            this.lbWrongAnswer = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.greentick = new FontAwesome.Sharp.IconButton();
            this.lbRightAnswer = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.lbTestTime = new System.Windows.Forms.Label();
            this.tick = new FontAwesome.Sharp.IconButton();
            this.label30 = new System.Windows.Forms.Label();
            this.accuracy = new FontAwesome.Sharp.IconButton();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbScores = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.clock = new FontAwesome.Sharp.IconButton();
            this.btnBack2 = new FontAwesome.Sharp.IconButton();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPageTestList.SuspendLayout();
            this.tabPageTestDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageTestResult.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTestList);
            this.tabControl1.Controls.Add(this.tabPageTestDetail);
            this.tabControl1.Controls.Add(this.tabPageTestResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 467);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageTestList
            // 
            this.tabPageTestList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageTestList.Controls.Add(this.panelContent);
            this.tabPageTestList.Controls.Add(this.panelTop);
            this.tabPageTestList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPageTestList.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestList.Name = "tabPageTestList";
            this.tabPageTestList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestList.Size = new System.Drawing.Size(898, 438);
            this.tabPageTestList.TabIndex = 0;
            this.tabPageTestList.Text = "Test List";
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoSize = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 141);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(892, 294);
            this.panelContent.TabIndex = 66;
            // 
            // tabPageTestDetail
            // 
            this.tabPageTestDetail.AutoScroll = true;
            this.tabPageTestDetail.Controls.Add(this.groupBox2);
            this.tabPageTestDetail.Controls.Add(this.iconCheck);
            this.tabPageTestDetail.Controls.Add(this.iconPictureBox1);
            this.tabPageTestDetail.Controls.Add(this.lbTestCount);
            this.tabPageTestDetail.Controls.Add(this.label2);
            this.tabPageTestDetail.Controls.Add(this.lbMinutes);
            this.tabPageTestDetail.Controls.Add(this.numLimitTime);
            this.tabPageTestDetail.Controls.Add(this.groupBox1);
            this.tabPageTestDetail.Controls.Add(this.btnBack);
            this.tabPageTestDetail.Controls.Add(this.btnFullTest);
            this.tabPageTestDetail.Controls.Add(this.btnPractice);
            this.tabPageTestDetail.Controls.Add(this.label17);
            this.tabPageTestDetail.Controls.Add(this.lbTestName);
            this.tabPageTestDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestDetail.Name = "tabPageTestDetail";
            this.tabPageTestDetail.Size = new System.Drawing.Size(898, 438);
            this.tabPageTestDetail.TabIndex = 2;
            this.tabPageTestDetail.Text = "Test Detail";
            this.tabPageTestDetail.UseVisualStyleBackColor = true;
            // 
            // iconCheck
            // 
            this.iconCheck.BackColor = System.Drawing.Color.Transparent;
            this.iconCheck.ForeColor = System.Drawing.Color.Green;
            this.iconCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconCheck.IconColor = System.Drawing.Color.Green;
            this.iconCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCheck.Location = new System.Drawing.Point(477, 478);
            this.iconCheck.Name = "iconCheck";
            this.iconCheck.Size = new System.Drawing.Size(32, 32);
            this.iconCheck.TabIndex = 80;
            this.iconCheck.TabStop = false;
            this.iconCheck.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(89, 143);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 79;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbTestCount
            // 
            this.lbTestCount.AutoSize = true;
            this.lbTestCount.Location = new System.Drawing.Point(124, 151);
            this.lbTestCount.Name = "lbTestCount";
            this.lbTestCount.Size = new System.Drawing.Size(50, 16);
            this.lbTestCount.TabIndex = 78;
            this.lbTestCount.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "OR";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.Location = new System.Drawing.Point(148, 440);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(67, 18);
            this.lbMinutes.TabIndex = 76;
            this.lbMinutes.Text = "minutes";
            this.lbMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numLimitTime
            // 
            this.numLimitTime.Location = new System.Drawing.Point(89, 438);
            this.numLimitTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numLimitTime.Name = "numLimitTime";
            this.numLimitTime.Size = new System.Drawing.Size(56, 22);
            this.numLimitTime.TabIndex = 10;
            this.numLimitTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.cbYes);
            this.groupBox1.Location = new System.Drawing.Point(240, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 46);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Checked = true;
            this.cbYes.Location = new System.Drawing.Point(6, 20);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(52, 20);
            this.cbYes.TabIndex = 8;
            this.cbYes.TabStop = true;
            this.cbYes.Text = "Yes";
            this.cbYes.UseVisualStyleBackColor = true;
            this.cbYes.CheckedChanged += new System.EventHandler(this.cbYes_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 20;
            this.btnBack.Location = new System.Drawing.Point(8, 57);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 34);
            this.btnBack.TabIndex = 72;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFullTest
            // 
            this.btnFullTest.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnFullTest.FlatAppearance.BorderSize = 0;
            this.btnFullTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullTest.ForeColor = System.Drawing.Color.White;
            this.btnFullTest.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.btnFullTest.IconColor = System.Drawing.Color.White;
            this.btnFullTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFullTest.IconSize = 24;
            this.btnFullTest.Location = new System.Drawing.Point(314, 478);
            this.btnFullTest.Name = "btnFullTest";
            this.btnFullTest.Size = new System.Drawing.Size(156, 32);
            this.btnFullTest.TabIndex = 71;
            this.btnFullTest.Text = "Do full test!";
            this.btnFullTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFullTest.UseVisualStyleBackColor = false;
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPractice.FlatAppearance.BorderSize = 0;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.ForeColor = System.Drawing.Color.White;
            this.btnPractice.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.btnPractice.IconColor = System.Drawing.Color.White;
            this.btnPractice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPractice.IconSize = 24;
            this.btnPractice.Location = new System.Drawing.Point(89, 478);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(156, 32);
            this.btnPractice.TabIndex = 71;
            this.btnPractice.Text = "Start practice";
            this.btnPractice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPractice.UseVisualStyleBackColor = false;
            // 
            // cbPart7
            // 
            this.cbPart7.AutoSize = true;
            this.cbPart7.Location = new System.Drawing.Point(9, 175);
            this.cbPart7.Name = "cbPart7";
            this.cbPart7.Size = new System.Drawing.Size(66, 20);
            this.cbPart7.TabIndex = 7;
            this.cbPart7.Tag = "7";
            this.cbPart7.Text = "Part 7";
            this.cbPart7.UseVisualStyleBackColor = true;
            // 
            // cbPart6
            // 
            this.cbPart6.AutoSize = true;
            this.cbPart6.Location = new System.Drawing.Point(9, 149);
            this.cbPart6.Name = "cbPart6";
            this.cbPart6.Size = new System.Drawing.Size(66, 20);
            this.cbPart6.TabIndex = 6;
            this.cbPart6.Tag = "6";
            this.cbPart6.Text = "Part 6";
            this.cbPart6.UseVisualStyleBackColor = true;
            // 
            // cbPart5
            // 
            this.cbPart5.AutoSize = true;
            this.cbPart5.Location = new System.Drawing.Point(9, 123);
            this.cbPart5.Name = "cbPart5";
            this.cbPart5.Size = new System.Drawing.Size(66, 20);
            this.cbPart5.TabIndex = 5;
            this.cbPart5.Tag = "5";
            this.cbPart5.Text = "Part 5";
            this.cbPart5.UseVisualStyleBackColor = true;
            // 
            // cbPart4
            // 
            this.cbPart4.AutoSize = true;
            this.cbPart4.Location = new System.Drawing.Point(9, 97);
            this.cbPart4.Name = "cbPart4";
            this.cbPart4.Size = new System.Drawing.Size(66, 20);
            this.cbPart4.TabIndex = 4;
            this.cbPart4.Tag = "4";
            this.cbPart4.Text = "Part 4";
            this.cbPart4.UseVisualStyleBackColor = true;
            // 
            // cbPart3
            // 
            this.cbPart3.AutoSize = true;
            this.cbPart3.Location = new System.Drawing.Point(9, 71);
            this.cbPart3.Name = "cbPart3";
            this.cbPart3.Size = new System.Drawing.Size(66, 20);
            this.cbPart3.TabIndex = 3;
            this.cbPart3.Tag = "3";
            this.cbPart3.Text = "Part 3";
            this.cbPart3.UseVisualStyleBackColor = true;
            // 
            // cbPart2
            // 
            this.cbPart2.AutoSize = true;
            this.cbPart2.Location = new System.Drawing.Point(9, 45);
            this.cbPart2.Name = "cbPart2";
            this.cbPart2.Size = new System.Drawing.Size(66, 20);
            this.cbPart2.TabIndex = 2;
            this.cbPart2.Tag = "2";
            this.cbPart2.Text = "Part 2";
            this.cbPart2.UseVisualStyleBackColor = true;
            // 
            // cbPart1
            // 
            this.cbPart1.AutoSize = true;
            this.cbPart1.Location = new System.Drawing.Point(9, 19);
            this.cbPart1.Name = "cbPart1";
            this.cbPart1.Size = new System.Drawing.Size(66, 20);
            this.cbPart1.TabIndex = 1;
            this.cbPart1.Tag = "1";
            this.cbPart1.Text = "Part 1";
            this.cbPart1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 18);
            this.label16.TabIndex = 68;
            this.label16.Text = "Choose parts you want to practice";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(86, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 18);
            this.label17.TabIndex = 68;
            this.label17.Text = "Limit time to practice:";
            // 
            // lbTestName
            // 
            this.lbTestName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTestName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbTestName.Location = new System.Drawing.Point(0, 0);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(881, 60);
            this.lbTestName.TabIndex = 51;
            this.lbTestName.Text = "Practice Set TOEIC 2024 Test 1";
            this.lbTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageTestResult
            // 
            this.tabPageTestResult.AutoScroll = true;
            this.tabPageTestResult.Controls.Add(this.panelAnswers);
            this.tabPageTestResult.Controls.Add(this.roundPanel1);
            this.tabPageTestResult.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestResult.Name = "tabPageTestResult";
            this.tabPageTestResult.Size = new System.Drawing.Size(898, 438);
            this.tabPageTestResult.TabIndex = 3;
            this.tabPageTestResult.Text = "Test Result";
            this.tabPageTestResult.UseVisualStyleBackColor = true;
            // 
            // panelAnswers
            // 
            this.panelAnswers.AutoScroll = true;
            this.panelAnswers.AutoSize = true;
            this.panelAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswers.Location = new System.Drawing.Point(0, 292);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(898, 146);
            this.panelAnswers.TabIndex = 87;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label28);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.CornerRadius = 10;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(892, 138);
            this.panelTop.TabIndex = 65;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label28.Location = new System.Drawing.Point(16, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(168, 24);
            this.label28.TabIndex = 50;
            this.label28.Text = "Explore our tests";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Enter test name keyword";
            this.txtSearch.Size = new System.Drawing.Size(572, 31);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 24;
            this.btnSearch.Location = new System.Drawing.Point(599, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Controls.Add(this.panel6);
            this.roundPanel1.Controls.Add(this.panel4);
            this.roundPanel1.Controls.Add(this.panel2);
            this.roundPanel1.Controls.Add(this.panel1);
            this.roundPanel1.Controls.Add(this.btnBack2);
            this.roundPanel1.Controls.Add(this.label18);
            this.roundPanel1.CornerRadius = 10;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(898, 292);
            this.roundPanel1.TabIndex = 86;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.skip);
            this.panel6.Controls.Add(this.lbSkip);
            this.panel6.Controls.Add(this.label39);
            this.panel6.Controls.Add(this.label40);
            this.panel6.Location = new System.Drawing.Point(701, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 128);
            this.panel6.TabIndex = 89;
            // 
            // skip
            // 
            this.skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skip.AutoSize = true;
            this.skip.BackColor = System.Drawing.Color.White;
            this.skip.FlatAppearance.BorderSize = 0;
            this.skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip.ForeColor = System.Drawing.Color.Black;
            this.skip.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.skip.IconColor = System.Drawing.Color.Gray;
            this.skip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.skip.IconSize = 32;
            this.skip.Location = new System.Drawing.Point(42, 16);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(71, 38);
            this.skip.TabIndex = 75;
            this.skip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skip.UseVisualStyleBackColor = false;
            // 
            // lbSkip
            // 
            this.lbSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSkip.AutoSize = true;
            this.lbSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkip.ForeColor = System.Drawing.Color.Black;
            this.lbSkip.Location = new System.Drawing.Point(67, 78);
            this.lbSkip.Name = "lbSkip";
            this.lbSkip.Size = new System.Drawing.Size(15, 16);
            this.lbSkip.TabIndex = 70;
            this.lbSkip.Text = "0";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(43, 100);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(67, 16);
            this.label39.TabIndex = 70;
            this.label39.Text = "Questions";
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Gray;
            this.label40.Location = new System.Drawing.Point(60, 59);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 16);
            this.label40.TabIndex = 70;
            this.label40.Text = "Skip";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.wrong);
            this.panel4.Controls.Add(this.lbWrongAnswer);
            this.panel4.Controls.Add(this.label36);
            this.panel4.Controls.Add(this.label37);
            this.panel4.Location = new System.Drawing.Point(527, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 128);
            this.panel4.TabIndex = 88;
            // 
            // wrong
            // 
            this.wrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wrong.AutoSize = true;
            this.wrong.BackColor = System.Drawing.Color.White;
            this.wrong.FlatAppearance.BorderSize = 0;
            this.wrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrong.ForeColor = System.Drawing.Color.Black;
            this.wrong.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.wrong.IconColor = System.Drawing.Color.Crimson;
            this.wrong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.wrong.IconSize = 32;
            this.wrong.Location = new System.Drawing.Point(40, 16);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(74, 38);
            this.wrong.TabIndex = 75;
            this.wrong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wrong.UseVisualStyleBackColor = false;
            // 
            // lbWrongAnswer
            // 
            this.lbWrongAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWrongAnswer.AutoSize = true;
            this.lbWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrongAnswer.ForeColor = System.Drawing.Color.Black;
            this.lbWrongAnswer.Location = new System.Drawing.Point(61, 78);
            this.lbWrongAnswer.Name = "lbWrongAnswer";
            this.lbWrongAnswer.Size = new System.Drawing.Size(23, 16);
            this.lbWrongAnswer.TabIndex = 70;
            this.lbWrongAnswer.Text = "77";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(43, 100);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 16);
            this.label36.TabIndex = 70;
            this.label36.Text = "Questions";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Crimson;
            this.label37.Location = new System.Drawing.Point(31, 59);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(93, 16);
            this.label37.TabIndex = 70;
            this.label37.Text = "Wrong answer";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.greentick);
            this.panel2.Controls.Add(this.lbRightAnswer);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Location = new System.Drawing.Point(355, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 128);
            this.panel2.TabIndex = 87;
            // 
            // greentick
            // 
            this.greentick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.greentick.AutoSize = true;
            this.greentick.BackColor = System.Drawing.Color.White;
            this.greentick.FlatAppearance.BorderSize = 0;
            this.greentick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greentick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greentick.ForeColor = System.Drawing.Color.Black;
            this.greentick.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.greentick.IconColor = System.Drawing.Color.LimeGreen;
            this.greentick.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.greentick.IconSize = 32;
            this.greentick.Location = new System.Drawing.Point(40, 16);
            this.greentick.Name = "greentick";
            this.greentick.Size = new System.Drawing.Size(73, 38);
            this.greentick.TabIndex = 75;
            this.greentick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.greentick.UseVisualStyleBackColor = false;
            // 
            // lbRightAnswer
            // 
            this.lbRightAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRightAnswer.AutoSize = true;
            this.lbRightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightAnswer.ForeColor = System.Drawing.Color.Black;
            this.lbRightAnswer.Location = new System.Drawing.Point(61, 78);
            this.lbRightAnswer.Name = "lbRightAnswer";
            this.lbRightAnswer.Size = new System.Drawing.Size(31, 16);
            this.lbRightAnswer.TabIndex = 70;
            this.lbRightAnswer.Text = "123";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(45, 100);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 16);
            this.label34.TabIndex = 70;
            this.label34.Text = "Questions";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.LimeGreen;
            this.label32.Location = new System.Drawing.Point(37, 57);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(84, 16);
            this.label32.TabIndex = 70;
            this.label32.Text = "Right answer";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.lbTestTime);
            this.panel1.Controls.Add(this.tick);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.accuracy);
            this.panel1.Controls.Add(this.lbAccuracy);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lbScores);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.clock);
            this.panel1.Location = new System.Drawing.Point(26, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 160);
            this.panel1.TabIndex = 86;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(72, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 16);
            this.label25.TabIndex = 70;
            this.label25.Text = "Test results";
            // 
            // lbTestTime
            // 
            this.lbTestTime.AutoSize = true;
            this.lbTestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTime.ForeColor = System.Drawing.Color.Black;
            this.lbTestTime.Location = new System.Drawing.Point(179, 110);
            this.lbTestTime.Name = "lbTestTime";
            this.lbTestTime.Size = new System.Drawing.Size(63, 16);
            this.lbTestTime.TabIndex = 70;
            this.lbTestTime.Text = "01:11:23";
            // 
            // tick
            // 
            this.tick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tick.AutoSize = true;
            this.tick.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tick.FlatAppearance.BorderSize = 0;
            this.tick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tick.ForeColor = System.Drawing.Color.Black;
            this.tick.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.tick.IconColor = System.Drawing.Color.Black;
            this.tick.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tick.IconSize = 32;
            this.tick.Location = new System.Drawing.Point(18, 22);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(48, 46);
            this.tick.TabIndex = 69;
            this.tick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tick.UseVisualStyleBackColor = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(72, 110);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 16);
            this.label30.TabIndex = 70;
            this.label30.Text = "Completion time";
            // 
            // accuracy
            // 
            this.accuracy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accuracy.AutoSize = true;
            this.accuracy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accuracy.FlatAppearance.BorderSize = 0;
            this.accuracy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracy.ForeColor = System.Drawing.Color.Black;
            this.accuracy.IconChar = FontAwesome.Sharp.IconChar.Bullseye;
            this.accuracy.IconColor = System.Drawing.Color.Black;
            this.accuracy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accuracy.IconSize = 32;
            this.accuracy.Location = new System.Drawing.Point(18, 58);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(48, 46);
            this.accuracy.TabIndex = 69;
            this.accuracy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accuracy.UseVisualStyleBackColor = false;
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccuracy.ForeColor = System.Drawing.Color.Black;
            this.lbAccuracy.Location = new System.Drawing.Point(179, 73);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(52, 16);
            this.lbAccuracy.TabIndex = 70;
            this.lbAccuracy.Text = "61.5 %";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(216, 37);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 16);
            this.lbTotal.TabIndex = 70;
            this.lbTotal.Text = "123";
            // 
            // lbScores
            // 
            this.lbScores.AutoSize = true;
            this.lbScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScores.ForeColor = System.Drawing.Color.Black;
            this.lbScores.Location = new System.Drawing.Point(179, 37);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(31, 16);
            this.lbScores.TabIndex = 70;
            this.lbScores.Text = "123";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(72, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 16);
            this.label27.TabIndex = 70;
            this.label27.Text = "Accuracy";
            // 
            // clock
            // 
            this.clock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clock.AutoSize = true;
            this.clock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clock.FlatAppearance.BorderSize = 0;
            this.clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.Color.Black;
            this.clock.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.clock.IconColor = System.Drawing.Color.Black;
            this.clock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clock.IconSize = 32;
            this.clock.Location = new System.Drawing.Point(18, 95);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(48, 46);
            this.clock.TabIndex = 69;
            this.clock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clock.UseVisualStyleBackColor = false;
            // 
            // btnBack2
            // 
            this.btnBack2.AutoSize = true;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack2.IconColor = System.Drawing.Color.Black;
            this.btnBack2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack2.IconSize = 20;
            this.btnBack2.Location = new System.Drawing.Point(0, 0);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(76, 34);
            this.btnBack2.TabIndex = 85;
            this.btnBack2.Text = "Back";
            this.btnBack2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(898, 73);
            this.label18.TabIndex = 79;
            this.label18.Text = "Practice Results: Practice Set TOEIC 2024 Test 1";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbPart1);
            this.groupBox2.Controls.Add(this.cbPart2);
            this.groupBox2.Controls.Add(this.cbPart3);
            this.groupBox2.Controls.Add(this.cbPart4);
            this.groupBox2.Controls.Add(this.cbPart5);
            this.groupBox2.Controls.Add(this.cbPart6);
            this.groupBox2.Controls.Add(this.cbPart7);
            this.groupBox2.Location = new System.Drawing.Point(89, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 202);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // StudentTestView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentTestView";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.StudentTestView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTestList.ResumeLayout(false);
            this.tabPageTestList.PerformLayout();
            this.tabPageTestDetail.ResumeLayout(false);
            this.tabPageTestDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageTestResult.ResumeLayout(false);
            this.tabPageTestResult.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTestList;
        private System.Windows.Forms.TabPage tabPageTestDetail;
        private System.Windows.Forms.Label lbTestName;
        private System.Windows.Forms.CheckBox cbPart7;
        private System.Windows.Forms.CheckBox cbPart6;
        private System.Windows.Forms.CheckBox cbPart5;
        private System.Windows.Forms.CheckBox cbPart4;
        private System.Windows.Forms.CheckBox cbPart3;
        private System.Windows.Forms.CheckBox cbPart2;
        private System.Windows.Forms.CheckBox cbPart1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnPractice;
        private System.Windows.Forms.TabPage tabPageTestResult;
        private System.Windows.Forms.Label label18;
        private RoundPanel panelTop;
        private System.Windows.Forms.Label label28;
        private Controller.RoundTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.NumericUpDown numLimitTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton cbYes;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnFullTest;
        private System.Windows.Forms.Label lbTestCount;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnBack2;
        private System.Windows.Forms.FlowLayoutPanel panelAnswers;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton skip;
        private System.Windows.Forms.Label lbSkip;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton wrong;
        private System.Windows.Forms.Label lbWrongAnswer;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton greentick;
        private System.Windows.Forms.Label lbRightAnswer;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbTestTime;
        private FontAwesome.Sharp.IconButton tick;
        private System.Windows.Forms.Label label30;
        private FontAwesome.Sharp.IconButton accuracy;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbScores;
        private System.Windows.Forms.Label label27;
        private FontAwesome.Sharp.IconButton clock;
        private FontAwesome.Sharp.IconPictureBox iconCheck;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}