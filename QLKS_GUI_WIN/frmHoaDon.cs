using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using _042082.QLKS_BUS_WebService;

namespace _042082
{
    public partial class frmHoaDon : DevComponents.DotNetBar.Office2007Form
    {
        DataTable dt = new DataTable();
        //HoaDonBUS busHD = new HoaDonBUS();

        HoaDonDTO dtoHD = new HoaDonDTO();
        //CT_HoaDonBUS busCTHD = new CT_HoaDonBUS();
        CT_HoaDonDTO dtoCTHD = new CT_HoaDonDTO();
        //ThamSoBUS busthamso = new ThamSoBUS();
        int chiso;
        public static string MaHD;
        public QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
        public DataTable ConvertKhachHangDTOArrayToDataTable(KhachHangDTO[] DTOArr)
        {
            DataTable dt = new DataTable();
            int row = DTOArr.Length;
            dt.Columns.Add("MaKhachHang", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("MaLoaiKH", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("KhachHangDaiDien", typeof(string));
            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(DTOArr[i].MaKhachHang, DTOArr[i].TenKhachHang, DTOArr[i].MaLoaiKH, DTOArr[i].CMND, DTOArr[i].DiaChi, DTOArr[i].KhachHangDaiDien);
            }
            return dt;
        }
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDonThanhToan_Load(object sender, EventArgs e)
        {
           
           /* _042082.UserControls.urlKhachHang n = new _042082.UserControls.urlKhachHang();
            this.Controls.Add(n);
            //_042082.UserControls.urlKhachHang.LoadOnHoaDon
           */
            btAdd.Enabled = false;
            cmd_ngaytra_thucte.Text = DateTime.Now.ToString();
            cmdNgayLap.Text = DateTime.Now.ToString();
            xoatrang();
            
        }
        //private void bt_sendkh_Click(object sender, EventArgs e)
        //{
        //    txt_MaKH.Text = _042082.UserControls.urlKhachHang.staticMaKhachHang;
        //}

        
        private void listViewHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPhieuThue.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                listViewCTPhong.Items.Clear();
                ListViewItem item = listViewPhieuThue.SelectedItems[0];
                chiso = item.Index;
                string maPT = item.SubItems[0].Text;
                DataTable dtinfoKH = new DataTable();
                dtinfoKH =ConvertKhachHangDTOArrayToDataTable(ws.InfoKH(maPT));
                for (int i = 0; i < dtinfoKH.Rows.Count;i++ )
                {
                    int j = listViewCTPhong.Items.Count;
                    listViewCTPhong.Items.Add(dtinfoKH.Rows[i][0].ToString());
                    listViewCTPhong.Items[j].SubItems.Add(dtinfoKH.Rows[i][1].ToString());
                    listViewCTPhong.Items[j].SubItems.Add(dtinfoKH.Rows[i][2].ToString());
                    listViewCTPhong.Items[j].SubItems.Add(dtinfoKH.Rows[i][3].ToString());
                    listViewCTPhong.Items[j].SubItems.Add(dtinfoKH.Rows[i][4].ToString());
                    
                }
                
                
            }
           
        }
        bool Kiemtrarong()
        {
            if (txt_MaHoaDon.Text.Trim() == "")
            {
                return true;
            }
            if (cmdNgayLap.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

       
        void infoHD()
        {
            dtoHD.MaHoaDon = txt_MaHoaDon.Text;
            dtoHD.NgayLap = DateTime.Parse(cmdNgayLap.Text);
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!Kiemtrarong())
            {
                infoHD();
               
                PhieuThueDTO dtoPT = new PhieuThueDTO();
                // kiem tra xem hoa don nay co ton tai chi tiet hoa don ko
                // new ko ton tai thi se ko cho lap hoa don
                bool kt_CTHD = false;
                for (int k = 0; k < listViewPhieuThue.Items.Count; k++)
                {
                    if (listViewPhieuThue.Items[k].Checked == true)
                    {
                        kt_CTHD = true;
                        break;
                    }
                }
                if (kt_CTHD == true)
                {
                    //lap hoa don
                    bool kt1 = ws.LapHoaDon(dtoHD);
                    //them vao bang CTHD
                    dtoCTHD.MaHoaDon = txt_MaHoaDon.Text.Trim();
                    for (int i = 0; i < listViewPhieuThue.Items.Count; i++)
                    {
                        if (listViewPhieuThue.Items[i].Checked == true)
                        {
                            dtoCTHD.MaPhieuThue = listViewPhieuThue.Items[i].SubItems[0].Text.ToString();
                            dtoCTHD.MaHoaDon = txt_MaHoaDon.Text.Trim();
                            bool kt = ws.InsertCTHOADON(dtoCTHD);

                        }
                        
                    }
                    // update lai ngay tra thuc te
                    if (kt_CTHD == true)
                    {
                        DateTime ngaytra_thucte = DateTime.Parse(cmd_ngaytra_thucte.Text.ToString());
                        if (checkNgayTra_ThucTe.Checked == true)
                        {
                            int kt_update_ngaytra_thucte = ws.Update_ngaytra_thucte(dtoHD.MaHoaDon, ngaytra_thucte);
                        }

                        if (kt1 == true)
                        {
                            MessageBox.Show("Lập hóa đơn " + dtoCTHD.MaHoaDon + " thành công!");

                            frmHoaDonThanhToan_Load(null, null);
                            listViewPhieuThue.Items.Clear();
                            listViewCTPhong.Items.Clear();
                            checkmatudong.Checked = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn phòng cần thanh toán!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInHD_Click(object sender, EventArgs e)
        {
            //MaHD = dtoHD.MaHoaDon;
            //DataTable dttmp = new DataTable();
            //dttmp=busHD.kiemtra_loaikhach(MaHD);
            //MessageBox.Show(MaHD+dttmp.Rows[0][0].ToString() + dttmp.Rows[0][1].ToString() + dttmp.Rows[0][2].ToString() + dttmp.Rows[0][3].ToString());
            //frmrptHoaDon frmHD = new frmrptHoaDon();
            //frmHD.ShowDialog();
        }
        void xoatrang()
        {
           
            txt_MaKH.Text = "";
            txt_DiaChi.Text = "";
            dt = null;
        }
        private string DinhDangNgay(string ngay)
        {
            string tmp = "";
            tmp = ngay.ToString();
            tmp = tmp.Substring(0, tmp.Length - 12);
            return tmp;
        }
        private void btxem_Click(object sender, EventArgs e)
        {
            DataTable dtPT=new DataTable();
            DataTable dtPhuThu = new DataTable();
            //dtPT=ws.Xem(txt_MaKH.Text);
            listViewPhieuThue.Items.Clear();
            if (dtPT.Rows.Count == 0)
            {
                MessageBox.Show("Khách hàng này đã thanh toán hóa đơn hoặc Mã khách hàng đại diện không đúng! ");
                return;
            }
            for(int i=0;i<dtPT.Rows.Count;i++)
            {
                int j=listViewPhieuThue.Items.Count;
                listViewPhieuThue.Items.Add(dtPT.Rows[i][0].ToString());
                listViewPhieuThue.Items[j].SubItems.Add(dtPT.Rows[i]["MaPhong"].ToString());
                listViewPhieuThue.Items[j].SubItems.Add(dtPT.Rows[i]["TenPhong"].ToString());
                listViewPhieuThue.Items[j].SubItems.Add(DinhDangNgay(dtPT.Rows[i]["NgayTra"].ToString()));
                
            }
            btAdd.Enabled = true;
          
        }

        private void checkmatudong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmatudong.Checked == true)
            {
                txt_MaHoaDon.Text = ws.NextIDHoaDon();
            }
            else
            {
                txt_MaHoaDon.Text = "";
            }
            
        }
 
        private void txtKHdaidien_TextChanged(object sender, EventArgs e)
        {
            DataTable dtKH = new DataTable();
            dtKH = ConvertKhachHangDTOArrayToDataTable(ws.GetInfoKH(txt_MaKH.Text.ToString()));
            if (dtKH.Rows.Count > 0)
            {
                txt_tenKH.Text = dtKH.Rows[0][0].ToString();
                txt_DiaChi.Text = dtKH.Rows[0][1].ToString();
            }
            else
            {
                txt_tenKH.Text = "";
                txt_DiaChi.Text = "";
            }
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            DataTable dtKH = new DataTable();
            dtKH = ConvertKhachHangDTOArrayToDataTable(ws.GetInfoKH(txt_MaKH.Text.ToString()));
            if (dtKH.Rows.Count > 0)
            {
                txt_tenKH.Text = dtKH.Rows[0][0].ToString();
                txt_DiaChi.Text = dtKH.Rows[0][1].ToString();
            }
            else
            {
                txt_tenKH.Text = "";
                txt_DiaChi.Text = "";
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void checkNgayTra_ThucTe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNgayTra_ThucTe.Checked == true)
            {
                cmd_ngaytra_thucte.Enabled = true;
            }
            else
            {
                cmd_ngaytra_thucte.Enabled = false;
            }
            
        }
    

     

      

       
      
    }
}