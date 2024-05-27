namespace PBL.Resources.Components
{
    partial class AddQuestion
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.ImageOK = new System.Windows.Forms.PictureBox();
            this.cbbAnswer = new System.Windows.Forms.ComboBox();
            this.txtContent = new PBL.Controller.RoundTextBox();
            this.txtD = new PBL.Controller.RoundTextBox();
            this.txtC = new PBL.Controller.RoundTextBox();
            this.txtB = new PBL.Controller.RoundTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtA = new PBL.Controller.RoundTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new PBL.Controller.RoundTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.SeaShell;
            this.roundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.button1);
            this.roundPanel1.Controls.Add(this.btnImage);
            this.roundPanel1.Controls.Add(this.ImageOK);
            this.roundPanel1.Controls.Add(this.cbbAnswer);
            this.roundPanel1.Controls.Add(this.txtContent);
            this.roundPanel1.Controls.Add(this.txtD);
            this.roundPanel1.Controls.Add(this.txtC);
            this.roundPanel1.Controls.Add(this.txtB);
            this.roundPanel1.Controls.Add(this.label7);
            this.roundPanel1.Controls.Add(this.txtA);
            this.roundPanel1.Controls.Add(this.label6);
            this.roundPanel1.Controls.Add(this.txtNumber);
            this.roundPanel1.Controls.Add(this.label5);
            this.roundPanel1.Controls.Add(this.label2);
            this.roundPanel1.Controls.Add(this.label4);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.CornerRadius = 30;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(718, 301);
            this.roundPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Question: ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(184, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImage.Location = new System.Drawing.Point(97, 50);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(81, 29);
            this.btnImage.TabIndex = 27;
            this.btnImage.Text = "Chọn Ảnh";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // ImageOK
            // 
            this.ImageOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageOK.Location = new System.Drawing.Point(20, 178);
            this.ImageOK.Name = "ImageOK";
            this.ImageOK.Size = new System.Drawing.Size(298, 98);
            this.ImageOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageOK.TabIndex = 26;
            this.ImageOK.TabStop = false;
            // 
            // cbbAnswer
            // 
            this.cbbAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbAnswer.FormattingEnabled = true;
            this.cbbAnswer.Location = new System.Drawing.Point(458, 266);
            this.cbbAnswer.Name = "cbbAnswer";
            this.cbbAnswer.Size = new System.Drawing.Size(50, 24);
            this.cbbAnswer.TabIndex = 25;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContent.BackColor = System.Drawing.SystemColors.Window;
            this.txtContent.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtContent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtContent.BorderRadius = 0;
            this.txtContent.BorderSize = 2;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContent.Location = new System.Drawing.Point(20, 86);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContent.PasswordChar = false;
            this.txtContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContent.PlaceholderText = "";
            this.txtContent.Size = new System.Drawing.Size(299, 85);
            this.txtContent.TabIndex = 23;
            this.txtContent.Texts = "";
            this.txtContent.UnderlinedStyle = false;
            // 
            // txtD
            // 
            this.txtD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtD.BackColor = System.Drawing.SystemColors.Window;
            this.txtD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtD.BorderRadius = 0;
            this.txtD.BorderSize = 2;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtD.Location = new System.Drawing.Point(408, 224);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtD.PasswordChar = false;
            this.txtD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtD.PlaceholderText = "";
            this.txtD.Size = new System.Drawing.Size(288, 35);
            this.txtD.TabIndex = 22;
            this.txtD.Texts = "";
            this.txtD.UnderlinedStyle = false;
            // 
            // txtC
            // 
            this.txtC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtC.BackColor = System.Drawing.SystemColors.Window;
            this.txtC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtC.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtC.BorderRadius = 0;
            this.txtC.BorderSize = 2;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtC.Location = new System.Drawing.Point(408, 156);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtC.PasswordChar = false;
            this.txtC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtC.PlaceholderText = "";
            this.txtC.Size = new System.Drawing.Size(287, 35);
            this.txtC.TabIndex = 24;
            this.txtC.Texts = "";
            this.txtC.UnderlinedStyle = false;
            // 
            // txtB
            // 
            this.txtB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtB.BackColor = System.Drawing.SystemColors.Window;
            this.txtB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtB.BorderRadius = 0;
            this.txtB.BorderSize = 2;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtB.Location = new System.Drawing.Point(406, 86);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtB.PasswordChar = false;
            this.txtB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtB.PlaceholderText = "";
            this.txtB.Size = new System.Drawing.Size(288, 35);
            this.txtB.TabIndex = 21;
            this.txtB.Texts = "";
            this.txtB.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(373, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "D:";
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA.BackColor = System.Drawing.SystemColors.Window;
            this.txtA.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtA.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtA.BorderRadius = 0;
            this.txtA.BorderSize = 2;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtA.Location = new System.Drawing.Point(407, 13);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtA.PasswordChar = false;
            this.txtA.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtA.PlaceholderText = "";
            this.txtA.Size = new System.Drawing.Size(288, 35);
            this.txtA.TabIndex = 20;
            this.txtA.Texts = "";
            this.txtA.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(373, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "C:";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber.BorderRadius = 15;
            this.txtNumber.BorderSize = 2;
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumber.Location = new System.Drawing.Point(114, 8);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumber.PasswordChar = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.Size = new System.Drawing.Size(46, 35);
            this.txtNumber.TabIndex = 19;
            this.txtNumber.Texts = "";
            this.txtNumber.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(372, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "B:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Content:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(372, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "A:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(373, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Answer:";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPanel1);
            this.Name = "AddQuestion";
            this.Size = new System.Drawing.Size(718, 301);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox ImageOK;
        private System.Windows.Forms.ComboBox cbbAnswer;
        private Controller.RoundTextBox txtContent;
        private Controller.RoundTextBox txtD;
        private Controller.RoundTextBox txtC;
        private Controller.RoundTextBox txtB;
        private System.Windows.Forms.Label label7;
        private Controller.RoundTextBox txtA;
        private System.Windows.Forms.Label label6;
        private Controller.RoundTextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
