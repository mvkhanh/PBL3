namespace PBL.Views.Teacher.TeacherMain
{
    partial class TeacherMainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMainView));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTests = new FontAwesome.Sharp.IconButton();
            this.btnLessons = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnRestoreDown = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnTests);
            this.panelMenu.Controls.Add(this.btnLessons);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 533);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // btnTests
            // 
            this.btnTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTests.FlatAppearance.BorderSize = 0;
            this.btnTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTests.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTests.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnTests.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTests.IconSize = 32;
            this.btnTests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTests.Location = new System.Drawing.Point(0, 260);
            this.btnTests.Margin = new System.Windows.Forms.Padding(6);
            this.btnTests.Name = "btnTests";
            this.btnTests.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTests.Size = new System.Drawing.Size(220, 60);
            this.btnTests.TabIndex = 5;
            this.btnTests.Text = "Tests";
            this.btnTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTests.UseVisualStyleBackColor = true;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // btnLessons
            // 
            this.btnLessons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLessons.FlatAppearance.BorderSize = 0;
            this.btnLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessons.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLessons.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLessons.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLessons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLessons.IconSize = 32;
            this.btnLessons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLessons.Location = new System.Drawing.Point(0, 200);
            this.btnLessons.Margin = new System.Windows.Forms.Padding(6);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLessons.Size = new System.Drawing.Size(220, 60);
            this.btnLessons.TabIndex = 4;
            this.btnLessons.Text = "Lessons";
            this.btnLessons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLessons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLessons.UseVisualStyleBackColor = true;
            this.btnLessons.Click += new System.EventHandler(this.btnLessons_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 32;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 140);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProfile.Size = new System.Drawing.Size(220, 60);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::PBL.Properties.Resources.TOEIC_Master;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 140);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(906, 75);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lbTeacherName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(599, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(259, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTeacherName.Location = new System.Drawing.Point(27, 19);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(206, 33);
            this.lbTeacherName.TabIndex = 1;
            this.lbTeacherName.Text = "Hello, huydeptrai!";
            this.lbTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitleChildForm.Location = new System.Drawing.Point(80, 30);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Home";
            this.lbTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(42, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Location = new System.Drawing.Point(220, 72);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(906, 10);
            this.panelShadow.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(43)))), ((int)(((byte)(106)))));
            this.panelTitle.Controls.Add(this.btnMinisize);
            this.panelTitle.Controls.Add(this.btnRestoreDown);
            this.panelTitle.Controls.Add(this.btClose);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1126, 26);
            this.panelTitle.TabIndex = 11;
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
            this.btnMinisize.Location = new System.Drawing.Point(1048, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(20, 26);
            this.btnMinisize.TabIndex = 6;
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
            this.btnRestoreDown.Location = new System.Drawing.Point(1068, 0);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(29, 26);
            this.btnRestoreDown.TabIndex = 5;
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
            this.btClose.Location = new System.Drawing.Point(1097, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(29, 26);
            this.btClose.TabIndex = 4;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(82, 26);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "TOEIC Master";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.panelTitleBar);
            this.panelMain.Controls.Add(this.panelDesktop);
            this.panelMain.Controls.Add(this.panelShadow);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 26);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1126, 533);
            this.panelMain.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Location = new System.Drawing.Point(220, 81);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(906, 452);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.panelDesktop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseMove);
            // 
            // TeacherMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1126, 559);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TeacherMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView2";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnTests;
        private FontAwesome.Sharp.IconButton btnLessons;
        private FontAwesome.Sharp.IconButton btnProfile;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbTeacherName;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnRestoreDown;
        private System.Windows.Forms.Button btClose;
    }
}