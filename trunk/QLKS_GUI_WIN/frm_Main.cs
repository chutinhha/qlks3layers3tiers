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
    public partial class frm_Main : DevComponents.DotNetBar.Office2007RibbonForm
    {

        // Vùng biến để đảm bảo cho form chỉ mở 1 lần khi chạy.
        /*activeFrom[0]=0; form Login
         * 1 : Thay đoi quy đinh
         * 2 : Phân quyền
         * 3 : Lập phiếu thuê phòng
         * 4 : Tra Cứu Phòng
         * 5 : Lập doanh mục phòng
         * 6 : Quản lý loại phòng ==> Cùng chức năng 2 - Phân Quyền
         * 7 : Lập hòa dơn thanh toán
         * 8 : Quản lý khách hàng
         * 9 : Quản lý loại khách hàng ==> Cùng chức năng 2 - Phân Quyền
         * 10 : Báo cáo thống kê
         * 11 : Export
         * 12 : Import
         * 13 : Backup
         * 14 : Restore
         * // bỏ    qua huong dan
         * 15 : About
         * 16 : Tác giả & phiên bản phần mềm
         */

        static public int[] activeFrom = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};

        static public string pws="";
        //static public void Setpws(string pws)
        //{
        //    pws = pws;
        //}
        private int convertPower(string Power)
        {
            int pw=0;
            switch(Power)
            {
                case "QT": pw = 0; break;
                case "GD": pw = 1; break;
                case "TT": pw = 2; break;
                case "KH": pw = 3; break;
            }
            return pw;
        }
        // Thứ tự các quyền hạn : Người quản trị(0)	Ban giám đốc(1)	Tiếp tân(2)	Người dùng khác(3)

        private string stringPower = "0,1,16,17,18,22,23_0,1,3,6,7,10,11,13,14,15,16,23_12,8,19,14,2,5,4,6,1,0,9,16,18,20,21,22,23,24_16,14,23,1,0,6";
       
        /* Biến này là một mảng gồm n LoạiUser. Mỗi LoạiUser có 1 vài quyền hạn nhất định. 
         * Mỗi quyền hạn được thao trên nhiều Buttons
         * và mỗi Button được thao tác với nhiều LoạiUser
         * Mỗi Button có 1 công việc riêng, có 1 name và 1 Id nhất định. Và chuỗi trên Lưu dạng như thế - THAM KHẢO THÊM BẢNG QUYỀN HẠNG.
         */

        private string[] ipower;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

            /*Quyền hạn nào được chỉ ra mới kích hoạt từng nút phù hợp.
               1. Tách các quyền hạn của từng loại người dùng ra riêng ==> mảng ipower đản nhiệm Lưu 
               2. Nếu loại người dùng nào đăng nhập thì setId cho phù hợp
             */

            // Disable tất cả các nút
            this.disableButtonsAll();

            this.ipower = stringPower.Split(new char[] { '_' });
            int idLoaiNguoiDung = convertPower(pws);
            PhanQuyen(idLoaiNguoiDung);
            if(!pws.Equals("KH"))
                this.btiQTLogin.Text = "Đăng Xuất";
            // Tạm thời đang viết soft nên --> Quyền cao nhất :D
            //this.enableButtonsAll();

        }
        private void disableButtonsAll()
        {
            //List<DevComponents.DotNetBar.ButtonItem> lstB = new List<DevComponents.DotNetBar.ButtonItem>();
            //lstB[0].(this.btidpSoftAbout);
            this.btidpSoftAbout.Enabled = false;
            this.btidpSoftVersion.Enabled = false;
            this.btiHelpLBCTK.Enabled = false;
            this.btiHelpLDMP.Enabled = false;
            this.btiHelpLHDTT.Enabled = false;
            this.btiHelpLPTP.Enabled = false;
            this.btiHelpTCP.Enabled = false;
            this.btiHelpTDQD.Enabled = false;
            this.btiKHLapHoaDon.Enabled = false;
            this.btiKHQuanLyKH.Enabled = false;
            this.btiKHQuanLyLKH.Enabled = false;
            this.btiPLapDMP.Enabled = false;
            this.btiPLapPhieuThue.Enabled = false;
            this.btiPQuanLyLP.Enabled = false;
            this.btiPTraCuuPhong.Enabled = false;
            this.btiQTChangeRole.Enabled = false;
            this.btiQTLogin.Enabled = false;
            this.btiQTPower.Enabled = false;
            this.btiTXBackup.Enabled = false;
            this.btiTXBaoCaoTK.Enabled = false;
            this.btiTXExport.Enabled = false;
            this.btiTXImport.Enabled = false;
            this.btiTXRestore.Enabled = false;
            this.buttonItem_TOP_QLKS.Enabled = false;
            this.btiHelpQLKH.Enabled = false;
        }
        private void enableButtonsAll()
        {
            this.btidpSoftAbout.Enabled = true;
            this.btidpSoftVersion.Enabled = true;
            this.btiHelpLBCTK.Enabled = true;
            this.btiHelpLDMP.Enabled = true;
            this.btiHelpLHDTT.Enabled = true;
            this.btiHelpLPTP.Enabled = true;
            this.btiHelpTCP.Enabled = true;
            this.btiHelpTDQD.Enabled = true;
            this.btiKHLapHoaDon.Enabled = true;
            this.btiKHQuanLyKH.Enabled = true;
            this.btiKHQuanLyLKH.Enabled = true;
            this.btiPLapDMP.Enabled = true;
            this.btiPLapPhieuThue.Enabled = true;
            this.btiPQuanLyLP.Enabled = true;
            this.btiPTraCuuPhong.Enabled = true;
            this.btiQTChangeRole.Enabled = true;
            this.btiQTLogin.Enabled = true;
            this.btiQTPower.Enabled = true;
            this.btiTXBackup.Enabled = true;
            this.btiTXBaoCaoTK.Enabled = true;
            this.btiTXExport.Enabled = true;
            this.btiTXImport.Enabled = true;
            this.btiTXRestore.Enabled = true;
            this.buttonItem_TOP_QLKS.Enabled = true;
            this.btiHelpQLKH.Enabled = true;
        }
        private void PhanQuyen(int IdLoaiNguoiDung)
        {
            string[] tmpId = this.ipower[IdLoaiNguoiDung].Split(new char[] { ',' });
            //string[] tmpName = namebuttonItems.Split(new char[] { ',' });
            for (int i = 0; i < tmpId.Length; i++)
            {
                switch (tmpId[i])
                {
                    case "0": this.btidpSoftAbout.Enabled = true; break;
                    case "1": this.btidpSoftVersion.Enabled = true; break;
                    case "2": this.btiHelpLBCTK.Enabled = true; break;
                    case "3": this.btiHelpLDMP.Enabled = true; break;
                    case "4": this.btiHelpLHDTT.Enabled = true; break;
                    case "5": this.btiHelpLPTP.Enabled = true; break;
                    case "6": this.btiHelpTCP.Enabled = true; break;
                    case "7": this.btiHelpTDQD.Enabled = true; break;
                    case "8": this.btiKHLapHoaDon.Enabled = true; break;
                    case "9": this.btiKHQuanLyKH.Enabled = true; break;
                    case "10": this.btiKHQuanLyLKH.Enabled = true; break;
                    case "11": this.btiPLapDMP.Enabled = true; break;
                    case "12": this.btiPLapPhieuThue.Enabled = true; break;
                    case "13": this.btiPQuanLyLP.Enabled = true; break;
                    case "14": this.btiPTraCuuPhong.Enabled = true; break;
                    case "15": this.btiQTChangeRole.Enabled = true; break;
                    case "16": this.btiQTLogin.Enabled = true; break;
                    case "17": this.btiQTPower.Enabled = true; break;
                    case "18": this.btiTXBackup.Enabled = true; break;
                    case "19": this.btiTXBaoCaoTK.Enabled = true; break;
                    case "20": this.btiTXExport.Enabled = true; break;
                    case "21": this.btiTXImport.Enabled = true; break;
                    case "22": this.btiTXRestore.Enabled = true; break;
                    case "23": this.buttonItem_TOP_QLKS.Enabled = true; break;
                    case "24": this.btiHelpQLKH.Enabled = true; break;
                }

            }

        }
        // Hàm chung cho việc mở form - Tiết kiệm vùng nhớ cục bộ - Ít gõ code - Kiểm soát code khoa học hơn 
        
        private void Show_frmLogin()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        // Vùng Hàm thao tác Click trên Menu

        private void buttonItemLogin_Click(object sender, EventArgs e)
        {
            if (!frm_Main.pws.Equals("KH"))
            {
                if (MessageBox.Show("Bạn muốn đăng xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm_Main.pws = "";
                    //Thread thread = new Thread(new ThreadStart(Show_frmLogin)); //Tạo luồng mới
                    //thread.Start(); //Khởi chạy luồng
                    Show_frmLogin();
                    this.Close(); //đóng Form hiện tại. (Form1);
                }
            }
            else
            {
                if (frm_Main.pws.Equals("KH"))
                {
                    frm_Main.pws = "";
                    Thread thread = new Thread(new ThreadStart(Show_frmLogin)); //Tạo luồng mới
                    thread.Start(); //Khởi chạy luồng
                    this.Close(); //đóng Form hiện tại. (Form1);
                }
            }
        }

        private void frmShow(DevComponents.DotNetBar.Office2007Form frm,int idFromOpen)
        {
            if (activeFrom[idFromOpen] == idFromOpen)
            {
                activeFrom[idFromOpen] = 0;
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        private void buttonItemChangeRole_Click(object sender, EventArgs e)
        {
            frmShow(new frmThayDoiQD(),1);
        }

        private void buttonItemPower_Click(object sender, EventArgs e)
        {
            frmShow(new frmQTHT(),2);
        
        }

        private void btiPLapPhieuThue_Click(object sender, EventArgs e)
        {
            if (activeFrom[3] == 3)
            {
                activeFrom[3] = 0;
                frmPhieuThue frm = new frmPhieuThue();
                //frm.IsMdiContainer = true; ==> form này không dùng chức năng này
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
           
        }

        private void btiPTraCuuPhong_Click(object sender, EventArgs e)
        {
            frmShow(new frmTraCuuPhong(),4);
        }

        private void btiPLapDMP_Click(object sender, EventArgs e)
        {
            frmShow(new frmPhong(),5);
        }

        private void btiPQuanLyLP_Click(object sender, EventArgs e)
        {
            frmShow(new frmThayDoiQD(),1);
        }

        private void btiKHLapHoaDon_Click(object sender, EventArgs e)
        {
            frmShow(new frmDSHoaDon(),7);
        }

        private void btiKHQuanLyKH_Click(object sender, EventArgs e)
        {
            frmShow(new frmKhachHang(),8);
        }

        private void btiKHQuanLyLKH_Click(object sender, EventArgs e)
        {
            frmShow(new frmThayDoiQD(),1);
        }

        private void btiTXBaoCaoTK_Click(object sender, EventArgs e)
        {
            //frmShow(new frmBaoCaoTK(),10);
        }

        private void btiTXExport_Click(object sender, EventArgs e)
        {

        }

        private void btiTXImport_Click(object sender, EventArgs e)
        {

        }
        void ShowBackupForm()
        {
            frmbackup main = new frmbackup();
            main.WindowState = FormWindowState.Maximized;
            main.ShowDialog();
            
        }
        void ShowRestoreForm()
        {
            frmrestore main = new frmrestore();
            main.WindowState = FormWindowState.Maximized;
            main.ShowDialog();

        }

        private void btiTXBackup_Click(object sender, EventArgs e)
        {
            if (activeFrom[13] == 13)
            {
                activeFrom[13] = 0;
                frmbackup frm = new frmbackup();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            //frmShow(new frmbackup(),13);
        }

        private void btiTXRestore_Click(object sender, EventArgs e)
        {
            if (activeFrom[14] == 14)
            {
                activeFrom[14] = 0;
                frmrestore frm = new frmrestore();
                frm.MdiParent = this; //==> form này không dùng chức năng này
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                
            }
            ////frmShow(new frmrestore(),14); ===> DO BỊ LỖI KHI HỘP THOẠI SAVE FILE HIỆN LÊN
            //Thread t = new Thread(new ThreadStart(ShowRestoreForm));
            //ShowRestoreForm();
            //t.Start();
            //this.Dispose();
        }

        private void btiHelpLDMP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("LDMP.chm");
        }

        private void btiHelpLPTP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("LPTP.chm");
        }

        private void btiHelpTCP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TCP.chm");
        }

        private void btiHelpLHDTT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("LHDTT.chm");
        }

        private void btiHelpLBCTK_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(".chm");
        }

        private void btiHelpTDQD_Click(object sender, EventArgs e)
        {

        }

        private void btidpSoftAbout_Click(object sender, EventArgs e)
        {

        }

        private void btidpSoftVersion_Click(object sender, EventArgs e)
        {
            if (activeFrom[16] == 16)
            {
                activeFrom[16] = 0;
                frmSoftwareVersion f = new frmSoftwareVersion();
                f.IsMdiContainer = false;
                //frm.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void ribbonControlQLKS_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DevComponents.DotNetBar.Office2007Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
        }

        private void btiHelpQLKH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("QLKH.chm");
        }
    }
}