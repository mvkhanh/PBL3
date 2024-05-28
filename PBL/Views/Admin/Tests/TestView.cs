using PBL.Controller;
using PBL.Resources.Components;
using PBL.Resources.Components.Question;
using PBL.Views.Admin.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace PBL
{
    public partial class TestView : Form, ITestView
    {
        //Fields
        private bool _IsEdit;
        private bool _IsSuccessful;
        private string _Message;
        private int[] QuestionNumEachPart = { 6, 25, 39, 30, 30, 16, 54};
        private int currentPage = 0;
        private RoundButton currentButton;

        //Constructor
        public TestView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Remove(tabPageQuestionList);
            Teachers = new List<CBBItem>();
            cbbTeacherName.DataSource = Teachers;
            Questions = new List<List<QuestionBox>>();
            InitQuestionList();
            AddQuestionToPanel();
            SetCurrentButton(btnPart1);
        }

        private void SetCurrentButton(RoundButton btnPart)
        {
            if(currentButton != null)
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

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTestList);
                tabControl1.TabPages.Add(tabPageTestDetail);
                tabPageTestDetail.Text = "Add new Test";
            };
            btnEdit.Click += delegate
            {
                try
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageTestList);
                    tabControl1.TabPages.Add(tabPageTestDetail);
                    tabPageTestDetail.Text = "Edit Test";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Test?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageTestDetail);
                    tabControl1.TabPages.Add(tabPageTestList);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTestDetail);
                tabControl1.TabPages.Add(tabPageTestList);
            };
        }
        private void InitQuestionList()
        {
            int partNum = 7, j = 0;
            for(int i = 0; i < partNum; i++)
            {
                var list = new List<QuestionBox>();
                int maxNum = j + QuestionNumEachPart[i];
                switch (i)
                {
                    case 0:
                        while (++j <= maxNum) list.Add(new Part1() { QuestionNum = j });
                        break;
                    case 1:
                        while (++j <= maxNum) list.Add(new Part2() { QuestionNum = j });
                        break;
                    case 4:
                        while (++j <= maxNum) list.Add(new Part5() { QuestionNum = j });
                        break;
                    default:
                        while (++j <= maxNum) list.Add(new Part3467() { QuestionNum = j });
                        break;
                }
                j--;
                Questions.Add(list);
            }
        }
        private void AddQuestionToPanel()
        {
            lbPart.Text = "Part " + (currentPage + 1);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(lbPart);
            panelMain.Controls.AddRange(Questions[currentPage].ToArray());
            panelMain.Controls.Add(panelBtn);
            btnBack.Visible = btnNext.Visible = btnPrevious.Visible = btnFinish.Visible = true;
            if (currentPage == 6) btnNext.Visible = false;
            else
            {
                btnFinish.Visible = false;
                if (currentPage == 0) btnPrevious.Visible = false;
            }
        }

        //Properties
        public int TestId
        { get => Convert.ToInt32(txtId.Texts); set => txtId.Texts = value.ToString(); }
        public string TestName
        { get => txtName.Texts; set => txtName.Texts = value; }
        public DateTime TestPublishDay
        { get => regist.Value.Date; set => regist.Value = value.Date; }
        public string TestDescription
        { get => txtDescription.Texts; set => txtDescription.Texts = value; }
        public int TestCount
        { get => Convert.ToInt32(txtPaticipant.Texts); set => txtPaticipant.Texts = value.ToString(); }
        public int TestId_Teacher
        {
            get => ((CBBItem)cbbTeacherName.SelectedItem).Value;
            set
            {
                foreach (var item in cbbTeacherName.Items) if (((CBBItem)item).Value == value)
                    {
                        cbbTeacherName.SelectedItem = item;
                    }
            }
        }
        public string SearchValue
        { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit
        { get => _IsEdit; set => _IsEdit = value; }
        public bool IsSuccessful
        { get => _IsSuccessful; set => _IsSuccessful = value; }
        public string Message
        { get => _Message; set => _Message = value; }
        public List<CBBItem> Teachers
        { get; set; }
        public List<List<QuestionBox>> Questions { get; set; }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Id_Teacher" || e.Column.Name == "Description" || e.Column.Name == "Questions") e.Column.Visible = false;
        }
        //Question number each part
        //Methods
        public void SetTestListBindingSource(BindingSource TestList)
        {
            dataGridView1.DataSource = TestList;
        }

        //Singleton
        private static TestView instance;
        public static TestView GetInstance()
        {
            if (instance == null || instance.IsDisposed) instance = new TestView();
            return instance;
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Add(tabPageQuestionList);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;
            AddQuestionToPanel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            AddQuestionToPanel();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageQuestionList);
            tabControl1.TabPages.Add(tabPageTestDetail);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //
            tabControl1.TabPages.Remove(tabPageQuestionList);
            tabControl1.TabPages.Add(tabPageTestDetail);
        }
        private void btnPart_Click(object sender, EventArgs e)
        {
            RoundButton btn = (RoundButton)sender;
            SetCurrentButton(btn);
            currentPage = btn.Text[btn.Text.Length - 1] - '0' - 1;
            AddQuestionToPanel();
        }
    }

}
