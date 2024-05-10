namespace PBL.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnTests = new FontAwesome.Sharp.IconButton();
            this.btnLessons = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnTeachers = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnTests);
            this.panelMenu.Controls.Add(this.btnLessons);
            this.panelMenu.Controls.Add(this.btnStudents);
            this.panelMenu.Controls.Add(this.btnTeachers);
            this.panelMenu.Controls.Add(this.btnAccounts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 551);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 440);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.btnTests.Location = new System.Drawing.Point(0, 380);
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
            this.btnLessons.Location = new System.Drawing.Point(0, 320);
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
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudents.IconSize = 32;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 260);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStudents.Size = new System.Drawing.Size(220, 60);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeachers.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnTeachers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTeachers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeachers.IconSize = 32;
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(0, 200);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(6);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTeachers.Size = new System.Drawing.Size(220, 60);
            this.btnTeachers.TabIndex = 2;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 32;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 140);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccounts.Size = new System.Drawing.Size(220, 60);
            this.btnAccounts.TabIndex = 1;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
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
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(60, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(906, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitleChildForm.Location = new System.Drawing.Point(80, 30);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(41, 15);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Home";
            this.lbTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(906, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(906, 467);
            this.panelDesktop.TabIndex = 3;
            // 
            // MainView2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1126, 551);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainView2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView2";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnTests;
        private FontAwesome.Sharp.IconButton btnLessons;
        private FontAwesome.Sharp.IconButton btnStudents;
        private FontAwesome.Sharp.IconButton btnTeachers;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}