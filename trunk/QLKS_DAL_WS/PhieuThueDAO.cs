using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;

namespace DAL
{
    public class PhieuThueDAO:DataProvider
    {
        private string strSQL = "";
        private DataProvider dp = new DataProvider();
        PhieuThueDTO ptDTO = new PhieuThueDTO();

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            PhieuThueDTO ptDTO = new PhieuThueDTO();
            // if HeSo=NULL thi = 0 else dt[i]["HeSo"].toString();
            ptDTO.Heso = float.Parse(dt.Rows[i]["HeSo"].ToString().Equals("")?"0":dt.Rows[i]["HeSo"].ToString());
            ptDTO.KhachHangDaiDien = dt.Rows[i]["KhachHangDaiDien"].ToString();
            ptDTO.MaPhieuThue = dt.Rows[i]["MaPhieuThue"].ToString();
            ptDTO.MaPhong = dt.Rows[i]["MaPhong"].ToString();
            ptDTO.NgayThue = DateTime.Parse(dt.Rows[i]["NgayThue"].ToString());
            ptDTO.NgayTra = DateTime.Parse(dt.Rows[i]["NgayTra"].ToString());
            //ptDTO.NgayTra_ThucTe = DateTime.Parse(dt.Rows[i]["NgayTra_ThucTe"].ToString());
            //ptDTO.Songaythue = int.Parse(dt.Rows[i]["SoNgayThue"].ToString());
            ptDTO.ThanhToan = dt.Rows[i]["ThanhToan"].ToString();
            ptDTO.Tienphuthu = float.Parse(dt.Rows[i]["TienPhuThu"].ToString().Equals("") ? "0" : dt.Rows[i]["TienPhuThu"].ToString());
            ptDTO.Tienthue = float.Parse(dt.Rows[i]["TienThue"].ToString().Equals("") ? "0" : dt.Rows[i]["TienThue"].ToString());
            return (object)ptDTO;
        }
        public PhieuThueDTO[] getList()
        {
            strSQL = " Select * from PHIEUTHUE";
            DataTable dt =  dp.ExecuteQuery(strSQL);
            PhieuThueDTO[] ptDTOArr = new PhieuThueDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Object ptDTO = GetDataFromDataRow(dt, i);
                ptDTOArr[i] = (PhieuThueDTO)ptDTO;
            }
            return ptDTOArr;

        }
        public int testExistMaPhieuThueInCTHOADON(string MaPhieuThue)
        {
            strSQL = "Select Count(MaPhieuThue) From CTHOADON Where CTHOADON.MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public  int testExistMaPhongInPhieuThue(string MaPhong)
        {
            // Select Phong.MaPhong from Phong Where MaPhong='A103' and  Exists ( Select MaPhong from PhieuThue)
            //Select count(MaPhong) from PhieuThue Where MaPhong='A103'
            // Nếu tồn tại = 1 ;
            strSQL = "Select count(MaPhong) from PhieuThue Where MaPhong='" + MaPhong + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public  int testExistsMaPhongInPhong(string MaPhong)
        {
            strSQL = "Select count(MaPhong) From Phong Where Phong.MaPhong='" + MaPhong + "'";
            int isExist = dp.ExcuteScalar(strSQL);
            return isExist;
        }

        public  string getMaLoaiPhongByMaPhong(string MaPhong)
        {
            strSQL = " Select PHONG.MaLoaiPhong from LOAIPHONG,PHONG Where PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and MaPhong='" + MaPhong + "'";
            return dp.getStrByString(strSQL, "MaLoaiPhong");
        }
        public int Insert(PhieuThueDTO ptDTO)
        {
            strSQL = "Insert Into PHIEUTHUE (MaPhieuThue,NgayThue,NgayTra,MaPhong,ThanhToan,KhachHangDaiDien) Values('" + ptDTO.MaPhieuThue + "','" + ptDTO.NgayThue + "','" + ptDTO.NgayTra + "','" + ptDTO.MaPhong + "','" + ptDTO.ThanhToan + "','" + ptDTO.KhachHangDaiDien + "')";
            return dp.ExecuteNonQuery(strSQL)?1:0;
        }
        public int Delete(string MaPhieuThue)
        {
            strSQL = " Delete from PHIEUTHUE Where MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExecuteNonQuery(strSQL)?1:0;
        }
        public int Update(PhieuThueDTO ptDTO)
        {
            strSQL = "Update PHIEUTHUE Set MaPhong='" + ptDTO.MaPhong + "',NgayThue='" + ptDTO.NgayThue + "',NgayTra='" + ptDTO.NgayTra + "',KhachHangDaiDien='" + ptDTO.KhachHangDaiDien + "' Where MaPhieuThue='" + ptDTO.MaPhieuThue + "'";
            //MessageBox.Show(BUS.PhieuThueBUS.getstrSQL());
            return dp.ExecuteNonQuery(strSQL)?1:0;
        }
        public int Update_ngaytra_thucte(string MaHD, DateTime ngaytra_thucte)
        {
            string sql = "update PHIEUTHUE set PHIEUTHUE.NgayTra='" + ngaytra_thucte + "'from HOADON,CTHOADON,PHIEUTHUE where HOADON.MaHoaDon=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and HOADON.MaHoaDon='" + MaHD + "'";
            return dp.ExecuteNonQuery(sql)?1:0;
        }
        public  string NextID()
        {
            return dp.NextID(dp.GetLastID("PHIEUTHUE", "MaPhieuThue"), "PT");
        }
        public  string getTinhTrangByMaPhong(string MaPhong)
        {
            strSQL = "Select * From PHONG Where MaPhong='" + MaPhong + "'";
            return dp.getStrByString(strSQL, "TinhTrang");
        }
        public  string getstrSQL()
        {
            return strSQL;
        }
        public  int testExistsMaPhieuThueInPHIEUTHUE(string MaPT)
        {
            strSQL = "Select Count(MaPhieuThue) From PHIEUTHUE Where MaPhieuThue ='" + MaPT + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public  int getTinhTrangPhieuThue(string MaPT)
        {
            strSQL = "Select ThanhToan From PHIEUTHUE Where MaPhieuThue='" + MaPT + "'";
            return Int32.Parse(dp.getStrByString(strSQL, "ThanhToan").ToString());
        }

        // Mới cập nhật từ HoaDon

        public PhieuThueDTO[] IN(string maHD)
        {
            string sql = "select PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra,PHIEUTHUE.HeSo,LOAIPHONG.DonGia,PHIEUTHUE.TienPhuThu,PHIEUTHUE.TienThue, PHIEUTHUE.MaPhieuThue,KhachHangDaiDien,PHIEUTHUE.ThanhToan from HOADON,CTHOADON,PHIEUTHUE,PHONG,LOAIPHONG WHERE HOADON.MaHoaDOn=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhong=PHONG.MaPhong and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and HOADON.MaHoaDon='" + maHD + "' and HOADON.ThanhToan='1' and PHIEUTHUE.ThanhToan='1'";
            DataTable dt = dp.ExecuteQuery(sql);
            PhieuThueDTO[] ptDTOArr = new PhieuThueDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Object ptDTO = GetDataFromDataRow(dt, i);
                ptDTOArr[i] = (PhieuThueDTO)ptDTO;
            }
            return ptDTOArr;
        }

    }
}
