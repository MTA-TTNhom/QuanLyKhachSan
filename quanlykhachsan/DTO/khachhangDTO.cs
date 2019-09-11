using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhangDTO
    {
        

        
        public string tenKhachHang
        {
            get { return _tenKhachHang; }
            set { _tenKhachHang = value; }
        }
        public bool gioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        public DateTime ngaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string chungMinhNhanDan
        {
            get { return _chungMinhNhanDan; }
            set { _chungMinhNhanDan = value; }
        }
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string soDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
        public String quocTich
        {
            get { return _quocTich; }
            set { _quocTich = value; }
        }
    }
}
