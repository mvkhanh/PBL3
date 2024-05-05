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
            btSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        //Properties
        public int Id => Convert.ToInt32(txtId.Text);

        public DateTime Bith { get => birth.Value; set => birth.Value = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public DateTime RegistDay { get => regist.Value; set => regist.Value = value; }
        public int Lessons { get => Convert.ToInt32(txtLessons.Text); set => txtLessons.Text = value.ToString(); }
        public int Tests { get => Convert.ToInt32(txtTests.Text); set => txtTests.Text = value.ToString(); }
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
    }
}
