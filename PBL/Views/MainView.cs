using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btTeachers.Click += delegate { ShowTeacherView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowTeacherView;
        public event EventHandler ShowStudentView;
        public event EventHandler ShowAccountView;
        public event EventHandler ShowLessonView;
        public event EventHandler ShowTestView;
    }
}
