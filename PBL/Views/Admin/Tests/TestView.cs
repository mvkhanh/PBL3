using PBL.Resources.Components;
using PBL.Views.Admin.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public List<AddQuestion> li;
        List<FlowLayoutPanel> Fl;
        int K = 0;
        public TestView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Remove(tabPage3);
            Teachers = new List<CBBItem>();
            cbbTeacherName.DataSource = Teachers;
            li = new List<AddQuestion>();
            Fl = new List<FlowLayoutPanel>();

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
            //get => ((CBBItem)cbbTeacherName.SelectedItem).Value;
            //set
            //{
            //    foreach (var item in cbbTeacherName.Items) if (((CBBItem)item).Value == value)
            //        {
            //            cbbTeacherName.SelectedItem = item;
            //        }
            //}
            get; set;
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

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Id_Teacher" || e.Column.Name == "Description") e.Column.Visible = false;
        }

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
            int count = 1;
            for(int i = 1; i <= 7; i++)
            {
                Add(3, ref count);
            }
            tabControl1.TabPages.Remove(tabPageTestDetail);
            tabControl1.TabPages.Add(tabPage3);
            
            panel1.Controls.Add(Fl[0]); K = 0;
        }
        private void Add(int numQuestions, ref int questionCount)
        {
            Label lb = new Label();
            lb.Text = "Part " + (K+1);
            lb.Size = new Size(panelbtn.Width, 30);
            Dock = DockStyle.Top;
            FlowLayoutPanel questionContainer = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Height = this.Height-panelbtn.Height,
                Width = panelbtn.Width,
                AutoSize = true,
                Anchor = AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right,
                Name = "Part 1"
            };
            questionContainer.Controls.Add(lb);
            for (int j = 1; j <= numQuestions; j++)
            {
                AddQuestion addQuestion = new AddQuestion
                {
                    ID = questionCount.ToString(),
                    Dock = DockStyle.Fill,
                };

                Panel questionPanel = new Panel
                {
                    Size = new Size(panelbtn.Width-150, 301),
                };
                questionContainer.Location = new Point(0, 0);
                questionPanel.Controls.Add(addQuestion);
                li.Add(addQuestion);
                questionContainer.Controls.Add(questionPanel);
                questionCount++;
            }
            Fl.Add(questionContainer);
        }
        void back()
        {
            panelbtn.Dock = DockStyle.Bottom;
            tabPage3.Controls.Clear();
            tabPage3.Controls.Add(panel1);
            for (int i = 0; i < 7; i++) panel1.Controls.RemoveByKey("Part " + (i + 1));
            if (panelbtn.Parent != null)
            {
                panelbtn.Parent.Controls.Remove(panelbtn);
            }
            panelbtn.Location = new Point(22, 4);
        }
        private void btnCanCel1_Click(object sender, EventArgs e)
        {
            back();
            li.Clear();
            Fl.Clear();
            panel1.AutoScroll = true;
            panel1.Controls.Add(panelbtn);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Add(tabPageTestDetail);
            
        }
        private void BtnSave1_Click(object sender, EventArgs e)
        {
            back();
            panel1.Controls.Add(panelbtn);
            panel1.AutoScroll = true;
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Add(tabPageTestDetail);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {  
            K++;
            back();
            panel1.Controls.Add(panelbtn);
            panel1.Controls.Add(Fl[K]);
            panelbtn.Location = new Point(Fl[K].Location.X, Fl[K].Location.Y + Fl[K].Height + 30);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            K--;
            panel1.Controls.RemoveByKey("Part " + (K));
        }
    }

}
