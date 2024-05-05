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
        private DateTime _Birth;
        private string _Email;
        private int _Id;
        private string _Phone;
        private DateTime _RegistDay;
        private int _Lessons;
        private int _Tests;

        public TeacherView()
        {
            InitializeComponent();
        }

        //Properties
        public int Id => _Id;

        public DateTime Bith { get => _Birth; set => _Birth = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public DateTime RegistDay { get => _RegistDay; set => _RegistDay = value; }
        public int Lessons { get => _Lessons; set => _Lessons = value; }
        public int Tests { get => _Tests; set => _Tests = value; }
        public string searchValue { get =>  set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
