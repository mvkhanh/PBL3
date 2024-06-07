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
        public override string AnswerAContent
        {
            get => txtA.Texts;
            set => txtA.Texts = value;
        }
        public override string AnswerBContent
        {
            get => txtB.Texts;
            set => txtB.Texts = value;
        }
        public override string AnswerCContent
        {
            get => txtC.Texts;
            set => txtC.Texts = value;
        }
        public override string AnswerDContent
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
        public override int QuestionAnswer { get => ((CBBItem)cbbAnswers.SelectedItem).Value; set => cbbAnswers.SelectedIndex = value; }
        public Part5()
        {
            InitializeComponent();
            cbbAnswers.Items.AddRange(new CBBItem[]
            {
                new CBBItem{Value = 0, Text = "A"},
                new CBBItem{Value = 1, Text = "B"},
                new CBBItem{Value = 2, Text = "C"},
                new CBBItem{Value=3, Text = "D"}
            });
            cbbAnswers.SelectedIndex = 0;
        }
        public override void ClearFields()
        {
            QuestionAnswer = 0;
            QuestionContent = AnswerAContent = AnswerBContent = AnswerCContent = AnswerDContent = "";
        }
    }
}
