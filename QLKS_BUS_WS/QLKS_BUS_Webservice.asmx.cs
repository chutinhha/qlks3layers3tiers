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
        public string NextID()
        {
            return ws.NextID();
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
        public int testExist(string MaPhong)
        {
            return ws.testExist(MaPhong);

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

    }
}
