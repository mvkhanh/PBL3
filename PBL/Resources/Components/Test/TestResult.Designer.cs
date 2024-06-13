
namespace PBL.Resources.Components
{
    partial class TestResult
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
            this.WrongAnswer = new System.Windows.Forms.Label();
            this.lbcolon = new System.Windows.Forms.Label();
            this.CorrectAnswer = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Label();
            this.NumQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WrongAnswer
            // 
            this.WrongAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WrongAnswer.AutoSize = true;
            this.WrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswer.ForeColor = System.Drawing.Color.Crimson;
            this.WrongAnswer.Location = new System.Drawing.Point(78, 13);
            this.WrongAnswer.Name = "WrongAnswer";
            this.WrongAnswer.Size = new System.Drawing.Size(17, 16);
            this.WrongAnswer.TabIndex = 121;
            this.WrongAnswer.Text = "B";
            this.WrongAnswer.Visible = false;
            // 
            // lbcolon
            // 
            this.lbcolon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcolon.AutoSize = true;
            this.lbcolon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcolon.ForeColor = System.Drawing.Color.Black;
            this.lbcolon.Location = new System.Drawing.Point(61, 13);
            this.lbcolon.Name = "lbcolon";
            this.lbcolon.Size = new System.Drawing.Size(11, 16);
            this.lbcolon.TabIndex = 127;
            this.lbcolon.Text = ":";
            this.lbcolon.Visible = false;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CorrectAnswer.AutoSize = true;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.ForeColor = System.Drawing.Color.LimeGreen;
            this.CorrectAnswer.Location = new System.Drawing.Point(37, 13);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(18, 16);
            this.CorrectAnswer.TabIndex = 128;
            this.CorrectAnswer.Text = "D";
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetail.AutoSize = true;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDetail.Location = new System.Drawing.Point(114, 13);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(49, 16);
            this.btnDetail.TabIndex = 122;
            this.btnDetail.Text = "Details";
            // 
            // NumQuestion
            // 
            this.NumQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumQuestion.AutoSize = true;
            this.NumQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQuestion.ForeColor = System.Drawing.Color.Black;
            this.NumQuestion.Location = new System.Drawing.Point(16, 13);
            this.NumQuestion.Name = "NumQuestion";
            this.NumQuestion.Size = new System.Drawing.Size(15, 16);
            this.NumQuestion.TabIndex = 124;
            this.NumQuestion.Text = "3";
            // 
            // QuestionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WrongAnswer);
            this.Controls.Add(this.lbcolon);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.NumQuestion);
            this.Name = "QuestionResult";
            this.Size = new System.Drawing.Size(182, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WrongAnswer;
        private System.Windows.Forms.Label lbcolon;
        private System.Windows.Forms.Label CorrectAnswer;
        private System.Windows.Forms.Label btnDetail;
        private System.Windows.Forms.Label NumQuestion;
    }
}
