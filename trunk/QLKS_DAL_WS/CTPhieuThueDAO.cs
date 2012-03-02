using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class CTPhieuThueDAO:DataProvider
    {

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            CTPhieuThueDTO ctptDTO = new CTPhieuThueDTO();
            ctptDTO.MaCTPT = dt.Rows[i]["MaCTPT"].ToString();
            ctptDTO.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
            ctptDTO.MaPhieuThue = dt.Rows[i]["MaPhieuThue"].ToString();
            return (object)ctptDTO;
        }

        public CTPhieuThueDTO[] getList()
        {
            strSQL = "Select KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang,KHACHHANG.MaLoaiKH, KHACHHANG.CMND,KHACHHANG.DiaChi, CTPHIEUTHUE.MaCTPT, PHIEUTHUE.MaPhieuThue From CTPHIEUTHUE,KHACHHANG,LOAIKHACHHANG,PHIEUTHUE Where KHACHHANG.MaLoaiKH=LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaKhachHang=CTPHIEUTHUE.MaKhachHang and CTPHIEUTHUE.MaPhieuThue=PHIEUTHUE.MaPhieuThue";
            DataTable dt =  dp.ExecuteQuery(strSQL);
            CTPhieuThueDTO[] ctptDTOArr = new CTPhieuThueDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object ctptDTO = GetDataFromDataRow(dt, i);
                ctptDTOArr[i] = (CTPhieuThueDTO)ctptDTO;
            }
            return ctptDTOArr;
        }
        public string NextID()
        {
            return dp.NextID(dp.GetLastID("CTPHIEUTHUE", "MaCTPT"), "CTPT");
        }
        public CTPhieuThueDTO[] getListByMaPhieuThue(string MaPhieuThue)
        {
            strSQL = "Select KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang,KHACHHANG.MaLoaiKH, KHACHHANG.CMND,KHACHHANG.DiaChi, CTPHIEUTHUE.MaCTPT, PHIEUTHUE.MaPhieuThue From CTPHIEUTHUE,KHACHHANG,LOAIKHACHHANG,PHIEUTHUE Where KHACHHANG.MaLoaiKH=LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaKhachHang=CTPHIEUTHUE.MaKhachHang and CTPHIEUTHUE.MaPhieuThue=PHIEUTHUE.MaPhieuThue and CTPHIEUTHUE.MaPhieuThue='" + MaPhieuThue + "'";
            DataTable dt = dp.ExecuteQuery(strSQL);
            CTPhieuThueDTO[] ctptDTOArr = new CTPhieuThueDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object ctptDTO = GetDataFromDataRow(dt, i);
                ctptDTOArr[i] = (CTPhieuThueDTO)ctptDTO;
            }
            return ctptDTOArr;
        }
        // Viết dạng
        private string strSQL = "";
        private DataProvider dp = new DataProvider();
        public int testExistsMaPhieuThueInCTPhieuThue(string MaPhieuThue)
        {
            strSQL = "Select Count(MaPhieuThue) From CTPHIEUTHUE Where MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public int testExistsMaPhieuThueInPhieuThue(string MaPhieThue)
        {
            strSQL = "Select Count(MaPhieuThue) From PHIEUTHUE Where MaPhieuThue='" + MaPhieThue + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public int testExistMaCTPTInCTPHIEUTHUE(string MaCTPT)
        {
            strSQL = "Select Count(MaCTPT) From CTPHIEUTHUE Where MaCTPT='" + MaCTPT + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public int testExistsMaKhachHangInCTPHIEUTHUE(string MaKhachHang, string MaPhieuThue)// Thực ra mà mã phiếu thuê
        {
            strSQL = "Select Count(MaKhachHang) From CTPHIEUTHUE Where MaKhachHang='" + MaKhachHang + "' and MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public int Insert(CTPhieuThueDTO ctptDTO)
        {
            strSQL = "Insert Into CTPHIEUTHUE Values('" + ctptDTO.MaCTPT + "','" + ctptDTO.MaPhieuThue + "','" + ctptDTO.MaKhachHang + "')";
            return dp.ExecuteNonQuery(strSQL)?1:0;
        }
        public int Update(CTPhieuThueDTO ctptDTO)
        {
            strSQL = "Update CTPHIEUTHUE Set MaKhachHang='" + ctptDTO.MaKhachHang + "' Where MaCTPT='" + ctptDTO.MaCTPT + "'";
            return dp.ExecuteNonQuery(strSQL)?1:0;
        }
        public int Delete(string MaCTPT)
        {
            strSQL = "Delete From CTPHIEUTHUE Where MaCTPT='" + MaCTPT + "'";
            return dp.ExecuteNonQuery(strSQL) ? 1 : 0;
        }
        //public int testExistsMaCTPTInCTHOADON(string MaCTPT)
        //{
        //    strSQL = "Select Count(MaCTPT) From CTHOADON Where MaCTPT='" + MaCTPT + "'";
        //    return dp.ExcuteScalar(strSQL);
        //}
        //public int testExistMaPhieuThueIn
       
        public int CountMaKhachHang(string MaPhieuThue)
        {
            strSQL = "Select count(MaCTPT) From CTPHIEUTHUE Where CTPHIEUTHUE.MaPhieuThue='" + MaPhieuThue + "'";
            return dp.ExcuteScalar(strSQL);
        }
        public string getListMaCTPTByMaPhieuThue(string MaPhieuThue)
        {
            strSQL = "Select MaCTPT From CTPHIEUTHUE Where MaPhieuThue = '" + MaPhieuThue + "'";
            string listId = "";
            DataTable tmp = new DataTable();
            tmp = dp.ExecuteQuery(strSQL);
            for (int i = 0; i < tmp.Rows.Count; i++)
            {
                if (i == tmp.Rows.Count - 1)
                    listId += tmp.Rows[i]["MaCTPT"].ToString();
                else
                    listId += tmp.Rows[i]["MaCTPT"].ToString() + ",";

            }
            return listId;
        }
    }
}
