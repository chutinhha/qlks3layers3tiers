using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAL;
using DAL.DTO;
namespace QLKS_DAL_WS
{
    /// <summary>
    /// Summary description for QLKS_DAL_Webservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLKS_DAL_Webservice : System.Web.Services.WebService
    {
        KhachHangDAO kDAO = new KhachHangDAO();
        LoaiKhachHangDAO lkDAO = new LoaiKhachHangDAO();
        PhongDAO pDAO = new PhongDAO();
        LoaiPhongDAO lpDAO = new LoaiPhongDAO();

        // ======================== KHACH HANG ================================
        [WebMethod]
        public KhachHangDTO[] getListKhachHang()
        {
            return kDAO.getListKhachHang();
        }
        // KHU VỰC - HA@M tìm kiếm
        [WebMethod]
        public KhachHangDTO[] getKhachHangById(string Id)
        {
            return kDAO.getKhachHangById(Id);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByName(string Name)
        {
            return kDAO.getKhachHangByName(Name);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByCMND(string CMND)
        {
            return kDAO.getKhachHangByCMND(CMND);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByKind(string Kind)
        {
            return kDAO.getKhachHangByKind(Kind);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByAddress(string Address)
        {
            return kDAO.getKhachHangByAddress(Address);
        }
        [WebMethod]
        public KhachHangDTO[] getKhachHangByMulti(string Name, string Kind, string Address)
        {
            return kDAO.getKhachHangByMulti(Name, Kind, Address);
        }
        [WebMethod]
        public string NextIDKhachHang()
        {
            return kDAO.NextID();
        }
        [WebMethod]
        public int InsertKhachHang(KhachHangDTO kDTO)
        {
            return kDAO.Insert(kDTO);
        }
        [WebMethod]
        public int testExistsMaKhachHangInKHACHHANG(string MaKhachHang)
        {
            return kDAO.testExistsMaKhachHangInKHACHHANG(MaKhachHang);
        }
        [WebMethod]
        public int testExistsMaKhachHangInCTPHIEUTHUE(string MaKhachHang)
        {
            return kDAO.testExistsMaKhachHangInCTPHIEUTHUE(MaKhachHang);
        }
        // Delete
        [WebMethod]
        public int DeleteKhachHang(string MaKhachHang)
        {
            return kDAO.Delete(MaKhachHang);
        }
        [WebMethod]
        public int UpdateKhachHang(KhachHangDTO kDTO)
        {
            return kDAO.Update(kDTO);
        }
        [WebMethod]
        public KhachHangDTO[] getListKhachHangDaiDien()
        {
            return kDAO.getListKhachHangDaiDien();
        }
        [WebMethod]
        public KhachHangDTO[] getListKhachHangDaiDienById(string Id)
        {
            return kDAO.getListKhachHangDaiDienById(Id);
        }
        [WebMethod]
        public int KhachHangDaiDienisNULL(string MaKhachHang)
        {
            return kDAO.KhachHangDaiDienisNULL(MaKhachHang);
        }
        [WebMethod]
        public string getKhachHangDaiDienNotNULL(string MaKhachHang)
        {
            return kDAO.getKhachHangDaiDienNotNULL(MaKhachHang);
        }
        [WebMethod]
        public string getKhachHangDaiDienisNULL(string MaKhachHang)
        {
            return kDAO.getKhachHangDaiDienisNULL(MaKhachHang);
            
        }
        [WebMethod]
        public int testMaKhachHangisKhachHangDaiDien(string MaKhachHang)// Tức là khách hàng có đại diện cho 1 khách hàng trở lên, còn chưa có thì xóa được.
        {
            return kDAO.testMaKhachHangisKhachHangDaiDien(MaKhachHang);
        }

        // Mới cập nhật từ HOADON
        [WebMethod]
        public KhachHangDTO[] InfoKH(string maPT)
        {
            return kDAO.InfoKH(maPT);
        }
         [WebMethod]
        public KhachHangDTO[] GetInfoKH(string maKH)
        {
            return kDAO.GetInfoKH(maKH);
        }
         [WebMethod]
        public KhachHangDTO[] TenKHDaiDien(string MaHD)
        {
            return kDAO.TenKHDaiDien(MaHD);
        }


        // ======================== XONG KHACH HANG ================================

        // ======================== LOAI KHACH HANG ================================
        [WebMethod]
        public LoaiKhachHangDTO[] getListLoaiKhachHang()
        {

            return lkDAO.getListLoaiKhachHang();
        }
        // ======================== XONG LOAI KHACH HANG ================================

        // ======================== PHONG  ================================
        [WebMethod]
        public int InsertPhong(PhongDTO pDTO)
        {
            return pDAO.InsertPhong(pDTO);
        }
        [WebMethod]
        public PhongDTO[] getListPhong()
        {
            return pDAO.getListPhong();
        }
        [WebMethod]
        public PhongDTO[] searchPhongById(string id)
        {
            return pDAO.searchPhongById(id);
        }
        [WebMethod]
        public PhongDTO[] searchPhongByKind(string kind)
        {
            return pDAO.searchPhongByKind(kind);
        }
        [WebMethod]
        public PhongDTO[] searchPhongByStatus(int status)
        {
            return pDAO.searchPhongByStatus(status);
        }
        [WebMethod]
        public PhongDTO[] searchPhongByTuaLuaHotDua(string kind, int status)
        {
            return pDAO.searchPhongByTuaLuaHotDua(kind, status);
        }

        [WebMethod]
        public int testExistMaPhong(string MaPhong)
        {
            return pDAO.testExist(MaPhong);

        }
        [WebMethod]
        public int DeletePhong(string MaPhong)
        {
            return pDAO.Delete(MaPhong);
        }
        [WebMethod]
        public int UpdatePhongInfo(PhongDTO pDTO)
        {
            return pDAO.Update(pDTO);
        }
        [WebMethod]
        public int UpdatePhongStatus(string MaPhong, string TinhTrang)
        {
            return pDAO.Update(MaPhong, TinhTrang);
        }
        // ======================== XONG PHONG  ================================

        // ======================== LOAI PHONG  ================================
        [WebMethod]
        public LoaiPhongDTO[] getListLoaiPhong()
        {
            return lpDAO.getListLoaiPhong();
        }
        [WebMethod]
        public int insertLoaiPhong(LoaiPhongDTO dtoLP)
        {
            return lpDAO.insertLoaiPhong(dtoLP);
        }
        [WebMethod]
        public int UpdateLoaiPhong(LoaiPhongDTO dtoLP)
        {
            return lpDAO.update(dtoLP);
        }
        [WebMethod]
        public int DeleteLoaiPhong(string maLP)
        {
            return lpDAO.delete(maLP);
        }
        [WebMethod]
        public int KiemTra_MaLP(LoaiPhongDTO dtoLP)
        {
            return lpDAO.KiemTra_MaLP(dtoLP);
        }
        [WebMethod]
        public int KiemTra_So(string str)
        {
            return lpDAO.KiemTra_So(str);
        }
        [WebMethod]
        public int KiemTra_Using(string maLP)
        {
            return lpDAO.KiemTra_Using(maLP);
        }
        [WebMethod]
        public int getDonGiaByLoaiPhong(string MaLoaiPhong)
        {
            return lpDAO.getDonGiaByLoaiPhong(MaLoaiPhong);
        }
        [WebMethod]
        public int getDonGiaByMaPhong(string MaPhong)
        {
            return lpDAO.getDonGiaByMaPhong(MaPhong);
        }
        [WebMethod]
        public int testExistMaPhongInPhieuThue(string MaPhong)
        {
            return pDAO.testExistMaPhongInPhieuThue(MaPhong);
        }
        // ======================== XONG LOAI PHONG  ================================

        // ======================== PHIEU THUE  ================================
        [WebMethod]
        public PhieuThueDTO[] getListPhieuThue()
        {
            return new PhieuThueDAO().getList();
        }
         [WebMethod]
        public int testExistsMaPhongInPhieuThue(string MaPhong)
        {
            return new PhieuThueDAO().testExistMaPhongInPhieuThue(MaPhong);
        }
        [WebMethod]
        public string getMaLoaiPhongByMaPhong(string MaPhong)
        {
            return new PhieuThueDAO().getMaLoaiPhongByMaPhong(MaPhong);
        }
        [WebMethod]
        public int testExistsInPhong(string MaPhong)
        {
            return new PhieuThueDAO().testExistsMaPhongInPhong(MaPhong);
        }
        [WebMethod]
        public int DeletePhieuThue(string MaPhieuThue)
        {
            return new PhieuThueDAO().Delete(MaPhieuThue);
        }
        [WebMethod]
        public int UpdatePhieuThue(PhieuThueDTO ptDTO)
        {
            return new PhieuThueDAO().Update(ptDTO);
        }
        [WebMethod]
        public int Update_ngaytra_thucte(string MaHD, DateTime ngaytra_thucte)
        {
            PhieuThueDAO daoPT = new PhieuThueDAO();
            return daoPT.Update_ngaytra_thucte(MaHD, ngaytra_thucte);
        }
        [WebMethod]
        public string NextIDPhieuThue()
        {
            return new PhieuThueDAO().NextID();
        }
        [WebMethod]
        public int testExistMaPhieuThueInCTHOADON(string MaPhieuThue)
        {
            return new PhieuThueDAO().testExistMaPhieuThueInCTHOADON(MaPhieuThue);
        }
        [WebMethod]
        public int InsertPhieuThue(PhieuThueDTO ptDTO)
        {
            return new PhieuThueDAO().Insert(ptDTO);
        }
        [WebMethod]
        public string getTinhTrangByMaPhong(string MaPhong)
        {
            return new PhieuThueDAO().getTinhTrangByMaPhong(MaPhong);
        }
        [WebMethod]
        public string getstrSQL()
        {
            return new PhieuThueDAO().getstrSQL();
        }
        [WebMethod]
        public int testExistsMaPhieuThueInPHIEUTHUE(string MaPT)
        {
            return new PhieuThueDAO().testExistsMaPhieuThueInPHIEUTHUE(MaPT);
        }
        [WebMethod]
        public int getTinhTrangPhieuThue(string MaPT)
        {
            return new PhieuThueDAO().getTinhTrangPhieuThue(MaPT);
        }
        // Mới cập nhật cừ HOADON
        [WebMethod]
        public PhieuThueDTO[] IN(string maHD)
        {
            return new PhieuThueDAO().IN(maHD);
        }


        // ======================== THAM SO  ================================
        [WebMethod]
        public float getValue(int MaThamSo)
        {
            return new ThamSoDAO().getValue(MaThamSo);
        }
        [WebMethod]
        public ThamSoDTO[] getListThamSo()
        {
            return new ThamSoDAO().getListThamSo();
        }
        [WebMethod]
        public int UpdateThamSo(string mathamso, float giatri)
        {
            return new ThamSoDAO().Update(mathamso,giatri);
        }
        [WebMethod]
        public float getheso()
        {
            return new ThamSoDAO().getheso();
        }
        [WebMethod]
        public float getphuthu()
        {
            return new ThamSoDAO().getphuthu();
        }
        [WebMethod]
        public float getkhachtoida()
        {
            return new ThamSoDAO().getkhachtoida();
        }


        // ======================== CTPHIEUTHUE  ================================

        [WebMethod]
        public CTPhieuThueDTO[] getListCTPhieuThue()
        {
            return new CTPhieuThueDAO().getList();
        }
        [WebMethod]
        public string NextIDCTPhieuThue()
        {
            return new CTPhieuThueDAO().NextID();
        }
        [WebMethod]
        public CTPhieuThueDTO[] getListByMaPhieuThue(string MaPhieuThue)
        {
            return new CTPhieuThueDAO().getListByMaPhieuThue(MaPhieuThue);
        }
        [WebMethod]
        public int testExistsMaPhieuThueInCTPhieuThue(string MaPhieuThue)
        {
            return new CTPhieuThueDAO().testExistsMaPhieuThueInCTPhieuThue(MaPhieuThue);
        }
        [WebMethod]
        public int testExistsMaPhieuThueInPhieuThue(string MaPhieThue)
        {
            return new CTPhieuThueDAO().testExistsMaPhieuThueInPhieuThue(MaPhieThue);
        }
        [WebMethod]
        public int testExistMaCTPTInCTPHIEUTHUE(string MaCTPT)
        {
            return new CTPhieuThueDAO().testExistMaCTPTInCTPHIEUTHUE(MaCTPT);
        }
        //========> ĐÃ LÀM BÊN KHACHANG ==> NÊN BỊ BÁO LỖI TRÙNG METHOD. --> BỎ ĐI
        [WebMethod]
        public int testExistsMaKhachHangInCTPHIEUTHUE2(string MaKhachHang, string MaPhieuThue)// Thực ra mà mã phiếu thuê
        {
            return new CTPhieuThueDAO().testExistsMaKhachHangInCTPHIEUTHUE(MaKhachHang, MaPhieuThue);
        }
        [WebMethod]
        public int InsertCTPhieuThue(CTPhieuThueDTO ctptDTO)
        {
            return new CTPhieuThueDAO().Insert(ctptDTO);
        }
        [WebMethod]
        public int UpdateCTPhieuThue(CTPhieuThueDTO ctptDTO)
        {
            return new CTPhieuThueDAO().Update(ctptDTO);
        }
        [WebMethod]
        public int DeleteCTPhieuThue(string MaCTPT)
        {
            return new CTPhieuThueDAO().Delete(MaCTPT);
        }
        [WebMethod]
        public int CountMaKhachHang(string MaPhieuThue)
        {
            return new CTPhieuThueDAO().CountMaKhachHang(MaPhieuThue);
        }
        [WebMethod]
        public string getListMaCTPTByMaPhieuThue(string MaPhieuThue)
        {
            return new CTPhieuThueDAO().getListMaCTPTByMaPhieuThue(MaPhieuThue);
        }

        // ======================== HOA DON  ================================
        // - Một số hàm chuyển sang KhachHang và PhieuThue
        // - Một số hàm thì chưa hiểu lắm

        [WebMethod]
        public HoaDonDTO[] getlistHoaDon()
        {
            return new HoaDonDAO().getlistHoaDon();
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
            return new HoaDonDAO().Thanhtoan_HD(mahoadon, tongtien);
        }
        [WebMethod]
        public bool Thanhtoan_Phieuthue(string maHD, string maphong, PhieuThueDTO dtoPT)
        {
            return new HoaDonDAO().Thanhtoan_Phieuthue(maHD, maphong, dtoPT);
        }

        // UpdatePhongStatus
        [WebMethod]
        public bool Thanhtoan_Phong(string maphong)
        {
            return new HoaDonDAO().Thanhtoan_Phong(maphong);
        }
        [WebMethod]
        public bool LapHoaDon(HoaDonDTO dtoHD)
        {
            return new HoaDonDAO().LapHoaDon(dtoHD);
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
            return new HoaDonDAO().kiemtra_loaikhach(maphieuthue, MaLoaiKH);
        }
        [WebMethod]
        public int dem_KH_Phong(string maphieuthue)
        {
            return new HoaDonDAO().dem_KH_Phong(maphieuthue);
        }
        [WebMethod]
        public bool delete_hd(string mahd)
        {
            return new HoaDonDAO().delete_hd(mahd);
        }
        [WebMethod]
        public string NextIDHoaDon()
        {
            return new HoaDonDAO().NextID();
        }

        // ======================= CT_HOADON
        [WebMethod]
        public bool InsertCTHOADON(CT_HoaDonDTO dtoCTHD)
        {
            return new CT_HoaDonDAO().Them(dtoCTHD);
        }

        [WebMethod]
        public string getMaPT(string maphong)
        {
            return new CT_HoaDonDAO().getMaPT(maphong);
        }

        [WebMethod]
        public bool delete_cthd(string mahd)
        {
            return new CT_HoaDonDAO().delete_cthd(mahd);
        }

        // User DTO ======================================

         [WebMethod]
        public bool KiemTra_tendangnhap(string _tendangnhap)
        {
            return new UserDAO().KiemTra_tendangnhap(_tendangnhap);
        }
         [WebMethod]
        public bool KiemTra_matkhau(string _tendangnhap, string _matkhau)
        {
            return new UserDAO().KiemTra_matkhau(_tendangnhap, _matkhau);
        }
         [WebMethod]
        public bool backup(string path)
        {
            return new UserDAO().backup(path);
        }

         [WebMethod]
        public bool restore(string path)
        {
            return new UserDAO().restore(path);
        }

         [WebMethod]
        public string getIdKUserByIdUser(UserDTO uDTO)
        {
            return new UserDAO().getIdKUserByIdUser(uDTO);
        }
    }
}
