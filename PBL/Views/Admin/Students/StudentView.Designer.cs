namespace PBL.Views.Admin.Students
{
    partial class StudentView
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
            this.tabPageStudentList = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tabPageStudentDetail = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRegistDay = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dateTimePickerRegistDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.lbId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageStudentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStudentList);
            this.tabControl1.Controls.Add(this.tabPageStudentDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStudentList
            // 
            this.tabPageStudentList.Controls.Add(this.txtSearch);
            this.tabPageStudentList.Controls.Add(this.dataGridView1);
            this.tabPageStudentList.Controls.Add(this.btnDelete);
            this.tabPageStudentList.Controls.Add(this.btnEdit);
            this.tabPageStudentList.Controls.Add(this.btnAddNew);
            this.tabPageStudentList.Controls.Add(this.btnSearch);
            this.tabPageStudentList.Controls.Add(this.lbSearch);
            this.tabPageStudentList.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudentList.Name = "tabPageStudentList";
            this.tabPageStudentList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentList.Size = new System.Drawing.Size(750, 424);
            this.tabPageStudentList.TabIndex = 0;
            this.tabPageStudentList.Text = "Student list";
            this.tabPageStudentList.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(112, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(411, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 279);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(651, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(651, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(651, 98);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(24, 37);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(82, 13);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search student:";
            // 
            // tabPageStudentDetail
            // 
            this.tabPageStudentDetail.Controls.Add(this.txtName);
            this.tabPageStudentDetail.Controls.Add(this.txtPhone);
            this.tabPageStudentDetail.Controls.Add(this.txtEmail);
            this.tabPageStudentDetail.Controls.Add(this.txtId);
            this.tabPageStudentDetail.Controls.Add(this.lbPhone);
            this.tabPageStudentDetail.Controls.Add(this.lbName);
            this.tabPageStudentDetail.Controls.Add(this.lbRegistDay);
            this.tabPageStudentDetail.Controls.Add(this.lbBirth);
            this.tabPageStudentDetail.Controls.Add(this.lbEmail);
            this.tabPageStudentDetail.Controls.Add(this.dateTimePickerRegistDay);
            this.tabPageStudentDetail.Controls.Add(this.dateTimePickerBirth);
            this.tabPageStudentDetail.Controls.Add(this.lbId);
            this.tabPageStudentDetail.Controls.Add(this.btnCancel);
            this.tabPageStudentDetail.Controls.Add(this.btnSave);
            this.tabPageStudentDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudentDetail.Name = "tabPageStudentDetail";
            this.tabPageStudentDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentDetail.Size = new System.Drawing.Size(750, 424);
            this.tabPageStudentDetail.TabIndex = 1;
            this.tabPageStudentDetail.Text = "Student Detail";
            this.tabPageStudentDetail.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(179, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(60, 71);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(176, 117);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(81, 13);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Student Phone:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(176, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Student Name:";
            // 
            // lbRegistDay
            // 
            this.lbRegistDay.AutoSize = true;
            this.lbRegistDay.Location = new System.Drawing.Point(176, 170);
            this.lbRegistDay.Name = "lbRegistDay";
            this.lbRegistDay.Size = new System.Drawing.Size(102, 13);
            this.lbRegistDay.TabIndex = 1;
            this.lbRegistDay.Text = "Student Regist Day:";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(57, 170);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(71, 13);
            this.lbBirth.TabIndex = 1;
            this.lbBirth.Text = "Student Birth:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(57, 117);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(75, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Student Email:";
            // 
            // dateTimePickerRegistDay
            // 
            this.dateTimePickerRegistDay.Enabled = false;
            this.dateTimePickerRegistDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegistDay.Location = new System.Drawing.Point(179, 186);
            this.dateTimePickerRegistDay.Name = "dateTimePickerRegistDay";
            this.dateTimePickerRegistDay.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerRegistDay.TabIndex = 2;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(60, 186);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerBirth.TabIndex = 2;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(57, 55);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(61, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Student ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentView";
            this.Text = "Student";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStudentList.ResumeLayout(false);
            this.tabPageStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageStudentDetail.ResumeLayout(false);
            this.tabPageStudentDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStudentList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TabPage tabPageStudentDetail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbRegistDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistDay;
        private System.Windows.Forms.Button btnCancel;
    }
}