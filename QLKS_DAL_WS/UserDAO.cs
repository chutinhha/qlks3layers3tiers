using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class UserDAO
    {
        DataProvider dp = new DataProvider();
        public bool KiemTra_tendangnhap(string _tendangnhap)
        {
            string sql = "select * from USERS where Name='" + _tendangnhap + "'";
            return dp.ExecuteReader(sql);
        }
        public bool KiemTra_matkhau(string _tendangnhap, string _matkhau)
        {
            string sql = "select * from USERS where Name='" + _tendangnhap + "' and Password='" + _matkhau + "'";
            return dp.ExecuteReader(sql);
        }

        public bool backup(string path)
        {
            string strBackup = "BACKUP DATABASE QLKhachSan TO DISK ='" + path + "'";
            return dp.ExecuteNonQuery(strBackup);
        }
        public bool restore(string path)
        {
            string sqlRestore = "USE master RESTORE DATABASE QLKhachSan FROM DISK ='" + path + "'";
            return dp.ExecuteNonQuery(sqlRestore);
        }
        public string getIdKUserByIdUser(UserDTO uDTO)
        {
            string sql = "Select USERS.IdKUser From USERS Where Name ='" + uDTO.Name + "'";
            return dp.getStrByString(sql, "IdKUser");
        }
    }
}
