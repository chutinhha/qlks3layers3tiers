using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _042082
{
    public partial class frmSoftwareVersion : DevComponents.DotNetBar.Office2007Form
    {
        public frmSoftwareVersion()
        {
            InitializeComponent();
        }

        private void frmSoftwareVersion_Load(object sender, EventArgs e)
        {

        }

        private void frmSoftwareVersion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[16] = 16;

        }
    }
}