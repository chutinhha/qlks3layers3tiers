using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;

namespace DAL
{
    public class PhieuThueDAO
    {
        private static string strSQL = "";
        private static DataProvider dp = new DataProvider();
        PhieuThueDTO ptDTO = new PhieuThueDTO();


        public static DataTable getList()
        {
            strSQL = " Select * from PHIEUTHUE";
            return dp.ExecuteQuery(strSQL);
        }
        public static int testExistMaPhieuThueInCTHOADON(string MaPhieuThue)
        {
            strSQL = "Select Count(MaPhieuThue) From CTHOADON Where CTHOADON.MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public static int testExistMaPhongInPhieuThue(string MaPhong)
        {
            // Select Phong.MaPhong from Phong Where MaPhong='A103' and  Exists ( Select MaPhong from PhieuThue)
            //Select count(MaPhong) from PhieuThue Where MaPhong='A103'
            // Nếu tồn tại = 1 ;
            strSQL = "Select count(MaPhong) from PhieuThue Where MaPhong='" + MaPhong + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public static int testExistsMaPhongInPhong(string MaPhong)
        {
            strSQL = "Select count(MaPhong) From Phong Where Phong.MaPhong='" + MaPhong + "'";
            int isExist = dp.ExcuteScalar(strSQL);
            return isExist;
        }

        public static string getMaLoaiPhongByMaPhong(string MaPhong)
        {
            strSQL = " Select PHONG.MaLoaiPhong from LOAIPHONG,PHONG Where PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and MaPhong='" + MaPhong + "'";
            return dp.getStrByString(strSQL, "MaLoaiPhong");
        }
        public static bool Insert(PhieuThueDTO ptDTO)
        {
            strSQL = "Insert Into PHIEUTHUE (MaPhieuThue,NgayThue,NgayTra,MaPhong,ThanhToan,KhachHangDaiDien) Values('" + ptDTO.MaPhieuThue + "','" + ptDTO.NgayThue + "','" + ptDTO.NgayTra + "','" + ptDTO.MaPhong + "','" + ptDTO.ThanhToan + "','" + ptDTO.KhachHangDaiDien + "')";
            return dp.ExecuteNonQuery(strSQL);
        }
        public static bool Delete(string MaPhieuThue)
        {
            strSQL = " Delete from PHIEUTHUE Where MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExecuteNonQuery(strSQL);
        }
        public static bool Update(PhieuThueDTO ptDTO)
        {
            strSQL = "Update PHIEUTHUE Set MaPhong='" + ptDTO.MaPhong + "',NgayThue='" + ptDTO.NgayThue + "',NgayTra='" + ptDTO.NgayTra + "',KhachHangDaiDien='" + ptDTO.KhachHangDaiDien + "' Where MaPhieuThue='" + ptDTO.MaPhieuThue + "'";
            //MessageBox.Show(BUS.PhieuThueBUS.getstrSQL());
            return dp.ExecuteNonQuery(strSQL);
        }
        public bool Update_ngaytra_thucte(string MaHD, DateTime ngaytra_thucte)
        {
            string sql = "update PHIEUTHUE set PHIEUTHUE.NgayTra='" + ngaytra_thucte + "'from HOADON,CTHOADON,PHIEUTHUE where HOADON.MaHoaDon=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and HOADON.MaHoaDon='" + MaHD + "'";
            return dp.ExecuteNonQuery(sql);
        }
        public static string NextID()
        {
            return dp.NextID(dp.GetLastID("PHIEUTHUE", "MaPhieuThue"), "PT");
        }
        public static string getTinhTrangByMaPhong(string MaPhong)
        {
            strSQL = "Select * From PHONG Where MaPhong='" + MaPhong + "'";
            return dp.getStrByString(strSQL, "TinhTrang");
        }
        public static string getstrSQL()
        {
            return strSQL;
        }
        public static int testExistsMaPhieuThueInPHIEUTHUE(string MaPT)
        {
            strSQL = "Select Count(MaPhieuThue) From PHIEUTHUE Where MaPhieuThue ='" + MaPT + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public static int getTinhTrangPhieuThue(string MaPT)
        {
            strSQL = "Select ThanhToan From PHIEUTHUE Where MaPhieuThue='" + MaPT + "'";
            return Int32.Parse(dp.getStrByString(strSQL, "ThanhToan").ToString());
        }
    }
}
