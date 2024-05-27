using FontAwesome.Sharp;
using PBL.Views.Admin.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views
{
    public partial class MainView : Form, IMainView
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor

        public MainView()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Events
        public event EventHandler ShowTeacherView;
        public event EventHandler ShowStudentView;
        public event EventHandler ShowLessonView;
        public event EventHandler ShowTestView;
        public event EventHandler ShowDashBoardView;

        #region Menu Item Colors
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        #endregion
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleChildForm.Text = childForm.Text;
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowTeacherView(sender, EventArgs.Empty);
            OpenChildForm(TeacherView.GetInstance());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ShowStudentView(sender, EventArgs.Empty);
            OpenChildForm(StudentView.GetInstance());
        }

        private void btnLessons_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowLessonView(sender, EventArgs.Empty);
            OpenChildForm(LessonView.GetInstance());
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            ShowTestView(sender, EventArgs.Empty);
            OpenChildForm(TestView.GetInstance());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lbTitleChildForm.Text = "Home";
        }

        #region Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Define the constant values for the interop functions
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HT_CAPTION = 0x0002;
        private const int HT_LEFT = 0x0A;
        private const int HT_RIGHT = 0x0B;
        private const int HT_TOP = 0x0C;
        private const int HT_TOPLEFT = 0x0D;
        private const int HT_TOPRIGHT = 0x0E;
        private const int HT_BOTTOM = 0x0F;
        private const int HT_BOTTOMLEFT = 0x10;
        private const int HT_BOTTOMRIGHT = 0x11;
        // Handle the mouse down event on the form to enable dragging and resizing
        private void resizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X <= 5 && e.Y <= 5) // Top-left corner
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_TOPLEFT, 0);
                }
                else if (e.X >= panelTitle.Width - 5 && e.Y <= 5) // Top-right corner
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_TOPRIGHT, 0);
                }
                else if (e.X <= 5 && e.Y >= panelDesktop.Height - 5) // Bottom-left corner
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_BOTTOMLEFT, 0);
                }
                else if (e.X >= panelDesktop.Width - 5 && e.Y >= panelDesktop.Height - 5) // Bottom-right corner
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_BOTTOMRIGHT, 0);
                }
                else if (e.Y <= 5) // Top edge
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_TOP, 0);
                }
                else if (e.Y >= panelDesktop.Height - 5) // Bottom edge
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_BOTTOM, 0);
                }
                else if (e.X <= 5) // Left edge
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_LEFT, 0);
                }
                else if (e.X >= panelDesktop.Width - 5) // Right edge
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_RIGHT, 0);
                }
                else if (sender == panelTitle)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        // Handle the mouse move event on the resize panel to change the mouse pointer
        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= 5 && e.Y <= 5) Cursor = Cursors.SizeNWSE;
            else if (e.X >= panelTitle.Width - 5 && e.Y <= 5) Cursor = Cursors.SizeNESW;
            else if (e.X <= 5 || e.X >= panelTitle.Width - 5) Cursor = Cursors.SizeWE;
            else if (e.Y <= 5) Cursor = Cursors.SizeNS;
            else Cursor = Cursors.Default;
        }
        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= 5 && e.Y >= panelMain.Height - 5) Cursor = Cursors.SizeNESW;
            else if(e.X <= 5) Cursor = Cursors.SizeWE;
            else if (e.Y >= panelMain.Height - 5) Cursor = Cursors.SizeNS;
            else Cursor = Cursors.Default;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= panelShadow.Width - 5) Cursor = Cursors.SizeWE;
            else Cursor = Cursors.Default;
        }

        private void panelDesktop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= panelDesktop.Width - 5 && e.Y >= panelDesktop.Height - 5) Cursor = Cursors.SizeNWSE;
            else if (e.Y >= panelDesktop.Height - 5) Cursor = Cursors.SizeNS;
            else if (e.X >= panelDesktop.Width - 5) Cursor = Cursors.SizeWE;
            else Cursor = Cursors.Default;
        }
        #endregion


        #region Modify window
        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
