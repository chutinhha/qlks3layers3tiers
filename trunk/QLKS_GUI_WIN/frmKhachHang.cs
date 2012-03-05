using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _042082
{
    public partial class frmKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public frmKhachHang()
        {
            _042082.UserControls.urlKhachHang.run = 1;
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
           // _042082.UserControls.urlKhachHang.OnLoad_frmKhachHang();
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[8] = 8;

        }
    }
}