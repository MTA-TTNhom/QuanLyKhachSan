using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
   public class thuephongBLL
    {
        thuephongDAL tpDAL = new thuephongDAL();
        public bool them_thuephong(int maKhachHang, DateTime ngayDen, int maPhong)
        {
            return tpDAL.them_thuephong(maKhachHang, ngayDen, maPhong);
        }
        public DataTable hienthi_thuetheophong()
        {
            return tpDAL.hienthi_thuetheophong();
        }
        public void tinhtien(DateTime ngayDi, float thanhTien, int maThuePhong, int maPhong)
        {

            tpDAL.tinhtien(ngayDi, thanhTien, maThuePhong, maPhong);
        }
    }
}

//Hoang chinh sua
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
