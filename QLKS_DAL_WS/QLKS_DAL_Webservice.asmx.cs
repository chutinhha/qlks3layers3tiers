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
        public string NextID()
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

        // ======================== XONG KHACH HANG ================================
        [WebMethod]
        public LoaiKhachHangDTO[] getListLoaiKhachHang()
        {

            return lkDAO.getListLoaiKhachHang();
        }
        // ======================== XONG LOAI KHACH HANG ================================
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
        public int testExist(string MaPhong)
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

    }
}
