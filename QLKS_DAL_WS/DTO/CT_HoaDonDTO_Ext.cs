using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS_DAL_WS.DTO
{
    public class CT_HoaDonDTO_Ext
    {

        //string sql = "select PHIEUTHUE.MaPhieuThue,PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra,LOAIPHONG.DonGia,DATEDIFF(dd,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra)as SoNgayThue from HOADON,CTHOADON,PHIEUTHUE,PHONG,LOAIPHONG WHERE HOADON.MaHoaDon=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhong=PHONG.MaPhong and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and HOADON.MaHoaDon='" + MaHD + "'";

        DateTime _NgayThue, _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }

        public DateTime NgayThue
        {
            get { return _NgayThue; }
            set { _NgayThue = value; }
        }
        string _MaPhong;

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
       
        string _MaPhieuThue;

        public string MaPhieuThue
        {
            get { return _MaPhieuThue; }
            set { _MaPhieuThue = value; }
        }
        private int _songaythue;

        
        public int Songaythue
        {
            get { return _songaythue; }
            set { _songaythue = value; }
        }
    }
}