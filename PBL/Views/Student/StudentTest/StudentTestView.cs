using Google.Protobuf.WellKnownTypes;
using NAudio.CoreAudioApi;
using Org.BouncyCastle.Utilities;
using PBL.Controller;
using PBL.Resources.Components;
using PBL.Resources.Components.Lesson;
using PBL.Resources.Components.Test;
using PBL.Resources.Components.Test.TestQuestion;
using PBL.Views;
using PBL.Views.Student.StudentTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL
{
    
    public partial class StudentTestView : Form, IStudentTestView
    {
        //Fields
        private int currentPage = 0;
        private RoundButton currentButton;
        private FlowLayoutPanel pagePanel;
        private TestBox currentTestBox;

        //Constructor
        public StudentTestView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Remove(tabPageTestResult);
            part = new List<int>();
            ////Add CommentBox
            //CommentsBox comment = new CommentsBox();
            //comment.Location = new Point(80, 410);
            //comment.AutoScroll = true;
            //comment.AutoSize = false;
            //this.tabPageTestDetail.Controls.Add(comment);
        }
        public void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                if (CurrentTests.Count > 0) InitTestView();
                else
                {
                    tabPageTestList.Controls.Remove(pagePanel);
                    panelContent.Controls.Clear();
                    var lb = new Label();
                    lb.Text = "Non exist result";
                    lb.AutoSize = true;
                    lb.ForeColor = Color.Red;
                    panelContent.Controls.Add(lb);
                }
            };
            foreach (var TestBox in Tests)
            {
                foreach (Control control in TestBox.controls)
                    control.Click += delegate
                    {
                        currentTestBox = TestBox;
                        CurrentTestId = currentTestBox.TestId;
                        OpenEvent?.Invoke(TestBox, EventArgs.Empty);
                        LoadCommentsEvent?.Invoke(currentTestBox, EventArgs.Empty);
                        InitComments();
                        tabControl1.TabPages.Remove(tabPageTestList);
                        tabControl1.TabPages.Add(tabPageTestDetail);
                        lbTestName.Text = currentTestBox.TestName;
                        lbTestCount.Text = $"{currentTestBox.TestCount} people have done this exam";
                    };
            }
            btnPractice.Click += delegate
            {
                var cbList = groupBox2.Controls.OfType<CheckBox>().Where(c => c.Checked).ToList();
                if(cbList.Count == 0)
                {
                    MessageBox.Show("You have not choose parts to practice");
                    return;
                }
                foreach (var cb in cbList) part.Add(Convert.ToInt32(cb.Tag));
                DoTestEvent?.Invoke(this, EventArgs.Empty);
            };
            btnFullTest.Click += delegate
            {
                DoTestEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSend.Click += delegate
            {
                if (string.IsNullOrEmpty(txtComment.Texts))
                {
                    MessageBox.Show("Comment box is empty");
                    return;
                }
                SendCommentEvent?.Invoke(currentTestBox, EventArgs.Empty);
                txtComment.Texts = "";
                InitComments();
            };
        }
        private void InitComments()
        {
            panelComments.Controls.Clear();
            foreach (var comment in Comments) panelComments.Controls.Add(comment);
        }

        private void CleanViews()
        {
            cbPart1.Checked = cbPart2.Checked = cbPart3.Checked = cbPart4.Checked = cbPart5.Checked = cbPart6.Checked = cbPart7.Checked = false;
            cbYes.Checked = true;
            numLimitTime.Value = 60;
            part.Clear();
        }

        public void InitTestView()
        {
            AddTestToPanel();
            tabPageTestList.Controls.Remove(pagePanel);
            makePanelPageNumber();
            tabPageTestList.Controls.Add(pagePanel);
            pagePanel.Dock = DockStyle.Bottom;
        }

        private void AddTestToPanel()
        {
            panelContent.Controls.Clear();
            int i = currentPage * 8, j = i + 8 < CurrentTests.Count ? i + 8 : CurrentTests.Count;
            while (i < j)
            {
                panelContent.Controls.Add(CurrentTests[i++]);
            }
        }

        private void makePanelPageNumber()
        {
            pagePanel = new FlowLayoutPanel();
            var btnPage = new List<RoundButton>();
            for (int i = 0; i < Math.Ceiling(CurrentTests.Count / 8.0); i++)
            {
                var btn = new RoundButton();
                btn.Size = new Size(40, 40);
                btn.BorderRadius = 20;
                btn.Text = (i + 1).ToString();
                if (i == 0) SetCurrentButton(btn);
                else SetNotChooseButton(btn);
                btn.BorderColor = Color.MediumSlateBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += (s, e) =>
                {
                    var btn2 = (RoundButton)s;
                    if (currentButton == btn2) return;
                    SetCurrentButton(btn2);
                    currentPage = btn2.Text[btn2.Text.Length - 1] - '0' - 1;
                    AddTestToPanel();
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
        public event EventHandler DoTestEvent;
        public event EventHandler SendCommentEvent;
        public event EventHandler LoadCommentsEvent;

        #region Properties
        public List<TestBox> Tests { get; set; }
        public List<TestBox> CurrentTests { get; set; }
        public List<int> part { get; set; }
        public int Minutes { get => Convert.ToInt32(numLimitTime.Value); set => numLimitTime.Value = value; }
        public int CurrentTestId {  get; set; }
        public bool Done { 
            get => iconCheck.Visible; 
            set {
                iconCheck.Visible = value;
            } 
        }
        public List<CommentsBox> Comments { get; set; }
        public string CommentContent { get => txtComment.Texts; }
        public string SearchValue { get => txtSearch.Texts; set => txtSearch.Texts = value; }

        #endregion

        #region Singleton pattern 
        private static StudentTestView instance;

        public static StudentTestView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentTestView();
            }
            return instance;
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            CleanViews();
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Add(tabPageTestList);
        }

        private void StudentTestView_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            InitTestView();
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYes.Checked)
            {
                numLimitTime.Visible = true;
                lbMinutes.Visible = true;
                numLimitTime.Value = 60;
            }
            else
            {
                numLimitTime.Visible = false;
                lbMinutes.Visible = false;
                numLimitTime.Value = 0;
            }
        }

        public void ShowResult(List<List<TestQuestionBox>> AnswerList, int scores, int total, int testTime, List<int> Parts)
        {
            panelAnswers.Controls.Clear();
            currentTestBox.TestCount++;
            lbScores.Text = scores.ToString() + "/";
            lbRightAnswer.Text = scores.ToString();
            TimeSpan timeSpan = TimeSpan.FromSeconds(testTime);
            lbTestTime.Text = timeSpan.ToString(@"hh\:mm\:ss");
            lbTotal.Text = total.ToString();
            lbAccuracy.Text = ((double)scores / total * 100).ToString("N2") + "%";
            int i = 0, skip = 0;
            foreach(var part in Parts)
            {
                panelAnswers.Controls.Add(new Label
                {
                    Width = 1500,
                    Text = $"Part {part}",
                    BackColor = Color.Transparent,
                    ForeColor = Color.MediumSlateBlue
                });
                foreach(var answer in AnswerList[i])
                {
                    panelAnswers.Controls.Add(new TestResult
                    {
                        numQues = answer.QuestionNum,
                        StudentAnswer = answer.QuestionChooseAnswer,
                        TestAnswer = answer.QuestionAnswer
                    });
                    if (answer.QuestionChooseAnswer == -1) skip++;
                }
                i++;
            }
            lbSkip.Text = skip.ToString();
            lbWrongAnswer.Text = (total - scores - skip).ToString();
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Add(tabPageTestResult);
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            CleanViews();
            tabControl1.TabPages.Remove(tabPageTestResult);
            tabControl1.TabPages.Add(tabPageTestList);
        }
    }
}
