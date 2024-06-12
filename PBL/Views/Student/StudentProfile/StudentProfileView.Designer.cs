namespace PBL
{
    partial class StudentProfileView
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
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.btnEditProfile5 = new FontAwesome.Sharp.IconButton();
            this.btnChangePassword5 = new FontAwesome.Sharp.IconButton();
            this.roundPanelAvatar = new RoundPanel();
            this.btnAvatar = new FontAwesome.Sharp.IconButton();
            this.lbStudentEmail = new System.Windows.Forms.Label();
            this.roundPanel1 = new RoundPanel();
            this.btnChangePassword = new FontAwesome.Sharp.IconButton();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.lbStudentBirth = new System.Windows.Forms.Label();
            this.lbStudentPhone = new System.Windows.Forms.Label();
            this.lbStudentScores = new System.Windows.Forms.Label();
            this.lbStudentTests = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birthIcon = new FontAwesome.Sharp.IconButton();
            this.phone = new FontAwesome.Sharp.IconButton();
            this.btnEditProfile = new FontAwesome.Sharp.IconButton();
            this.education = new FontAwesome.Sharp.IconButton();
            this.lbMail = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.tabPageChangePassword = new System.Windows.Forms.TabPage();
            this.btnSaveChangePass = new FontAwesome.Sharp.IconButton();
            this.lbNewPassAgain = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbCurrentPass = new System.Windows.Forms.Label();
            this.btnCancelChangePass = new FontAwesome.Sharp.IconButton();
            this.txtNewPassAgain = new PBL.Controller.RoundTextBox();
            this.txtCurrentPass = new PBL.Controller.RoundTextBox();
            this.txtNewPass = new PBL.Controller.RoundTextBox();
            this.tabPageEditProfile = new System.Windows.Forms.TabPage();
            this.btnChangePassword3 = new FontAwesome.Sharp.IconButton();
            this.btnCancelEdit = new FontAwesome.Sharp.IconButton();
            this.btnSaveEdit = new FontAwesome.Sharp.IconButton();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.editBirth = new PBL.Resources.Components.RJDatePicker();
            this.txtStudentPhone = new PBL.Controller.RoundTextBox();
            this.txtStudentEmail = new PBL.Controller.RoundTextBox();
            this.txtStudentName = new PBL.Controller.RoundTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.roundPanelAvatar.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.tabPageChangePassword.SuspendLayout();
            this.tabPageEditProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProfile);
            this.tabControl1.Controls.Add(this.tabPageChangePassword);
            this.tabControl1.Controls.Add(this.tabPageEditProfile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1235, 706);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.btnEditProfile5);
            this.tabPageProfile.Controls.Add(this.btnChangePassword5);
            this.tabPageProfile.Controls.Add(this.roundPanelAvatar);
            this.tabPageProfile.Controls.Add(this.lbStudentEmail);
            this.tabPageProfile.Controls.Add(this.roundPanel1);
            this.tabPageProfile.Controls.Add(this.lbStudentBirth);
            this.tabPageProfile.Controls.Add(this.lbStudentPhone);
            this.tabPageProfile.Controls.Add(this.lbStudentScores);
            this.tabPageProfile.Controls.Add(this.lbStudentTests);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Controls.Add(this.birthIcon);
            this.tabPageProfile.Controls.Add(this.phone);
            this.tabPageProfile.Controls.Add(this.btnEditProfile);
            this.tabPageProfile.Controls.Add(this.education);
            this.tabPageProfile.Controls.Add(this.lbMail);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.lbStudentName);
            this.tabPageProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProfile.ForeColor = System.Drawing.Color.Maroon;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 25);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(1227, 677);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile5
            // 
            this.btnEditProfile5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditProfile5.AutoSize = true;
            this.btnEditProfile5.BackColor = System.Drawing.Color.Green;
            this.btnEditProfile5.FlatAppearance.BorderSize = 0;
            this.btnEditProfile5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile5.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile5.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditProfile5.IconColor = System.Drawing.Color.White;
            this.btnEditProfile5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProfile5.IconSize = 30;
            this.btnEditProfile5.Location = new System.Drawing.Point(329, 561);
            this.btnEditProfile5.Name = "btnEditProfile5";
            this.btnEditProfile5.Size = new System.Drawing.Size(229, 46);
            this.btnEditProfile5.TabIndex = 87;
            this.btnEditProfile5.Text = "   Edit Profile";
            this.btnEditProfile5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProfile5.UseVisualStyleBackColor = false;
            this.btnEditProfile5.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnChangePassword5
            // 
            this.btnChangePassword5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangePassword5.AutoSize = true;
            this.btnChangePassword5.BackColor = System.Drawing.Color.Orange;
            this.btnChangePassword5.FlatAppearance.BorderSize = 0;
            this.btnChangePassword5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword5.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword5.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePassword5.IconColor = System.Drawing.Color.White;
            this.btnChangePassword5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword5.IconSize = 30;
            this.btnChangePassword5.Location = new System.Drawing.Point(654, 561);
            this.btnChangePassword5.Name = "btnChangePassword5";
            this.btnChangePassword5.Size = new System.Drawing.Size(229, 46);
            this.btnChangePassword5.TabIndex = 87;
            this.btnChangePassword5.Text = "Change Password";
            this.btnChangePassword5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword5.UseVisualStyleBackColor = false;
            this.btnChangePassword5.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // roundPanelAvatar
            // 
            this.roundPanelAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanelAvatar.Controls.Add(this.btnAvatar);
            this.roundPanelAvatar.CornerRadius = 100;
            this.roundPanelAvatar.Location = new System.Drawing.Point(504, 85);
            this.roundPanelAvatar.Name = "roundPanelAvatar";
            this.roundPanelAvatar.Size = new System.Drawing.Size(200, 200);
            this.roundPanelAvatar.TabIndex = 72;
            // 
            // btnAvatar
            // 
            this.btnAvatar.AutoSize = true;
            this.btnAvatar.BackColor = System.Drawing.Color.Thistle;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatar.ForeColor = System.Drawing.Color.White;
            this.btnAvatar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAvatar.IconColor = System.Drawing.Color.White;
            this.btnAvatar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnAvatar.IconSize = 100;
            this.btnAvatar.Location = new System.Drawing.Point(0, 0);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(200, 200);
            this.btnAvatar.TabIndex = 71;
            this.btnAvatar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvatar.UseVisualStyleBackColor = false;
            // 
            // lbStudentEmail
            // 
            this.lbStudentEmail.AutoSize = true;
            this.lbStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbStudentEmail.Location = new System.Drawing.Point(309, 383);
            this.lbStudentEmail.Name = "lbStudentEmail";
            this.lbStudentEmail.Size = new System.Drawing.Size(70, 25);
            this.lbStudentEmail.TabIndex = 79;
            this.lbStudentEmail.Text = "Email";
            // 
            // roundPanel1
            // 
            this.roundPanel1.Controls.Add(this.btnChangePassword);
            this.roundPanel1.Controls.Add(this.pictureBoxBackground);
            this.roundPanel1.CornerRadius = 15;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundPanel1.Location = new System.Drawing.Point(3, 3);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(1221, 178);
            this.roundPanel1.TabIndex = 84;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.BackColor = System.Drawing.Color.MediumPurple;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePassword.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword.IconSize = 40;
            this.btnChangePassword.Location = new System.Drawing.Point(1147, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(81, 66);
            this.btnChangePassword.TabIndex = 68;
            this.btnChangePassword.Text = " ";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1221, 178);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 64;
            this.pictureBoxBackground.TabStop = false;
            // 
            // lbStudentBirth
            // 
            this.lbStudentBirth.AutoSize = true;
            this.lbStudentBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentBirth.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbStudentBirth.Location = new System.Drawing.Point(309, 517);
            this.lbStudentBirth.Name = "lbStudentBirth";
            this.lbStudentBirth.Size = new System.Drawing.Size(99, 25);
            this.lbStudentBirth.TabIndex = 81;
            this.lbStudentBirth.Text = "Birthday";
            // 
            // lbStudentPhone
            // 
            this.lbStudentPhone.AutoSize = true;
            this.lbStudentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentPhone.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbStudentPhone.Location = new System.Drawing.Point(309, 452);
            this.lbStudentPhone.Name = "lbStudentPhone";
            this.lbStudentPhone.Size = new System.Drawing.Size(79, 25);
            this.lbStudentPhone.TabIndex = 80;
            this.lbStudentPhone.Text = "Phone";
            // 
            // lbStudentScores
            // 
            this.lbStudentScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStudentScores.AutoSize = true;
            this.lbStudentScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentScores.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbStudentScores.Location = new System.Drawing.Point(976, 521);
            this.lbStudentScores.Name = "lbStudentScores";
            this.lbStudentScores.Size = new System.Drawing.Size(51, 25);
            this.lbStudentScores.TabIndex = 78;
            this.lbStudentScores.Text = "123";
            // 
            // lbStudentTests
            // 
            this.lbStudentTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStudentTests.AutoSize = true;
            this.lbStudentTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentTests.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbStudentTests.Location = new System.Drawing.Point(930, 455);
            this.lbStudentTests.Name = "lbStudentTests";
            this.lbStudentTests.Size = new System.Drawing.Size(51, 25);
            this.lbStudentTests.TabIndex = 77;
            this.lbStudentTests.Text = "123";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(772, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "Average score:";
            // 
            // birthIcon
            // 
            this.birthIcon.AutoSize = true;
            this.birthIcon.BackColor = System.Drawing.Color.White;
            this.birthIcon.FlatAppearance.BorderSize = 0;
            this.birthIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birthIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthIcon.ForeColor = System.Drawing.Color.Transparent;
            this.birthIcon.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            this.birthIcon.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.birthIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.birthIcon.IconSize = 40;
            this.birthIcon.Location = new System.Drawing.Point(237, 498);
            this.birthIcon.Name = "birthIcon";
            this.birthIcon.Size = new System.Drawing.Size(66, 66);
            this.birthIcon.TabIndex = 65;
            this.birthIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.birthIcon.UseVisualStyleBackColor = false;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.White;
            this.phone.FlatAppearance.BorderSize = 0;
            this.phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.Black;
            this.phone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.phone.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.phone.IconSize = 40;
            this.phone.Location = new System.Drawing.Point(237, 435);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(66, 66);
            this.phone.TabIndex = 66;
            this.phone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phone.UseVisualStyleBackColor = false;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditProfile.AutoSize = true;
            this.btnEditProfile.BackColor = System.Drawing.Color.White;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.Black;
            this.btnEditProfile.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditProfile.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProfile.IconSize = 40;
            this.btnEditProfile.Location = new System.Drawing.Point(682, 216);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(66, 66);
            this.btnEditProfile.TabIndex = 68;
            this.btnEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // education
            // 
            this.education.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.education.AutoSize = true;
            this.education.BackColor = System.Drawing.Color.White;
            this.education.FlatAppearance.BorderSize = 0;
            this.education.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.education.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.education.ForeColor = System.Drawing.Color.LimeGreen;
            this.education.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.education.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.education.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.education.IconSize = 40;
            this.education.Location = new System.Drawing.Point(762, 364);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(66, 66);
            this.education.TabIndex = 68;
            this.education.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.education.UseVisualStyleBackColor = false;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.BackColor = System.Drawing.Color.White;
            this.lbMail.FlatAppearance.BorderSize = 0;
            this.lbMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.Black;
            this.lbMail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.lbMail.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.lbMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbMail.IconSize = 40;
            this.lbMail.Location = new System.Drawing.Point(237, 368);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(66, 66);
            this.lbMail.TabIndex = 69;
            this.lbMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbMail.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(772, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "Tests done:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(834, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Achivement";
            // 
            // lbStudentName
            // 
            this.lbStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbStudentName.Location = new System.Drawing.Point(488, 302);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(205, 29);
            this.lbStudentName.TabIndex = 63;
            this.lbStudentName.Text = "Nguyen Viet Huy";
            // 
            // tabPageChangePassword
            // 
            this.tabPageChangePassword.Controls.Add(this.btnSaveChangePass);
            this.tabPageChangePassword.Controls.Add(this.lbNewPassAgain);
            this.tabPageChangePassword.Controls.Add(this.lbNewPass);
            this.tabPageChangePassword.Controls.Add(this.lbCurrentPass);
            this.tabPageChangePassword.Controls.Add(this.btnCancelChangePass);
            this.tabPageChangePassword.Controls.Add(this.txtNewPassAgain);
            this.tabPageChangePassword.Controls.Add(this.txtCurrentPass);
            this.tabPageChangePassword.Controls.Add(this.txtNewPass);
            this.tabPageChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageChangePassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPageChangePassword.Location = new System.Drawing.Point(4, 25);
            this.tabPageChangePassword.Name = "tabPageChangePassword";
            this.tabPageChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangePassword.Size = new System.Drawing.Size(1227, 677);
            this.tabPageChangePassword.TabIndex = 1;
            this.tabPageChangePassword.Text = "Change password";
            this.tabPageChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnSaveChangePass
            // 
            this.btnSaveChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChangePass.AutoSize = true;
            this.btnSaveChangePass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSaveChangePass.FlatAppearance.BorderSize = 0;
            this.btnSaveChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChangePass.ForeColor = System.Drawing.Color.White;
            this.btnSaveChangePass.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnSaveChangePass.IconColor = System.Drawing.Color.White;
            this.btnSaveChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveChangePass.IconSize = 30;
            this.btnSaveChangePass.Location = new System.Drawing.Point(334, 493);
            this.btnSaveChangePass.Name = "btnSaveChangePass";
            this.btnSaveChangePass.Size = new System.Drawing.Size(111, 46);
            this.btnSaveChangePass.TabIndex = 8;
            this.btnSaveChangePass.Text = " Save";
            this.btnSaveChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChangePass.UseVisualStyleBackColor = false;
            // 
            // lbNewPassAgain
            // 
            this.lbNewPassAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNewPassAgain.AutoSize = true;
            this.lbNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassAgain.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbNewPassAgain.Location = new System.Drawing.Point(385, 326);
            this.lbNewPassAgain.Name = "lbNewPassAgain";
            this.lbNewPassAgain.Size = new System.Drawing.Size(195, 24);
            this.lbNewPassAgain.TabIndex = 4;
            this.lbNewPassAgain.Text = "New Password Again:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbNewPass.Location = new System.Drawing.Point(387, 232);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(141, 24);
            this.lbNewPass.TabIndex = 4;
            this.lbNewPass.Text = "New Password:";
            // 
            // lbCurrentPass
            // 
            this.lbCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCurrentPass.AutoSize = true;
            this.lbCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbCurrentPass.Location = new System.Drawing.Point(384, 146);
            this.lbCurrentPass.Name = "lbCurrentPass";
            this.lbCurrentPass.Size = new System.Drawing.Size(164, 24);
            this.lbCurrentPass.TabIndex = 2;
            this.lbCurrentPass.Text = "Current Password:";
            // 
            // btnCancelChangePass
            // 
            this.btnCancelChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelChangePass.AutoSize = true;
            this.btnCancelChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnCancelChangePass.FlatAppearance.BorderSize = 0;
            this.btnCancelChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChangePass.ForeColor = System.Drawing.Color.White;
            this.btnCancelChangePass.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancelChangePass.IconColor = System.Drawing.Color.White;
            this.btnCancelChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelChangePass.IconSize = 30;
            this.btnCancelChangePass.Location = new System.Drawing.Point(730, 493);
            this.btnCancelChangePass.Name = "btnCancelChangePass";
            this.btnCancelChangePass.Size = new System.Drawing.Size(111, 46);
            this.btnCancelChangePass.TabIndex = 9;
            this.btnCancelChangePass.Text = "Cancel";
            this.btnCancelChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelChangePass.UseVisualStyleBackColor = false;
            // 
            // txtNewPassAgain
            // 
            this.txtNewPassAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPassAgain.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPassAgain.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewPassAgain.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPassAgain.BorderRadius = 0;
            this.txtNewPassAgain.BorderSize = 2;
            this.txtNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassAgain.Location = new System.Drawing.Point(391, 354);
            this.txtNewPassAgain.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassAgain.Multiline = false;
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPassAgain.PasswordChar = true;
            this.txtNewPassAgain.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassAgain.PlaceholderText = "";
            this.txtNewPassAgain.Size = new System.Drawing.Size(405, 39);
            this.txtNewPassAgain.TabIndex = 5;
            this.txtNewPassAgain.Texts = "";
            this.txtNewPassAgain.UnderlinedStyle = false;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCurrentPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCurrentPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCurrentPass.BorderRadius = 0;
            this.txtCurrentPass.BorderSize = 2;
            this.txtCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentPass.Location = new System.Drawing.Point(389, 174);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPass.Multiline = false;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCurrentPass.PasswordChar = true;
            this.txtCurrentPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPass.PlaceholderText = "";
            this.txtCurrentPass.Size = new System.Drawing.Size(405, 39);
            this.txtCurrentPass.TabIndex = 3;
            this.txtCurrentPass.Texts = "";
            this.txtCurrentPass.UnderlinedStyle = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPass.BorderRadius = 0;
            this.txtNewPass.BorderSize = 2;
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.Location = new System.Drawing.Point(391, 260);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass.PasswordChar = true;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass.PlaceholderText = "";
            this.txtNewPass.Size = new System.Drawing.Size(405, 39);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.Texts = "";
            this.txtNewPass.UnderlinedStyle = false;
            // 
            // tabPageEditProfile
            // 
            this.tabPageEditProfile.Controls.Add(this.btnChangePassword3);
            this.tabPageEditProfile.Controls.Add(this.btnCancelEdit);
            this.tabPageEditProfile.Controls.Add(this.btnSaveEdit);
            this.tabPageEditProfile.Controls.Add(this.lbName);
            this.tabPageEditProfile.Controls.Add(this.lbBirth);
            this.tabPageEditProfile.Controls.Add(this.lbPhone);
            this.tabPageEditProfile.Controls.Add(this.lbEmail);
            this.tabPageEditProfile.Controls.Add(this.editBirth);
            this.tabPageEditProfile.Controls.Add(this.txtStudentPhone);
            this.tabPageEditProfile.Controls.Add(this.txtStudentEmail);
            this.tabPageEditProfile.Controls.Add(this.txtStudentName);
            this.tabPageEditProfile.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditProfile.Name = "tabPageEditProfile";
            this.tabPageEditProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditProfile.Size = new System.Drawing.Size(1227, 657);
            this.tabPageEditProfile.TabIndex = 2;
            this.tabPageEditProfile.Text = "Edit profile";
            this.tabPageEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword3
            // 
            this.btnChangePassword3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword3.AutoSize = true;
            this.btnChangePassword3.BackColor = System.Drawing.Color.Orange;
            this.btnChangePassword3.FlatAppearance.BorderSize = 0;
            this.btnChangePassword3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword3.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword3.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePassword3.IconColor = System.Drawing.Color.White;
            this.btnChangePassword3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword3.IconSize = 30;
            this.btnChangePassword3.Location = new System.Drawing.Point(246, 480);
            this.btnChangePassword3.Name = "btnChangePassword3";
            this.btnChangePassword3.Size = new System.Drawing.Size(206, 46);
            this.btnChangePassword3.TabIndex = 86;
            this.btnChangePassword3.Text = "Change Password";
            this.btnChangePassword3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword3.UseVisualStyleBackColor = false;
            this.btnChangePassword3.Click += new System.EventHandler(this.btnChangePassword2_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelEdit.AutoSize = true;
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancelEdit.IconColor = System.Drawing.Color.White;
            this.btnCancelEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelEdit.IconSize = 30;
            this.btnCancelEdit.Location = new System.Drawing.Point(785, 480);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(206, 46);
            this.btnCancelEdit.TabIndex = 86;
            this.btnCancelEdit.Text = "     Cancel";
            this.btnCancelEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveEdit.AutoSize = true;
            this.btnSaveEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnSaveEdit.IconColor = System.Drawing.Color.White;
            this.btnSaveEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveEdit.IconSize = 30;
            this.btnSaveEdit.Location = new System.Drawing.Point(512, 480);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(206, 46);
            this.btnSaveEdit.TabIndex = 85;
            this.btnSaveEdit.Text = "      Save";
            this.btnSaveEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbName.Location = new System.Drawing.Point(336, 108);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 24);
            this.lbName.TabIndex = 84;
            this.lbName.Text = "Name:";
            // 
            // lbBirth
            // 
            this.lbBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbBirth.Location = new System.Drawing.Point(337, 374);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(82, 24);
            this.lbBirth.TabIndex = 83;
            this.lbBirth.Text = "Birthday:";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbPhone.Location = new System.Drawing.Point(337, 288);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(142, 24);
            this.lbPhone.TabIndex = 82;
            this.lbPhone.Text = "Phone number:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbEmail.Location = new System.Drawing.Point(338, 198);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 24);
            this.lbEmail.TabIndex = 81;
            this.lbEmail.Text = "Email:";
            // 
            // editBirth
            // 
            this.editBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editBirth.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editBirth.BorderSize = 0;
            this.editBirth.CustomFormat = "";
            this.editBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBirth.Location = new System.Drawing.Point(340, 401);
            this.editBirth.MinimumSize = new System.Drawing.Size(0, 35);
            this.editBirth.Name = "editBirth";
            this.editBirth.Size = new System.Drawing.Size(294, 35);
            this.editBirth.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.editBirth.TabIndex = 79;
            this.editBirth.TextColor = System.Drawing.Color.White;
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStudentPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStudentPhone.BorderRadius = 0;
            this.txtStudentPhone.BorderSize = 2;
            this.txtStudentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentPhone.Location = new System.Drawing.Point(340, 316);
            this.txtStudentPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentPhone.Multiline = false;
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Padding = new System.Windows.Forms.Padding(10);
            this.txtStudentPhone.PasswordChar = false;
            this.txtStudentPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStudentPhone.PlaceholderText = "";
            this.txtStudentPhone.Size = new System.Drawing.Size(555, 45);
            this.txtStudentPhone.TabIndex = 76;
            this.txtStudentPhone.Texts = "";
            this.txtStudentPhone.UnderlinedStyle = false;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStudentEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStudentEmail.BorderRadius = 0;
            this.txtStudentEmail.BorderSize = 2;
            this.txtStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentEmail.Location = new System.Drawing.Point(341, 226);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentEmail.Multiline = false;
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Padding = new System.Windows.Forms.Padding(10);
            this.txtStudentEmail.PasswordChar = false;
            this.txtStudentEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStudentEmail.PlaceholderText = "";
            this.txtStudentEmail.Size = new System.Drawing.Size(555, 45);
            this.txtStudentEmail.TabIndex = 75;
            this.txtStudentEmail.Texts = "";
            this.txtStudentEmail.UnderlinedStyle = false;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStudentName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStudentName.BorderRadius = 0;
            this.txtStudentName.BorderSize = 2;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentName.Location = new System.Drawing.Point(340, 136);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Multiline = false;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Padding = new System.Windows.Forms.Padding(10);
            this.txtStudentName.PasswordChar = false;
            this.txtStudentName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStudentName.PlaceholderText = "";
            this.txtStudentName.Size = new System.Drawing.Size(555, 45);
            this.txtStudentName.TabIndex = 74;
            this.txtStudentName.Texts = "";
            this.txtStudentName.UnderlinedStyle = false;
            // 
            // StudentProfileView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1235, 706);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentProfileView";
            this.Text = "Profile";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.roundPanelAvatar.ResumeLayout(false);
            this.roundPanelAvatar.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.tabPageChangePassword.ResumeLayout(false);
            this.tabPageChangePassword.PerformLayout();
            this.tabPageEditProfile.ResumeLayout(false);
            this.tabPageEditProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageChangePassword;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbCurrentPass;
        private FontAwesome.Sharp.IconButton btnSaveChangePass;
        private FontAwesome.Sharp.IconButton btnCancelChangePass;
        private System.Windows.Forms.Label lbNewPassAgain;
        private Controller.RoundTextBox txtNewPass;
        private Controller.RoundTextBox txtNewPassAgain;
        private Controller.RoundTextBox txtCurrentPass;
        private FontAwesome.Sharp.IconButton birthIcon;
        private FontAwesome.Sharp.IconButton phone;
        private FontAwesome.Sharp.IconButton education;
        private FontAwesome.Sharp.IconButton lbMail;//
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStudentName;
        private RoundPanel roundPanelAvatar;
        private System.Windows.Forms.Label lbStudentScores;
        private System.Windows.Forms.Label lbStudentTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStudentBirth;
        private System.Windows.Forms.Label lbStudentPhone;
        private System.Windows.Forms.Label lbStudentEmail;
        private System.Windows.Forms.TabPage tabPageEditProfile;
        private Controller.RoundTextBox txtStudentName;
        private Controller.RoundTextBox txtStudentPhone;
        private Controller.RoundTextBox txtStudentEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private Resources.Components.RJDatePicker editBirth;
        private FontAwesome.Sharp.IconButton btnCancelEdit;
        private FontAwesome.Sharp.IconButton btnSaveEdit;
        private FontAwesome.Sharp.IconButton btnChangePassword3;
        private FontAwesome.Sharp.IconButton btnAvatar;
        private FontAwesome.Sharp.IconButton btnChangePassword;
        private FontAwesome.Sharp.IconButton btnEditProfile;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private FontAwesome.Sharp.IconButton btnChangePassword5;
        private FontAwesome.Sharp.IconButton btnEditProfile5;
    }
}