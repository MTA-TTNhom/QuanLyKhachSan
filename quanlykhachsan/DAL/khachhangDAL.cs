using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class khachhangDAL
    {
        public DataTable hienthikhachhang()
        {
            SqlConnection cnn = ketnoi.Get();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthikhachhang", cnn);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool them_khachhang(string tenKhachHang, DateTime ngaySinh, bool gioiTinh, string chungMinhNhanDan, string diaChi, string soDienThoai, string quocTich)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("them_khachhang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tenKhachHang", tenKhachHang);
            cmd.Parameters.AddWithValue("ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("chungMinhNhanDan", chungMinhNhanDan);
            cmd.Parameters.AddWithValue("diaChi", diaChi);
            cmd.Parameters.AddWithValue("soDienThoai", soDienThoai);
            cmd.Parameters.AddWithValue("quocTich", quocTich);

            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void xoa_nhanvien(int maKhachHang)
        {

            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("xoa_khachhang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("maKhachHang", maKhachHang);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public void sua_khachhang(string tenKhachHang, DateTime ngaySinh, bool gioiTinh, string chungMinhNhanDan, string diaChi, string soDienThoai, string quocTich, int maKhachHang)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("sua_khachhang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tenKhachHang", tenKhachHang);
            cmd.Parameters.AddWithValue("ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("chungMinhNhanDan", chungMinhNhanDan);
            cmd.Parameters.AddWithValue("diaChi", diaChi);
            cmd.Parameters.AddWithValue("soDienThoai", soDienThoai);
            cmd.Parameters.AddWithValue("quocTich", quocTich);
            cmd.Parameters.AddWithValue("maKhachHang", maKhachHang);

            int i = cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}

DataService ds = new DataService();
public DataTable LayMaPhong()
{
    SqlCommand cmd = new SqlCommand("select * from PHONG");
    ds.Load(cmd);
    return ds;
}

public DataTable LayMaPhong(string id)
{
    SqlCommand cmd = new SqlCommand("select * from PHONG WHERE MaPhong = @id");
    cmd.Parameters.Add("id", SqlDbType.VarChar, 3).Value = id;
    ds.Load(cmd);
    return ds;
}
//Download source code tai Sharecode.vn
public DataTable LayMaTinhTrangPhong(int id)
{
    SqlCommand cmd = new SqlCommand("select * from PHONG WHERE MaLoaiTinhTrangPhong = @id");
    cmd.Parameters.Add("id", SqlDbType.VarChar, 10).Value = id;
    ds.Load(cmd);
    return ds;
}

public DataTable LayDSMaTinhTrangPhong()
{
    SqlCommand cmd = new SqlCommand("select * from PHONG WHERE MaLoaiTinhTrangPhong");
    //cmd.Parameters.Add("id", SqlDbType.VarChar, 10).Value = id;
    ds.Load(cmd);
    return ds;
}

public DataTable LayMaLoaiPhong()
{
    SqlCommand cmd = new SqlCommand("select * from PHONG WHERE MaLoaiPhong");
    //cmd.Parameters.Add("id", SqlDbType.VarChar, 10).Value = id;
    ds.Load(cmd);
    return ds;
}


public static void CapNhatMaLoaiTinhTrangPhong(String maphong, int id)
{
    DataService ds = new DataService();
    SqlCommand cmd = new SqlCommand("UPDATE PHONG SET MaLoaiTinhTrangPhong = @so WHERE MaPhong = @id");
    cmd.Parameters.Add("so", SqlDbType.Int).Value = id;
    cmd.Parameters.Add("id", SqlDbType.VarChar).Value = maphong;
    ds.ExecuteNoneQuery(cmd);
}
public static void CapNhatMaLoaiTinhTrangPhong(String maphong, int id)
{
    DataService ds = new DataService();
    SqlCommand cmd = new SqlCommand("UPDATE PHONG SET MaLoaiTinhTrangPhong = @so WHERE MaPhong = @id");
    cmd.Parameters.Add("so", SqlDbType.Int).Value = id;
    cmd.Parameters.Add("id", SqlDbType.VarChar).Value = maphong;
    ds.ExecuteNoneQuery(cmd);
}



public DataTable TimMaLoaiPhong(string maloaiphong)
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHONG WHERE MaLoaiPhong = @maloaiphong ");
    cmd.Parameters.Add("maloaiphong", SqlDbType.VarChar).Value = maloaiphong;
    ds.Load(cmd);

    return ds;
}

public DataTable TimTinhTrangPhong(string tinhtrangphong)
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHONG WHERE MaLoaiTinhTrangPhong=@tinhtrangphong ");
    cmd.Parameters.Add("tinhtrangphong", SqlDbType.VarChar).Value = tinhtrangphong;
    ds.Load(cmd);

    return ds;
}


public DataRow NewRow()
{
    return ds.NewRow();
}

public void Add(DataRow row)
{
    ds.Rows.Add(row);
}

public bool Save()
{
    return (ds.ExecuteNoneQuery() > 0);
}
DataService ds = new DataService();
public DataTable LayDSTinhTrangPhong()
{
    SqlCommand cmd = new SqlCommand("select * from LOAI_TINH_TRANG");
    ds.Load(cmd);
    return ds;
}
public DataRow NewRow()
{
    return ds.NewRow();
}

public void Add(DataRow row)
{
    ds.Rows.Add(row);
}

public bool Save()
{
    return (ds.ExecuteNoneQuery() > 0);
}
    }
DataService ds = new DataService();
public DataTable LayDanhSachNhanPhong()
{
    SqlCommand cmd = new SqlCommand("select * from PHIEU_NHAN_PHONG");
    ds.Load(cmd);
    return ds;
}

public void LoadSchema()
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEU_NHAN_PHONG WHERE MaNhanPhong='-1'");
    ds.Load(cmd);

}

public DataTable LayMaNhanPhong(String id)
{
    SqlCommand cmd = new SqlCommand("select * from PHIEU_NHAN_PHONG WHERE MaNhanPhong = @id ");
    cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;
    ds.Load(cmd);
    return ds;
}

public DataTable TimPhieuThue(String mathuephong)
{
    SqlCommand cmd = new SqlCommand(" SELECT  pt.MaPhong, kh.MaKhachHang,ct.MaPhieuThue" +
        "FROM  CHI_TIET_PHIEU_THUE_PHONG pt inner join" +
        "  PHIEU_THUE_PHONG ct on pt.MaPhieuThue=ct.MaPhieuThue inner join" +
        " KHACH_HANG kh on kh.MaKhachHang=ct.MaKhachHang ");
    //cmd.Parameters.Add("mathuephong", SqlDbType.VarChar).Value = mathuephong;
    ds.Load(cmd);
    return ds;
}

public DataTable LayTheoMaPhong(String maphong)
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEU_NHAN_PHONG WHERE MaPhieuThue = @mathuephong ");
    cmd.Parameters.Add("mathuephong", SqlDbType.VarChar).Value = maphong;
    ds.Load(cmd);
    return ds;
}

public DataRow NewRow()
{
    return ds.NewRow();
}

public void Add(DataRow row)
{
    ds.Rows.Add(row);
}

public bool Save()
{
    return (ds.ExecuteNoneQuery() > 0);
}
