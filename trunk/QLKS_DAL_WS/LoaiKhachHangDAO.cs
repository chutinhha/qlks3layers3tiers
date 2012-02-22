using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class LoaiKhachHangDAO:DataProvider
    {
       
        KhachHangDTO lkDTO = new KhachHangDTO();
        string strSQL = "";
        public LoaiKhachHangDTO[] getListLoaiKhachHang()
        {
            strSQL = " Select * From LOAIKHACHHANG";
            DataTable dt =  ExecuteQuery(strSQL);
            LoaiKhachHangDTO[] lkhDTOArr = new LoaiKhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object lkhDTO = GetDataFromDataRow(dt, i);
                lkhDTOArr[i] = (LoaiKhachHangDTO)lkhDTO;
            }
            return lkhDTOArr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            LoaiKhachHangDTO lkhDTO = new LoaiKhachHangDTO();
            lkhDTO.HeSoKH = dt.Rows[i]["HeSoKH"].ToString();
            lkhDTO.MaLoaiKH = dt.Rows[i]["MaLoaiKH"].ToString();
            lkhDTO.TenLoaiKH = dt.Rows[i]["TenLoaiKH"].ToString();
            return (object)lkhDTO;
        }
    }
}
