using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.Test.TestQuestion
{
    public partial class TestQuestionBox : UserControl
    {

        public virtual string QuestionA { get; set; }
        public virtual string QuestionB { get; set; }
        public virtual string QuestionC { get; set; }
        public virtual string QuestionD { get; set; }
        public virtual string QuestionContent { get; set; }
        public virtual int QuestionNum { get; set; }
        public virtual int QuestionAnswer { get; set; }
        public virtual byte[] QuestionImage {  get; set; }
        public virtual int QuestionChooseAnswer {get; set; }
        public virtual bool ischecked { get; set; }
        public virtual event EventHandler CheckedChanged;
        public TestQuestionBox()
        {
            InitializeComponent();
        }
    }
}
