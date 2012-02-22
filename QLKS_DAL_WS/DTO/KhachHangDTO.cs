using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class KhachHangDTO
    {
        string _MaKhachHang;

        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }
        string _MaLoaiKH;

        public string MaLoaiKH
        {
            get { return _MaLoaiKH; }
            set { _MaLoaiKH = value; }
        }
        string _TenKhachHang;

        public string TenKhachHang
        {
            get { return _TenKhachHang; }
            set { _TenKhachHang = value; }
        }
        string _CMND;

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        string _KhachHangDaiDien;

        public string KhachHangDaiDien
        {
            get { return _KhachHangDaiDien; }
            set { _KhachHangDaiDien = value; }
        }
        string _TenKhachHang_EN;

        public string TenKhachHang_EN
        {
            get { return _TenKhachHang_EN; }
            set { _TenKhachHang_EN = value; }
        }
    }
}
