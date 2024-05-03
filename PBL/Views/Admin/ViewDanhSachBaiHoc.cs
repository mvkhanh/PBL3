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
    public partial class ViewDanhSachBaiHoc : Form
    {
        public ViewDanhSachBaiHoc()
        {
            InitializeComponent();
        }
        private void FormQuanLyBaiHoc_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
