namespace PBL.Views.Shared
{
    partial class ForgetPasssword
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnRestoreDown = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLogin = new RoundPanel();
            this.btnReturn = new PBL.Controller.RoundButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new PBL.Controller.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOpenEye2 = new System.Windows.Forms.Button();
            this.btCloseEye2 = new System.Windows.Forms.Button();
            this.txtPass2 = new PBL.Controller.RoundTextBox();
            this.btOpenEye1 = new System.Windows.Forms.Button();
            this.btCloseEye1 = new System.Windows.Forms.Button();
            this.txtPass1 = new PBL.Controller.RoundTextBox();
            this.btOpenEye3 = new System.Windows.Forms.Button();
            this.btCloseEye3 = new System.Windows.Forms.Button();
            this.txtEmail = new PBL.Controller.RoundTextBox();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change Password";
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
            this.panelLogin.Controls.Add(this.btnReturn);
            this.panelLogin.Controls.Add(this.pictureBox3);
            this.panelLogin.Controls.Add(this.lbLogin);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.btnConfirm);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.btOpenEye2);
            this.panelLogin.Controls.Add(this.btCloseEye2);
            this.panelLogin.Controls.Add(this.txtPass2);
            this.panelLogin.Controls.Add(this.btOpenEye1);
            this.panelLogin.Controls.Add(this.btCloseEye1);
            this.panelLogin.Controls.Add(this.txtPass1);
            this.panelLogin.Controls.Add(this.btOpenEye3);
            this.panelLogin.Controls.Add(this.btCloseEye3);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.CornerRadius = 10;
            this.panelLogin.Location = new System.Drawing.Point(262, 23);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(379, 432);
            this.panelLogin.TabIndex = 0;
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
            this.btnReturn.Location = new System.Drawing.Point(81, 374);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(221, 34);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextColor = System.Drawing.Color.DarkOrchid;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::PBL.Properties.Resources.Password_2_;
            this.pictureBox3.Location = new System.Drawing.Point(37, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.lbLogin.Location = new System.Drawing.Point(102, 21);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(200, 31);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Change Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PBL.Properties.Resources.Password_2_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::PBL.Properties.Resources.Password_2_;
            this.pictureBox2.Location = new System.Drawing.Point(37, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.Empty;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(77, 321);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(233, 38);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Change";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(73, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Password";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(77, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(73, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btOpenEye2
            // 
            this.btOpenEye2.BackColor = System.Drawing.SystemColors.Window;
            this.btOpenEye2.BackgroundImage = global::PBL.Properties.Resources.Eye;
            this.btOpenEye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOpenEye2.FlatAppearance.BorderSize = 0;
            this.btOpenEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenEye2.Location = new System.Drawing.Point(302, 266);
            this.btOpenEye2.Name = "btOpenEye2";
            this.btOpenEye2.Size = new System.Drawing.Size(25, 25);
            this.btOpenEye2.TabIndex = 7;
            this.btOpenEye2.UseVisualStyleBackColor = false;
            this.btOpenEye2.Visible = false;
            this.btOpenEye2.Click += new System.EventHandler(this.btOpenEye_Click2);
            // 
            // btCloseEye2
            // 
            this.btCloseEye2.BackColor = System.Drawing.SystemColors.Window;
            this.btCloseEye2.BackgroundImage = global::PBL.Properties.Resources.Hide;
            this.btCloseEye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCloseEye2.FlatAppearance.BorderSize = 0;
            this.btCloseEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseEye2.Location = new System.Drawing.Point(302, 266);
            this.btCloseEye2.Name = "btCloseEye2";
            this.btCloseEye2.Size = new System.Drawing.Size(25, 25);
            this.btCloseEye2.TabIndex = 7;
            this.btCloseEye2.UseVisualStyleBackColor = false;
            this.btCloseEye2.Visible = false;
            this.btCloseEye2.Click += new System.EventHandler(this.btCloseEye_Click2);
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
            this.txtPass2.Location = new System.Drawing.Point(80, 260);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass2.Multiline = false;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass2.PasswordChar = true;
            this.txtPass2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass2.PlaceholderText = "Enter new password again";
            this.txtPass2.Size = new System.Drawing.Size(251, 35);
            this.txtPass2.TabIndex = 3;
            this.txtPass2.Texts = "";
            this.txtPass2.UnderlinedStyle = false;
            this.txtPass2._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
            // 
            // btOpenEye1
            // 
            this.btOpenEye1.BackColor = System.Drawing.SystemColors.Window;
            this.btOpenEye1.BackgroundImage = global::PBL.Properties.Resources.Eye;
            this.btOpenEye1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOpenEye1.FlatAppearance.BorderSize = 0;
            this.btOpenEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenEye1.Location = new System.Drawing.Point(302, 184);
            this.btOpenEye1.Name = "btOpenEye1";
            this.btOpenEye1.Size = new System.Drawing.Size(25, 25);
            this.btOpenEye1.TabIndex = 7;
            this.btOpenEye1.UseVisualStyleBackColor = false;
            this.btOpenEye1.Visible = false;
            this.btOpenEye1.Click += new System.EventHandler(this.btOpenEye_Click1);
            // 
            // btCloseEye1
            // 
            this.btCloseEye1.BackColor = System.Drawing.SystemColors.Window;
            this.btCloseEye1.BackgroundImage = global::PBL.Properties.Resources.Hide;
            this.btCloseEye1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCloseEye1.FlatAppearance.BorderSize = 0;
            this.btCloseEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseEye1.Location = new System.Drawing.Point(302, 184);
            this.btCloseEye1.Name = "btCloseEye1";
            this.btCloseEye1.Size = new System.Drawing.Size(25, 25);
            this.btCloseEye1.TabIndex = 7;
            this.btCloseEye1.UseVisualStyleBackColor = false;
            this.btCloseEye1.Visible = false;
            this.btCloseEye1.Click += new System.EventHandler(this.btCloseEye_Click1);
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
            this.txtPass1.Location = new System.Drawing.Point(80, 178);
            this.txtPass1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass1.Multiline = false;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass1.PasswordChar = true;
            this.txtPass1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass1.PlaceholderText = "Enter password";
            this.txtPass1.Size = new System.Drawing.Size(251, 35);
            this.txtPass1.TabIndex = 3;
            this.txtPass1.Texts = "";
            this.txtPass1.UnderlinedStyle = false;
            this.txtPass1._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
            // 
            // btOpenEye3
            // 
            this.btOpenEye3.BackColor = System.Drawing.SystemColors.Window;
            this.btOpenEye3.BackgroundImage = global::PBL.Properties.Resources.Eye;
            this.btOpenEye3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOpenEye3.FlatAppearance.BorderSize = 0;
            this.btOpenEye3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenEye3.Location = new System.Drawing.Point(302, 99);
            this.btOpenEye3.Name = "btOpenEye3";
            this.btOpenEye3.Size = new System.Drawing.Size(25, 25);
            this.btOpenEye3.TabIndex = 7;
            this.btOpenEye3.UseVisualStyleBackColor = false;
            this.btOpenEye3.Visible = false;
            this.btOpenEye3.Click += new System.EventHandler(this.btOpenEye_Click3);
            // 
            // btCloseEye3
            // 
            this.btCloseEye3.BackColor = System.Drawing.SystemColors.Window;
            this.btCloseEye3.BackgroundImage = global::PBL.Properties.Resources.Hide;
            this.btCloseEye3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCloseEye3.FlatAppearance.BorderSize = 0;
            this.btCloseEye3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseEye3.Location = new System.Drawing.Point(302, 99);
            this.btCloseEye3.Name = "btCloseEye3";
            this.btCloseEye3.Size = new System.Drawing.Size(25, 25);
            this.btCloseEye3.TabIndex = 7;
            this.btCloseEye3.UseVisualStyleBackColor = false;
            this.btCloseEye3.Visible = false;
            this.btCloseEye3.Click += new System.EventHandler(this.btCloseEye_Click3);
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
            this.txtEmail.Location = new System.Drawing.Point(80, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = true;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Enter current password";
            this.txtEmail.Size = new System.Drawing.Size(251, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail._TextChanged += new System.EventHandler(this.txtPass__TextChanged);
            // 
            // ChangePassword
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
            this.Name = "ChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbLogin;
        private Controller.RoundButton btnConfirm;
        private RoundPanel panelLogin;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private Controller.RoundTextBox txtPass2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpenEye2;
        private System.Windows.Forms.Button btCloseEye2;
        private Controller.RoundButton btnReturn;
        private System.Windows.Forms.Button btOpenEye1;
        private System.Windows.Forms.Button btOpenEye3;
        private System.Windows.Forms.Button btCloseEye1;
        private System.Windows.Forms.Button btCloseEye3;
        private Controller.RoundTextBox txtPass1;
        private Controller.RoundTextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnRestoreDown;
    }
}