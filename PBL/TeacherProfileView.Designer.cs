namespace PBL
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
            this.txtName1 = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.birth = new FontAwesome.Sharp.IconButton();
            this.phone = new FontAwesome.Sharp.IconButton();
            this.pass = new FontAwesome.Sharp.IconButton();
            this.education = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageChangePassword = new System.Windows.Forms.TabPage();
            this.txtNewPass2 = new PBL.Controller.RoundTextBox();
            this.txtCurrentPass = new PBL.Controller.RoundTextBox();
            this.txtNewPass1 = new PBL.Controller.RoundTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.roundPanelAvatar = new RoundPanel();
            this.btnAvatar = new FontAwesome.Sharp.IconButton();
            this.txtName1.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageChangePassword.SuspendLayout();
            this.roundPanelAvatar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName1
            // 
            this.txtName1.Controls.Add(this.tabPageProfile);
            this.txtName1.Controls.Add(this.tabPageChangePassword);
            this.txtName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName1.Location = new System.Drawing.Point(0, 0);
            this.txtName1.Name = "txtName1";
            this.txtName1.SelectedIndex = 0;
            this.txtName1.Size = new System.Drawing.Size(906, 467);
            this.txtName1.TabIndex = 2;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.roundPanelAvatar);
            this.tabPageProfile.Controls.Add(this.birth);
            this.tabPageProfile.Controls.Add(this.phone);
            this.tabPageProfile.Controls.Add(this.pass);
            this.tabPageProfile.Controls.Add(this.education);
            this.tabPageProfile.Controls.Add(this.iconButton1);
            this.tabPageProfile.Controls.Add(this.label4);
            this.tabPageProfile.Controls.Add(this.label3);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.label8);
            this.tabPageProfile.Controls.Add(this.label6);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Controls.Add(this.pictureBox2);
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
            // birth
            // 
            this.birth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birth.AutoSize = true;
            this.birth.BackColor = System.Drawing.Color.White;
            this.birth.FlatAppearance.BorderSize = 0;
            this.birth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.ForeColor = System.Drawing.Color.Black;
            this.birth.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            this.birth.IconColor = System.Drawing.Color.Black;
            this.birth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.birth.IconSize = 32;
            this.birth.Location = new System.Drawing.Point(99, 377);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(48, 46);
            this.birth.TabIndex = 51;
            this.birth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.birth.UseVisualStyleBackColor = false;
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.phone.Location = new System.Drawing.Point(99, 332);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(48, 46);
            this.phone.TabIndex = 52;
            this.phone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phone.UseVisualStyleBackColor = false;
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.pass.Location = new System.Drawing.Point(492, 183);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(38, 38);
            this.pass.TabIndex = 53;
            this.pass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pass.UseVisualStyleBackColor = false;
            // 
            // education
            // 
            this.education.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.education.Location = new System.Drawing.Point(527, 284);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(48, 46);
            this.education.TabIndex = 53;
            this.education.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.education.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(99, 284);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 46);
            this.iconButton1.TabIndex = 54;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(153, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "03/04/2004";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(153, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "0905076755";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(581, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tests published: 21";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(581, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Rank: 3543";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(581, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Lessons published: 103";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(581, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Education";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(153, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "mvkhanh2004@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mai Van Khanh";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL.Properties.Resources.background_profile_student;
            this.pictureBox2.Location = new System.Drawing.Point(64, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(762, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // tabPageChangePassword
            // 
            this.tabPageChangePassword.Controls.Add(this.txtNewPass2);
            this.tabPageChangePassword.Controls.Add(this.txtCurrentPass);
            this.tabPageChangePassword.Controls.Add(this.txtNewPass1);
            this.tabPageChangePassword.Controls.Add(this.panel1);
            this.tabPageChangePassword.Controls.Add(this.lbPassword);
            this.tabPageChangePassword.Controls.Add(this.lbEmail);
            this.tabPageChangePassword.Controls.Add(this.lbName);
            this.tabPageChangePassword.Controls.Add(this.btnCancel);
            this.tabPageChangePassword.Controls.Add(this.btnSave);
            this.tabPageChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageChangePassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPageChangePassword.Location = new System.Drawing.Point(4, 25);
            this.tabPageChangePassword.Name = "tabPageChangePassword";
            this.tabPageChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangePassword.Size = new System.Drawing.Size(898, 438);
            this.tabPageChangePassword.TabIndex = 1;
            this.tabPageChangePassword.Text = "Change Password";
            this.tabPageChangePassword.UseVisualStyleBackColor = true;
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass2.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPass2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewPass2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPass2.BorderRadius = 0;
            this.txtNewPass2.BorderSize = 2;
            this.txtNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass2.Location = new System.Drawing.Point(322, 284);
            this.txtNewPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass2.Multiline = false;
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass2.PasswordChar = false;
            this.txtNewPass2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass2.PlaceholderText = "";
            this.txtNewPass2.Size = new System.Drawing.Size(405, 31);
            this.txtNewPass2.TabIndex = 5;
            this.txtNewPass2.Texts = "";
            this.txtNewPass2.UnderlinedStyle = false;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // txtNewPass1
            // 
            this.txtNewPass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPass1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewPass1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPass1.BorderRadius = 0;
            this.txtNewPass1.BorderSize = 2;
            this.txtNewPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass1.Location = new System.Drawing.Point(322, 184);
            this.txtNewPass1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass1.Multiline = false;
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass1.PasswordChar = false;
            this.txtNewPass1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass1.PlaceholderText = "";
            this.txtNewPass1.Size = new System.Drawing.Size(405, 31);
            this.txtNewPass1.TabIndex = 3;
            this.txtNewPass1.Texts = "";
            this.txtNewPass1.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Location = new System.Drawing.Point(29, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 250);
            this.panel1.TabIndex = 18;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbPassword.Location = new System.Drawing.Point(319, 268);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(153, 18);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "New Password Again:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbEmail.Location = new System.Drawing.Point(319, 168);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(113, 18);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "New Password:";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbName.Location = new System.Drawing.Point(319, 65);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(132, 18);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Current Password:";
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
            this.btnCancel.Location = new System.Drawing.Point(554, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 46);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(404, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // roundPanelAvatar
            // 
            this.roundPanelAvatar.Controls.Add(this.btnAvatar);
            this.roundPanelAvatar.CornerRadius = 54;
            this.roundPanelAvatar.Location = new System.Drawing.Point(375, 125);
            this.roundPanelAvatar.Name = "roundPanelAvatar";
            this.roundPanelAvatar.Size = new System.Drawing.Size(111, 110);
            this.roundPanelAvatar.TabIndex = 73;
            // 
            // btnAvatar
            // 
            this.btnAvatar.AutoSize = true;
            this.btnAvatar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // TeacherProfileView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.txtName1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherProfileView";
            this.Text = "Teachers";
            this.txtName1.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageChangePassword.ResumeLayout(false);
            this.tabPageChangePassword.PerformLayout();
            this.roundPanelAvatar.ResumeLayout(false);
            this.roundPanelAvatar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl txtName1;
        private System.Windows.Forms.TabPage tabPageChangePassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label lbPassword;
        private Controller.RoundTextBox txtNewPass1;
        private Controller.RoundTextBox txtNewPass2;
        private Controller.RoundTextBox txtCurrentPass;
        private System.Windows.Forms.TabPage tabPageProfile;
        private FontAwesome.Sharp.IconButton birth;
        private FontAwesome.Sharp.IconButton phone;
        private FontAwesome.Sharp.IconButton education;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        
        private FontAwesome.Sharp.IconButton pass;
        private RoundPanel roundPanelAvatar;
        private FontAwesome.Sharp.IconButton btnAvatar;
    }
}