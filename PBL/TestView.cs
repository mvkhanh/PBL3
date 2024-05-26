using PBL.Resources.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class TestView : Form
    {
        public TestView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            addQuestion.Size= new Size(addQuestion1.Width, addQuestion1.Height);
            flowLayoutPanel1.Controls.Add(addQuestion);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnSave1);
            flowLayoutPanel1.Controls.Add(btnCancel1);
        }
    }
}
