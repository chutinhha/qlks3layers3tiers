using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class ThamSoDAO:DataProvider
    {
        string strSQL;
        DataProvider dp = new DataProvider();
        public float getValue(int MaThamSo)
        {
            strSQL = "Select GiaTri From THAMSO Where MaThamSo='" + MaThamSo + "'";
            return dp.ExcuteScalar(strSQL);
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            ThamSoDTO tsDTO = new ThamSoDTO();
            //tsDTO.MaThamSo = int.Parse(dt.Rows[i]["MaThamSo"].ToString());
            tsDTO.TenThamSo = dt.Rows[i]["TenThamSo"].ToString();
            tsDTO.GiaTri = float.Parse(dt.Rows[i]["GiaTri"].ToString());
            //tsDTO.GhiChu = dt.Rows[i]["GhiChu"].ToString();
            return (object)tsDTO;
        }
        public ThamSoDTO[] getListThamSo()
        {
            strSQL = "Select TenThamSo ,GiaTri From THAMSO ";
            DataTable dt =  dp.ExecuteQuery(strSQL);
            ThamSoDTO[] tsDTOArr = new ThamSoDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object tsDTO = GetDataFromDataRow(dt, i);
                tsDTOArr[i] = (ThamSoDTO)tsDTO;                
            }
            return tsDTOArr;
        }
        public int Update(string mathamso, float giatri)
        {
            string sql = "update THAMSO set THAMSO.GiaTri='" + giatri + "' where THAMSO.MaThamSo='" + mathamso + "'";
            return dp.ExecuteNonQuery(sql)?1:0;
        }
        public float getheso()
        {
            string sql = "select GiaTri from THAMSO where MaThamSo='" + 2 + "'";
            return (float)dp.ExcuteScalar(sql);
        }
        public float getphuthu()
        {
            string sql = "select GiaTri from THAMSO where MaThamSo='" + 3 + "'";
            return (float)dp.ExcuteScalar(sql);
        }
        public float getkhachtoida()
        {
            string sql = "select GiaTri from THAMSO where MaThamSo='" + 1 + "'";
            return (float)dp.ExcuteScalar(sql);
        }
    }
}
