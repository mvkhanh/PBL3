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
        public List<Control> controls;
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
            set => lbLessonPublishDay.Text = value.ToShortDateString();
        }
        public string LessonName
        {
            get => txtLessonName.Text;
            set => txtLessonName.Text = value;
        }
        public bool LessonSaved { get; set; }
        #endregion
        public LessonBox()
        {
            InitializeComponent();
            LessonSaved = false;
            controls = new List<Control>();
            controls.Add(panel1);
            controls.Add(roundPanel1);
            foreach(Control control in panel1.Controls) controls.Add(control);
            foreach(Control control in roundPanel1.Controls) controls.Add(control);
        }
    }
}
