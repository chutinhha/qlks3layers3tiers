using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class CT_HoaDonDTO
    {
        private string _MaHoaDon;

        public string MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        private string _MaPhieuThue;

        public string MaPhieuThue
        {
            get { return _MaPhieuThue; }
            set { _MaPhieuThue = value; }
        }
    }
}
