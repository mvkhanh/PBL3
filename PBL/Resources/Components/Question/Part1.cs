using PBL.Resources.Components.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components
{
    public partial class Part1 : QuestionBox
    {
        protected override void OnImagePathChanged()
        {
            if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                imageBox.Image = Image.FromFile(ImagePath);
            }
            else
            {
                imageBox.Image = null;
            }

            OnPropertyChanged(nameof(ImagePath));
        }

        protected override void OnQuestionImageChanged()
        {
            if (QuestionImage != null && QuestionImage.Length > 0)
            {
                using (var ms = new MemoryStream(QuestionImage))
                {
                    imageBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                imageBox.Image = null;
            }

            OnPropertyChanged(nameof(QuestionImage));
        }
        public Part1()
        {
            InitializeComponent();
            cbbAnswers.Items.AddRange(new CBBItem[]
            {
                new CBBItem{Value = 0, Text = "A"},
                new CBBItem{Value = 1, Text = "B"},
                new CBBItem{Value = 2, Text = "C"},
                new CBBItem{Value=3, Text = "D"}
            } );
            cbbAnswers.SelectedIndex = 0;
            if(QuestionImage != null)
            {
                LoadImage();
            }
        }

        public override int QuestionNum { get => Convert.ToInt32(txtNumber.Texts); set => txtNumber.Texts = value.ToString(); }
        public override int QuestionAnswer { get => ((CBBItem)cbbAnswers.SelectedItem).Value; set => cbbAnswers.SelectedIndex = value; }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            imageBox.Image = null;
        }

        private void LoadImage()
        {
            try
            {
                string fileName = "tmp.png";
                File.WriteAllBytes(fileName, QuestionImage);
                imageBox.Image = Image.FromFile(fileName);
                File.Delete(fileName);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured when display image");
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Optional: Filter to show only image files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load and display the image in the PictureBox
                ImagePath = openFileDialog.FileName;
            }
        }
        public override void ClearFields()
        {
            QuestionAnswer = 0;
            ImagePath = "";
        }
    }
}
