using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
   public class HoaDonDTO
    {
        private string _MaHoaDon;

        public string MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        private string _TenKhachHang;

        public string TenKhachHang
        {
            get { return _TenKhachHang; }
            set { _TenKhachHang = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        private float _TriGia;

        public float TriGia
        {
            get { return _TriGia; }
            set { _TriGia = value; }
        }
        private string _ThanhToan;

        public string ThanhToan
        {
            get { return _ThanhToan; }
            set { _ThanhToan = value; }
        }

    }
}
