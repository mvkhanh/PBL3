using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Resources.Components.Test.TestQuestion
{
    public partial class Test2 : TestQuestionBox
    {
        public override int QuestionNum { get => Convert.ToInt32(lbNum.Text); set => lbNum.Text = value.ToString(); }
        public override int QuestionChooseAnswer
        {
            get
            {
                var check = groupBox1.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(rb => rb.Checked);
                if (check == null) return -1;
                else return Convert.ToInt32(check.Tag);
            }
            set
            {
            }
        }
        public override bool ischecked
        {
            get
            {
                // Find the first checked radio button
                RadioButton checkedRadioButton = groupBox1.Controls.OfType<RadioButton>()
                                                   .FirstOrDefault(rb => rb.Checked);

                // Return true if a radio button is checked, false otherwise
                return checkedRadioButton != null;
            }
            set
            {
                // Find all radio buttons in the group box
                RadioButton[] radioButtons = groupBox1.Controls.OfType<RadioButton>().ToArray();

                // If setting isChecked to true
                if (value)
                {
                    // Find the first unchecked radio button and check it
                    RadioButton uncheckedRadioButton = radioButtons.FirstOrDefault(rb => !rb.Checked);
                    if (uncheckedRadioButton != null)
                    {
                        uncheckedRadioButton.Checked = true;
                    }
                }
                // If setting isChecked to false
                else
                {
                    // Uncheck all radio buttons
                    foreach (RadioButton radioButton in radioButtons)
                    {
                        radioButton.Checked = false;
                    }
                }
            }
        }
        public override event EventHandler CheckedChanged;
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Raise the CheckedChanged event
            this.OnCheckedChanged(EventArgs.Empty);
        }
        protected virtual void OnCheckedChanged(EventArgs e) 
        {
            CheckedChanged?.Invoke(this, e);
        }
        public Test2()
        {
            InitializeComponent();
        }
        
    }
}
