using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class LoaiPhongDTO
    {
        private string _MaLoaiPhong;
        private string _TenLoaiPhong;
        private Int32 _DonGia;

        public string MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }

        public string TenLoaiPhong
        {
            get { return _TenLoaiPhong; }
            set { _TenLoaiPhong = value; }
        }

        public Int32 DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
    }
}
