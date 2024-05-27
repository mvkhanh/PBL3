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
    public partial class AddQuestion : UserControl
    {
        public string AnswerA
        {
            get => txtA.Texts;
            set => txtA.Texts = value;
        }
        public string AnswerB
        {
            get => txtB.Texts;
            set => txtB.Texts = value;
        }
        public string AnswerC
        {
            get => txtC.Texts;
            set => txtC.Texts = value;
        }
        public string AnswerD
        {
            get => txtD.Texts;
            set => txtD.Texts = value;
        }
        public string Content
        {
            get => txtContent.Texts;
            set => txtContent.Texts = value;
        }
        public string ID
        {
            get => txtNumber.Texts;
            set => txtNumber.Texts = value;
        }
        public Image ImageQ
        {
            get => ImageOK.Image;
            set => ImageOK.Image = value;
        }
        public AddQuestion()
        {
            InitializeComponent();
            cbbAnswer.Items.AddRange( new string[] { "A", "B", "C", "D" } );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ImageOK.Image = null;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Optional: Filter to show only image files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load and display the image in the PictureBox
                ImageOK.Image = Image.FromFile(openFileDialog.FileName);
                ImageOK.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
