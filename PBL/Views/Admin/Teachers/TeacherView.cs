using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views
{
    public partial class TeacherView : Form, ITeacherView
    {
        private bool _IsEdit;
        private bool _IsSuccessfull;
        private string _Message;

        public TeacherView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageTeacherDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            btnAddNew.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTeacherList);
                tabControl1.TabPages.Add(tabPageTeacherDetail);
                tabPageTeacherDetail.Text = "Add new teacher";
            };
            //Edit
            btnEdit.Click += delegate {
                try
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageTeacherList);
                    tabControl1.TabPages.Add(tabPageTeacherDetail);
                    tabPageTeacherDetail.Text = "Edit teacher";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            //Delete
            btnDelete.Click += delegate { 
                var res = MessageBox.Show("Are you sure you want to delete the selected teacher?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes) { 
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };
            //Save changes
            btnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageTeacherDetail);
                    tabControl1.TabPages.Add(tabPageTeacherList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTeacherDetail);
                tabControl1.TabPages.Add(tabPageTeacherList);
            };
        }

        #region Properties
        public int TeacherId 
            { get => Convert.ToInt32(txtId.Texts); set => txtId.Texts = value.ToString(); }
        public string TeacherName 
            { get => txtName.Texts; set => txtName.Texts = value.Trim(); }
        public DateTime TeacherBith 
            { get => birth.Value.Date; set => birth.Value = value.Date; }
        public string TeacherEmail
            { get => txtEmail.Texts; set => txtEmail.Texts = value.Trim(); }
        public string TeacherPhone 
            { get => txtPhone.Texts; set => txtPhone.Texts = value.Trim(); }
        public DateTime TeacherRegistDay 
            { get => regist.Value.Date; set => regist.Value = value.Date; }
        public string TeacherAccount 
            { get => txtAccount.Texts; set => txtAccount.Texts = value.Trim(); }
        public string TeacherPassword 
            { get => txtPassword.Texts; set => txtPassword.Texts = value.Trim(); }

        public string SearchValue
            { get => txtSearch.Text; set => txtSearch.Text = value.Trim(); }
        public bool IsEdit
            { get => _IsEdit; set => _IsEdit = value; }
        public bool IsSuccessful 
            { get => _IsSuccessfull; set => _IsSuccessfull = value; }
        public string Message 
            { get => _Message; set => _Message = value; }
        #endregion

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Lessons" || e.Column.Name == "Tests" || e.Column.Name == "Password" || e.Column.Name == "Account") e.Column.Visible = false;
        }

        //Methods
        public void SetTeacherListBindingSource(BindingSource teacherList)
        {
            dataGridView1.DataSource = teacherList;
        }

        #region Singleton
        private static TeacherView instance;
        public static TeacherView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TeacherView();
            }
            return instance;
        }
        #endregion
    }
}
