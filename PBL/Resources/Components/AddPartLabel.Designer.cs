
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
            this.numPart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numPart
            // 
            this.numPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPart.AutoSize = true;
            this.numPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPart.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.numPart.Location = new System.Drawing.Point(4, 0);
            this.numPart.Name = "numPart";
            this.numPart.Size = new System.Drawing.Size(48, 16);
            this.numPart.TabIndex = 71;
            this.numPart.Text = "Part 1";
            // 
            // AddPartLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numPart);
            this.Name = "AddPartLabel";
            this.Size = new System.Drawing.Size(63, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numPart;
    }
}
