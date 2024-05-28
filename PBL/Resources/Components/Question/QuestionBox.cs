using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.Question
{
    public partial class QuestionBox : UserControl
    {
        public virtual string QuestionA { get; set; }
        public virtual string QuestionB { get; set; }
        public virtual string QuestionC { get; set; }
        public virtual string QuestionD { get; set; }
        public virtual string QuestionContent { get; set; }
        public virtual int QuestionNum { get; set; }
        public virtual Image QuestionImage { get; set; }
        public virtual string QuestionAnswer { get; set; }
        public QuestionBox()
        {
            InitializeComponent();
        }
    }
}
