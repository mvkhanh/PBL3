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
    public partial class Part2 : QuestionBox
    {
        public Part2()
        {
            InitializeComponent();
            cbbAnswers.Items.AddRange(new string[] { "A", "B", "C" });
            cbbAnswers.SelectedIndex = 0;
        }
        public override int QuestionNum { get => Convert.ToInt32(txtNumber.Texts); set => txtNumber.Texts = value.ToString(); }
        public override string QuestionAnswer { get => cbbAnswers.SelectedItem.ToString(); set => cbbAnswers.SelectedItem = value; }
    }
}
