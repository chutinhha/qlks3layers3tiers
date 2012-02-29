using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class PhieuThueDTO
    {
        DateTime _NgayThue, _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }

        public DateTime NgayThue
        {
            get { return _NgayThue; }
            set { _NgayThue = value; }
        }
        string _MaPhong;

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        private DateTime _NgayTra_ThucTe;

        public DateTime NgayTra_ThucTe
        {
            get { return _NgayTra_ThucTe; }
            set { _NgayTra_ThucTe = value; }
        }
        private string _ThanhToan;

        public string ThanhToan
        {
            get { return _ThanhToan; }
            set { _ThanhToan = value; }
        }
        string _MaPhieuThue;

        public string MaPhieuThue
        {
            get { return _MaPhieuThue; }
            set { _MaPhieuThue = value; }
        }
        private int _songaythue;

        private string _KhachHangDaiDien;

        public string KhachHangDaiDien
        {
            get { return _KhachHangDaiDien; }
            set { _KhachHangDaiDien = value; }
        }

        public int Songaythue
        {
            get { return _songaythue; }
            set { _songaythue = value; }
        }
        private float _heso;

        public float Heso
        {
            get { return _heso; }
            set { _heso = value; }
        }
        private float _tienphuthu;

        public float Tienphuthu
        {
            get { return _tienphuthu; }
            set { _tienphuthu = value; }
        }
        private float _tienthue;

        public float Tienthue
        {
            get { return _tienthue; }
            set { _tienthue = value; }
        }
    }
}
