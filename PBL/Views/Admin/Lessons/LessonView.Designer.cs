﻿using System.Drawing;

namespace PBL
{
    partial class LessonView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLessonList = new System.Windows.Forms.TabPage();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageLessonDetail = new System.Windows.Forms.TabPage();
            this.cbbTeacherName = new PBL.Resources.Components.RJComboBox();
            this.regist = new PBL.Resources.Components.RJDatePicker();
            this.txtName = new PBL.Controller.RoundTextBox();
            this.txtView = new PBL.Controller.RoundTextBox();
            this.txtPdf = new PBL.Controller.RoundTextBox();
            this.txtId = new PBL.Controller.RoundTextBox();
            this.btnAddPdf = new FontAwesome.Sharp.IconButton();
            this.lbRegist = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.tabPageLessonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageLessonDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLessonList);
            this.tabControl1.Controls.Add(this.tabPageLessonDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 467);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLessonList
            // 
            this.tabPageLessonList.Controls.Add(this.btnEdit);
            this.tabPageLessonList.Controls.Add(this.btnSearch);
            this.tabPageLessonList.Controls.Add(this.btnDelete);
            this.tabPageLessonList.Controls.Add(this.btnAddNew);
            this.tabPageLessonList.Controls.Add(this.txtSearch);
            this.tabPageLessonList.Controls.Add(this.lbSearch);
            this.tabPageLessonList.Controls.Add(this.dataGridView1);
            this.tabPageLessonList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPageLessonList.Location = new System.Drawing.Point(4, 25);
            this.tabPageLessonList.Name = "tabPageLessonList";
            this.tabPageLessonList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLessonList.Size = new System.Drawing.Size(898, 438);
            this.tabPageLessonList.TabIndex = 0;
            this.tabPageLessonList.Text = "Lesson List";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 32;
            this.btnEdit.Location = new System.Drawing.Point(766, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 46);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "  Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.Location = new System.Drawing.Point(648, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(766, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddNew.IconColor = System.Drawing.Color.White;
            this.btnAddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNew.IconSize = 32;
            this.btnAddNew.Location = new System.Drawing.Point(766, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(115, 46);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(609, 33);
            this.txtSearch.TabIndex = 2;
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbSearch.Location = new System.Drawing.Point(21, 3);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(115, 16);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Search Lesson:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(24, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(727, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageLessonDetail
            // 
            this.tabPageLessonDetail.Controls.Add(this.cbbTeacherName);
            this.tabPageLessonDetail.Controls.Add(this.regist);
            this.tabPageLessonDetail.Controls.Add(this.txtName);
            this.tabPageLessonDetail.Controls.Add(this.txtView);
            this.tabPageLessonDetail.Controls.Add(this.txtPdf);
            this.tabPageLessonDetail.Controls.Add(this.txtId);
            this.tabPageLessonDetail.Controls.Add(this.btnAddPdf);
            this.tabPageLessonDetail.Controls.Add(this.lbRegist);
            this.tabPageLessonDetail.Controls.Add(this.lbBirth);
            this.tabPageLessonDetail.Controls.Add(this.label3);
            this.tabPageLessonDetail.Controls.Add(this.lbName);
            this.tabPageLessonDetail.Controls.Add(this.label1);
            this.tabPageLessonDetail.Controls.Add(this.lbId);
            this.tabPageLessonDetail.Controls.Add(this.btnCancel);
            this.tabPageLessonDetail.Controls.Add(this.btnSave);
            this.tabPageLessonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLessonDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageLessonDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageLessonDetail.Name = "tabPageLessonDetail";
            this.tabPageLessonDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLessonDetail.Size = new System.Drawing.Size(898, 438);
            this.tabPageLessonDetail.TabIndex = 1;
            this.tabPageLessonDetail.Text = "Lesson detail";
            this.tabPageLessonDetail.UseVisualStyleBackColor = true;
            // 
            // cbbTeacherName
            // 
            this.cbbTeacherName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbTeacherName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbTeacherName.BorderSize = 1;
            this.cbbTeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbTeacherName.ForeColor = System.Drawing.Color.DimGray;
            this.cbbTeacherName.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbTeacherName.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbTeacherName.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbTeacherName.Location = new System.Drawing.Point(351, 141);
            this.cbbTeacherName.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbTeacherName.Name = "cbbTeacherName";
            this.cbbTeacherName.Padding = new System.Windows.Forms.Padding(1);
            this.cbbTeacherName.Size = new System.Drawing.Size(406, 30);
            this.cbbTeacherName.TabIndex = 21;
            this.cbbTeacherName.Texts = "";
            // 
            // regist
            // 
            this.regist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.regist.BorderSize = 0;
            this.regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.regist.Location = new System.Drawing.Point(115, 263);
            this.regist.MinimumSize = new System.Drawing.Size(0, 35);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(200, 35);
            this.regist.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.regist.TabIndex = 20;
            this.regist.TextColor = System.Drawing.Color.White;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(351, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(406, 31);
            this.txtName.TabIndex = 19;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.SystemColors.Window;
            this.txtView.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtView.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtView.BorderRadius = 0;
            this.txtView.BorderSize = 2;
            this.txtView.Enabled = false;
            this.txtView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtView.Location = new System.Drawing.Point(352, 267);
            this.txtView.Margin = new System.Windows.Forms.Padding(4);
            this.txtView.Multiline = false;
            this.txtView.Name = "txtView";
            this.txtView.Padding = new System.Windows.Forms.Padding(10);
            this.txtView.PasswordChar = false;
            this.txtView.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtView.PlaceholderText = "";
            this.txtView.Size = new System.Drawing.Size(159, 31);
            this.txtView.TabIndex = 18;
            this.txtView.Texts = "0";
            this.txtView.UnderlinedStyle = false;
            // 
            // txtPdf
            // 
            this.txtPdf.BackColor = System.Drawing.SystemColors.Window;
            this.txtPdf.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPdf.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPdf.BorderRadius = 0;
            this.txtPdf.BorderSize = 2;
            this.txtPdf.Enabled = false;
            this.txtPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPdf.Location = new System.Drawing.Point(117, 140);
            this.txtPdf.Margin = new System.Windows.Forms.Padding(4);
            this.txtPdf.Multiline = false;
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.Padding = new System.Windows.Forms.Padding(10);
            this.txtPdf.PasswordChar = false;
            this.txtPdf.PlaceholderColor = System.Drawing.Color.White;
            this.txtPdf.PlaceholderText = "";
            this.txtPdf.Size = new System.Drawing.Size(200, 31);
            this.txtPdf.TabIndex = 18;
            this.txtPdf.Texts = "0";
            this.txtPdf.UnderlinedStyle = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderRadius = 0;
            this.txtId.BorderSize = 2;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(116, 60);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
            this.txtId.Size = new System.Drawing.Size(199, 31);
            this.txtId.TabIndex = 18;
            this.txtId.Texts = "0";
            this.txtId.UnderlinedStyle = false;
            // 
            // btnAddPdf
            // 
            this.btnAddPdf.AutoSize = true;
            this.btnAddPdf.BackColor = System.Drawing.Color.Orange;
            this.btnAddPdf.FlatAppearance.BorderSize = 0;
            this.btnAddPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPdf.ForeColor = System.Drawing.Color.White;
            this.btnAddPdf.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddPdf.IconColor = System.Drawing.Color.White;
            this.btnAddPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPdf.IconSize = 32;
            this.btnAddPdf.Location = new System.Drawing.Point(117, 172);
            this.btnAddPdf.Name = "btnAddPdf";
            this.btnAddPdf.Size = new System.Drawing.Size(200, 38);
            this.btnAddPdf.TabIndex = 16;
            this.btnAddPdf.Text = "Add File PDF";
            this.btnAddPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPdf.UseVisualStyleBackColor = false;
            // 
            // lbRegist
            // 
            this.lbRegist.AutoSize = true;
            this.lbRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegist.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbRegist.Location = new System.Drawing.Point(114, 246);
            this.lbRegist.Name = "lbRegist";
            this.lbRegist.Size = new System.Drawing.Size(90, 18);
            this.lbRegist.TabIndex = 12;
            this.lbRegist.Text = "Publish Day:";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbBirth.Location = new System.Drawing.Point(115, 124);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(117, 18);
            this.lbBirth.TabIndex = 8;
            this.lbBirth.Text = "Lesson Content:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(349, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lesson Teacher Name:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbName.Location = new System.Drawing.Point(348, 44);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(105, 18);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Lesson Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(349, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Views:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbId.Location = new System.Drawing.Point(113, 44);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(79, 18);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Lesson ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.Location = new System.Drawing.Point(501, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(351, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // LessonView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 467);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LessonView";
            this.Text = "Teachers";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLessonList.ResumeLayout(false);
            this.tabPageLessonList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageLessonDetail.ResumeLayout(false);
            this.tabPageLessonDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLessonList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageLessonDetail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbRegist;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAddPdf;
        private Controller.RoundTextBox txtId;
        private Controller.RoundTextBox txtPdf;
        private Controller.RoundTextBox txtName;
        private Controller.RoundTextBox txtView;
        private Resources.Components.RJDatePicker regist;
        private Resources.Components.RJComboBox cbbTeacherName;
    }
}