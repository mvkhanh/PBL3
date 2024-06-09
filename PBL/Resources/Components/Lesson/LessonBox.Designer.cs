namespace PBL.Resources.Components.Lesson
{
    partial class LessonBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonBox));
            this.roundPanel1 = new RoundPanel();
            this.lbLessonTeacher = new FontAwesome.Sharp.IconButton();
            this.lbLessonPublishDay = new FontAwesome.Sharp.IconButton();
            this.lbLessonViews = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLessonName = new PBL.Controller.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.roundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundPanel1.Controls.Add(this.lbLessonTeacher);
            this.roundPanel1.Controls.Add(this.lbLessonPublishDay);
            this.roundPanel1.Controls.Add(this.lbLessonViews);
            this.roundPanel1.Controls.Add(this.panel1);
            this.roundPanel1.CornerRadius = 15;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(326, 205);
            this.roundPanel1.TabIndex = 0;
            // 
            // lbLessonTeacher
            // 
            this.lbLessonTeacher.BackColor = System.Drawing.Color.Transparent;
            this.lbLessonTeacher.Enabled = false;
            this.lbLessonTeacher.FlatAppearance.BorderSize = 0;
            this.lbLessonTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLessonTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbLessonTeacher.IconChar = FontAwesome.Sharp.IconChar.User;
            this.lbLessonTeacher.IconColor = System.Drawing.Color.WhiteSmoke;
            this.lbLessonTeacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbLessonTeacher.IconSize = 28;
            this.lbLessonTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLessonTeacher.Location = new System.Drawing.Point(12, 146);
            this.lbLessonTeacher.Name = "lbLessonTeacher";
            this.lbLessonTeacher.Size = new System.Drawing.Size(216, 30);
            this.lbLessonTeacher.TabIndex = 1;
            this.lbLessonTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbLessonTeacher.UseVisualStyleBackColor = false;
            // 
            // lbLessonPublishDay
            // 
            this.lbLessonPublishDay.BackColor = System.Drawing.Color.Transparent;
            this.lbLessonPublishDay.Enabled = false;
            this.lbLessonPublishDay.FlatAppearance.BorderSize = 0;
            this.lbLessonPublishDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLessonPublishDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonPublishDay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbLessonPublishDay.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.lbLessonPublishDay.IconColor = System.Drawing.Color.WhiteSmoke;
            this.lbLessonPublishDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbLessonPublishDay.IconSize = 20;
            this.lbLessonPublishDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLessonPublishDay.Location = new System.Drawing.Point(234, 171);
            this.lbLessonPublishDay.Name = "lbLessonPublishDay";
            this.lbLessonPublishDay.Size = new System.Drawing.Size(107, 33);
            this.lbLessonPublishDay.TabIndex = 1;
            this.lbLessonPublishDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbLessonPublishDay.UseVisualStyleBackColor = false;
            // 
            // lbLessonViews
            // 
            this.lbLessonViews.BackColor = System.Drawing.Color.Transparent;
            this.lbLessonViews.Enabled = false;
            this.lbLessonViews.FlatAppearance.BorderSize = 0;
            this.lbLessonViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLessonViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonViews.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbLessonViews.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.lbLessonViews.IconColor = System.Drawing.Color.WhiteSmoke;
            this.lbLessonViews.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbLessonViews.IconSize = 20;
            this.lbLessonViews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLessonViews.Location = new System.Drawing.Point(234, 146);
            this.lbLessonViews.Name = "lbLessonViews";
            this.lbLessonViews.Size = new System.Drawing.Size(87, 30);
            this.lbLessonViews.TabIndex = 1;
            this.lbLessonViews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbLessonViews.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtLessonName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 140);
            this.panel1.TabIndex = 0;
            // 
            // txtLessonName
            // 
            this.txtLessonName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLessonName.BorderColor = System.Drawing.Color.Transparent;
            this.txtLessonName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtLessonName.BorderRadius = 0;
            this.txtLessonName.BorderSize = 2;
            this.txtLessonName.Enabled = false;
            this.txtLessonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLessonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(151)))), ((int)(((byte)(70)))));
            this.txtLessonName.Location = new System.Drawing.Point(11, 24);
            this.txtLessonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLessonName.Multiline = true;
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLessonName.PasswordChar = false;
            this.txtLessonName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLessonName.PlaceholderText = "";
            this.txtLessonName.Size = new System.Drawing.Size(175, 112);
            this.txtLessonName.TabIndex = 2;
            this.txtLessonName.Texts = "Lesson name 123123123";
            this.txtLessonName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOEIC Master";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LessonBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPanel1);
            this.Name = "LessonBox";
            this.Size = new System.Drawing.Size(326, 205);
            this.roundPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton lbLessonViews;
        private Controller.RoundTextBox txtLessonName;
        private FontAwesome.Sharp.IconButton lbLessonPublishDay;
        private FontAwesome.Sharp.IconButton lbLessonTeacher;
    }
}
