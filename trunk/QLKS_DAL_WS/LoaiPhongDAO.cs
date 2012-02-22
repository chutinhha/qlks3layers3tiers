using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using DAL.DTO;
namespace DAL
{
    public class LoaiPhongDAO:DataProvider
    {
        private string strSQL = "";
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            LoaiPhongDTO lpDTO = new LoaiPhongDTO();
            lpDTO.DonGia = int.Parse(dt.Rows[i]["DonGia"].ToString());
            lpDTO.MaLoaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();
            lpDTO.TenLoaiPhong = dt.Rows[i]["TenLoaiPhong"].ToString();
            return (object)lpDTO;
        }
        public LoaiPhongDTO[] getListLoaiPhong()
        {
            string strSQL = "SELECT * FROM LOAIPHONG";
            DataTable dt = ExecuteQuery(strSQL);
            LoaiPhongDTO[] lpDTOArr = new LoaiPhongDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object lpDTO = GetDataFromDataRow(dt, i);
                lpDTOArr[i] = (LoaiPhongDTO)lpDTO;

            }
            return lpDTOArr;
        }
        public int insertLoaiPhong(LoaiPhongDTO dtoLP)
        {
            string sql = "insert into LOAIPHONG(MaLoaiPhong,TenLoaiPhong,DonGia) values('" + dtoLP.MaLoaiPhong + "','" + dtoLP.TenLoaiPhong + "','" + dtoLP.DonGia + "')";
            return ExecuteNonQuery(sql,"isReturInt");
        }
        public int update(LoaiPhongDTO dtoLP)
        {
            string sql = "update LOAIPHONG set LOAIPHONG.TenLoaiPhong='" + dtoLP.TenLoaiPhong + "',LOAIPHONG.DonGia='" + dtoLP.DonGia + "' where LOAIPHONG.MaLoaiPhong='" + dtoLP.MaLoaiPhong + "'";
            return ExecuteNonQuery(sql,"isReturnInt");
        }
        public int delete(string maLP)
        {
            string sql = "delete from LOAIPHONG where LOAIPHONG.MaLoaiPhong='" + maLP + "'";
            return ExecuteNonQuery(sql,"isReturnInt");
        }
        public int KiemTra_MaLP(LoaiPhongDTO dtoLP)
        {
            string sql = "select * from LOAIPHONG where LOAIPHONG.MaLoaiPhong='" + dtoLP.MaLoaiPhong + "'";
            return ExecuteReader(sql,"isReturnInt");
        }
        public int KiemTra_So(string str)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str)?1:0;
        }

        public int KiemTra_Using(string maLP)
        {
            string sql = "select * from PHONG where PHONG.MaLoaiPhong='" + maLP + "'";
            return ExecuteReader(sql,"isReturnInt");
        }
        public int getDonGiaByLoaiPhong(string MaLoaiPhong)
        {
            strSQL = "Select DonGia from LoaiPhong Where MaLoaiPhong='" + MaLoaiPhong + "'";
            return ExcuteScalar(strSQL);
        }
        public int getDonGiaByMaPhong(string MaPhong)
        {
            string sql = "Select DonGia from PHONG,LoaiPhong Where MaPhong='" + MaPhong + "' and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong";
            return ExcuteScalar(sql);
        }
    }
}
