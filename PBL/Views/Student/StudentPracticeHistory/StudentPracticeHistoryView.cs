using PBL.Resources.Components.TestHistory;
using PBL.Views.Student.StudentPracticeHistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Student
{
    public partial class StudentPracticeHistoryView : Form, IStudentPracticeHistoryView
    {
        public StudentPracticeHistoryView()
        {
            InitializeComponent();
        }

        public List<HistoryBox> testList {  get; set; }
        #region Singleton
        private static StudentPracticeHistoryView instance;

        public static StudentPracticeHistoryView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentPracticeHistoryView();
            }
            return instance;
        }

        #endregion

        private void StudentPracticeHistoryView_Load(object sender, EventArgs e)
        {
            panelMain.Controls.AddRange(testList.ToArray());
        }
    }
}
