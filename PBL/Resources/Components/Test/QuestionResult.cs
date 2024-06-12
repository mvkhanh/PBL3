using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace PBL.Resources.Components
{
    public partial class QuestionResult : UserControl
    {
        private int _StudentAnswer;
        private int _numQues;

        public int numQues 
        {
            get { return _numQues; }
            set { NumQuestion.Text = value.ToString() + "."; } 
        }
        public int StudentAnswer 
        {
            get
            {
                return _StudentAnswer;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        CorrectAnswer.Text = "A";
                        break;
                    case 1:
                        CorrectAnswer.Text = "B";
                        break;
                    case 3:
                        CorrectAnswer.Text = "D";
                        break;
                    case 2:
                        CorrectAnswer.Text = "C";
                        break;
                    default:
                        CorrectAnswer.Text = "_";
                        break;
                }
                _StudentAnswer = value;
            } }
        public int TestAnswer
        {
            set
            {
                if(value == StudentAnswer)
                {
                    CorrectAnswer.ForeColor = Color.Green;
                    WrongAnswer.Visible = false;
                    lbcolon.Visible = false;
                }
                else
                {
                    CorrectAnswer.ForeColor = Color.Red;
                    WrongAnswer.Visible = true;
                    lbcolon.Visible = true;
                    WrongAnswer.ForeColor = Color.Black;
                }
                switch (value)
                {
                    case 0:
                        WrongAnswer.Text = "A";
                        break;
                    case 1:
                        WrongAnswer.Text = "B";
                        break;
                    case 3:
                        WrongAnswer.Text = "D";
                        break;
                    default:
                        WrongAnswer.Text = "C";
                        break;
                }
                if (numQues == 1) MessageBox.Show(StudentAnswer.ToString() + " " + value.ToString());
            }
        }
        public QuestionResult()
        {
            InitializeComponent();
        }
    }
}
