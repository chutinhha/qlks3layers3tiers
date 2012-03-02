using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _042082
{
    public partial class frmQTHT : DevComponents.DotNetBar.Office2007Form
    {
        public frmQTHT()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {


        }

        private void tabControlPhanQuyen_Click(object sender, EventArgs e)
        {

        }

        private void frmQTHT_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[2] = 2;
        }
    }
}