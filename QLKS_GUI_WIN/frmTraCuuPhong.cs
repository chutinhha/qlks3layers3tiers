﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _042082
{
    public partial class frmTraCuuPhong : DevComponents.DotNetBar.Office2007Form
    {
        public frmTraCuuPhong()
        {
            InitializeComponent();
        }

        private void frmTraCuuPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[4] = 4;
        }
    }
}
