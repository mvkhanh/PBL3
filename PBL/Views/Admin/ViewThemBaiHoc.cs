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
    public partial class ViewThemBaiHoc : Form
    {
        public ViewThemBaiHoc()
        {
            InitializeComponent();
        }

        private void FormThemBaiHoc_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel3.Location = new Point((Width - panel3.Width) / 2, (Height - panel3.Height) / 2);
            panelInfo.Location = new Point(Width - panelInfo.Width - 20, panelHeader.Height + 5);
        }
        private void userPicture_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = !panelInfo.Visible;
        }

        private void panelUser_MouseEnter(object sender, EventArgs e)
        {
            panelUser.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelUser_MouseLeave(object sender, EventArgs e)
        {
            panelUser.BorderStyle = BorderStyle.None;
        }
    }
}
