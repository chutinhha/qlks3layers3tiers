using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class HoaDonDAO:DataProvider
    {
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            HoaDonDTO hDTO = new HoaDonDTO();
            //hDTO.DiaChi = dt.Rows[i]["DiaChi"].ToString();
            hDTO.MaHoaDon = dt.Rows[i]["MaHoaDon"].ToString();
            hDTO.NgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
            hDTO.TriGia = float.Parse(dt.Rows[i]["TriGia"].ToString().Equals("")?"0":dt.Rows[i]["TriGia"].ToString());
            hDTO.ThanhToan = dt.Rows[i]["ThanhToan"].ToString();
            return (object)hDTO;
        }
        //private object GetDataFromDataRow2(DataTable dt, int i)
        //{
        //     hDTO = new HoaDonDTO();
           
        //    hDTO.MaHoaDon = dt.Rows[i]["MaHoaDon"].ToString();
        //    hDTO.NgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
        //    hDTO.TriGia = float.Parse(dt.Rows[i]["TriGia"].ToString().Equals("") ? "0" : dt.Rows[i]["TriGia"].ToString());
        //    hDTO.ThanhToan = dt.Rows[i]["ThanhToan"].ToString();

        //}
        public HoaDonDTO[] getlistHoaDon()
        {
            string sql = "select HOADON.MaHoaDon,HOADON.NgayLap,HOADON.TriGia,HOADON.ThanhToan from HOADON";
            DataTable dt =  ExecuteQuery(sql);
            HoaDonDTO[] hDTOArr = new HoaDonDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object hDTO = GetDataFromDataRow(dt, i);
                hDTOArr[i] = (HoaDonDTO)hDTO;
            }
            return hDTOArr;
        }
        public DataTable Phong_KH(string _maphong)
        {
            string thanhtoan = "0";
            string sql = "select PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,CTPHIEUTHUE.MaKhachHang,TenKhachHang,KHACHHANG.MaLoaiKH,CMND from CTPHIEUTHUE,PHIEUTHUE,KHACHHANG,LOAIKHACHHANG WHERE KHACHHANG.MaLoaiKH=LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaKhachHang=CTPHIEUTHUE.MaKhachHang and CTPHIEUTHUE.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.ThanhToan='" + thanhtoan + "' and PHIEUTHUE.MaPhong='" + _maphong + "'";
            return ExecuteQuery(sql);
        }
        public bool Thanhtoan_HD(string mahoadon, double tongtien)
        {
            //string thu = "update HOADON,PHONG,PHIEUTHUE SET HOADON.ThanhToan='" + 1 + "',PHIEUTHUE.ThanhToan='" + 1 + "',PHONG.TinhTrang='" + 0 + "' where PHIEUTHUE.MaPhong=(select PHIEUTHUE.MaPhong from PHIEUTHUE,CTHOADON where HOADON.MaHoaDon=CTHOADON.MAHoaDon and CT_HOANDON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHONG.MAPhong=PHIEUTHUE.MaPhong";
            string thanhtoan = "0";
            string d = "update HOADON set HOADON.ThanhToan='" + 1 + "',HOADON.TriGia='" + tongtien + "' where HOADON.MaHoaDon='" + mahoadon + "' and HOADON.ThanhToan='" + thanhtoan + "'";
            //string sql = "update HOADON,CTHOADON,PHIEUTHUE,PHONG set HOADON.ThanhToan='" + 1 + "',PHONG.TinhTrang='"+ 0 +"',PHIEUTHUE.ThanhToan='"+ 1 +"' where HOADON.MaHoaDon='" + mahoadon + "' and HOADON.MaHoaDon=CTHOADON.MAHoaDon and CT_HOANDON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHONG.MAPhong=PHIEUTHUE.MaPhong";
            return ExecuteNonQuery(d);
        }
        public bool Thanhtoan_Phieuthue(string maHD, string maphong, PhieuThueDTO dtoPT)
        {
            string sql = "update PHIEUTHUE set PHIEUTHUE.ThanhToan='1',PHIEUTHUE.HeSo='" + dtoPT.Heso + "',PHIEUTHUE.TienPhuThu='" + dtoPT.Tienphuthu + "', PHIEUTHUE.TienThue='" + dtoPT.Tienthue + "' from HOADON,CTHOADON where HOADON.MaHoaDon=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and HOADON.MaHoaDon='" + maHD + "'and PHIEUTHUE.MaPhong='" + maphong + "' and PHIEUTHUE.ThanhToan='0'";
            return ExecuteNonQuery(sql);
        }

        // UpdatePhongStatus
        public bool Thanhtoan_Phong(string maphong)
        {
            string sql = "update PHONG set PHONG.TinhTrang=0 where PHONG.MaPhong='" + maphong + "'";
            return ExecuteNonQuery(sql);
        }

        public bool LapHoaDon(HoaDonDTO dtoHD)
        {
            dtoHD.ThanhToan = "0";
            string sql = "insert into HOADON(MaHoaDon,NgayLap,TriGia,ThanhToan) values('" + dtoHD.MaHoaDon + "','" + dtoHD.NgayLap + "','" + dtoHD.TriGia + "','" + dtoHD.ThanhToan + "')";
            return ExecuteNonQuery(sql);
        }
        // Là làm cái gì
        public DataTable Xem(string KHdaidien)
        {
            //,PHONG.TenPhong
            string sql = "Select PHIEUTHUE.MaPhieuThue,PHIEUTHUE.MaPhong,PHIEUTHUE.NgayTra from PHIEUTHUE,PHONG Where  PHIEUTHUE.MaPhong = PHONG.MaPhong and PHIEUTHUE.KhachHangDaiDien='" + KHdaidien + "' and PHIEUTHUE.ThanhToan='0'";
            return ExecuteQuery(sql);
        }
        // Là làm cái gì
        public DataTable CT_HoaDon(string MaHD)
        {
            string sql = "select PHIEUTHUE.MaPhieuThue,PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra,LOAIPHONG.DonGia,DATEDIFF(dd,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra)as SoNgayThue from HOADON,CTHOADON,PHIEUTHUE,PHONG,LOAIPHONG WHERE HOADON.MaHoaDon=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhong=PHONG.MaPhong and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and HOADON.MaHoaDon='" + MaHD + "'";
            return ExecuteQuery(sql);
        }

        public bool kiemtra_loaikhach(string maphieuthue, string MaLoaiKH)
        {
            string sql = "select * from CTPHIEUTHUE,PHIEUTHUE,KHACHHANG,LOAIKHACHHANG where PHIEUTHUE.MaPhieuThue=CTPHIEUTHUE.MaPhieuThue and CTPHIEUTHUE.MaKhachHang=KHACHHANG.MaKhachHang and KHACHHANG.MaLoaiKH=LOAIKHACHHANG.MaLoaiKH and PHIEUTHUE.MaPhieuThue='" + maphieuthue + "' and KHACHHANG.MaLoaiKH='" + MaLoaiKH + "'";
            return ExecuteReader(sql);
        }

        public int dem_KH_Phong(string maphieuthue)
        {
            string sql = "select count(CTPHIEUTHUE.MaKhachHang) from PHIEUTHUE,CTPHIEUTHUE where PHIEUTHUE.MaPhieuThue=CTPHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhieuThue='" + maphieuthue + "'";
            return ExcuteScalar(sql);
        }

        public bool delete_hd(string mahd)
        {
            string sql = "delete from HOADON where MaHoaDon='" + mahd + "'";
            return ExecuteNonQuery(sql);
        }

        // Copy cái này sang lớp KHACHHANG
        public DataTable InfoKH(string maPT)
        {
            string sql = "select CTPHIEUTHUE.MaKhachHang,KHACHHANG.TenKhachHang,KHACHHANG.DiaChi,KHACHHANG.MaLoaiKH,LOAIKHACHHANG.TenLoaiKH from LOAIKHACHHANG,KHACHHANG,CTPHIEUTHUE,PHIEUTHUE where KHACHHANG.MaLoaiKH=LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaKhachHang=CTPHIEUTHUE.MaKhachHang and CTPHIEUTHUE.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhieuThue='" + maPT + "'";
            return ExecuteQuery(sql);
        }

        public DataTable GetInfoKH(string maKH)
        {
            string sql = "select distinct KHACHHANG.TenKhachHang,KHACHHANG.DiaChi from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKhachHang=PHIEUTHUE.KhachHangDaiDien and PHIEUTHUE.KhachHangDaiDien='" + maKH + "'";
            return ExecuteQuery(sql);
        }
        public DataTable TenKHDaiDien(string MaHD)
        {
            string sql = "select KHACHHANG.TenKhachHang,KHACHHANG.DiaChi from KHACHHANG,PHIEUTHUE,CTHOADON,HOADON where KHACHHANG.MaKhachHang=PHIEUTHUE.KhachHangDaiDien and PHIEUTHUE.MaPhieuThue=CTHOADON.MaPhieuThue and HOADON.MaHoaDOn=CTHOADON.MaHoaDon and HOADON.MaHoaDOn='" + MaHD + "'";
            return ExecuteQuery(sql);
        }
        // == > end

        public string NextID()
        {
            return NextID(GetLastID("HOADON", "MaHoaDon"), "HD");
        }

        // Copy sang phieuthue
        public DataTable IN(string maHD)
        {
            string sql = "select PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra,PHIEUTHUE.HeSo,LOAIPHONG.DonGia,PHIEUTHUE.TienPhuThu,PHIEUTHUE.TienThue from HOADON,CTHOADON,PHIEUTHUE,PHONG,LOAIPHONG WHERE HOADON.MaHoaDOn=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhong=PHONG.MaPhong and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and HOADON.MaHoaDon='" + maHD + "' and HOADON.ThanhToan='1' and PHIEUTHUE.ThanhToan='1'";
            return ExecuteQuery(sql);
        }
        //== > end

        //public DataTable IN(string maHD)
        //{
        //    string sql = "select PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra_ThucTe,PHIEUTHUE.SoNgayThue,LOAIPHONg.DonGia,PHIEUTHUE.HeSo,PHIEUTHUE.TienPhuThu,PHIEUTHUE.TienThue from PHIEUTHUE,PHONG,LOAIPHONG,CTHOADON,HOADON where";
        //}
        //public DataTable DoanhThu_LoaiPhong(int thang, int nam, string maloaiphong)
        //{
        //    string sql = "select LOAIPHONG.DonGia,DATEDIFF(dd,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra)as SoNgayThue from HOADON,CTHOADON,PHIEUTHUE,PHONG,LOAIPHONG where HOADON.MaHoaDOn=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhong=PHONG.MaPhong and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and day(HOADON.NgayLap)='"+ thang +"' and year(HOADON.NgayLap)='"+ nam +"' and PHONG.MaLoaiPhong='"+ maloaiphong +"'";
        //}
    }
}
