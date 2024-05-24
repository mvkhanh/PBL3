namespace PBL.Views.Shared
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnRestoreDown = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelLogin = new RoundPanel();
            this.btOpenEye = new System.Windows.Forms.Button();
            this.btCloseEye = new System.Windows.Forms.Button();
            this.txtPass = new PBL.Controller.RoundTextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtUserName = new PBL.Controller.RoundTextBox();
            this.btLogin = new PBL.Controller.RoundButton();
            this.picturePass = new System.Windows.Forms.PictureBox();
            this.lbForgot = new System.Windows.Forms.LinkLabel();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lbCreate = new System.Windows.Forms.LinkLabel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLogin.SuspendLayout();
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
            this.btnMinisize.TabIndex = 3;
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
            this.btnRestoreDown.TabIndex = 2;
            this.btnRestoreDown.UseVisualStyleBackColor = true;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(872, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(29, 29);
            this.btClose.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::PBL.Properties.Resources.background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.lbTitle);
            this.panelMain.Controls.Add(this.panelLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(901, 535);
            this.panelMain.TabIndex = 6;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(209, 48);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(482, 54);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Welcome to TOEIC Master";
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.btOpenEye);
            this.panelLogin.Controls.Add(this.btCloseEye);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.lbLogin);
            this.panelLogin.Controls.Add(this.txtUserName);
            this.panelLogin.Controls.Add(this.btLogin);
            this.panelLogin.Controls.Add(this.picturePass);
            this.panelLogin.Controls.Add(this.lbForgot);
            this.panelLogin.Controls.Add(this.pictureUser);
            this.panelLogin.Controls.Add(this.lbCreate);
            this.panelLogin.Controls.Add(this.lbUserName);
            this.panelLogin.Controls.Add(this.lbPass);
            this.panelLogin.CornerRadius = 10;
            this.panelLogin.Location = new System.Drawing.Point(262, 156);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(377, 328);
            this.panelLogin.TabIndex = 7;
            // 
            // btOpenEye
            // 
            this.btOpenEye.BackColor = System.Drawing.SystemColors.Window;
            this.btOpenEye.BackgroundImage = global::PBL.Properties.Resources.Eye;
            this.btOpenEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOpenEye.FlatAppearance.BorderSize = 0;
            this.btOpenEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenEye.Location = new System.Drawing.Point(302, 165);
            this.btOpenEye.Name = "btOpenEye";
            this.btOpenEye.Size = new System.Drawing.Size(25, 25);
            this.btOpenEye.TabIndex = 7;
            this.btOpenEye.UseVisualStyleBackColor = false;
            this.btOpenEye.Visible = false;
            this.btOpenEye.Click += new System.EventHandler(this.btOpenEye_Click);
            // 
            // btCloseEye
            // 
            this.btCloseEye.BackColor = System.Drawing.SystemColors.Window;
            this.btCloseEye.BackgroundImage = global::PBL.Properties.Resources.Hide;
            this.btCloseEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCloseEye.FlatAppearance.BorderSize = 0;
            this.btCloseEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseEye.Location = new System.Drawing.Point(302, 165);
            this.btCloseEye.Name = "btCloseEye";
            this.btCloseEye.Size = new System.Drawing.Size(25, 25);
            this.btCloseEye.TabIndex = 7;
            this.btCloseEye.UseVisualStyleBackColor = false;
            this.btCloseEye.Visible = false;
            this.btCloseEye.Click += new System.EventHandler(this.btCloseEye_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.BorderColor = System.Drawing.Color.Silver;
            this.txtPass.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtPass.BorderRadius = 5;
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Location = new System.Drawing.Point(80, 160);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass.PasswordChar = true;
            this.txtPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass.PlaceholderText = "Enter password";
            this.txtPass.Size = new System.Drawing.Size(251, 35);
            this.txtPass.TabIndex = 3;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            this.txtPass._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.lbLogin.Location = new System.Drawing.Point(159, 19);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(75, 31);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Login";
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
            this.txtUserName.Location = new System.Drawing.Point(80, 97);
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
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.btLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.btLogin.BorderColor = System.Drawing.Color.Empty;
            this.btLogin.BorderRadius = 20;
            this.btLogin.BorderSize = 0;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(80, 234);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(233, 38);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.TextColor = System.Drawing.Color.White;
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // picturePass
            // 
            this.picturePass.BackColor = System.Drawing.Color.White;
            this.picturePass.Image = ((System.Drawing.Image)(resources.GetObject("picturePass.Image")));
            this.picturePass.Location = new System.Drawing.Point(37, 157);
            this.picturePass.Name = "picturePass";
            this.picturePass.Size = new System.Drawing.Size(36, 41);
            this.picturePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePass.TabIndex = 6;
            this.picturePass.TabStop = false;
            // 
            // lbForgot
            // 
            this.lbForgot.AutoSize = true;
            this.lbForgot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.lbForgot.Location = new System.Drawing.Point(219, 199);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(112, 19);
            this.lbForgot.TabIndex = 2;
            this.lbForgot.TabStop = true;
            this.lbForgot.Text = "Forgot Password";
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.White;
            this.pictureUser.Image = global::PBL.Properties.Resources.User_2_;
            this.pictureUser.Location = new System.Drawing.Point(37, 94);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(36, 41);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.lbCreate.Location = new System.Drawing.Point(129, 284);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(134, 19);
            this.lbCreate.TabIndex = 2;
            this.lbCreate.TabStop = true;
            this.lbCreate.Text = "Create New Account";
            this.lbCreate.Click += new System.EventHandler(this.lbCreate_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbUserName.Location = new System.Drawing.Point(77, 78);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(82, 20);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbPass.Location = new System.Drawing.Point(77, 141);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(70, 20);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(901, 564);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private Controller.RoundTextBox txtPass;
        private Controller.RoundTextBox txtUserName;
        private System.Windows.Forms.PictureBox picturePass;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.LinkLabel lbCreate;
        private System.Windows.Forms.LinkLabel lbForgot;
        private Controller.RoundButton btLogin;
        private RoundPanel panelLogin;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btCloseEye;
        private System.Windows.Forms.Button btOpenEye;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnRestoreDown;
    }
}