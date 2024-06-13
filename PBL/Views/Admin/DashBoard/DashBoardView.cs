using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Admin.DashBoard
{
    public partial class DashBoardView : Form,IDashBoardView
    {
        public List<KeyValuePair<string, int>> TopLessonList { get; set; }
        public List<KeyValuePair<string, int>> TopTestList { get; set; }
        public List<KeyValuePair<string, int>> TopTeacherList { get; set; }
        public int totalStudent { get => Convert.ToInt32(lbTotalStudent.Text); set => lbTotalStudent.Text = value.ToString(); }
        public int totalTeacher { get => Convert.ToInt32(lbTotalTeacher.Text); set => lbTotalTeacher.Text = value.ToString(); }
        public int totalLesson { get => Convert.ToInt32(lbTotalLesson.Text); set => lbTotalLesson.Text = value.ToString(); }
        public int totalGrade { get => Convert.ToInt32(lbTotalgrade.Text); set => lbTotalgrade.Text = value.ToString(); }
        public int numberTest { get => Convert.ToInt32(lbNumberTest.Text); set => lbNumberTest.Text = value.ToString(); }
        public int numberLesson { get => Convert.ToInt32(lbNumberLesson.Text); set => lbNumberLesson.Text = value.ToString(); }
        public DateTime startDate { get => dtpStartDate.Value; set => dtpStartDate.Value = value; }
        public DateTime endDate { get => dtpEndDate.Value; set => dtpEndDate.Value = value; }

        private Button currentButton;
        public DashBoardView()
        {
            InitializeComponent();
            SetDateMenuButttonUI(btnLast7days);
            AssociateAndRaiseViewEvents();
            this.WindowState = FormWindowState.Maximized;
        }
        //Events
        public event EventHandler showToday;
        public event EventHandler Show30Day;
        public event EventHandler Show7day;
        public event EventHandler Showcustomday;
        public event EventHandler Showthismonth;
        public void AssociateAndRaiseViewEvents()
        {

            btnOk.Click += delegate
            {
                Showcustomday?.Invoke(this, EventArgs.Empty);
            };
            btnToday.Click += delegate
            {

                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Now;
                SetDateMenuButttonUI(btnToday);
                DisableCustomDates();
                showToday?.Invoke(this, EventArgs.Empty);
            };
            btnLast7days.Click += delegate
            {

                dtpStartDate.Value = DateTime.Today.AddDays(-7);
                dtpEndDate.Value = DateTime.Now;
                SetDateMenuButttonUI(btnLast7days);
                Show();
                DisableCustomDates();
                Show7day?.Invoke(this, EventArgs.Empty);
            };
            btnLast30days.Click += delegate
            {

                dtpStartDate.Value = DateTime.Today.AddDays(-30);
                dtpEndDate.Value = DateTime.Now;
                SetDateMenuButttonUI(btnLast30days);
                DisableCustomDates();
                Show30Day?.Invoke(this, EventArgs.Empty);
            };
            btnThismonth.Click += delegate
            {

                dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpEndDate.Value = DateTime.Now;
                SetDateMenuButttonUI(btnThismonth);
                DisableCustomDates();
                Showthismonth?.Invoke(this, EventArgs.Empty);
            };
            btnCustom.Click += delegate
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOk.Visible = true;
                SetDateMenuButttonUI(btnCustom);
            };
        }
        private void SetDateMenuButttonUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = btnLast30days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(158, 218, 251);
            }
            currentButton = btn;
            if (btn == btnCustom)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOk.BackColor = Color.FromArgb(252, 185, 60);
                btnOk.Visible = true;
                lbStartDate.Cursor = Cursors.Hand;
                lbEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                btnOk.Visible = false;
                lbStartDate.Cursor = Cursors.Default;
                lbEndDate.Cursor = Cursors.Default;
            }
        }

        private void lbStartDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustom)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }
        private void lbEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustom)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }


        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Value.ToShortDateString();
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lbEndDate.Text = dtpEndDate.Value.ToShortDateString();
        }
        #region Singleton
        private static DashBoardView instance;
        public static DashBoardView GetInstance()
        {
            if (instance == null || instance.IsDisposed) instance = new DashBoardView();
            return instance;
        }
        #endregion
        public void Show()
        {
            dataGridView1.DataSource = TopTeacherList;
            lbTotalLesson.Text = totalLesson.ToString();
            lbTotalTeacher.Text = totalTeacher.ToString();
            lbTotalStudent.Text = totalStudent.ToString();
            lbTotalgrade.Text = totalGrade.ToString();
            lbNumberTest.Text = numberTest.ToString();
            lbNumberLesson.Text = numberLesson.ToString();

            chart1.DataSource = TopLessonList;
            chart1.Series[0].XValueMember = "Key";
            chart1.Series[0].YValueMembers = "Value";
            chart1.DataBind();

            chart2.DataSource = TopTestList;
            chart2.Series[0].XValueMember = "Key";
            chart2.Series[0].YValueMembers = "Value";
            chart2.DataBind();

            dataGridView1.DataSource = TopTeacherList;
            dataGridView1.Columns[0].HeaderText = "Teacher Name";
            dataGridView1.Columns[1].HeaderText = "Lesson Count";
            dataGridView1.DataSource = TopTeacherList;
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }

    }
}
