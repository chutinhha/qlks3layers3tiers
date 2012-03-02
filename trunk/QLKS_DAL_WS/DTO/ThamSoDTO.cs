using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class ThamSoDTO
    {
        int _MaThamSo;

        public int MaThamSo
        {
            get { return _MaThamSo; }
            set { _MaThamSo = value; }
        }
        string _TenThamSo;

        public string TenThamSo
        {
            get { return _TenThamSo; }
            set { _TenThamSo = value; }
        }
        float _GiaTri;

        public float GiaTri
        {
            get { return _GiaTri; }
            set { _GiaTri = value; }
        }
        string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
