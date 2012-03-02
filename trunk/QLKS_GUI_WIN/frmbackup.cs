using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _042082
{
    public partial class frmbackup : DevComponents.DotNetBar.Office2007Form
    {
        static public string pws = frm_Main.pws;
        //UserBUS busnguodung = new UserBUS();
        public frmbackup()
        {
            InitializeComponent();
        }
        private void btbackup_Click(object sender, EventArgs e)
        {
            bool kt = new QLKS_BUS_WebService.QLKS_BUS_WebserviceSoapClient().backup(txtduongdan.Text.Trim().ToString());
            if (kt == true)
            {
                MessageBox.Show("Backup thành công!");
                txtduongdan.Text = "";
            }
        }

        private void ShowFromSaveFile()
        {
            //SaveFileDialog sa = new SaveFileDialog();


            
        }
        private void btduongdan_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Filter = "|*.bak";
            if (sa.ShowDialog() == DialogResult.OK)
            {
                txtduongdan.Text = sa.FileName + ".bak";
            }
        }

        private void frmbackup_Load(object sender, EventArgs e)
        {

        }

        private void frmbackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[13] = 13;
            //Thread thread = new Thread(new ThreadStart(hienform_main)); //Tạo luồng mới
            //thread.Start(); //Khởi chạy luồng
            //this.Close(); //đóng Form hiện tại. (Form1);
        }
        void hienform_main()
        {
            frm_Main main = new frm_Main();
            main.ShowDialog();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            //Thread t = new Thread(new ThreadStart(hienform_main));
            //t.Start();
            //this.Close();

        }

 
    }
}
