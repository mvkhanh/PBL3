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
            tabControl1.TabPages.Remove(tabPage2);
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
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add new teacher";
            };
            //Edit
            btnEdit.Click += delegate {
                try
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Add(tabPage2);
                    tabPage2.Text = "Edit teacher";
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
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
        }
        
        //Properties
        public int TeacherId { get => Convert.ToInt32(txtId.Text); set => txtId.Text = value.ToString(); }
        public string TeacherName { get => txtName.Text; set => txtName.Text = value; }
        public DateTime TeacherBith { get => birth.Value; set => birth.Value = value; }
        public string TeacherEmail { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string TeacherPhone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public DateTime TeacherRegistDay { get => regist.Value; set => regist.Value = value; }
        public string TeacherAccount { get => txtAccount.Text; set => txtAccount.Text = value; }
        public string TeacherPassword { get => txtPassword.Text; set => txtPassword.Text = value; }

        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => _IsEdit; set => _IsEdit = value; }
        public bool IsSuccessful { get => _IsSuccessfull; set => _IsSuccessfull = value; }
        public string Message { get => _Message; set => _Message = value; }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetTeacherListBindingSource(BindingSource teacherList)
        {
            dataGridView1.DataSource = teacherList;
        }

        //Singleton pattern 
        private static TeacherView instance;
        public static TeacherView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TeacherView();
            }
            return instance;
        }
    }
}
