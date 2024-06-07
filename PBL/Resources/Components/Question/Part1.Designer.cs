namespace PBL.Resources.Components
{
    partial class Part1
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.cbbAnswers = new System.Windows.Forms.ComboBox();
            this.txtNumber = new PBL.Controller.RoundTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.btnDelete);
            this.roundPanel1.Controls.Add(this.btnChoose);
            this.roundPanel1.Controls.Add(this.imageBox);
            this.roundPanel1.Controls.Add(this.cbbAnswers);
            this.roundPanel1.Controls.Add(this.txtNumber);
            this.roundPanel1.Controls.Add(this.label2);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.CornerRadius = 10;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(288, 245);
            this.roundPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Question: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.Location = new System.Drawing.Point(171, 45);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 24);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChoose.AutoSize = true;
            this.btnChoose.BackColor = System.Drawing.Color.White;
            this.btnChoose.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChoose.Location = new System.Drawing.Point(86, 45);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(64, 24);
            this.btnChoose.TabIndex = 52;
            this.btnChoose.Text = "Chọn Ảnh";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // imageBox
            // 
            this.imageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox.Location = new System.Drawing.Point(21, 73);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(246, 159);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 51;
            this.imageBox.TabStop = false;
            // 
            // cbbAnswers
            // 
            this.cbbAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbAnswers.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbAnswers.FormattingEnabled = true;
            this.cbbAnswers.Location = new System.Drawing.Point(229, 15);
            this.cbbAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAnswers.Name = "cbbAnswers";
            this.cbbAnswers.Size = new System.Drawing.Size(38, 21);
            this.cbbAnswers.TabIndex = 50;
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
            this.txtNumber.Location = new System.Drawing.Point(92, 13);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNumber.PasswordChar = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.Size = new System.Drawing.Size(43, 29);
            this.txtNumber.TabIndex = 49;
            this.txtNumber.Texts = "";
            this.txtNumber.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Content:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Answer:";
            // 
            // Part1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPanel1);
            this.Name = "Part1";
            this.Size = new System.Drawing.Size(288, 245);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.ComboBox cbbAnswers;
        private Controller.RoundTextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
