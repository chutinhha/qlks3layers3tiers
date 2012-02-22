using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class PhongDAO : DataProvider
    {
        private string strSQL = "";
        //private DataProvider dp = new DataProvider();
        public int InsertPhong(PhongDTO pDTO)
        {
            string str = "Phòng";
            pDTO.TenPhong = str + pDTO.MaPhong;
            strSQL = "INSERT INTO PHONG(MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrang)";
            strSQL += " VALUES ('" + pDTO.MaPhong + "',N'" + pDTO.TenPhong + "','" + pDTO.MaLoaiPhong + "','" + pDTO.GhiChu + "','" + "0')";
            return ExecuteNonQuery(strSQL,"isReturnInt");
            //return true;
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            PhongDTO pDTO = new PhongDTO();

            pDTO.GhiChu = dt.Rows[i]["GhiChu"].ToString();
            pDTO.MaLoaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();
            pDTO.MaPhong = dt.Rows[i]["MaPhong"].ToString();
            
            pDTO.TinhTrang = int.Parse(dt.Rows[i]["TinhTrang"].ToString());
            pDTO.DonGia = int.Parse(dt.Rows[i]["DonGia"].ToString());
            return (object)pDTO;
        }
        public PhongDTO[] getListPhong()
        {
            strSQL = "SELECT (SELECT COUNT(*) FROM PHONG AS tmp WHERE tmp.MaPhong<=PHONG.MaPhong) AS STT,PHONG.MaPhong, PHONG.MaLoaiPhong,LOAIPHONG.DonGia, GhiChu, TinhTrang FROM PHONG, LOAIPHONG Where PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong";
            DataTable dt =  ExecuteQuery(strSQL);
            PhongDTO[] pDTOArr = new PhongDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object pDTO = GetDataFromDataRow(dt, i);
                pDTOArr[i] = (PhongDTO)pDTO;
            }
            return pDTOArr;
        }
        public PhongDTO[] searchPhongById(string id)
        {
            strSQL = "Select (SELECT COUNT(*) FROM PHONG AS tmp WHERE tmp.MaPhong<=PHONG.MaPhong) AS STT,MaPhong, PHONG.MaLoaiPhong, LOAIPHONG.DonGia, GhiChu, TinhTrang from PHONG,LOAIPHONG Where PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong and MaPhong='" + id + "'";
            DataTable dt = ExecuteQuery(strSQL);
            PhongDTO[] pDTOArr = new PhongDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object pDTO = GetDataFromDataRow(dt, i);
                pDTOArr[i] = (PhongDTO)pDTO;
            }
            return pDTOArr;
        }
        public PhongDTO[] searchPhongByKind(string kind)
        {
            strSQL = "Select (SELECT COUNT(*) FROM PHONG as tmp Where tmp.MaLoaiPhong='" + kind + "' and tmp.MaPhong<=PHONG.MaPhong) AS STT, MaPhong, PHONG.MaLoaiPhong,LOAIPHONG.DonGia, GhiChu,TinhTrang,from PHONG,LOAIPHONG Where PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong and PHONG.MaLoaiPhong='" + kind + "'";
            DataTable dt = ExecuteQuery(strSQL);
            PhongDTO[] pDTOArr = new PhongDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object pDTO = GetDataFromDataRow(dt, i);
                pDTOArr[i] = (PhongDTO)pDTO;
            }
            return pDTOArr;
        }
        public PhongDTO[] searchPhongByStatus(int status)
        {
            strSQL = "Select (SELECT COUNT(*) FROM PHONG AS tmp WHERE tmp.TinhTrang='" + status + "' and tmp.MaPhong<=PHONG.MaPhong) AS STT, MaPhong, PHONG.MaLoaiPhong, LOAIPHONG.DonGia, GhiChu, TinhTrang from PHONG,LOAIPHONG Where PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong and TinhTrang='" + status + "'";
            DataTable dt = ExecuteQuery(strSQL);
            PhongDTO[] pDTOArr = new PhongDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object pDTO = GetDataFromDataRow(dt, i);
                pDTOArr[i] = (PhongDTO)pDTO;
            }
            return pDTOArr;
        }
        public PhongDTO[] searchPhongByTuaLuaHotDua(string kind, int status)
        {
            strSQL = " Select (SELECT COUNT(*) FROM PHONG AS tmp WHERE tmp.MaPhong<=PHONG.MaPhong) AS STT, MaPhong, PHONG.MaLoaiPhong, LOAIPHONG.DonGia, GhiChu, TinhTrang from PHONG,LOAIPHONG Where PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong and TinhTrang='" + status + "' and PHONG.MaLoaiPhong='" + kind + "'";
            DataTable dt = ExecuteQuery(strSQL);
            PhongDTO[] pDTOArr = new PhongDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object pDTO = GetDataFromDataRow(dt, i);
                pDTOArr[i] = (PhongDTO)pDTO;
            }
            return pDTOArr;
        }
        public int testExist(string MaPhong)
        {
            strSQL = "Select count(MaPhong) From Phong Where PHONG.MaPhong='" + MaPhong + "'";
            int isExist = ExcuteScalar(strSQL);
            return isExist;

        }

        // Delete 

        public int Delete(string MaPhong)
        {
            strSQL = " Delete from PHONG Where MaPhong='" + MaPhong + "'";
            return ExecuteNonQuery(strSQL,"isReturnInt");
        }
        public int Update(PhongDTO pDTO)
        {
            strSQL = "Update PHONG Set MaLoaiPhong='" + pDTO.MaLoaiPhong + "',TenPhong=N'" + pDTO.TenPhong + "',TinhTrang='0',GhiChu=N'" + pDTO.GhiChu + "' Where MaPhong='" + pDTO.MaPhong + "'";
            return ExecuteNonQuery(strSQL, "isReturnInt");
        }
        public int Update(string MaPhong, string TinhTrang)
        {
            strSQL = "Update PHONG set TinhTrang='" + TinhTrang + "'Where MaPhong='" + MaPhong + "'";
            return ExecuteNonQuery(strSQL, "isReturnInt");
        }

        public int testExistMaPhongInPhieuThue(string MaPhong)
        {
            // Select Phong.MaPhong from Phong Where MaPhong='A103' and  Exists ( Select MaPhong from PhieuThue)
            //Select count(MaPhong) from PhieuThue Where MaPhong='A103'
            // Nếu tồn tại = 1 ;
            string strSQL = "Select count(MaPhong) from PhieuThue Where MaPhong='" + MaPhong + "'";
            return ExcuteScalar(strSQL);
        }

    }
}
