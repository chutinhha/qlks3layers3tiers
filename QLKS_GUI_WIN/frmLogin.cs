using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.WinForms;

using System.Data.SqlClient;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.IO;

using System.Runtime.InteropServices;

using _042082.QLKS_BUS_WebService;
namespace _042082
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        
        UserDTO UserDTO = new UserDTO();
        public static string tenmay;

        //Move GroupBox
        private bool dragging;

        private Point pointClicked;

        public frmLogin()
        {
            InitializeComponent();
           //this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            //this.TitleText = "";
            this.Text = "";

            //this
        }
        void info()
        {
            UserDTO.Name = txt_UserName.Text;
            UserDTO.PassWord = txt_Password.Text;
        }
        bool KiemTraRong()
        {
            bool kt = true;
            if (txt_UserName.Text == "")
            {
                errorProvider_dangnhap.SetError(txt_UserName, "Tên Người Dùng Không Được Để Trống");
                txt_UserName.Focus();
                kt = false;
                return kt;
            }
            else
            {
                errorProvider_dangnhap.SetError(txt_UserName, "");
                kt = true;
            }
            if (txt_Password.Text == "")
            {
                errorProvider_dangnhap.SetError(txt_Password, "Mật Khẩu Không Được Để Trống");
                txt_Password.Focus();
                kt = false;
                return kt;
            }
            else
            {
                errorProvider_dangnhap.SetError(txt_Password, "");
                kt = true;
            }
            return kt;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
            if (KiemTraRong() == true)
            {
                info();
                if (ws.KiemTra_tendangnhap(UserDTO.Name) == false)
                {
                    MessageBox.Show("Tên đăng nhập không đúng!");
                    txt_UserName.Focus();
                    return;
                }
                else
                {
                    if (ws.KiemTra_matkhau(UserDTO.Name, UserDTO.PassWord) == false)
                    {
                        MessageBox.Show("Mật khẩu chưa chính xác!");
                        txt_Password.Focus();
                        return;
                    }
                    else
                    {
                        frm_Main.pws = ws.getIdKUserByIdUser(UserDTO);
                        //MessageBox.Show(busnguoidung.getIdKUserByIdUser(UserDTO));
                        
                        //Thread thread = new Thread(new ThreadStart(hienform_main)); //Tạo luồng mới
                        //thread.Start(); //Khởi chạy luồng
                        Thread thread = new Thread(new ThreadStart(hienform_main));
                        thread.Start();
                        this.Dispose();
                        //this.Close();
                        //this.Close(); //đóng Form hiện tại. (Form1)
                    }
                }
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            frm_Main.pws = "KH"; // Guest - người dùng khác
            Thread thread = new Thread(new ThreadStart(hienform_main)); 
            thread.Start();
            this.Close(); 
        }
        void hienform_main()
        {
            frm_Main main = new frm_Main();
            main.ShowDialog();
        }

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            //Process netUtility = new Process();
            //netUtility.StartInfo.FileName = "net.exe";
            //netUtility.StartInfo.CreateNoWindow = true;
            //netUtility.StartInfo.Arguments = "view";
            //netUtility.StartInfo.RedirectStandardOutput = true;
            //netUtility.StartInfo.UseShellExecute = false;
            //netUtility.StartInfo.RedirectStandardError = true;
            //netUtility.Start();
            //StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);
            //string line = "";
            //while ((line = streamReader.ReadLine()) != null)
            //{
            //    if (line.StartsWith("\\"))
            //    {
            //        cboTenMay.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
            //    }
            //}
            //streamReader.Close();
            //netUtility.WaitForExit(1000);
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // GorupBox
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                this.Location = pointMoveTo;
            }   
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}