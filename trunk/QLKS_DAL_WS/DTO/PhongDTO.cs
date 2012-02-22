using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class PhongDTO
    {
        private string _MaPhong;
        private String _TenPhong;
        private string _MaLoaiPhong;
        private int _TinhTrang;
        private string _GhiChu;
        private int _DonGia;

        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        public String TenPhong
        {
            get { return _TenPhong; }
            set { _TenPhong = value; }
        }
        public string MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
    }
}
