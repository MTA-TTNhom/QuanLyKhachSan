using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class nhanvienDTO
    {
        private int _maNhanVien;
        private string _hoTen;
        private bool _gioiTinh;
        private DateTime _ngaySinh;
        private string _soChungMinh;
        private string _diaChi;
        private string _soDienThoai;
        private DateTime _ngayVaoLam;

        public int maNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        public string hoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
    }
}
