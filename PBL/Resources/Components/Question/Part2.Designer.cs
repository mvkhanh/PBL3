namespace PBL.Resources.Components
{
    partial class Part2
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
            this.roundPanel1 = new RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAnswers = new System.Windows.Forms.ComboBox();
            this.txtNumber = new PBL.Controller.RoundTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.AutoSize = true;
            this.roundPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.cbbAnswers);
            this.roundPanel1.Controls.Add(this.txtNumber);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.CornerRadius = 10;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(153, 80);
            this.roundPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Question: ";
            // 
            // cbbAnswers
            // 
            this.cbbAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbAnswers.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbAnswers.FormattingEnabled = true;
            this.cbbAnswers.Location = new System.Drawing.Point(90, 46);
            this.cbbAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAnswers.Name = "cbbAnswers";
            this.cbbAnswers.Size = new System.Drawing.Size(38, 21);
            this.cbbAnswers.TabIndex = 32;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber.BorderRadius = 15;
            this.txtNumber.BorderSize = 2;
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumber.Location = new System.Drawing.Point(85, 11);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNumber.PasswordChar = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.Size = new System.Drawing.Size(43, 29);
            this.txtNumber.TabIndex = 31;
            this.txtNumber.Texts = "";
            this.txtNumber.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Answer:";
            // 
            // Part2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPanel1);
            this.Name = "Part2";
            this.Size = new System.Drawing.Size(153, 80);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAnswers;
        private Controller.RoundTextBox txtNumber;
        private System.Windows.Forms.Label label3;
    }
}
