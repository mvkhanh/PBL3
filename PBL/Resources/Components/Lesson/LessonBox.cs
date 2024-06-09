using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.Lesson
{
    public partial class LessonBox : UserControl
    {
        #region Properties
        public int LessonId { get; set; }
        public string LessonTeacher
        {
            get => lbLessonTeacher.Text;
            set => lbLessonTeacher.Text = value;
        }
        public int LessonViews
        {
            get => Convert.ToInt32(lbLessonViews.Text);
            set => lbLessonViews.Text = value.ToString();
        }
        public DateTime LessonPublishDay
        {
            get => Convert.ToDateTime(lbLessonPublishDay.Text);
            set => lbLessonViews.Text = value.ToShortDateString();
        }
        public string LessonName
        {
            get => txtLessonName.Texts;
            set => txtLessonName.Texts = value;
        }
        #endregion
        public LessonBox()
        {
            InitializeComponent();
        }
    }
}
