using PBL.Resources.Components.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components
{
    public partial class Part1 : QuestionBox
    {
        public Part1()
        {
            InitializeComponent();
            cbbAnswers.Items.AddRange(new string[] { "A", "B", "C", "D" });
            cbbAnswers.SelectedIndex = 0;
        }
        public override int QuestionNum { get => Convert.ToInt32(txtNumber.Texts); set => txtNumber.Texts = value.ToString(); }
        public override Image QuestionImage { get => imageBox.Image; set => imageBox.Image = value; }
        public override string QuestionAnswer { get => cbbAnswers.SelectedItem.ToString(); set => cbbAnswers.SelectedItem = value; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            imageBox.Image = null;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Optional: Filter to show only image files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load and display the image in the PictureBox
                imageBox.Image = Image.FromFile(openFileDialog.FileName);
                imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
