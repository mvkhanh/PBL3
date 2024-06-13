using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PBL.Views.Teacher.TeacherProfile
{
    public partial class TeacherProfileView : Form,ITeacherProfileView
    {
        //Fields
        private string _Message;
        private bool _IsSuccessful;

        public TeacherProfileView()
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
        public string TeacherName
        {
            get => lbTeacherName.Text = txtTeacherName.Texts;
            set
            {
                lbTeacherName.Text = txtTeacherName.Texts = value;
            }
        }
        public DateTime TeacherBirth
        {
            get => Convert.ToDateTime(lbTeacherBirth.Text = editBirth.Value.ToShortDateString());
            set
            {
                lbTeacherBirth.Text = (editBirth.Value = value).ToShortDateString();
            }
        }
        public string TeacherEmail
        {
            get => lbTeacherEmail1.Text = txtTeacherEmail.Texts;
            set
            {
                lbTeacherEmail1.Text = txtTeacherEmail.Texts = value;
            }
        }
        public string TeacherPhone
        {
            get => lbTeacherPhone.Text = txtTeacherPhone.Texts;
            set
            {
                lbTeacherPhone.Text = txtTeacherPhone.Texts = value;
            }
        }
        public string TeacherCurrentPassword { get => txtCurrentPass.Texts; set => txtCurrentPass.Texts = value; }
        public string TeacherNewPassword { get => txtNewPass.Texts; set => txtNewPass.Texts = value; }
        public int TotalLesson { get => Convert.ToInt32(lbTeacherLesson.Text); set => lbTeacherLesson.Text = value.ToString(); }
        public int TotalTest { get=> Convert.ToInt32(lbTeacherTest.Text); set => lbTeacherTest.Text = value.ToString(); }
        public bool IsSuccessful
        { get => _IsSuccessful; set => _IsSuccessful = value; }
        public string Message
        { get => _Message; set => _Message = value; }
        #endregion

        #region Singleton pattern 
        private static TeacherProfileView instance;

        public static TeacherProfileView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TeacherProfileView();
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
