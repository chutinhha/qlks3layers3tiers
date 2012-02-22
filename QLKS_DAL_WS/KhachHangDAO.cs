using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.DTO;
namespace DAL
{
    public class KhachHangDAO: DataProvider
    {
        //DataProvider dp = new DataProvider();
        public string strSQL = "";
        DataTable dt = new DataTable();
        KhachHangDTO kDTO = new KhachHangDTO();
        // Hàm làm thử theo kiểu add LIST
        public List<KhachHangDTO> getListKH()
        {
            List<KhachHangDTO> listKH = new List<KhachHangDTO>();
            DataTable dt = new DataTable();
            strSQL = "Select * From KHACHHANG";
            dt = ExecuteQuery(strSQL);
            foreach (DataRow irow in dt.Rows)
            {
                KhachHangDTO tmp = new KhachHangDTO();
                tmp.CMND = (string)irow["CMND"];
                tmp.DiaChi = (string)irow["DiaChi"];
                if (irow["KhachHangDaiDien"].Equals(""))
                    tmp.KhachHangDaiDien = (string)irow["KhachHangDaiDien"];
                else
                    tmp.KhachHangDaiDien = "";
                tmp.MaKhachHang = (string)irow["MaKhachHang"];
                tmp.MaLoaiKH = (string)irow["MaLoaiKH"];
                tmp.TenKhachHang = (string)irow["TenKhachHang"];
                listKH.Add(tmp);
            }
            return listKH;
        }
        // Lòng nhân ái thật sự : Người ta có thể cho đi những gì đã cũ - nhưng lòng nhân ái thật sự người ta cho đi những gì mình yêu thích nhất - HTV9- Những Điều kỳ Điệu :10:30 6-6-2011

        // Hàm lấy toàn bộ danh sách.
        /*
         * CÓ vài điều cần lưu ý.
         *  Thứ 1 : Chỉ viết cho đúng & đủ
         *  Thứ 2 : Chưa xử lý cho trường hợp sai, nên khi dt=NULL thì chương trình sẽ ERROR.
         */
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            KhachHangDTO kDTO = new KhachHangDTO();
            kDTO.CMND = dt.Rows[i]["CMND"].ToString();
            kDTO.DiaChi = dt.Rows[i]["DiaChi"].ToString();
            kDTO.KhachHangDaiDien = dt.Rows[i]["KhachHangDaiDien"].ToString();
            kDTO.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
            kDTO.MaLoaiKH = dt.Rows[i]["MaLoaiKH"].ToString();
            kDTO.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
            //kDTO.
            return (object)kDTO;
        }
        public KhachHangDTO[] getListKhachHang()
        {
            strSQL = "SELECT (SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang) as STT, KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH";
            //strSQL = "SELECT KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        // KHU VỰC - HA@M tìm kiếm
        public KhachHangDTO[] getKhachHangById(string Id)
        {
            strSQL = "SELECT(SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang) as STT, KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi, KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaKhachHang = '" + Id + "'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public KhachHangDTO[] getKhachHangByName(string Name)
        {
            // (SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang and KHACHHANG.TenKhachHang like '" + Name + "%') as STT,
            strSQL = "SELECT KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH and KHACHHANG.TenKhachHang_EN like '" + Name + "%'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public KhachHangDTO[] getKhachHangByCMND(string CMND)
        {
            strSQL = "SELECT(SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang and KHACHHANG.CMND = '" + CMND + "') as STT, KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG, LOAIKHACHHANG  Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH and  KHACHHANG.CMND = '" + CMND + "'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }

        public KhachHangDTO[] getKhachHangByKind(string Kind)
        {
            strSQL = "SELECT(SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang and KHACHHANG.MaLoaiKH = '" + Kind + "') as STT, KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaLoaiKH = '" + Kind + "'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public KhachHangDTO[] getKhachHangByAddress(string Address)
        {
            strSQL = "SELECT(SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang and KHACHHANG.DiaChi = '" + Address + "') as STT, KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaLoaiKH = '" + Address + "'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public KhachHangDTO[] getKhachHangByMulti(string Name, string Kind, string Address)
        {
            strSQL = "SELECT(SELECT COUNT(*) FROM KHACHHANG AS tmp WHERE tmp.MaKhachHang<=KHACHHANG.MaKhachHang and KHACHHANG.DiaChi = '" + Address + "' and KHACHHANG.Name ='" + Name + "' and KHACHHANG.MaLoaiKH = '" + Kind + "') as STT, KHACHHANG.MaKhachHang, KHACHHANG.TenKhachHang, KHACHHANG.MaLoaiKH,KHACHHANG.CMND,KHACHHANG.DiaChi,KHACHHANG.KhachHangDaiDien From KHACHHANG,LOAIKHACHHANG Where KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH and KHACHHANG.DiaChi = '" + Address + "' and KHACHHANG.Name ='" + Name + "' and KHACHHANG.MaLoaiKH = '" + Kind + "'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public string NextID()
        {
            return NextID(GetLastID("KHACHHANG", "MaKhachHang"), "KH");
        }
        public int Insert(KhachHangDTO kDTO)
        {
            if (kDTO.KhachHangDaiDien.Equals(""))
                strSQL = " Insert Into KHACHHANG(MaKhachHang,TenKhachHang,CMND,DiaChi,MaLoaiKH,TenKhachHang_EN) Values('" + kDTO.MaKhachHang + "',N'" + kDTO.TenKhachHang + "','" + kDTO.CMND + "',N'" + kDTO.DiaChi + "','" + kDTO.MaLoaiKH + "','" + kDTO.TenKhachHang_EN + "')";
            else
                strSQL = " Insert Into KHACHHANG(MaKhachHang,TenKhachHang,CMND,DiaChi,MaLoaiKH,KhachHangDaiDien,TenKhachHang_EN) Values('" + kDTO.MaKhachHang + "',N'" + kDTO.TenKhachHang + "','" + kDTO.CMND + "',N'" + kDTO.DiaChi + "','" + kDTO.MaLoaiKH + "','" + kDTO.KhachHangDaiDien + "','" + kDTO.TenKhachHang_EN + "')";
            return ExecuteNonQuery(strSQL,"isReturnInt");
        }

        public int testExistsMaKhachHangInKHACHHANG(string MaKhachHang)
        {
            strSQL = "Select Count(MaKhachHang) From KHACHHANG Where MaKhachHang='" + MaKhachHang + "'";
            int nRecord = ExcuteScalar(strSQL);
            return nRecord;
        }
        public int testExistsMaKhachHangInCTPHIEUTHUE(string MaKhachHang)
        {
            strSQL = "Select Count(MaKhachHang) From CTPHIEUTHUE Where MaKhachHang='" + MaKhachHang + "'";
            int nRecord = ExcuteScalar(strSQL);
            return nRecord;
        }
        // Delete
        public int Delete(string MaKhachHang)
        {
            strSQL = "Delete From KHACHHANG Where KHACHHANG.MaKhachHang = '" + MaKhachHang + "'";
            return ExecuteNonQuery(strSQL,"isReturnInt");
        }
        public int Update(KhachHangDTO kDTO)
        {
            /* Nếu khách hàng cần sửa có KHDD ! NULL thì lệnh 1 ==> cập nhật lại KHDD cho khách hàng cần sửa.
             * Ngược lại là thì xóa KH và thêm lại KH với MaKHDD là NULL.
             * Còn 1 trường hợp khách hàng sửa có KHDD là NULL
             */
            // Trường hợp sửa mã khách hàng đại diện cho khách hàng ko phải là KHDD ==> Ô textbox KHDD<>NULL
            if (!kDTO.KhachHangDaiDien.Equals(""))
                strSQL = "Update KHACHHANG Set TenKhachHang=N'" + kDTO.TenKhachHang + "',CMND='" + kDTO.CMND + "',DiaChi=N'" + kDTO.DiaChi + "',MaLoaiKH='" + kDTO.MaLoaiKH + "',KhachHangDaiDien='" + kDTO.KhachHangDaiDien + "',TenKhachHang_EN='" + kDTO.TenKhachHang_EN + "' Where MaKhachHang='" + kDTO.MaKhachHang + "'";
            else
            {
                // Trường hợp này khách hàng cần sửa này là 1 khách hàng đại diện có thể chưa chính thức(có tham chiếu) hoặc chính thức --> Nhưng chỉ thực hiện sửa các thông tin đơn thuần
                if (KhachHangDaiDienisNULL(kDTO.MaKhachHang)==0)
                    strSQL = "Update KHACHHANG Set TenKhachHang=N'" + kDTO.TenKhachHang + "',CMND='" + kDTO.CMND + "',DiaChi=N'" + kDTO.DiaChi + "',MaLoaiKH='" + kDTO.MaLoaiKH + "',TenKhachHang_EN='" + kDTO.TenKhachHang_EN + "' Where MaKhachHang='" + kDTO.MaKhachHang + "'";
                else
                {
                    // Ngược lại của trường hợp trên, tức là khách hàng này không là KHDD nhưng sửa lại là KHDD
                    // Vì nếu sửa lại là KHDD thì không thể nào set KHDD="" được, phải Del cái cũ đi, Insert cái mới vào với trường KhachHangDaiDien = NULL bằng cách không liệt kê trong danh sách trường chèn Vì cách này duy nhất gấn NULL cho 1 khóa ngoại.
                    strSQL = "Delete From KHACHHANG Where MaKhachHang='" + kDTO.MaKhachHang + "'";
                    ExecuteNonQuery(strSQL);
                    strSQL = " Insert Into KHACHHANG(MaKhachHang,TenKhachHang,CMND,DiaChi,MaLoaiKH,TenKhachHang_EN) Values('" + kDTO.MaKhachHang + "',N'" + kDTO.TenKhachHang + "','" + kDTO.CMND + "',N'" + kDTO.DiaChi + "','" + kDTO.MaLoaiKH + "','" + kDTO.TenKhachHang_EN + "')";
                }
            }
            return ExecuteNonQuery(strSQL,"isReturnInt");
        }
        public KhachHangDTO[] getListKhachHangDaiDien()
        {
            strSQL = "Select * From KHACHHANG Where KhachHangDaiDien is NULL";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public KhachHangDTO[] getListKhachHangDaiDienById(string Id)
        {
            strSQL = "Select * From KHACHHANG Where KhachHangDaiDien='" + Id + "'";
            DataTable dt = ExecuteQuery(strSQL);
            KhachHangDTO[] kDTOArr = new KhachHangDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object kDTO = GetDataFromDataRow(dt, i);
                kDTOArr[i] = (KhachHangDTO)kDTO;

            }
            return kDTOArr;
        }
        public int KhachHangDaiDienisNULL(string MaKhachHang)
        {
            strSQL = "Select KhachHangDaiDien From KHACHHANG Where MaKhachHang = '" + MaKhachHang + "' and KhachHangDaiDien is NULL";
            return getStrByString(strSQL, "KhachHangDaiDien").Equals("")?1:0;
        }
        public string getKhachHangDaiDienNotNULL(string MaKhachHang)
        {
            strSQL = "Select * From KHACHHANG Where MaKhachHang='" + MaKhachHang + "'";
            return getKhachHangById(getStrByString(strSQL, "KhachHangDaiDien")).ElementAt(0).KhachHangDaiDien.ToString();//.Rows[0]["TenKhachHang"].ToString();
        }
        public string getKhachHangDaiDienisNULL(string MaKhachHang)
        {
            strSQL = "Select * From KHACHHANG Where MaKhachHang='" + MaKhachHang + "'";
            return getStrByString(strSQL, "TenKhachHang");
        }
        public int testMaKhachHangisKhachHangDaiDien(string MaKhachHang)// Tức là khách hàng có đại diện cho 1 khách hàng trở lên, còn chưa có thì xóa được.
        {
            strSQL = "Select Count(MaKhachHang) From KHACHHANG Where MaKhachHang in	(Select MaKhachHang From KHACHHANG Where KhachHangDaiDien='" + MaKhachHang + "')";
            int nRecord = ExcuteScalar(strSQL);
            if (nRecord == 0)
                return 0;
            return 1;
        }
    }
}
