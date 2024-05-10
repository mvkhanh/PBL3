﻿namespace PBL.Views
{
    partial class TeacherView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTests = new System.Windows.Forms.TextBox();
            this.lbTests = new System.Windows.Forms.Label();
            this.txtLessons = new System.Windows.Forms.TextBox();
            this.lbLessons = new System.Windows.Forms.Label();
            this.regist = new System.Windows.Forms.DateTimePicker();
            this.lbRegist = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.lbBirth = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 59);
            this.panel1.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.AutoSize = true;
            this.btClose.Location = new System.Drawing.Point(862, 13);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(36, 40);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 408);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDelete);
            this.tabPage1.Controls.Add(this.btEdit);
            this.tabPage1.Controls.Add(this.btAddNew);
            this.tabPage1.Controls.Add(this.btSearch);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teacher List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.AutoSize = true;
            this.btDelete.Location = new System.Drawing.Point(757, 240);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 40);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.AutoSize = true;
            this.btEdit.Location = new System.Drawing.Point(757, 174);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 40);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            this.btAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNew.AutoSize = true;
            this.btAddNew.Location = new System.Drawing.Point(757, 114);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(109, 40);
            this.btAddNew.TabIndex = 4;
            this.btAddNew.Text = "Add new";
            this.btAddNew.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.AutoSize = true;
            this.btSearch.Location = new System.Drawing.Point(698, 42);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(90, 40);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(24, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(668, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search teacher:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(704, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTests);
            this.tabPage2.Controls.Add(this.lbTests);
            this.tabPage2.Controls.Add(this.txtLessons);
            this.tabPage2.Controls.Add(this.lbLessons);
            this.tabPage2.Controls.Add(this.regist);
            this.tabPage2.Controls.Add(this.lbRegist);
            this.tabPage2.Controls.Add(this.btCancel);
            this.tabPage2.Controls.Add(this.btSave);
            this.tabPage2.Controls.Add(this.birth);
            this.tabPage2.Controls.Add(this.lbBirth);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.lbPhone);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.lbEmail);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.lbName);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.lbId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher detail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTests
            // 
            this.txtTests.Location = new System.Drawing.Point(367, 107);
            this.txtTests.Name = "txtTests";
            this.txtTests.ReadOnly = true;
            this.txtTests.Size = new System.Drawing.Size(125, 22);
            this.txtTests.TabIndex = 17;
            this.txtTests.Text = "0";
            // 
            // lbTests
            // 
            this.lbTests.AutoSize = true;
            this.lbTests.Location = new System.Drawing.Point(364, 91);
            this.lbTests.Name = "lbTests";
            this.lbTests.Size = new System.Drawing.Size(92, 13);
            this.lbTests.TabIndex = 16;
            this.lbTests.Text = "Number of tests:";
            // 
            // txtLessons
            // 
            this.txtLessons.Location = new System.Drawing.Point(210, 107);
            this.txtLessons.Name = "txtLessons";
            this.txtLessons.ReadOnly = true;
            this.txtLessons.Size = new System.Drawing.Size(125, 22);
            this.txtLessons.TabIndex = 15;
            this.txtLessons.Text = "0";
            // 
            // lbLessons
            // 
            this.lbLessons.AutoSize = true;
            this.lbLessons.Location = new System.Drawing.Point(207, 91);
            this.lbLessons.Name = "lbLessons";
            this.lbLessons.Size = new System.Drawing.Size(106, 13);
            this.lbLessons.TabIndex = 14;
            this.lbLessons.Text = "Number of lessons:";
            // 
            // regist
            // 
            this.regist.Enabled = false;
            this.regist.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regist.Location = new System.Drawing.Point(225, 168);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(158, 22);
            this.regist.TabIndex = 13;
            // 
            // lbRegist
            // 
            this.lbRegist.AutoSize = true;
            this.lbRegist.Location = new System.Drawing.Point(222, 151);
            this.lbRegist.Name = "lbRegist";
            this.lbRegist.Size = new System.Drawing.Size(64, 13);
            this.lbRegist.TabIndex = 12;
            this.lbRegist.Text = "Regist Day:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(185, 281);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(60, 281);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // birth
            // 
            this.birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth.Location = new System.Drawing.Point(60, 223);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(200, 22);
            this.birth.TabIndex = 9;
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(57, 206);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(94, 13);
            this.lbBirth.TabIndex = 8;
            this.lbBirth.Text = "Teacher Birthday:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(60, 167);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(57, 151);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(85, 13);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "Teacher Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(210, 43);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(207, 27);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(79, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Teacher Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 22);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(56, 91);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Teacher Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(59, 43);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(125, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(56, 27);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(63, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Teacher ID:";
            // 
            // TeacherView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherView";
            this.Text = "Teachers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txtTests;
        private System.Windows.Forms.Label lbTests;
        private System.Windows.Forms.TextBox txtLessons;
        private System.Windows.Forms.Label lbLessons;
        private System.Windows.Forms.DateTimePicker regist;
        private System.Windows.Forms.Label lbRegist;
    }
}