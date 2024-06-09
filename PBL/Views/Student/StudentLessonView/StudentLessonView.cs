using PBL.Controller;
using PBL.Resources.Components.Lesson;
using PBL.Views;
using PBL.Views.Student.StudentLessonView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class StudentLessonView : Form, IStudentLessonView
    {
        //Fields
        private int currentPage = 0;
        private RoundButton currentButton;
        private FlowLayoutPanel pagePanel;

        //Constructor
        public StudentLessonView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageLessonContent);
        }

        public void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                InitLessonView();
            };
            foreach (var lessonBox in Lessons)
            {
                lessonBox.Click += delegate
                {
                    OpenEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Add(tabPageLessonList);
                    tabControl1.TabPages.Remove(tabPageLessonContent);
                    DisplayContent();
                };
            }
            CurrentLessons = Lessons;
        }

        public void InitLessonView()
        {
            panelContent.Controls.Clear();
            int i = currentPage * 8, j = i + 8 < CurrentLessons.Count ? i + 8 : CurrentLessons.Count;
            while(i < j)
            {
                panelContent.Controls.Add(CurrentLessons[i++]);
            }
            tabPageLessonList.Controls.Remove(pagePanel);
            makePanelPageNumber();
            tabPageLessonList.Controls.Add(pagePanel);
            pagePanel.Dock = DockStyle.Bottom;
        }

        private void makePanelPageNumber()
        {
            pagePanel = new FlowLayoutPanel();
            var btnPage = new List<RoundButton>();
            for(int i = 0; i < Math.Ceiling(CurrentLessons.Count / 8.0); i++)
            {
                var btn = new RoundButton();
                btn.Size = new Size(40, 40);
                btn.BorderRadius = 20;
                btn.Text = (i + 1).ToString();
                if(i == 0) SetChooseButton(btn);
                else SetNotChooseButton(btn);
                btn.BorderColor = Color.MediumSlateBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += delegate
                {
                    if (currentButton == btn) return;
                    SetCurrentButton(btn);
                    currentPage = btn.Text[btn.Text.Length - 1] - '0' - 1;
                    InitLessonView();
                    MessageBox.Show(currentButton.Text);
                };
                btnPage.Add(btn);
            }
            pagePanel.Controls.AddRange(btnPage.ToArray());
        }
        private void SetCurrentButton(RoundButton btnPart)
        {
            if (currentButton != null)
            {
                SetNotChooseButton(currentButton);
            }
            currentButton = btnPart;
            SetChooseButton(currentButton);
        }
        private void SetChooseButton(RoundButton btn)
        {
            btn.BorderSize = 0;
            btn.BackgroundColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;
        }

        private void SetNotChooseButton(RoundButton btn)
        {
            btn.BorderSize = 2;
            btn.BackgroundColor = Color.White;
            btn.ForeColor = Color.MediumSlateBlue;
        }

        public event EventHandler SearchEvent;
        public event EventHandler OpenEvent;

        public byte[] LessonContent { get; set; }
        public List<LessonBox> Lessons { get; set; }
        public List<LessonBox> CurrentLessons { get; set; }
        public string SearchValue { get => txtSearch.Texts; set => txtSearch.Texts = value; }

        #region Singleton pattern 
        private static StudentLessonView instance;
        public static StudentLessonView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentLessonView();
            }
            return instance;
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageLessonContent);
            tabControl1.TabPages.Add(tabPageLessonList);
        }
        private void DisplayContent()
        {
            try
            {
                string fileName = "tmp.pdf";
                File.WriteAllBytes(fileName, LessonContent);
                pdfViewer1.LoadFromFile(fileName);
                File.Delete(fileName);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured when display content");
                btnBack.PerformClick();
            }
        }

        private void StudentLessonView_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            InitLessonView();
        }
    }
}
