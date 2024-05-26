
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjComboBox1 = new PBL.Resources.Components.RJComboBox();
            this.txtName = new PBL.Controller.RoundTextBox();
            this.roundTextBox4 = new PBL.Controller.RoundTextBox();
            this.roundTextBox3 = new PBL.Controller.RoundTextBox();
            this.roundTextBox2 = new PBL.Controller.RoundTextBox();
            this.roundTextBox1 = new PBL.Controller.RoundTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new PBL.Controller.RoundTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjComboBox1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.roundTextBox4);
            this.panel1.Controls.Add(this.roundTextBox3);
            this.panel1.Controls.Add(this.roundTextBox2);
            this.panel1.Controls.Add(this.roundTextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbContent);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 380);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(3, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Question Answer:";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C",
            "D"});
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(6, 312);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 39;
            this.rjComboBox1.Texts = "";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(6, 137);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(279, 108);
            this.txtName.TabIndex = 33;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // roundTextBox4
            // 
            this.roundTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundTextBox4.BorderRadius = 0;
            this.roundTextBox4.BorderSize = 2;
            this.roundTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundTextBox4.Location = new System.Drawing.Point(334, 306);
            this.roundTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.roundTextBox4.Multiline = true;
            this.roundTextBox4.Name = "roundTextBox4";
            this.roundTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundTextBox4.PasswordChar = false;
            this.roundTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundTextBox4.PlaceholderText = "";
            this.roundTextBox4.Size = new System.Drawing.Size(486, 56);
            this.roundTextBox4.TabIndex = 34;
            this.roundTextBox4.Texts = "";
            this.roundTextBox4.UnderlinedStyle = false;
            // 
            // roundTextBox3
            // 
            this.roundTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundTextBox3.BorderRadius = 0;
            this.roundTextBox3.BorderSize = 2;
            this.roundTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundTextBox3.Location = new System.Drawing.Point(334, 220);
            this.roundTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.roundTextBox3.Multiline = true;
            this.roundTextBox3.Name = "roundTextBox3";
            this.roundTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundTextBox3.PasswordChar = false;
            this.roundTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundTextBox3.PlaceholderText = "";
            this.roundTextBox3.Size = new System.Drawing.Size(486, 56);
            this.roundTextBox3.TabIndex = 35;
            this.roundTextBox3.Texts = "";
            this.roundTextBox3.UnderlinedStyle = false;
            // 
            // roundTextBox2
            // 
            this.roundTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundTextBox2.BorderRadius = 0;
            this.roundTextBox2.BorderSize = 2;
            this.roundTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundTextBox2.Location = new System.Drawing.Point(334, 136);
            this.roundTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.roundTextBox2.Multiline = true;
            this.roundTextBox2.Name = "roundTextBox2";
            this.roundTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundTextBox2.PasswordChar = false;
            this.roundTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundTextBox2.PlaceholderText = "";
            this.roundTextBox2.Size = new System.Drawing.Size(486, 56);
            this.roundTextBox2.TabIndex = 36;
            this.roundTextBox2.Texts = "";
            this.roundTextBox2.UnderlinedStyle = false;
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundTextBox1.BorderRadius = 0;
            this.roundTextBox1.BorderSize = 2;
            this.roundTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundTextBox1.Location = new System.Drawing.Point(334, 58);
            this.roundTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundTextBox1.Multiline = true;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundTextBox1.PasswordChar = false;
            this.roundTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundTextBox1.PlaceholderText = "";
            this.roundTextBox1.Size = new System.Drawing.Size(486, 56);
            this.roundTextBox1.TabIndex = 37;
            this.roundTextBox1.Texts = "";
            this.roundTextBox1.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(331, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Answer D:";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderRadius = 0;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(6, 58);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
            this.txtId.Size = new System.Drawing.Size(141, 31);
            this.txtId.TabIndex = 38;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(331, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Answer C:";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.AutoSize = true;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.Location = new System.Drawing.Point(725, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(95, 38);
            this.iconButton2.TabIndex = 32;
            this.iconButton2.Text = "Delete";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(331, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Answer B:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(331, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Answer A:";
            // 
            // lbContent
            // 
            this.lbContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbContent.Location = new System.Drawing.Point(3, 121);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(128, 18);
            this.lbContent.TabIndex = 31;
            this.lbContent.Text = "Question Content:";
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbId.Location = new System.Drawing.Point(3, 43);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(90, 18);
            this.lbId.TabIndex = 30;
            this.lbId.Text = "Question ID:";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddQuestion";
            this.Size = new System.Drawing.Size(823, 380);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RJComboBox rjComboBox1;
        private Controller.RoundTextBox txtName;
        private Controller.RoundTextBox roundTextBox4;
        private Controller.RoundTextBox roundTextBox3;
        private Controller.RoundTextBox roundTextBox2;
        private Controller.RoundTextBox roundTextBox1;
        private System.Windows.Forms.Label label5;
        private Controller.RoundTextBox txtId;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbId;
    }
}
