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
    public partial class FormQuanLyBaiHoc : Form
    {
        public FormQuanLyBaiHoc()
        {
            InitializeComponent();
        }

        private void roundButton1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }
    }
}
