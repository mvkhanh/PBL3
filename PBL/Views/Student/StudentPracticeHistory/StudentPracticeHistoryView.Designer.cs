namespace PBL.Views.Student
{
    partial class StudentPracticeHistoryView
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
            this.lbSearch = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(906, 98);
            this.lbSearch.TabIndex = 3;
            this.lbSearch.Text = "Test Results:";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMain.Location = new System.Drawing.Point(0, 98);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(906, 369);
            this.panelMain.TabIndex = 4;
            this.panelMain.WrapContents = false;
            // 
            // StudentPracticeHistoryView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lbSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPracticeHistoryView";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentPracticeHistoryView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
    }
}