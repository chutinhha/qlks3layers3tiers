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
    public partial class frmDSHoaDon : DevComponents.DotNetBar.Office2007Form
    {
        DataTable dtHD = new DataTable();
        //HoaDonBUS busHD = new HoaDonBUS();
        //CT_HoaDonBUS bus_cthd = new CT_HoaDonBUS();
        //ThamSoBUS busTS = new ThamSoBUS();
        public static DataTable dt_in = new DataTable();
        QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
        //kiem tra lisviewHD da duoc clickv index hay chua
        public static string mahd;
        public static string tenKHDD="";
        public static string Diachi="";
        public static double tongtien = 0;

        private DataTable ConvertHoaDonDTOArrayToDataTable(HoaDonDTO[] hDTOArr)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHoaDon", typeof(string));
            dt.Columns.Add("NgayLap", typeof(DateTime));
            dt.Columns.Add("TriGia", typeof(float));
            dt.Columns.Add("ThanhToan", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows.Add(hDTOArr[i].DiaChi, hDTOArr[i].MaHoaDon, hDTOArr[i].NgayLap, hDTOArr[i].TriGia, hDTOArr[i].ThanhToan);
            }
            return dt;
        }

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
        public DataTable ConvertPhieuTHueDTOArrayToDataTable(PhieuThueDTO[] ptDTOArr)
        {
            DataTable dt = new DataTable();
            int row = ptDTOArr.Length;

            dt.Columns.Add("MaPhieuThue", typeof(string));
            dt.Columns.Add("NgayThue", typeof(DateTime));
            dt.Columns.Add("NgayTra", typeof(DateTime));
            dt.Columns.Add("HeSo", typeof(float));
            dt.Columns.Add("TienPhuThu", typeof(float));
            dt.Columns.Add("TienThue", typeof(float));
            dt.Columns.Add("MaPhong", typeof(string));
            dt.Columns.Add("ThanhToan", typeof(string));
            dt.Columns.Add("KhachHangDaiDien", typeof(string));

            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(ptDTOArr[i].MaPhieuThue, ptDTOArr[i].NgayThue, ptDTOArr[i].NgayTra, ptDTOArr[i].Heso, ptDTOArr[i].Tienphuthu, ptDTOArr[i].Tienthue, ptDTOArr[i].MaPhong, ptDTOArr[i].ThanhToan, ptDTOArr[i].KhachHangDaiDien);
            }
            return dt;
        }
        public DataTable ConvertCTPhieuTHueDTOArrayToDataTable(CTPhieuThueDTO[] ctptDTOArr)
        {
            DataTable dt = new DataTable();
            int row = ctptDTOArr.Length;
            dt.Columns.Add("MaCTPT", typeof(string));
            dt.Columns.Add("MaPhieuThue", typeof(string));
            dt.Columns.Add("MaKhachHang", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("MaLoaiKH", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("CMND", typeof(string));


            for (int i = 0; i < row; i++)
            {
                KhachHangDTO[] kDTO = new KhachHangDTO[1];
                kDTO = ws.getKhachHangById(ctptDTOArr[i].MaKhachHang);
                dt.Rows.Add(ctptDTOArr[i].MaCTPT, ctptDTOArr[i].MaPhieuThue, ctptDTOArr[i].MaKhachHang, kDTO[0].TenKhachHang, kDTO[0].MaLoaiKH, kDTO[0].DiaChi, kDTO[0].CMND);
            }
            return dt;
        }
        public frmDSHoaDon()
        {
            InitializeComponent();
        }
        private string DinhDangNgay(string ngay)
        {
            string tmp = "";
            tmp = ngay.ToString();
            tmp = tmp.Substring(0, tmp.Length - 12);
            return tmp;
        }
        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
        
            listViewHD.Items.Clear();
            tongtien = 0;
            dtHD = ConvertHoaDonDTOArrayToDataTable(ws.getlistHoaDon());
            for (int i = 0; i < dtHD.Rows.Count; i++)
            {
                int j = listViewHD.Items.Count;

                string MaHD=dtHD.Rows[i]["MaHoaDon"].ToString();
                DataTable dt_info_Khachhang= ConvertKhachHangDTOArrayToDataTable(ws.TenKHDaiDien(MaHD));
                string tenkhdd = "";
                string diachi = "";
                if (dt_info_Khachhang.Rows.Count > 0)
                {
                    tenkhdd = dt_info_Khachhang.Rows[0][0].ToString();
                    diachi = dt_info_Khachhang.Rows[0][1].ToString();
                }
                listViewHD.Items.Add(MaHD);
                listViewHD.Items[j].SubItems.Add(tenkhdd);
                listViewHD.Items[j].SubItems.Add(diachi);
                listViewHD.Items[j].SubItems.Add(DinhDangNgay(dtHD.Rows[i]["NgayLap"].ToString()));
                listViewHD.Items[j].SubItems.Add(dtHD.Rows[i]["TriGia"].ToString());
                listViewHD.Items[j].SubItems.Add(dtHD.Rows[i]["ThanhToan"].ToString());
                
            }
        }

        private void listViewHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            tongtien = 0;
            DataTable dtCTHD = new DataTable();
            DataTable dtPhuThu = new DataTable();
            if (listViewHD.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = listViewHD.SelectedItems[0];
                mahd = item.SubItems[0].Text.ToString();
                tenKHDD = item.SubItems[1].Text.ToString();
                Diachi = item.SubItems[2].Text.ToString(); 
                // dtCTHD = ws.CT_HoaDon(mahd);
                listViewCTHD.Items.Clear();
                for (int i = 0; i < dtCTHD.Rows.Count; i++)
                {

                    int j = listViewCTHD.Items.Count;
                    string _maPT = dtCTHD.Rows[i]["MaPhieuThue"].ToString();
                    // he so
                    float heso = 1;
                    bool ktloaiKH = ws.kiemtra_loaikhach(_maPT,"KHQT");
                    if(ktloaiKH==true)
                    {
                        heso=1.5F /1;
                    }
                    // so ngay thue
                    float songaythue = float.Parse(dtCTHD.Rows[i]["SoNgayThue"].ToString());
                    if (songaythue == 0)
                    {
                        songaythue = 1;
                    }
                    //don gia
                    float dongia = float.Parse(dtCTHD.Rows[i]["DonGia"].ToString());
                    float thanhtien = songaythue * dongia * heso;

                    // phu thu
                    float phuthu = 0;
                    int demKH = ws.dem_KH_Phong(_maPT);
                    if (demKH >= 3)
                    {
                        //dtPhuThu = ;
                        float pt = ws.getphuthu();
                        phuthu = thanhtien * pt;

                    }
                    // thanh tien
                    thanhtien = thanhtien + phuthu;
                    double PP = Convert.ToDouble(thanhtien);
                    // chen vao lisview
                    listViewCTHD.Items.Add(dtCTHD.Rows[i][1].ToString());
                    listViewCTHD.Items[j].SubItems.Add(DinhDangNgay(dtCTHD.Rows[i][2].ToString()));
                    listViewCTHD.Items[j].SubItems.Add(DinhDangNgay(dtCTHD.Rows[i][3].ToString()));
                    listViewCTHD.Items[j].SubItems.Add(songaythue.ToString());
                    listViewCTHD.Items[j].SubItems.Add(dtCTHD.Rows[i]["DonGia"].ToString());
                    listViewCTHD.Items[j].SubItems.Add(heso.ToString());
                    listViewCTHD.Items[j].SubItems.Add(phuthu.ToString());
                    listViewCTHD.Items[j].SubItems.Add(PP.ToString());
                    tongtien = tongtien + PP;

                }
            }
        }
        bool kiemtra_click_item()
        {
            for (int i = 0; i < listViewHD.Items.Count; i++) //duyệt tất cả các item trong list
            {

                if (listViewHD.Items[i].Selected==true)//nếu item đó dc check
                {
                    return true;
                }
            }
            return false;
        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            PhieuThueDTO dtoPT = new PhieuThueDTO();
            if (kiemtra_click_item())
            {
                ListViewItem item = listViewHD.SelectedItems[0];
                string thanhtoan = item.SubItems[4].Text.ToString();
                if (thanhtoan == "0")
                {
                    bool kt = ws.Thanhtoan_HD(mahd,tongtien);
                    for(int i=0;i<listViewCTHD.Items.Count;i++)
                    {
                        dtoPT.Songaythue = int.Parse(listViewCTHD.Items[i].SubItems[3].Text.ToString());
                        dtoPT.Heso =float.Parse(listViewCTHD.Items[i].SubItems[5].Text.ToString());
                        dtoPT.Tienphuthu =float.Parse(listViewCTHD.Items[i].SubItems[6].Text.ToString());
                        dtoPT.Tienthue =float.Parse(listViewCTHD.Items[i].SubItems[7].Text.ToString());
                        
                        string maphong = listViewCTHD.Items[i].SubItems[0].Text.ToString();
                        bool kt2 = ws.Thanhtoan_Phong(maphong);

                        bool kt1 = ws.Thanhtoan_Phieuthue(mahd,maphong,dtoPT);
                    }
                    
                    if (kt == true)
                    {
                        MessageBox.Show("Thanh toán hóa đơn " + mahd + " thành công!");
                        frmDSHoaDon_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Hóa đơn này đã được thanh toán");
                }
            }
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (mahd != "" && kiemtra_click_item()==true)
            {
                if (MessageBox.Show(this, "Bạn muốn xóa hóa đơn " + mahd + " này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    bool kt = ws.delete_cthd(mahd);
                    bool kt1 = ws.delete_hd(mahd);
                    if (kt == true && kt1 == true)
                    {
                        MessageBox.Show("Xóa hóa đơn " + mahd + " thành công");
                        frmDSHoaDon_Load(null, null);
                        mahd = "";
                        listViewCTHD.Items.Clear();
                    }
                }
            }
           
        }

      

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btrefesh_Click(object sender, EventArgs e)
        {
            frmDSHoaDon_Load(null, null);
        }

        private void btin_Click(object sender, EventArgs e)
        {
            if (kiemtra_click_item() == true)
            {
                //HoaDonBUS bushd1 = new HoaDonBUS();
                dt_in = ConvertPhieuTHueDTOArrayToDataTable(ws.IN(mahd));
                //frmrptHoaDon frm = new frmrptHoaDon();
                //=========> frm.ShowDialog();
            }
        
           

        }

        private void frmDSHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frm_Main.activeFrom[7] = 7;
        }
     
    }
}
