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
    public partial class Part5 : QuestionBox
    {
        public override string QuestionA
        {
            get => txtA.Texts;
            set => txtA.Texts = value;
        }
        public override string QuestionB
        {
            get => txtB.Texts;
            set => txtB.Texts = value;
        }
        public override string QuestionC
        {
            get => txtC.Texts;
            set => txtC.Texts = value;
        }
        public override string QuestionD
        {
            get => txtD.Texts;
            set => txtD.Texts = value;
        }
        public override string QuestionContent
        {
            get => txtContent.Texts;
            set => txtContent.Texts = value;
        }
        public override int QuestionNum
        {
            get => Convert.ToInt32(txtNumber.Texts);
            set => txtNumber.Texts = value.ToString();
        }
        public override string QuestionAnswer
        {
            get => cbbAnswers.SelectedItem.ToString();
            set => cbbAnswers.SelectedItem = value;
        }
        public Part5()
        {
            InitializeComponent();
            cbbAnswers.Items.AddRange(new string[] { "A", "B", "C", "D" });
            cbbAnswers.SelectedIndex = 0;
        }
    }
}
