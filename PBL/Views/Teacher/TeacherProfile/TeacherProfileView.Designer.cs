namespace PBL.Views.Teacher.TeacherProfile
{
    partial class TeacherProfileView
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
            this.btnChangePassword = new FontAwesome.Sharp.IconButton();
            this.btnEditProfile = new FontAwesome.Sharp.IconButton();
            this.lbTeacherBirth = new System.Windows.Forms.Label();
            this.lbTeacherPhone = new System.Windows.Forms.Label();
            this.lbTeacherEmail = new System.Windows.Forms.Label();
            this.lbTeacherTest = new System.Windows.Forms.Label();
            this.lbTeacherLesson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanelAvatar = new RoundPanel();
            this.btnAvatar = new FontAwesome.Sharp.IconButton();
            this.birthIcon = new FontAwesome.Sharp.IconButton();
            this.phone = new FontAwesome.Sharp.IconButton();
            this.pass = new FontAwesome.Sharp.IconButton();
            this.education = new FontAwesome.Sharp.IconButton();
            this.lbMail = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.tabPageChangePassword = new System.Windows.Forms.TabPage();
            this.txtNewPassAgain = new PBL.Controller.RoundTextBox();
            this.txtCurrentPass = new PBL.Controller.RoundTextBox();
            this.txtNewPass = new PBL.Controller.RoundTextBox();
            this.lbNewPassAgain = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbCurrentPass = new System.Windows.Forms.Label();
            this.btnCancelChangePass = new FontAwesome.Sharp.IconButton();
            this.btnSaveChangePass = new FontAwesome.Sharp.IconButton();
            this.tabPageEditProfile = new System.Windows.Forms.TabPage();
            this.btnCancelEdit = new FontAwesome.Sharp.IconButton();
            this.btnSaveEdit = new FontAwesome.Sharp.IconButton();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.editBirth = new PBL.Resources.Components.RJDatePicker();
            this.btnChangePassword2 = new FontAwesome.Sharp.IconButton();
            this.txtTeacherPhone = new PBL.Controller.RoundTextBox();
            this.txtTeacherEmail = new PBL.Controller.RoundTextBox();
            this.txtTeacherName = new PBL.Controller.RoundTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.roundPanelAvatar.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(906, 467);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.btnChangePassword);
            this.tabPageProfile.Controls.Add(this.btnEditProfile);
            this.tabPageProfile.Controls.Add(this.lbTeacherBirth);
            this.tabPageProfile.Controls.Add(this.lbTeacherPhone);
            this.tabPageProfile.Controls.Add(this.lbTeacherEmail);
            this.tabPageProfile.Controls.Add(this.lbTeacherTest);
            this.tabPageProfile.Controls.Add(this.lbTeacherLesson);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Controls.Add(this.roundPanelAvatar);
            this.tabPageProfile.Controls.Add(this.birthIcon);
            this.tabPageProfile.Controls.Add(this.phone);
            this.tabPageProfile.Controls.Add(this.pass);
            this.tabPageProfile.Controls.Add(this.education);
            this.tabPageProfile.Controls.Add(this.lbMail);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.lbTeacherName);
            this.tabPageProfile.Controls.Add(this.pictureBoxBackground);
            this.tabPageProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProfile.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 25);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(898, 438);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChangePassword.IconColor = System.Drawing.Color.Black;
            this.btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword.Location = new System.Drawing.Point(712, 345);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(163, 23);
            this.btnChangePassword.TabIndex = 83;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditProfile.IconColor = System.Drawing.Color.Black;
            this.btnEditProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProfile.Location = new System.Drawing.Point(712, 297);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(113, 23);
            this.btnEditProfile.TabIndex = 82;
            this.btnEditProfile.Text = "Edit profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lbTeacherBirth
            // 
            this.lbTeacherBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeacherBirth.AutoSize = true;
            this.lbTeacherBirth.Location = new System.Drawing.Point(129, 380);
            this.lbTeacherBirth.Name = "lbTeacherBirth";
            this.lbTeacherBirth.Size = new System.Drawing.Size(69, 18);
            this.lbTeacherBirth.TabIndex = 81;
            this.lbTeacherBirth.Text = "Birthday";
            // 
            // lbTeacherPhone
            // 
            this.lbTeacherPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeacherPhone.AutoSize = true;
            this.lbTeacherPhone.Location = new System.Drawing.Point(129, 335);
            this.lbTeacherPhone.Name = "lbTeacherPhone";
            this.lbTeacherPhone.Size = new System.Drawing.Size(56, 18);
            this.lbTeacherPhone.TabIndex = 80;
            this.lbTeacherPhone.Text = "Phone";
            // 
            // lbTeacherEmail
            // 
            this.lbTeacherEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeacherEmail.AutoSize = true;
            this.lbTeacherEmail.Location = new System.Drawing.Point(129, 287);
            this.lbTeacherEmail.Name = "lbTeacherEmail";
            this.lbTeacherEmail.Size = new System.Drawing.Size(50, 18);
            this.lbTeacherEmail.TabIndex = 79;
            this.lbTeacherEmail.Text = "Email";
            // 
            // lbTeacherTest
            // 
            this.lbTeacherTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeacherTest.AutoSize = true;
            this.lbTeacherTest.Location = new System.Drawing.Point(562, 363);
            this.lbTeacherTest.Name = "lbTeacherTest";
            this.lbTeacherTest.Size = new System.Drawing.Size(52, 18);
            this.lbTeacherTest.TabIndex = 78;
            this.lbTeacherTest.Text = "label2";
            // 
            // lbTeacherLesson
            // 
            this.lbTeacherLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeacherLesson.AutoSize = true;
            this.lbTeacherLesson.Location = new System.Drawing.Point(569, 335);
            this.lbTeacherLesson.Name = "lbTeacherLesson";
            this.lbTeacherLesson.Size = new System.Drawing.Size(52, 18);
            this.lbTeacherLesson.TabIndex = 77;
            this.lbTeacherLesson.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(485, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Total Test:";
            // 
            // roundPanelAvatar
            // 
            this.roundPanelAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanelAvatar.Controls.Add(this.btnAvatar);
            this.roundPanelAvatar.CornerRadius = 54;
            this.roundPanelAvatar.Location = new System.Drawing.Point(385, 116);
            this.roundPanelAvatar.Name = "roundPanelAvatar";
            this.roundPanelAvatar.Size = new System.Drawing.Size(111, 110);
            this.roundPanelAvatar.TabIndex = 72;
            // 
            // btnAvatar
            // 
            this.btnAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvatar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatar.ForeColor = System.Drawing.Color.White;
            this.btnAvatar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAvatar.IconColor = System.Drawing.Color.White;
            this.btnAvatar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnAvatar.IconSize = 50;
            this.btnAvatar.Location = new System.Drawing.Point(0, 0);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(111, 110);
            this.btnAvatar.TabIndex = 71;
            this.btnAvatar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvatar.UseVisualStyleBackColor = false;
            // 
            // birthIcon
            // 
            this.birthIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birthIcon.AutoSize = true;
            this.birthIcon.BackColor = System.Drawing.Color.White;
            this.birthIcon.FlatAppearance.BorderSize = 0;
            this.birthIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birthIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthIcon.ForeColor = System.Drawing.Color.Transparent;
            this.birthIcon.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            this.birthIcon.IconColor = System.Drawing.Color.Black;
            this.birthIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.birthIcon.IconSize = 32;
            this.birthIcon.Location = new System.Drawing.Point(75, 367);
            this.birthIcon.Name = "birthIcon";
            this.birthIcon.Size = new System.Drawing.Size(48, 46);
            this.birthIcon.TabIndex = 65;
            this.birthIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.birthIcon.UseVisualStyleBackColor = false;
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.White;
            this.phone.FlatAppearance.BorderSize = 0;
            this.phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.Black;
            this.phone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.phone.IconColor = System.Drawing.Color.Black;
            this.phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.phone.IconSize = 32;
            this.phone.Location = new System.Drawing.Point(75, 322);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(48, 46);
            this.phone.TabIndex = 66;
            this.phone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phone.UseVisualStyleBackColor = false;
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.FlatAppearance.BorderSize = 0;
            this.pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.pass.IconColor = System.Drawing.Color.Black;
            this.pass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pass.IconSize = 32;
            this.pass.Location = new System.Drawing.Point(502, 179);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(38, 38);
            this.pass.TabIndex = 67;
            this.pass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pass.UseVisualStyleBackColor = false;
            // 
            // education
            // 
            this.education.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.education.AutoSize = true;
            this.education.BackColor = System.Drawing.Color.White;
            this.education.FlatAppearance.BorderSize = 0;
            this.education.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.education.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.education.ForeColor = System.Drawing.Color.Black;
            this.education.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.education.IconColor = System.Drawing.Color.Black;
            this.education.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.education.IconSize = 32;
            this.education.Location = new System.Drawing.Point(431, 287);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(48, 46);
            this.education.TabIndex = 68;
            this.education.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.education.UseVisualStyleBackColor = false;
            // 
            // lbMail
            // 
            this.lbMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMail.AutoSize = true;
            this.lbMail.BackColor = System.Drawing.Color.White;
            this.lbMail.FlatAppearance.BorderSize = 0;
            this.lbMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.Black;
            this.lbMail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.lbMail.IconColor = System.Drawing.Color.Black;
            this.lbMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbMail.IconSize = 32;
            this.lbMail.Location = new System.Drawing.Point(75, 274);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(48, 46);
            this.lbMail.TabIndex = 69;
            this.lbMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbMail.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(485, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Total Lesson:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(485, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Achivement";
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.ForeColor = System.Drawing.Color.Black;
            this.lbTeacherName.Location = new System.Drawing.Point(365, 229);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(52, 18);
            this.lbTeacherName.TabIndex = 63;
            this.lbTeacherName.Text = "Name";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxBackground.Image = global::PBL.Properties.Resources.backgroudlessson1;
            this.pictureBoxBackground.Location = new System.Drawing.Point(74, 19);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(751, 154);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 64;
            this.pictureBoxBackground.TabStop = false;
            // 
            // tabPageChangePassword
            // 
            this.tabPageChangePassword.Controls.Add(this.txtNewPassAgain);
            this.tabPageChangePassword.Controls.Add(this.txtCurrentPass);
            this.tabPageChangePassword.Controls.Add(this.txtNewPass);
            this.tabPageChangePassword.Controls.Add(this.lbNewPassAgain);
            this.tabPageChangePassword.Controls.Add(this.lbNewPass);
            this.tabPageChangePassword.Controls.Add(this.lbCurrentPass);
            this.tabPageChangePassword.Controls.Add(this.btnCancelChangePass);
            this.tabPageChangePassword.Controls.Add(this.btnSaveChangePass);
            this.tabPageChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageChangePassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPageChangePassword.Location = new System.Drawing.Point(4, 25);
            this.tabPageChangePassword.Name = "tabPageChangePassword";
            this.tabPageChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangePassword.Size = new System.Drawing.Size(898, 438);
            this.tabPageChangePassword.TabIndex = 1;
            this.tabPageChangePassword.Text = "Change password";
            this.tabPageChangePassword.UseVisualStyleBackColor = true;
            // 
            // txtNewPassAgain
            // 
            this.txtNewPassAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPassAgain.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPassAgain.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewPassAgain.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPassAgain.BorderRadius = 0;
            this.txtNewPassAgain.BorderSize = 2;
            this.txtNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassAgain.Location = new System.Drawing.Point(322, 284);
            this.txtNewPassAgain.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassAgain.Multiline = false;
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPassAgain.PasswordChar = false;
            this.txtNewPassAgain.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassAgain.PlaceholderText = "";
            this.txtNewPassAgain.Size = new System.Drawing.Size(405, 31);
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
            this.txtCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentPass.Location = new System.Drawing.Point(322, 81);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPass.Multiline = false;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCurrentPass.PasswordChar = false;
            this.txtCurrentPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPass.PlaceholderText = "";
            this.txtCurrentPass.Size = new System.Drawing.Size(405, 31);
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
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.Location = new System.Drawing.Point(322, 184);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass.PasswordChar = false;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass.PlaceholderText = "";
            this.txtNewPass.Size = new System.Drawing.Size(405, 31);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.Texts = "";
            this.txtNewPass.UnderlinedStyle = false;
            // 
            // lbNewPassAgain
            // 
            this.lbNewPassAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNewPassAgain.AutoSize = true;
            this.lbNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassAgain.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbNewPassAgain.Location = new System.Drawing.Point(319, 268);
            this.lbNewPassAgain.Name = "lbNewPassAgain";
            this.lbNewPassAgain.Size = new System.Drawing.Size(153, 18);
            this.lbNewPassAgain.TabIndex = 4;
            this.lbNewPassAgain.Text = "New Password Again:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbNewPass.Location = new System.Drawing.Point(319, 168);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(113, 18);
            this.lbNewPass.TabIndex = 4;
            this.lbNewPass.Text = "New Password:";
            // 
            // lbCurrentPass
            // 
            this.lbCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCurrentPass.AutoSize = true;
            this.lbCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPass.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbCurrentPass.Location = new System.Drawing.Point(319, 65);
            this.lbCurrentPass.Name = "lbCurrentPass";
            this.lbCurrentPass.Size = new System.Drawing.Size(132, 18);
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
            this.btnCancelChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChangePass.ForeColor = System.Drawing.Color.White;
            this.btnCancelChangePass.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancelChangePass.IconColor = System.Drawing.Color.White;
            this.btnCancelChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelChangePass.IconSize = 32;
            this.btnCancelChangePass.Location = new System.Drawing.Point(554, 361);
            this.btnCancelChangePass.Name = "btnCancelChangePass";
            this.btnCancelChangePass.Size = new System.Drawing.Size(103, 46);
            this.btnCancelChangePass.TabIndex = 9;
            this.btnCancelChangePass.Text = "Cancel";
            this.btnCancelChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelChangePass.UseVisualStyleBackColor = false;
            // 
            // btnSaveChangePass
            // 
            this.btnSaveChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChangePass.AutoSize = true;
            this.btnSaveChangePass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSaveChangePass.FlatAppearance.BorderSize = 0;
            this.btnSaveChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChangePass.ForeColor = System.Drawing.Color.White;
            this.btnSaveChangePass.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnSaveChangePass.IconColor = System.Drawing.Color.White;
            this.btnSaveChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveChangePass.IconSize = 32;
            this.btnSaveChangePass.Location = new System.Drawing.Point(404, 361);
            this.btnSaveChangePass.Name = "btnSaveChangePass";
            this.btnSaveChangePass.Size = new System.Drawing.Size(103, 46);
            this.btnSaveChangePass.TabIndex = 8;
            this.btnSaveChangePass.Text = "Save";
            this.btnSaveChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChangePass.UseVisualStyleBackColor = false;
            // 
            // tabPageEditProfile
            // 
            this.tabPageEditProfile.Controls.Add(this.btnCancelEdit);
            this.tabPageEditProfile.Controls.Add(this.btnSaveEdit);
            this.tabPageEditProfile.Controls.Add(this.lbName);
            this.tabPageEditProfile.Controls.Add(this.lbBirth);
            this.tabPageEditProfile.Controls.Add(this.lbPhone);
            this.tabPageEditProfile.Controls.Add(this.lbEmail);
            this.tabPageEditProfile.Controls.Add(this.editBirth);
            this.tabPageEditProfile.Controls.Add(this.btnChangePassword2);
            this.tabPageEditProfile.Controls.Add(this.txtTeacherPhone);
            this.tabPageEditProfile.Controls.Add(this.txtTeacherEmail);
            this.tabPageEditProfile.Controls.Add(this.txtTeacherName);
            this.tabPageEditProfile.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditProfile.Name = "tabPageEditProfile";
            this.tabPageEditProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditProfile.Size = new System.Drawing.Size(898, 438);
            this.tabPageEditProfile.TabIndex = 2;
            this.tabPageEditProfile.Text = "Edit profile";
            this.tabPageEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelEdit.AutoSize = true;
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancelEdit.IconColor = System.Drawing.Color.White;
            this.btnCancelEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelEdit.IconSize = 32;
            this.btnCancelEdit.Location = new System.Drawing.Point(443, 327);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(103, 46);
            this.btnCancelEdit.TabIndex = 86;
            this.btnCancelEdit.Text = "Cancel";
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
            this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnSaveEdit.IconColor = System.Drawing.Color.White;
            this.btnSaveEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveEdit.IconSize = 32;
            this.btnSaveEdit.Location = new System.Drawing.Point(293, 327);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(103, 46);
            this.btnSaveEdit.TabIndex = 85;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbName.Location = new System.Drawing.Point(109, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 18);
            this.lbName.TabIndex = 84;
            this.lbName.Text = "Name:";
            // 
            // lbBirth
            // 
            this.lbBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbBirth.Location = new System.Drawing.Point(109, 212);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(65, 18);
            this.lbBirth.TabIndex = 83;
            this.lbBirth.Text = "Birthday:";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbPhone.Location = new System.Drawing.Point(109, 152);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(109, 18);
            this.lbPhone.TabIndex = 82;
            this.lbPhone.Text = "Phone number:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbEmail.Location = new System.Drawing.Point(109, 92);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(49, 18);
            this.lbEmail.TabIndex = 81;
            this.lbEmail.Text = "Email:";
            // 
            // editBirth
            // 
            this.editBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editBirth.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editBirth.BorderSize = 0;
            this.editBirth.CustomFormat = "";
            this.editBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.editBirth.Location = new System.Drawing.Point(112, 233);
            this.editBirth.MinimumSize = new System.Drawing.Size(0, 35);
            this.editBirth.Name = "editBirth";
            this.editBirth.Size = new System.Drawing.Size(200, 35);
            this.editBirth.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.editBirth.TabIndex = 79;
            this.editBirth.TextColor = System.Drawing.Color.White;
            // 
            // btnChangePassword2
            // 
            this.btnChangePassword2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChangePassword2.IconColor = System.Drawing.Color.Black;
            this.btnChangePassword2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword2.Location = new System.Drawing.Point(546, 64);
            this.btnChangePassword2.Name = "btnChangePassword2";
            this.btnChangePassword2.Size = new System.Drawing.Size(158, 23);
            this.btnChangePassword2.TabIndex = 78;
            this.btnChangePassword2.Text = "Change password";
            this.btnChangePassword2.UseVisualStyleBackColor = true;
            this.btnChangePassword2.Click += new System.EventHandler(this.btnChangePassword2_Click);
            // 
            // txtTeacherPhone
            // 
            this.txtTeacherPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTeacherPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtTeacherPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTeacherPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTeacherPhone.BorderRadius = 0;
            this.txtTeacherPhone.BorderSize = 2;
            this.txtTeacherPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTeacherPhone.Location = new System.Drawing.Point(112, 171);
            this.txtTeacherPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherPhone.Multiline = false;
            this.txtTeacherPhone.Name = "txtTeacherPhone";
            this.txtTeacherPhone.Padding = new System.Windows.Forms.Padding(10);
            this.txtTeacherPhone.PasswordChar = false;
            this.txtTeacherPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTeacherPhone.PlaceholderText = "";
            this.txtTeacherPhone.Size = new System.Drawing.Size(256, 37);
            this.txtTeacherPhone.TabIndex = 76;
            this.txtTeacherPhone.Texts = "";
            this.txtTeacherPhone.UnderlinedStyle = false;
            // 
            // txtTeacherEmail
            // 
            this.txtTeacherEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTeacherEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtTeacherEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTeacherEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTeacherEmail.BorderRadius = 0;
            this.txtTeacherEmail.BorderSize = 2;
            this.txtTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTeacherEmail.Location = new System.Drawing.Point(112, 111);
            this.txtTeacherEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherEmail.Multiline = false;
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.Padding = new System.Windows.Forms.Padding(10);
            this.txtTeacherEmail.PasswordChar = false;
            this.txtTeacherEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTeacherEmail.PlaceholderText = "";
            this.txtTeacherEmail.Size = new System.Drawing.Size(256, 37);
            this.txtTeacherEmail.TabIndex = 75;
            this.txtTeacherEmail.Texts = "";
            this.txtTeacherEmail.UnderlinedStyle = false;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTeacherName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTeacherName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTeacherName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTeacherName.BorderRadius = 0;
            this.txtTeacherName.BorderSize = 2;
            this.txtTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTeacherName.Location = new System.Drawing.Point(112, 51);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherName.Multiline = false;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Padding = new System.Windows.Forms.Padding(10);
            this.txtTeacherName.PasswordChar = false;
            this.txtTeacherName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTeacherName.PlaceholderText = "";
            this.txtTeacherName.Size = new System.Drawing.Size(256, 37);
            this.txtTeacherName.TabIndex = 74;
            this.txtTeacherName.Texts = "";
            this.txtTeacherName.UnderlinedStyle = false;
            // 
            // TeacherProfileView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherProfileView";
            this.Text = "Profile";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.roundPanelAvatar.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton pass;
        private FontAwesome.Sharp.IconButton education;
        private FontAwesome.Sharp.IconButton lbMail;//
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTeacherName;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private RoundPanel roundPanelAvatar;
        private FontAwesome.Sharp.IconButton btnAvatar;
        private System.Windows.Forms.Label lbTeacherTest;
        private System.Windows.Forms.Label lbTeacherLesson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTeacherBirth;
        private System.Windows.Forms.Label lbTeacherPhone;
        private System.Windows.Forms.Label lbTeacherEmail;
        private System.Windows.Forms.TabPage tabPageEditProfile;
        private Controller.RoundTextBox txtTeacherName;
        private FontAwesome.Sharp.IconButton btnChangePassword;
        private FontAwesome.Sharp.IconButton btnEditProfile;
        private FontAwesome.Sharp.IconButton btnChangePassword2;
        private Controller.RoundTextBox txtTeacherPhone;
        private Controller.RoundTextBox txtTeacherEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private Resources.Components.RJDatePicker editBirth;
        private FontAwesome.Sharp.IconButton btnCancelEdit;
        private FontAwesome.Sharp.IconButton btnSaveEdit;
    }
}