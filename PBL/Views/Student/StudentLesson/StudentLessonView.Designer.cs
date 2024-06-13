using System.Drawing;

namespace PBL
{
    partial class StudentLessonView
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
            this.tabPageLessonList = new System.Windows.Forms.TabPage();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new RoundPanel();
            this.cbSavedLessons = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSearch = new PBL.Controller.RoundTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.tabPageLessonContent = new System.Windows.Forms.TabPage();
            this.panelComments = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtComment = new PBL.Controller.RoundTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.tabControl1.SuspendLayout();
            this.tabPageLessonList.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tabPageLessonContent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLessonList);
            this.tabControl1.Controls.Add(this.tabPageLessonContent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 467);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLessonList
            // 
            this.tabPageLessonList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageLessonList.Controls.Add(this.panelContent);
            this.tabPageLessonList.Controls.Add(this.panelTop);
            this.tabPageLessonList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPageLessonList.Location = new System.Drawing.Point(4, 25);
            this.tabPageLessonList.Name = "tabPageLessonList";
            this.tabPageLessonList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLessonList.Size = new System.Drawing.Size(861, 438);
            this.tabPageLessonList.TabIndex = 0;
            this.tabPageLessonList.Text = "Lesson List";
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoSize = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 141);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(855, 294);
            this.panelContent.TabIndex = 65;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbSavedLessons);
            this.panelTop.Controls.Add(this.label28);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.CornerRadius = 10;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(855, 138);
            this.panelTop.TabIndex = 64;
            // 
            // cbSavedLessons
            // 
            this.cbSavedLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSavedLessons.AutoSize = true;
            this.cbSavedLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSavedLessons.Location = new System.Drawing.Point(582, 58);
            this.cbSavedLessons.Name = "cbSavedLessons";
            this.cbSavedLessons.Size = new System.Drawing.Size(218, 22);
            this.cbSavedLessons.TabIndex = 64;
            this.cbSavedLessons.Text = "Show only saved lessons";
            this.cbSavedLessons.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label28.Location = new System.Drawing.Point(16, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(197, 24);
            this.label28.TabIndex = 50;
            this.label28.Text = "Explore our lessons";
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
            this.txtSearch.PlaceholderText = "Enter lesson name keyword";
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
            // tabPageLessonContent
            // 
            this.tabPageLessonContent.Controls.Add(this.panel3);
            this.tabPageLessonContent.Controls.Add(this.panelComments);
            
            this.tabPageLessonContent.Controls.Add(this.panel1);
            this.tabPageLessonContent.Controls.Add(this.pdfViewer1);
            this.tabPageLessonContent.Location = new System.Drawing.Point(4, 25);
            this.tabPageLessonContent.Name = "tabPageLessonContent";
            this.tabPageLessonContent.Size = new System.Drawing.Size(861, 438);
            this.tabPageLessonContent.TabIndex = 2;
            this.tabPageLessonContent.Text = "Lesson Content";
            this.tabPageLessonContent.UseVisualStyleBackColor = true;
            // 
            // panelComments
            // 
            this.panelComments.AutoScroll = true;
            this.panelComments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelComments.Location = new System.Drawing.Point(0, 261);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(861, 100);
            this.panelComments.TabIndex = 101;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtComment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(861, 77);
            this.panel3.TabIndex = 98;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSend.IconColor = System.Drawing.Color.White;
            this.btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSend.IconSize = 24;
            this.btnSend.Location = new System.Drawing.Point(639, 37);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 31);
            this.btnSend.TabIndex = 87;
            this.btnSend.Text = "Send";
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label18.Location = new System.Drawing.Point(6, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 24);
            this.label18.TabIndex = 86;
            this.label18.Text = "Comments";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.SystemColors.Window;
            this.txtComment.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComment.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtComment.BorderRadius = 0;
            this.txtComment.BorderSize = 2;
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComment.Location = new System.Drawing.Point(10, 37);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComment.PasswordChar = false;
            this.txtComment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComment.PlaceholderText = "Share your thoughts";
            this.txtComment.Size = new System.Drawing.Size(622, 31);
            this.txtComment.TabIndex = 88;
            this.txtComment.Texts = "";
            this.txtComment.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 24;
            this.btnSave.Location = new System.Drawing.Point(771, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 24;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 48);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.Color.White;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.ForeColor = System.Drawing.Color.Black;
            this.pdfViewer1.FormFillEnabled = true;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = false;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(861, 438);
            this.pdfViewer1.TabIndex = 100;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // StudentLessonView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(869, 467);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLessonView";
            this.Text = "Lessons";
            this.Load += new System.EventHandler(this.StudentLessonView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLessonList.ResumeLayout(false);
            this.tabPageLessonList.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabPageLessonContent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLessonList;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TabPage tabPageLessonContent;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label label28;
        private Controller.RoundTextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private RoundPanel panelTop;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.CheckBox cbSavedLessons;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnSend;
        private System.Windows.Forms.Label label18;
        private Controller.RoundTextBox txtComment;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private System.Windows.Forms.FlowLayoutPanel panelComments;
    }
}