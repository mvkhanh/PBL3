using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.TestHistory
{
    public partial class HistoryBox : UserControl
    {
        public string TestName { set => lbTestName.Text = value; }
        public int TestResult { set => lbResults.Text = $"{value}/200"; }
        public int TestTime 
        {
            set
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(value);
                lbTestTime.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }
        }
        public DateTime TestDate { set => lbTestDay.Text = value.ToShortDateString(); }
            public HistoryBox()
        {
            InitializeComponent();
        }
    }
}
