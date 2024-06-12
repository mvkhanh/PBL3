using PBL.Views;
using PBL.Views.Student.StudentProfile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class StudentProfileView : Form, IStudentProfileView
    {
        //Fields
        private string _Message;
        private bool _IsSuccessful;

        public StudentProfileView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            tabControl1.TabPages.Remove(tabPageChangePassword);
            tabControl1.TabPages.Remove(tabPageEditProfile);
        }

        private void AssociateAndRaiseEvents()
        {
            btnSaveEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageEditProfile);
                    tabControl1.TabPages.Add(tabPageProfile);
                }
                MessageBox.Show(Message);
            };
            btnSaveChangePass.Click += delegate
            {
                if (txtNewPass.Texts != txtNewPassAgain.Texts) Message = "Password entered again not right";
                else if (txtCurrentPass.Texts == txtNewPass.Texts) Message = "New password and current password are the same";
                else
                {
                    ChangePassEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        tabControl1.TabPages.Remove(tabPageChangePassword);
                        tabControl1.TabPages.Add(tabPageProfile);
                        txtNewPassAgain.Texts = "";
                    }
                }
                MessageBox.Show(Message);
            };
            btnCancelEdit.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                txtNewPassAgain.Texts = "";
                tabControl1.TabPages.Remove(tabPageEditProfile);
                tabControl1.TabPages.Add(tabPageProfile);
            };
            btnCancelChangePass.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                txtNewPassAgain.Texts = "";
                tabControl1.TabPages.Remove(tabPageChangePassword);
                tabControl1.TabPages.Add(tabPageProfile);
            };
        }

        //Events
        public event EventHandler EditEvent;
        public event EventHandler ChangePassEvent;
        public event EventHandler CancelEvent;

        #region Properties
        public string StudentName {
            get => lbStudentName.Text = txtStudentName.Texts;
            set
            {
                lbStudentName.Text = txtStudentName.Texts = value;
            }
        }
        public DateTime StudentBirth
        {
            get => Convert.ToDateTime(lbStudentBirth.Text = editBirth.Value.ToShortDateString());
            set
            {
                lbStudentBirth.Text = (editBirth.Value = value).ToShortDateString();
            }
        }
        public string StudentEmail
        {
            get => lbStudentEmail.Text = txtStudentEmail.Texts;
            set
            {
                lbStudentEmail.Text = txtStudentEmail.Texts = value;
            }
        }
        public string StudentPhone
        {
            get => lbStudentPhone.Text = txtStudentPhone.Texts;
            set
            {
                lbStudentPhone.Text = txtStudentPhone.Texts = value;
            }
        }
        public string StudentCurrentPassword { get => txtCurrentPass.Texts; set => txtCurrentPass.Texts = value; }
        public string StudentNewPassword { get => txtNewPass.Texts; set => txtNewPass.Texts = value; }
        public int StudentTests { get => Convert.ToInt32(lbStudentTests.Text); set => lbStudentTests.Text = value.ToString(); }
        public int StudentAverageScores { get => Convert.ToInt32(lbStudentScores.Text); set => lbStudentScores.Text = value.ToString(); }
        public bool IsSuccessful
        { get => _IsSuccessful; set => _IsSuccessful = value; }
        public string Message
        { get => _Message; set => _Message = value; }
        #endregion

        #region Singleton pattern 
        private static StudentProfileView instance;

        public static StudentProfileView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentProfileView();
            }
            return instance;
        }
        #endregion

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageProfile);
            tabControl1.TabPages.Add(tabPageEditProfile);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageProfile);
            tabControl1.TabPages.Add(tabPageChangePassword);
        }

        private void btnChangePassword2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageEditProfile);
            tabControl1.TabPages.Add(tabPageChangePassword);
        }
    }
}
