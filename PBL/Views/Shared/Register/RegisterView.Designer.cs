namespace PBL.Views.Shared
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnRestoreDown = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLogin = new RoundPanel();
            this.txtEmail = new PBL.Controller.RoundTextBox();
            this.txtUserName = new PBL.Controller.RoundTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new PBL.Controller.RoundButton();
            this.btOpenEye2 = new System.Windows.Forms.Button();
            this.btOpenEye1 = new System.Windows.Forms.Button();
            this.btCloseEye2 = new System.Windows.Forms.Button();
            this.btCloseEye1 = new System.Windows.Forms.Button();
            this.txtPass2 = new PBL.Controller.RoundTextBox();
            this.txtPass1 = new PBL.Controller.RoundTextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtAccount = new PBL.Controller.RoundTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new PBL.Controller.RoundButton();
            this.picturePass = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(43)))), ((int)(((byte)(106)))));
            this.panelTitle.Controls.Add(this.btnMinisize);
            this.panelTitle.Controls.Add(this.btnRestoreDown);
            this.panelTitle.Controls.Add(this.btClose);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(901, 29);
            this.panelTitle.TabIndex = 10;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackgroundImage = global::PBL.Properties.Resources.editing1;
            this.btnMinisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinisize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Location = new System.Drawing.Point(823, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(20, 29);
            this.btnMinisize.TabIndex = 7;
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnRestoreDown
            // 
            this.btnRestoreDown.BackgroundImage = global::PBL.Properties.Resources.copy__1_;
            this.btnRestoreDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestoreDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestoreDown.FlatAppearance.BorderSize = 0;
            this.btnRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDown.Location = new System.Drawing.Point(843, 0);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(29, 29);
            this.btnRestoreDown.TabIndex = 6;
            this.btnRestoreDown.UseVisualStyleBackColor = true;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::PBL.Properties.Resources.Close;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(872, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(29, 29);
            this.btClose.TabIndex = 4;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Register";
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::PBL.Properties.Resources.background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.panelLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(901, 535);
            this.panelMain.TabIndex = 6;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.txtUserName);
            this.panelLogin.Controls.Add(this.pictureBox3);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.btnReturn);
            this.panelLogin.Controls.Add(this.btOpenEye2);
            this.panelLogin.Controls.Add(this.btOpenEye1);
            this.panelLogin.Controls.Add(this.btCloseEye2);
            this.panelLogin.Controls.Add(this.btCloseEye1);
            this.panelLogin.Controls.Add(this.txtPass2);
            this.panelLogin.Controls.Add(this.txtPass1);
            this.panelLogin.Controls.Add(this.lbLogin);
            this.panelLogin.Controls.Add(this.txtAccount);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.btnSignUp);
            this.panelLogin.Controls.Add(this.picturePass);
            this.panelLogin.Controls.Add(this.pictureUser);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.lbUserName);
            this.panelLogin.Controls.Add(this.lbPass);
            this.panelLogin.CornerRadius = 10;
            this.panelLogin.Location = new System.Drawing.Point(262, 6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(379, 517);
            this.panelLogin.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(84, 368);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Enter email";
            this.txtEmail.Size = new System.Drawing.Size(251, 35);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Location = new System.Drawing.Point(83, 297);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "Enter user name";
            this.txtUserName.Size = new System.Drawing.Size(251, 35);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::PBL.Properties.Resources.User_2_;
            this.pictureBox3.Location = new System.Drawing.Point(40, 294);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(81, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(80, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "User Name";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundColor = System.Drawing.Color.White;
            this.btnReturn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReturn.BorderRadius = 5;
            this.btnReturn.BorderSize = 0;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnReturn.Location = new System.Drawing.Point(107, 478);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(166, 24);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextColor = System.Drawing.Color.DarkOrchid;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btOpenEye2
            // 
            this.btOpenEye2.BackColor = System.Drawing.SystemColors.Window;
            this.btOpenEye2.BackgroundImage = global::PBL.Properties.Resources.Eye;
            this.btOpenEye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOpenEye2.FlatAppearance.BorderSize = 0;
            this.btOpenEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenEye2.Location = new System.Drawing.Point(305, 235);
            this.btOpenEye2.Name = "btOpenEye2";
            this.btOpenEye2.Size = new System.Drawing.Size(25, 25);
            this.btOpenEye2.TabIndex = 7;
            this.btOpenEye2.UseVisualStyleBackColor = false;
            this.btOpenEye2.Visible = false;
            this.btOpenEye2.Click += new System.EventHandler(this.btOpenEye_Click2);
            // 
            // btOpenEye1
            // 
            this.btOpenEye1.BackColor = System.Drawing.SystemColors.Window;
            this.btOpenEye1.BackgroundImage = global::PBL.Properties.Resources.Eye;
            this.btOpenEye1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOpenEye1.FlatAppearance.BorderSize = 0;
            this.btOpenEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenEye1.Location = new System.Drawing.Point(302, 164);
            this.btOpenEye1.Name = "btOpenEye1";
            this.btOpenEye1.Size = new System.Drawing.Size(25, 25);
            this.btOpenEye1.TabIndex = 7;
            this.btOpenEye1.UseVisualStyleBackColor = false;
            this.btOpenEye1.Visible = false;
            this.btOpenEye1.Click += new System.EventHandler(this.btOpenEye_Click1);
            // 
            // btCloseEye2
            // 
            this.btCloseEye2.BackColor = System.Drawing.SystemColors.Window;
            this.btCloseEye2.BackgroundImage = global::PBL.Properties.Resources.Hide;
            this.btCloseEye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCloseEye2.FlatAppearance.BorderSize = 0;
            this.btCloseEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseEye2.Location = new System.Drawing.Point(305, 235);
            this.btCloseEye2.Name = "btCloseEye2";
            this.btCloseEye2.Size = new System.Drawing.Size(25, 25);
            this.btCloseEye2.TabIndex = 7;
            this.btCloseEye2.UseVisualStyleBackColor = false;
            this.btCloseEye2.Visible = false;
            this.btCloseEye2.Click += new System.EventHandler(this.btCloseEye_Click2);
            // 
            // btCloseEye1
            // 
            this.btCloseEye1.BackColor = System.Drawing.SystemColors.Window;
            this.btCloseEye1.BackgroundImage = global::PBL.Properties.Resources.Hide;
            this.btCloseEye1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCloseEye1.FlatAppearance.BorderSize = 0;
            this.btCloseEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseEye1.Location = new System.Drawing.Point(302, 164);
            this.btCloseEye1.Name = "btCloseEye1";
            this.btCloseEye1.Size = new System.Drawing.Size(25, 25);
            this.btCloseEye1.TabIndex = 7;
            this.btCloseEye1.UseVisualStyleBackColor = false;
            this.btCloseEye1.Visible = false;
            this.btCloseEye1.Click += new System.EventHandler(this.btCloseEye_Click1);
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass2.BorderColor = System.Drawing.Color.Silver;
            this.txtPass2.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtPass2.BorderRadius = 5;
            this.txtPass2.BorderSize = 2;
            this.txtPass2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass2.Location = new System.Drawing.Point(83, 229);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass2.Multiline = false;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass2.PasswordChar = true;
            this.txtPass2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass2.PlaceholderText = "Enter password";
            this.txtPass2.Size = new System.Drawing.Size(251, 35);
            this.txtPass2.TabIndex = 2;
            this.txtPass2.Texts = "";
            this.txtPass2.UnderlinedStyle = false;
            this.txtPass2._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
            // 
            // txtPass1
            // 
            this.txtPass1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass1.BorderColor = System.Drawing.Color.Silver;
            this.txtPass1.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtPass1.BorderRadius = 5;
            this.txtPass1.BorderSize = 2;
            this.txtPass1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass1.Location = new System.Drawing.Point(80, 159);
            this.txtPass1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass1.Multiline = false;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass1.PasswordChar = true;
            this.txtPass1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass1.PlaceholderText = "Enter password";
            this.txtPass1.Size = new System.Drawing.Size(251, 35);
            this.txtPass1.TabIndex = 1;
            this.txtPass1.Texts = "";
            this.txtPass1.UnderlinedStyle = false;
            this.txtPass1._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.lbLogin.Location = new System.Drawing.Point(145, 7);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(101, 31);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Register";
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccount.BorderColor = System.Drawing.Color.Silver;
            this.txtAccount.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtAccount.BorderRadius = 5;
            this.txtAccount.BorderSize = 2;
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccount.Location = new System.Drawing.Point(80, 92);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccount.Multiline = false;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAccount.PasswordChar = false;
            this.txtAccount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAccount.PlaceholderText = "Enter account";
            this.txtAccount.Size = new System.Drawing.Size(251, 35);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.Texts = "";
            this.txtAccount.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PBL.Properties.Resources.Password_2_;
            this.pictureBox1.Location = new System.Drawing.Point(40, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.btnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.btnSignUp.BorderColor = System.Drawing.Color.Empty;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(74, 433);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(233, 38);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // picturePass
            // 
            this.picturePass.BackColor = System.Drawing.Color.White;
            this.picturePass.Image = global::PBL.Properties.Resources.Password_2_;
            this.picturePass.Location = new System.Drawing.Point(37, 156);
            this.picturePass.Name = "picturePass";
            this.picturePass.Size = new System.Drawing.Size(36, 41);
            this.picturePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePass.TabIndex = 6;
            this.picturePass.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.White;
            this.pictureUser.Image = global::PBL.Properties.Resources.User_2_;
            this.pictureUser.Location = new System.Drawing.Point(37, 89);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(36, 41);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(76, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbUserName.Location = new System.Drawing.Point(77, 73);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(63, 20);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Account";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbPass.Location = new System.Drawing.Point(77, 140);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(70, 20);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "Password";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(901, 564);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegisterView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private Controller.RoundTextBox txtPass1;
        private Controller.RoundTextBox txtAccount;
        private System.Windows.Forms.PictureBox picturePass;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUserName;
        private Controller.RoundButton btnSignUp;
        private RoundPanel panelLogin;
        private System.Windows.Forms.Button btCloseEye1;
        private System.Windows.Forms.Button btOpenEye1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private Controller.RoundTextBox txtPass2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpenEye2;
        private System.Windows.Forms.Button btCloseEye2;
        private Controller.RoundButton btnReturn;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnRestoreDown;
        private Controller.RoundTextBox txtEmail;
        private Controller.RoundTextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}