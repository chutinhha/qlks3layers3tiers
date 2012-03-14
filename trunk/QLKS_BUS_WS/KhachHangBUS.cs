using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLKS_BUS_WS.QLKS_DAL_WebService;
namespace QLKS_BUS_WS
{

    public class KhachHangBUS
    {
        public KhachHangDTO[] getListKhachHang()
        {
            return new QLKS_DAL_WebserviceSoapClient().getListKhachHang();
        }

    }
}