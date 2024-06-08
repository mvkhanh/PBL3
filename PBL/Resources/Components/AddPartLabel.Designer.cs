namespace PBL.Resources.Components
{
    partial class AddPartLabel
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
            this.namePart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namePart
            // 
            this.namePart.AutoSize = true;
            this.namePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePart.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.namePart.Location = new System.Drawing.Point(2, 5);
            this.namePart.Name = "namePart";
            this.namePart.Size = new System.Drawing.Size(45, 15);
            this.namePart.TabIndex = 50;
            this.namePart.Text = "Part 1";
            // 
            // AddPartLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.namePart);
            this.Name = "AddPartLabel";
            this.Size = new System.Drawing.Size(50, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePart;
    }
}
