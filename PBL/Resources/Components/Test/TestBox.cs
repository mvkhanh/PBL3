using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.Test
{
    public partial class TestBox : UserControl
    {
        #region Properties
        public List<Control> controls;
        public int TestId { get; set; }
        public string TestTeacher
        {
            get => lbTestTeacher.Text;
            set => lbTestTeacher.Text = value;
        }
        public string TestDescription
        {
            get => txtTestDescription.Text;
            set => txtTestDescription.Text = value;
        }
        public int TestCount
        {
            get => Convert.ToInt32(lbTestCount.Text);
            set => lbTestCount.Text = value.ToString();
        }
        public DateTime TestPublishDay
        {
            get => Convert.ToDateTime(lbTestPublishDay.Text);
            set => lbTestPublishDay.Text = value.ToShortDateString();
        }
        public string TestName
        {
            get => txtTestName.Text;
            set => txtTestName.Text = value;
        }
        #endregion
        public TestBox()
        {
            InitializeComponent();
            controls = new List<Control>();
            controls.Add(panel1);
            controls.Add(roundPanel1);
            foreach (Control control in panel1.Controls) controls.Add(control);
            foreach (Control control in roundPanel1.Controls) controls.Add(control);
        }
    }
}
