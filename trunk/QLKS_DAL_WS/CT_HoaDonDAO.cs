using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class CT_HoaDonDAO:DataProvider
    {
        private static DataProvider dp = new DataProvider();


        public bool Them(CT_HoaDonDTO dtoCTHD)
        {
            string sql = "insert into CTHOADON(MaHoaDon,MaPhieuThue) values('" + dtoCTHD.MaHoaDon + "','" + dtoCTHD.MaPhieuThue + "')";
            return dp.ExecuteNonQuery(sql);
        }


        public string getMaPT(string maphong)
        {
            string sql = "select MaPhieuThue from PHIEUTHUE where PHIEUTHUE.MaPhong='" + maphong + "'";
            DataTable dt =  dp.ExecuteQuery(sql);
            string listMaPhieuThue = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listMaPhieuThue += i == dt.Rows.Count-1?dt.Rows[i][0].ToString():dt.Rows[i][0].ToString() + ","; 
            }
            return listMaPhieuThue;
        }


        public bool delete_cthd(string mahd)
        {
            string sql = "delete from CTHOADON where MaHoaDon='" + mahd + "'";
            return dp.ExecuteNonQuery(sql);
        }


    }
}
