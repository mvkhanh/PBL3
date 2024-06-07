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
    public partial class StudentLessonView : Form
    {
        public StudentLessonView()
        {
            InitializeComponent();
        }

        private void StudentLessonView_Load(object sender, EventArgs e)
        {
            txtNameLesson1.Parent = panelLesson1;
            txtNameLesson1.BackColor = Color.Transparent;
            txtNameLesson2.Parent = panelLesson2;
            txtNameLesson2.BackColor = Color.Transparent;
            txtNameLesson3.Parent = panelLesson3;
            txtNameLesson3.BackColor = Color.Transparent;
            txtTitleLessson1.Parent = panelLesson1;
            txtTitleLessson1.BackColor = Color.Transparent;
            txtTitleLessson2.Parent = panelLesson2;
            txtTitleLessson2.BackColor = Color.Transparent;
            txtTitleLessson3.Parent = panelLesson3;
            txtTitleLessson3.BackColor = Color.Transparent;
        }
    }
}
