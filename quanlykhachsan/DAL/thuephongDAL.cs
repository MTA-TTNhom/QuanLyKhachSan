using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class thuephongDAL
    {
        public bool them_thuephong(int maKhachHang, DateTime ngayDen, int maPhong)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("them_thuephong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("maKhachHang", maKhachHang);
            cmd.Parameters.AddWithValue("ngayDen", ngayDen);

            cmd.Parameters.AddWithValue("maPhong", maPhong);

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
    }
}
