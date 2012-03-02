using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using QLKS_BUS_WS.QLKS_DAL_WebService;
namespace QLKS_BUS_WS
{
    /// <summary>
    /// Summary description for QLKS_BUS_Webservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLKS_BUS_Webservice : System.Web.Services.WebService
    {
        
        public QLKS_DAL_WebserviceSoapClient ws = new QLKS_DAL_WebserviceSoapClient();
        [WebMethod]
        public KhachHangDTO[] getListKhachHang()
        {
            return ws.getListKhachHang();
            
        }
        // KHU VỰC - HA@M tìm kiếm
        [WebMethod]
        public KhachHangDTO[] getKhachHangById(string Id)
        {
            return ws.getKhachHangById(Id);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByName(string Name)
        {
            return ws.getKhachHangByName(Name);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByCMND(string CMND)
        {
            return ws.getKhachHangByCMND(CMND);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByKind(string Kind)
        {
            return ws.getKhachHangByKind(Kind);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByAddress(string Address)
        {
            return ws.getKhachHangByAddress(Address);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByMulti(string Name, string Kind, string Address)
        {
            return ws.getKhachHangByMulti(Name, Kind, Address);
        }
        [WebMethod]
        public string NextIDKhachHang()
        {
            return ws.NextIDKhachHang();
        }
        [WebMethod]
        public int InsertKhachHang(KhachHangDTO kDTO)
        {
            return ws.InsertKhachHang(kDTO);
        }
        [WebMethod]
        public int testExistsMaKhachHangInKHACHHANG(string MaKhachHang)
        {
            return ws.testExistsMaKhachHangInKHACHHANG(MaKhachHang);
        }
        [WebMethod]
        public int testExistsMaKhachHangInCTPHIEUTHUE(string MaKhachHang)
        {
            return ws.testExistsMaKhachHangInCTPHIEUTHUE(MaKhachHang);
        }
        // Delete
        [WebMethod]
        public int DeleteKhachHang(string MaKhachHang)
        {
            return ws.DeleteKhachHang(MaKhachHang);
        }
        [WebMethod]
        public int UpdateKhachHang(KhachHangDTO kDTO)
        {
            return ws.UpdateKhachHang(kDTO);
        }
        [WebMethod]
        public KhachHangDTO[] getListKhachHangDaiDien()
        {
            return ws.getListKhachHangDaiDien();
        }
        [WebMethod]
        public KhachHangDTO[] getListKhachHangDaiDienById(string Id)
        {
            return ws.getListKhachHangDaiDienById(Id);
        }
        [WebMethod]
        public int KhachHangDaiDienisNULL(string MaKhachHang)
        {
            return ws.KhachHangDaiDienisNULL(MaKhachHang);
        }
        [WebMethod]
        public string getKhachHangDaiDienNotNULL(string MaKhachHang)
        {
            return ws.getKhachHangDaiDienNotNULL(MaKhachHang);
        }
        [WebMethod]
        public string getKhachHangDaiDienisNULL(string MaKhachHang)
        {
            return ws.getKhachHangDaiDienisNULL(MaKhachHang);

        }
        [WebMethod]
        public int testMaKhachHangisKhachHangDaiDien(string MaKhachHang)// Tức là khách hàng có đại diện cho 1 khách hàng trở lên, còn chưa có thì xóa được.
        {
            return ws.testMaKhachHangisKhachHangDaiDien(MaKhachHang);
        }

        [WebMethod]
        public KhachHangDTO[] InfoKH(string maPT)
        {
            return ws.InfoKH(maPT);
        }
        [WebMethod]
        public KhachHangDTO[] GetInfoKH(string maKH)
        {
            return ws.GetInfoKH(maKH);
        }
        [WebMethod]
        public KhachHangDTO[] TenKHDaiDien(string MaHD)
        {
            return ws.TenKHDaiDien(MaHD);
        }
        // ======================== XONG KHACH HANG ================================
        [WebMethod]
        public LoaiKhachHangDTO[] getListLoaiKhachHang()
        {

            return ws.getListLoaiKhachHang();
        }
        // ======================== XONG LOAI KHACH HANG ================================
        [WebMethod]
        public int InsertPhong(PhongDTO pDTO)
        {
            return ws.InsertPhong(pDTO);
        }
        [WebMethod]
        public PhongDTO[] getListPhong()
        {
            return ws.getListPhong();
        }
        [WebMethod]
        public PhongDTO[] searchPhongById(string id)
        {
            return ws.searchPhongById(id);
        }
        [WebMethod]
        public PhongDTO[] searchPhongByKind(string kind)
        {
            return ws.searchPhongByKind(kind);
        }
        [WebMethod]
        public PhongDTO[] searchPhongByStatus(int status)
        {
            return ws.searchPhongByStatus(status);
        }
        [WebMethod]
        public PhongDTO[] searchPhongByTuaLuaHotDua(string kind, int status)
        {
            return ws.searchPhongByTuaLuaHotDua(kind, status);
        }

        [WebMethod]
        public int testExistMaPhong(string MaPhong)
        {
            return ws.testExistMaPhong(MaPhong);

        }
        [WebMethod]
        public int DeletePhong(string MaPhong)
        {
            return ws.DeletePhong(MaPhong);
        }
        [WebMethod]
        public int UpdatePhongInfo(PhongDTO pDTO)
        {
            return ws.UpdatePhongInfo(pDTO);
        }
        [WebMethod]
        public int UpdatePhongStatus(string MaPhong, string TinhTrang)
        {
            return ws.UpdatePhongStatus(MaPhong, TinhTrang);
        }
        // ======================== XONG PHONG  ================================
        [WebMethod]
        public LoaiPhongDTO[] getListLoaiPhong()
        {
            return ws.getListLoaiPhong();
        }
        [WebMethod]
        public int insertLoaiPhong(LoaiPhongDTO dtoLP)
        {
            return ws.insertLoaiPhong(dtoLP);
        }
        [WebMethod]
        public int update(LoaiPhongDTO dtoLP)
        {
            return ws.UpdateLoaiPhong(dtoLP);
        }
        [WebMethod]
        public int delete(string maLP)
        {
            return ws.DeleteLoaiPhong(maLP);
        }
        [WebMethod]
        public int KiemTra_MaLP(LoaiPhongDTO dtoLP)
        {
            return ws.KiemTra_MaLP(dtoLP);
        }
        [WebMethod]
        public int KiemTra_So(string str)
        {
            return ws.KiemTra_So(str);
        }
        [WebMethod]
        public int KiemTra_Using(string maLP)
        {
            return ws.KiemTra_Using(maLP);
        }
        [WebMethod]
        public int getDonGiaByLoaiPhong(string MaLoaiPhong)
        {
            return ws.getDonGiaByLoaiPhong(MaLoaiPhong);
        }
        [WebMethod]
        public int getDonGiaByMaPhong(string MaPhong)
        {
            return ws.getDonGiaByMaPhong(MaPhong);
        }
        [WebMethod]
        public int testExistMaPhongInPhieuThue(string MaPhong)
        {
            return ws.testExistMaPhongInPhieuThue(MaPhong);
        }

        // ======================== THAM SO  ================================
        [WebMethod]
        public float getValue(int MaThamSo)
        {
            return ws.getValue(MaThamSo);
        }
        [WebMethod]
        public ThamSoDTO[] getListThamSo()
        {
            return ws.getListThamSo();
        }
        [WebMethod]
        public int UpdateThamSo(string mathamso, float giatri)
        {
            return ws.UpdateThamSo(mathamso, giatri);
        }
        [WebMethod]
        public float getheso()
        {
            return ws.getheso();
        }
        [WebMethod]
        public float getphuthu()
        {
            return ws.getphuthu();
        }
        [WebMethod]
        public float getkhachtoida()
        {
            return ws.getkhachtoida();
        }



        // ======================== PHIEUTHUE  ================================
        [WebMethod] 
        public PhieuThueDTO[] getListPhieuThue()
        {
            return ws.getListPhieuThue();
        }
        [WebMethod]
        public int testExistsMaPhongInPhieuThue(string MaPhong)
        {
            return ws.testExistMaPhongInPhieuThue(MaPhong);
        }
        [WebMethod]
        public string getMaLoaiPhongByMaPhong(string MaPhong)
        {
            return ws.getMaLoaiPhongByMaPhong(MaPhong);
        }
        [WebMethod]
        public int testExistsPhieuThueInPhong(string MaPhong)
        {
            return ws.testExistsInPhong(MaPhong);
        }
        [WebMethod]
        public int DeletePhieuThue(string MaPhieuThue)
        {
            return ws.DeletePhieuThue(MaPhieuThue);
        }
        [WebMethod]
        public int UpdatePhieuThue(PhieuThueDTO ptDTO)
        {
            return ws.UpdatePhieuThue(ptDTO);
        }
        [WebMethod]
        public int Update_ngaytra_thucte(string MaHD, DateTime ngaytra_thucte)
        {
            
            return ws.Update_ngaytra_thucte(MaHD, ngaytra_thucte);
        }
        [WebMethod]
        public string NextIDPhieuThue()
        {
            return ws.NextIDPhieuThue();
        }
        [WebMethod]
        public int testExistMaPhieuThueInCTHOADON(string MaPhieuThue)
        {
            return ws.testExistMaPhieuThueInCTHOADON(MaPhieuThue);
        }
        [WebMethod]
        public int InsertPhieuThue(PhieuThueDTO ptDTO)
        {
            return ws.InsertPhieuThue(ptDTO);
        }
        [WebMethod]
        public string getTinhTrangByMaPhong(string MaPhong)
        {
            return ws.getTinhTrangByMaPhong(MaPhong);
        }
        [WebMethod]
        public string getstrSQL()
        {
            return ws.getstrSQL();
        }
        [WebMethod]
        public int testExistsMaPhieuThueInPHIEUTHUE(string MaPT)
        {
            return ws.testExistsMaPhieuThueInPHIEUTHUE(MaPT);
        }
        [WebMethod]
        public int getTinhTrangPhieuThue(string MaPT)
        {
            return ws.getTinhTrangPhieuThue(MaPT);
        }
        // Mới cập nhật cừ HOADON
        [WebMethod]
        public PhieuThueDTO[] IN(string maHD)
        {
            return ws.IN(maHD);
        }

        // CT PHIEU THUE

        [WebMethod]
        public CTPhieuThueDTO[] getListCTPhieuThue()
        {
            return ws.getListCTPhieuThue();
        }
        [WebMethod]
        public string NextIDCTPhieuThue()
        {
            return ws.NextIDPhieuThue();
        }
        [WebMethod]
        public CTPhieuThueDTO[] getListByMaPhieuThue(string MaPhieuThue)
        {
            return ws.getListByMaPhieuThue(MaPhieuThue);
        }
        [WebMethod]
        public int testExistsMaPhieuThueInCTPhieuThue(string MaPhieuThue)
        {
            return ws.testExistsMaPhieuThueInCTPhieuThue(MaPhieuThue);
        }
        [WebMethod]
        public int testExistsMaPhieuThueInPhieuThue(string MaPhieThue)
        {
            return ws.testExistsMaPhieuThueInPHIEUTHUE(MaPhieThue);
        }
        [WebMethod]
        public int testExistMaCTPTInCTPHIEUTHUE(string MaCTPT)
        {
            return ws.testExistMaCTPTInCTPHIEUTHUE(MaCTPT);
        }
        //========> ĐÃ LÀM BÊN KHACHANG ==> NÊN BỊ BÁO LỖI TRÙNG METHOD. --> BỎ ĐI
        
        [WebMethod]
        public int testExistsMaKhachHangInCTPHIEUTHUE2(string MaKhachHang, string MaPhieuThue)// Thực ra mà mã phiếu thuê
        {
            return ws.testExistsMaKhachHangInCTPHIEUTHUE2(MaKhachHang, MaPhieuThue);
        }
        [WebMethod]
        public int InsertCTPhieuThue(CTPhieuThueDTO ctptDTO)
        {
            return ws.InsertCTPhieuThue(ctptDTO);
        }
        [WebMethod]
        public int UpdateCTPhieuThue(CTPhieuThueDTO ctptDTO)
        {
            return ws.UpdateCTPhieuThue(ctptDTO);
        }
        [WebMethod]
        public int DeleteCTPhieuThue(string MaCTPT)
        {
            return ws.DeleteCTPhieuThue(MaCTPT);
        }
        [WebMethod]
        public int CountMaKhachHang(string MaPhieuThue)
        {
            return ws.CountMaKhachHang(MaPhieuThue);
        }
        [WebMethod]
        public string getListMaCTPTByMaPhieuThue(string MaPhieuThue)
        {
            return ws.getListMaCTPTByMaPhieuThue(MaPhieuThue);
        }

        // ======================== HOA DON  ================================
        // - Một số hàm chuyển sang KhachHang và PhieuThue
        // - Một số hàm thì chưa hiểu lắm

        [WebMethod]
        public HoaDonDTO[] getlistHoaDon()
        {
            return ws.getlistHoaDon();
        }
        // ===> Chưa hiểu lắm

        //public DataTable Phong_KH(string _maphong)
        //{
        //    string thanhtoan = "0";
        //    string sql = "select PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,CTPHIEUTHUE.MaKhachHang,TenKhachHang,KHACHHANG.MaLoaiKH,CMND from CTPHIEUTHUE,PHIEUTHUE,KHACHHANG,LOAIKHACHHANG WHERE KHACHHANG.MaLoaiKH=LOAIKHACHHANG.MaLoaiKH and KHACHHANG.MaKhachHang=CTPHIEUTHUE.MaKhachHang and CTPHIEUTHUE.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.ThanhToan='" + thanhtoan + "' and PHIEUTHUE.MaPhong='" + _maphong + "'";
        //    return dp.ExecuteQuery(sql);
        //}
        [WebMethod]
        public bool Thanhtoan_HD(string mahoadon, double tongtien)
        {
            return ws.Thanhtoan_HD(mahoadon, tongtien);
        }
        [WebMethod]
        public bool Thanhtoan_Phieuthue(string maHD, string maphong, PhieuThueDTO dtoPT)
        {
            return ws.Thanhtoan_Phieuthue(maHD, maphong, dtoPT);
        }

        // UpdatePhongStatus
        [WebMethod]
        public bool Thanhtoan_Phong(string maphong)
        {
            return ws.Thanhtoan_Phong(maphong);
        }
        [WebMethod]
        public bool LapHoaDon(HoaDonDTO dtoHD)
        {
            return ws.LapHoaDon(dtoHD);
        }
        //// Là làm cái gì
        //public DataTable Xem(string KHdaidien)
        //{
        //    string sql = "Select PHIEUTHUE.MaPhieuThue,PHIEUTHUE.MaPhong,PHONG.TenPhong,PHIEUTHUE.NgayTra from PHIEUTHUE,PHONG Where  PHIEUTHUE.MaPhong = PHONG.MaPhong and PHIEUTHUE.KhachHangDaiDien='" + KHdaidien + "' and PHIEUTHUE.ThanhToan='0'";
        //    return dp.ExecuteQuery(sql);
        //}
        //// Là làm cái gì
        //public DataTable CT_HoaDon(string MaHD)
        //{
        //    string sql = "select PHIEUTHUE.MaPhieuThue,PHIEUTHUE.MaPhong,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra,LOAIPHONG.DonGia,DATEDIFF(dd,PHIEUTHUE.NgayThue,PHIEUTHUE.NgayTra)as SoNgayThue from HOADON,CTHOADON,PHIEUTHUE,PHONG,LOAIPHONG WHERE HOADON.MaHoaDon=CTHOADON.MaHoaDon and CTHOADON.MaPhieuThue=PHIEUTHUE.MaPhieuThue and PHIEUTHUE.MaPhong=PHONG.MaPhong and PHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong and HOADON.MaHoaDon='" + MaHD + "'";
        //    return dp.ExecuteQuery(sql);
        //}
        [WebMethod]
        public bool kiemtra_loaikhach(string maphieuthue, string MaLoaiKH)
        {
            return ws.kiemtra_loaikhach(maphieuthue, MaLoaiKH);
        }
        [WebMethod]
        public int dem_KH_Phong(string maphieuthue)
        {
            return ws.dem_KH_Phong(maphieuthue);
        }
        [WebMethod]
        public bool delete_hd(string mahd)
        {
            return ws.delete_hd(mahd);
        }
        [WebMethod]
        public string NextIDHoaDon()
        {
            return ws.NextIDHoaDon();
        }

        // ======================= CT_HOADON
        [WebMethod]
        public bool InsertCTHOADON(CT_HoaDonDTO dtoCTHD)
        {
            return ws.InsertCTHOADON(dtoCTHD);
        }

        [WebMethod]
        public string getMaPT(string maphong)
        {
            return ws.getMaPT(maphong);
        }

        [WebMethod]
        public bool delete_cthd(string mahd)
        {
            return ws.delete_cthd(mahd);
        }

        // ================== USER-DTO =====
        [WebMethod]
        public bool KiemTra_tendangnhap(string _tendangnhap)
        {
            return ws.KiemTra_tendangnhap(_tendangnhap);
        }
        [WebMethod]
        public bool KiemTra_matkhau(string _tendangnhap, string _matkhau)
        {
            return ws.KiemTra_matkhau(_tendangnhap, _matkhau);
        }
        [WebMethod]
        public bool backup(string path)
        {
            return ws.backup(path);
        }

        [WebMethod]
        public bool restore(string path)
        {
            return ws.restore(path);
        }

        [WebMethod]
        public string getIdKUserByIdUser(UserDTO uDTO)
        {
            return ws.getIdKUserByIdUser(uDTO);
        }
    }
}
