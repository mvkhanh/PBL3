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
            this.label28 = new System.Windows.Forms.Label();
            this.tabPageLessonContent = new System.Windows.Forms.TabPage();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLesson3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTitleLessson3 = new System.Windows.Forms.Label();
            this.txtNameLesson3 = new System.Windows.Forms.Label();
            this.panelLesson2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTitleLessson2 = new System.Windows.Forms.Label();
            this.txtNameLesson2 = new System.Windows.Forms.Label();
            this.panelLesson1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitleLessson1 = new System.Windows.Forms.Label();
            this.txtNameLesson1 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.roundTextBox1 = new PBL.Controller.RoundTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageLessonList.SuspendLayout();
            this.tabPageLessonContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLesson3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelLesson2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelLesson1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabPageLessonList.Controls.Add(this.roundTextBox1);
            this.tabPageLessonList.Controls.Add(this.iconButton6);
            this.tabPageLessonList.Controls.Add(this.iconButton5);
            this.tabPageLessonList.Controls.Add(this.iconButton4);
            this.tabPageLessonList.Controls.Add(this.iconButton3);
            this.tabPageLessonList.Controls.Add(this.iconButton2);
            this.tabPageLessonList.Controls.Add(this.iconButton1);
            this.tabPageLessonList.Controls.Add(this.panelLesson3);
            this.tabPageLessonList.Controls.Add(this.panelLesson2);
            this.tabPageLessonList.Controls.Add(this.panelLesson1);
            this.tabPageLessonList.Controls.Add(this.label28);
            this.tabPageLessonList.Controls.Add(this.btnSearch);
            this.tabPageLessonList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPageLessonList.Location = new System.Drawing.Point(4, 25);
            this.tabPageLessonList.Name = "tabPageLessonList";
            this.tabPageLessonList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLessonList.Size = new System.Drawing.Size(861, 438);
            this.tabPageLessonList.TabIndex = 0;
            this.tabPageLessonList.Text = "Lesson List";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label28.Location = new System.Drawing.Point(46, 85);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 24);
            this.label28.TabIndex = 50;
            this.label28.Text = "Explore";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageLessonContent
            // 
            this.tabPageLessonContent.Controls.Add(this.pdfViewer1);
            this.tabPageLessonContent.Controls.Add(this.panel1);
            this.tabPageLessonContent.Location = new System.Drawing.Point(4, 25);
            this.tabPageLessonContent.Name = "tabPageLessonContent";
            this.tabPageLessonContent.Size = new System.Drawing.Size(861, 438);
            this.tabPageLessonContent.TabIndex = 2;
            this.tabPageLessonContent.Text = "Lesson Content";
            this.tabPageLessonContent.UseVisualStyleBackColor = true;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.Color.White;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.ForeColor = System.Drawing.Color.Black;
            this.pdfViewer1.FormFillEnabled = false;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = false;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 24);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(861, 414);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 24);
            this.panel1.TabIndex = 1;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(509, 360);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(36, 34);
            this.iconButton6.TabIndex = 62;
            this.iconButton6.Text = ">";
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(467, 360);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(36, 34);
            this.iconButton5.TabIndex = 62;
            this.iconButton5.Text = "5";
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(425, 360);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(36, 34);
            this.iconButton4.TabIndex = 62;
            this.iconButton4.Text = "4";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(383, 360);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(36, 34);
            this.iconButton3.TabIndex = 62;
            this.iconButton3.Text = "3";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(341, 360);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 34);
            this.iconButton2.TabIndex = 62;
            this.iconButton2.Text = "2";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(299, 360);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 34);
            this.iconButton1.TabIndex = 62;
            this.iconButton1.Text = "1";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panelLesson3
            // 
            this.panelLesson3.BackgroundImage = global::PBL.Properties.Resources.backgroundLesson3;
            this.panelLesson3.Controls.Add(this.panel7);
            this.panelLesson3.Controls.Add(this.txtTitleLessson3);
            this.panelLesson3.Controls.Add(this.txtNameLesson3);
            this.panelLesson3.Location = new System.Drawing.Point(586, 127);
            this.panelLesson3.Name = "panelLesson3";
            this.panelLesson3.Size = new System.Drawing.Size(214, 175);
            this.panelLesson3.TabIndex = 61;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Location = new System.Drawing.Point(0, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 61);
            this.panel7.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(160, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 60;
            this.label19.Text = "Stars";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(72, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 60;
            this.label20.Text = "Comments";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(9, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 16);
            this.label21.TabIndex = 60;
            this.label21.Text = "Views";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(163, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 16);
            this.label22.TabIndex = 50;
            this.label22.Text = "4.9";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(85, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 16);
            this.label23.TabIndex = 50;
            this.label23.Text = "1432";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(12, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 16);
            this.label24.TabIndex = 50;
            this.label24.Text = "678";
            // 
            // txtTitleLessson3
            // 
            this.txtTitleLessson3.AutoSize = true;
            this.txtTitleLessson3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitleLessson3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleLessson3.ForeColor = System.Drawing.Color.White;
            this.txtTitleLessson3.Location = new System.Drawing.Point(4, 9);
            this.txtTitleLessson3.Name = "txtTitleLessson3";
            this.txtTitleLessson3.Size = new System.Drawing.Size(145, 16);
            this.txtTitleLessson3.TabIndex = 60;
            this.txtTitleLessson3.Text = "Basic tenses in English";
            // 
            // txtNameLesson3
            // 
            this.txtNameLesson3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNameLesson3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLesson3.ForeColor = System.Drawing.Color.White;
            this.txtNameLesson3.Location = new System.Drawing.Point(24, 39);
            this.txtNameLesson3.Name = "txtNameLesson3";
            this.txtNameLesson3.Size = new System.Drawing.Size(167, 48);
            this.txtNameLesson3.TabIndex = 50;
            this.txtNameLesson3.Text = "Present Simple  Tense";
            this.txtNameLesson3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLesson2
            // 
            this.panelLesson2.BackgroundImage = global::PBL.Properties.Resources.backgroundlessson2;
            this.panelLesson2.Controls.Add(this.panel5);
            this.panelLesson2.Controls.Add(this.txtTitleLessson2);
            this.panelLesson2.Controls.Add(this.txtNameLesson2);
            this.panelLesson2.Location = new System.Drawing.Point(314, 127);
            this.panelLesson2.Name = "panelLesson2";
            this.panelLesson2.Size = new System.Drawing.Size(214, 175);
            this.panelLesson2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(0, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 61);
            this.panel5.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(160, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Stars";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(72, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "Comments";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(9, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 60;
            this.label12.Text = "Views";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(163, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "4.9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(85, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "1432";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(12, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "678";
            // 
            // txtTitleLessson2
            // 
            this.txtTitleLessson2.AutoSize = true;
            this.txtTitleLessson2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitleLessson2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleLessson2.ForeColor = System.Drawing.Color.White;
            this.txtTitleLessson2.Location = new System.Drawing.Point(4, 9);
            this.txtTitleLessson2.Name = "txtTitleLessson2";
            this.txtTitleLessson2.Size = new System.Drawing.Size(145, 16);
            this.txtTitleLessson2.TabIndex = 60;
            this.txtTitleLessson2.Text = "Basic tenses in English";
            // 
            // txtNameLesson2
            // 
            this.txtNameLesson2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNameLesson2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLesson2.ForeColor = System.Drawing.Color.White;
            this.txtNameLesson2.Location = new System.Drawing.Point(22, 39);
            this.txtNameLesson2.Name = "txtNameLesson2";
            this.txtNameLesson2.Size = new System.Drawing.Size(167, 48);
            this.txtNameLesson2.TabIndex = 50;
            this.txtNameLesson2.Text = "Present Simple  Tense";
            this.txtNameLesson2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLesson1
            // 
            this.panelLesson1.BackgroundImage = global::PBL.Properties.Resources.backgroudlessson1;
            this.panelLesson1.Controls.Add(this.panel3);
            this.panelLesson1.Controls.Add(this.txtTitleLessson1);
            this.panelLesson1.Controls.Add(this.txtNameLesson1);
            this.panelLesson1.Location = new System.Drawing.Point(50, 126);
            this.panelLesson1.Name = "panelLesson1";
            this.panelLesson1.Size = new System.Drawing.Size(214, 175);
            this.panelLesson1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 61);
            this.panel3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(160, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Stars";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Comments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Views";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "4.9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(85, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "1432";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "678";
            // 
            // txtTitleLessson1
            // 
            this.txtTitleLessson1.AutoSize = true;
            this.txtTitleLessson1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitleLessson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleLessson1.ForeColor = System.Drawing.Color.White;
            this.txtTitleLessson1.Location = new System.Drawing.Point(4, 9);
            this.txtTitleLessson1.Name = "txtTitleLessson1";
            this.txtTitleLessson1.Size = new System.Drawing.Size(145, 16);
            this.txtTitleLessson1.TabIndex = 60;
            this.txtTitleLessson1.Text = "Basic tenses in English";
            // 
            // txtNameLesson1
            // 
            this.txtNameLesson1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNameLesson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLesson1.ForeColor = System.Drawing.Color.White;
            this.txtNameLesson1.Location = new System.Drawing.Point(24, 40);
            this.txtNameLesson1.Name = "txtNameLesson1";
            this.txtNameLesson1.Size = new System.Drawing.Size(167, 48);
            this.txtNameLesson1.TabIndex = 50;
            this.txtNameLesson1.Text = "Present Simple  Tense";
            this.txtNameLesson1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSearch.Location = new System.Drawing.Point(686, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 16;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 24);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundTextBox1.BorderRadius = 0;
            this.roundTextBox1.BorderSize = 2;
            this.roundTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundTextBox1.Location = new System.Drawing.Point(94, 24);
            this.roundTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundTextBox1.Multiline = false;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundTextBox1.PasswordChar = false;
            this.roundTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundTextBox1.PlaceholderText = "";
            this.roundTextBox1.Size = new System.Drawing.Size(572, 31);
            this.roundTextBox1.TabIndex = 63;
            this.roundTextBox1.Texts = "Enter the keyword of the lesson you want to search for";
            this.roundTextBox1.UnderlinedStyle = false;
            // 
            // StudentLessonView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(869, 467);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLessonView";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.StudentLessonView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLessonList.ResumeLayout(false);
            this.tabPageLessonList.PerformLayout();
            this.tabPageLessonContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLesson3.ResumeLayout(false);
            this.panelLesson3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelLesson2.ResumeLayout(false);
            this.panelLesson2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelLesson1.ResumeLayout(false);
            this.panelLesson1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLessonList;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TabPage tabPageLessonContent;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Panel panelLesson1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelLesson3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txtTitleLessson3;
        private System.Windows.Forms.Panel panelLesson2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtTitleLessson2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtTitleLessson1;
        private System.Windows.Forms.Label txtNameLesson1;
        private System.Windows.Forms.Label label28;
        private Controller.RoundTextBox roundTextBox1;
        private System.Windows.Forms.Label txtNameLesson3;
        private System.Windows.Forms.Label txtNameLesson2;
    }
}