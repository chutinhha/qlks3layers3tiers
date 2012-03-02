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
        public System.Data.DataTable ConvertLoaiPhongDTOToDataTable(LoaiPhongDTO[] lpDTOArr)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            int row = lpDTOArr.Length;
            dt.Columns.Add("MaLoaiPhong", typeof(string));
            dt.Columns.Add("TenLoaiPhong", typeof(string));
            dt.Columns.Add("DonGia", typeof(int));
            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(lpDTOArr[i].MaLoaiPhong, lpDTOArr[i].TenLoaiPhong, lpDTOArr[i].DonGia);
            }
            return dt;
        }
    }
    
}
