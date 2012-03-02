using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using _042082.QLKS_BUS_WebService;
namespace _042082
{
    public partial class frmrestore : DevComponents.DotNetBar.Office2007Form
    {
        //[STAThread]
       // UserBUS busnguoidung = new UserBUS();
        public frmrestore()
        {
            InitializeComponent();

        }
        
        private void btrestore_Click(object sender, EventArgs e)
        {
            if (txtduongdan.Text != "")
            {
                bool kt = new QLKS_BUS_WebserviceSoapClient().restore(txtduongdan.Text.Trim().ToString());
                if (kt == true)
                {
                    MessageBox.Show("restore cơ sở dữ liệu thành công!");
                    frmrestore.txtduongdan.Text= "";
                }
            }
 
        }

        private void btduongdan_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "|*.bak";
            if (op.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                txtduongdan.Text = op.FileName;
            }
            //Thread newThread = new Thread(new ThreadStart(ThreadMethod));
            //newThread.SetApartmentState(ApartmentState.STA);
            //newThread.Start();  
        }
        //static void ThreadMethod()
        //{
        //    //OpenFileDialog dlg = new OpenFileDialog();
        //    //dlg.ShowDialog();
        //    //MessageBox.Show(dlg.FileName);
        //    OpenFileDialog op = new OpenFileDialog();
        //    op.Filter = "|*.bak";
        //    if (op.ShowDialog() == DialogResult.OK)
        //    {
        //        MessageBox.Show(op.FileName);
        //        frmrestore.txtduongdan.Text = op.FileName;
        //    }
        //}
        void hienform_main()
        {
            frm_Main main = new frm_Main();
            main.ShowDialog();
        }
        private void tbthoat_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(hienform_main));
            t.Start();
            this.Close();
        }

        private void frmrestore_Load(object sender, EventArgs e)
        {

        }

        private void frmrestore_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[14] = 14;
        }
    }
}
