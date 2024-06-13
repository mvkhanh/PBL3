using PBL.Resources.Components;

namespace PBL.Views.Student.StudentTest
{
    partial class StudentDoTestView
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelQuestionNum = new System.Windows.Forms.FlowLayoutPanel();
            this.roundPanel3 = new RoundPanel();
            this.lbTimeRemain = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnFinish = new PBL.Controller.RoundButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.lbAudio = new System.Windows.Forms.Label();
            this.colorSlider1 = new PBL.Resources.Components.ColorSlider();
            this.panelBtn.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelBtn
            // 
            this.panelBtn.AutoSize = true;
            this.panelBtn.Controls.Add(this.btnNext);
            this.panelBtn.Controls.Add(this.btnPrevious);
            this.panelBtn.Location = new System.Drawing.Point(3, 3);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(896, 50);
            this.panelBtn.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 24;
            this.btnNext.Location = new System.Drawing.Point(818, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnPrevious.IconColor = System.Drawing.Color.Black;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 24;
            this.btnPrevious.Location = new System.Drawing.Point(99, 17);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 30);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.panelBtn);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMain.Location = new System.Drawing.Point(0, 83);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(960, 559);
            this.panelMain.TabIndex = 6;
            this.panelMain.WrapContents = false;
            // 
            // panelQuestionNum
            // 
            this.panelQuestionNum.AutoScroll = true;
            this.panelQuestionNum.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelQuestionNum.Location = new System.Drawing.Point(960, 83);
            this.panelQuestionNum.Name = "panelQuestionNum";
            this.panelQuestionNum.Size = new System.Drawing.Size(307, 559);
            this.panelQuestionNum.TabIndex = 7;
            // 
            // roundPanel3
            // 
            this.roundPanel3.Controls.Add(this.lbTimeRemain);
            this.roundPanel3.Controls.Add(this.lbTime);
            this.roundPanel3.Controls.Add(this.btnFinish);
            this.roundPanel3.Controls.Add(this.btnPlay);
            this.roundPanel3.Controls.Add(this.lbAudio);
            this.roundPanel3.Controls.Add(this.colorSlider1);
            this.roundPanel3.CornerRadius = 10;
            this.roundPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundPanel3.Location = new System.Drawing.Point(0, 0);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(1267, 83);
            this.roundPanel3.TabIndex = 5;
            // 
            // lbTimeRemain
            // 
            this.lbTimeRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeRemain.AutoSize = true;
            this.lbTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRemain.Location = new System.Drawing.Point(981, 14);
            this.lbTimeRemain.Name = "lbTimeRemain";
            this.lbTimeRemain.Size = new System.Drawing.Size(126, 25);
            this.lbTimeRemain.TabIndex = 9;
            this.lbTimeRemain.Text = "Time remain:";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1113, 14);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(62, 25);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "00:00";
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFinish.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFinish.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinish.BorderRadius = 5;
            this.btnFinish.BorderSize = 0;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(1030, 42);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(101, 34);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextColor = System.Drawing.Color.White;
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.Black;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 15;
            this.btnPlay.Location = new System.Drawing.Point(66, 18);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(34, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbAudio
            // 
            this.lbAudio.AutoSize = true;
            this.lbAudio.Location = new System.Drawing.Point(869, 23);
            this.lbAudio.Name = "lbAudio";
            this.lbAudio.Size = new System.Drawing.Size(34, 13);
            this.lbAudio.TabIndex = 2;
            this.lbAudio.Text = "00:00";
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.colorSlider1.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSlider1.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider1.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.colorSlider1.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.colorSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSlider1.ForeColor = System.Drawing.Color.White;
            this.colorSlider1.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider1.Location = new System.Drawing.Point(106, 21);
            this.colorSlider1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.colorSlider1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSlider1.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider1.ShowDivisionsText = true;
            this.colorSlider1.ShowSmallScale = false;
            this.colorSlider1.Size = new System.Drawing.Size(745, 17);
            this.colorSlider1.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSlider1.TabIndex = 1;
            this.colorSlider1.Text = "colorSlider1";
            this.colorSlider1.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider1.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSlider1.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSlider1.TickAdd = 0F;
            this.colorSlider1.TickColor = System.Drawing.Color.White;
            this.colorSlider1.TickDivide = 0F;
            this.colorSlider1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider1_Scroll);
            // 
            // StudentDoTestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 642);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelQuestionNum);
            this.Controls.Add(this.roundPanel3);
            this.Name = "StudentDoTestView";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentDoTestView_FormClosing);
            this.Load += new System.EventHandler(this.StudentDoTestView_Load);
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelBtn;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.Label lbAudio;
        private ColorSlider colorSlider1;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Label lbTimeRemain;
        private System.Windows.Forms.Label lbTime;
        private Controller.RoundButton btnFinish;
        private System.Windows.Forms.FlowLayoutPanel panelQuestionNum;
    }
}