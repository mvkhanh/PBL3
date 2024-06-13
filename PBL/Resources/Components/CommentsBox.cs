using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components
{
    public partial class CommentsBox : UserControl
    {
        public string CommentName { get => lbName.Text; set => lbName.Text = value; }
        public string CommentContent { get => txtContent.Text; set => txtContent.Text = value; }
        public DateTime CommentDate { set => lbDate.Text = value.ToLongDateString(); }
        public CommentsBox()
        {
            InitializeComponent();
        }
    }
}
