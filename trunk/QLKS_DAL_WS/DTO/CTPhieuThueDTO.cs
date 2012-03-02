using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class CTPhieuThueDTO
    {
        string _MaCTPT;

        public string MaCTPT
        {
            get { return _MaCTPT; }
            set { _MaCTPT = value; }
        }
        string _MaKhachHang;

        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }
        string _MaPhieuThue;

        public string MaPhieuThue
        {
            get { return _MaPhieuThue; }
            set { _MaPhieuThue = value; }
        }
    }
}
