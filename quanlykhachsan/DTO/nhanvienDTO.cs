using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhanvienDTO
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
        public string soChungMinh
        {
            get { return _soChungMinh; }
            set { _soChungMinh = value; }
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
        public DateTime ngayVaoLam
        {
            get { return ngayVaoLam; }
            set { _ngayVaoLam = value; }
        }
    }
}

DataService ds = new DataService();
public DataTable LayMaThietBi()
{
    SqlCommand cmd = new SqlCommand("select * from THIET_BI");
    ds.Load(cmd);
    return ds;
}

public DataTable TimMaLoaiPhong(string cmbmaloaiphong)
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM THIET_BI WHERE MaLoaiPhong = @maloaiphong");
    cmd.Parameters.Add("maloaiphong", SqlDbType.VarChar).Value = cmbmaloaiphong;

    ds.Load(cmd);
    return ds;
}

DataService ds = new DataService();

public void LoadSchema()
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEU_THUE_PHONG WHERE MaPhieuThue='-1'");
    ds.Load(cmd);

}

public DataTable DanhSachPhieudangKy()
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEU_THUE_PHONG");
    ds.Load(cmd);

    return ds;
}

public DataTable TimPhieuThue(string cmnd)
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEU_THUE_PHONG WHERE MaPhieuThue =@cmnd");
    cmd.Parameters.Add("cmnd", SqlDbType.VarChar).Value = cmnd;
    ds.Load(cmd);

    return ds;
}

public DataTable TimKhachHang(string cmnd)
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEU_THUE_PHONG WHERE MaKhachHang =@cmnd");
    cmd.Parameters.Add("cmnd", SqlDbType.VarChar).Value = cmnd;
    ds.Load(cmd);

    return ds;
}
