using PBL.Views.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Admin.Students
{
    public partial class StudentView : Form, IStudentView
    {
        //Fields
        private bool _IsEdit;
        private bool _IsSuccessful;
        private string _Message;

        //Constructor
        public StudentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageStudentDetail);
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
                tabControl1.TabPages.Remove(tabPageStudentList);
                tabControl1.TabPages.Add(tabPageStudentDetail);
                tabPageStudentDetail.Text = "Add new student";
            };
            btnEdit.Click += delegate
            {
                try
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageStudentList);
                    tabControl1.TabPages.Add(tabPageStudentDetail);
                    tabPageStudentDetail.Text = "Edit student";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected student?", "Warning", MessageBoxButtons.YesNo,
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
                    tabControl1.TabPages.Remove(tabPageStudentDetail);
                    tabControl1.TabPages.Add(tabPageStudentList);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageStudentDetail);
                tabControl1.TabPages.Add(tabPageStudentList);
            };
        }

        #region Properties
        public int StudentId
            { get => Convert.ToInt32(txtId.Texts); set => txtId.Texts = value.ToString(); }

        public string StudentName 
            { get => txtName.Texts; set => txtName.Texts = value; }
        public DateTime StudentBirth 
            { get => birth.Value.Date; set => birth.Value = value.Date; }
        public string StudentEmail 
            { get => txtEmail.Texts; set => txtEmail.Texts = value; }
        public string StudentPhone 
            { get => txtPhone.Texts; set => txtPhone.Texts = value; }
        public DateTime StudentRegistDay 
            { get => regist.Value.Date; set => regist.Value = value.Date; }
        public string StudentAccount { get => txtAccount.Texts; set => txtAccount.Texts = value; }
        public string StudentPassword { get => txtPassword.Texts; set => txtPassword.Texts = value; }

        public string SearchValue 
            { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit 
            { get => _IsEdit; set => _IsEdit = value; }
        public bool IsSuccessful
            { get => _IsSuccessful; set => _IsSuccessful = value; }
        public string Message 
            { get => _Message; set => _Message = value; }
        #endregion

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetStudentListBindingSource(BindingSource studentList)
        {
            dataGridView1.DataSource = studentList;
        }

        #region Singleton
        private static StudentView instance;
        public static StudentView GetInstance()
        {
            if(instance == null || instance.IsDisposed) instance = new StudentView();
            return instance;
        }
        #endregion

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Id_Account" || e.Column.Name == "Account") e.Column.Visible = false;
        }
    }
}
