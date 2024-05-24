﻿using System;
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
    public partial class LessonView : Form
    {
        public LessonView()
        {
            InitializeComponent();
        }



        private void btnAddPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = ofd.SafeFileName;
            }
        }
    }
}
