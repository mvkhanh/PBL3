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
    public partial class AddPartLabel : UserControl
    {
        public string nameP { set { namePart.Text = value; } }
        public AddPartLabel()
        {
            InitializeComponent();
        }

        
    }
}
