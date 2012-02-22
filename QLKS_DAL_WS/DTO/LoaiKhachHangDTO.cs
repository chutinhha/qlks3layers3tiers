using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class LoaiKhachHangDTO
    {
        string _MaLoaiKH;

        public string MaLoaiKH
        {
            get { return _MaLoaiKH; }
            set { _MaLoaiKH = value; }
        }
        string _TenLoaiKH;

        public string TenLoaiKH
        {
            get { return _TenLoaiKH; }
            set { _TenLoaiKH = value; }
        }
        string _HeSoKH;

        public string HeSoKH
        {
            get { return _HeSoKH; }
            set { _HeSoKH = value; }
        }
    }
}
