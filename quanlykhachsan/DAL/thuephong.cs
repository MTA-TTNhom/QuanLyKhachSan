using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class thuephong
    {
        public bool them_thuephong(DateTime ngayDen, int ma_phong,int mak_hang)
        {
            SqlConnection abo = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("them_thuephong", abo);
            cmd.Commanttype = Commanttype.StoredProcedure;
            cmd.Parameters.AddWithValue("mak_hang", mak_hang);
            cmd.Parameters.AddWithValue("ngayDen", ngayDen);

            cmd.Parameters.AddWithValue("ma_phong", ma_phong);

            int j = cmd.ExecuteNonQuery();
            abo.Close();
            if (j == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void thutien( float thanhTien,  int ma_phong)
        {
            SqlConnection abo = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("tinhtien ", abo);
            cmd.Commanttype = Commanttype.StoredProcedure;
            cmd.Parameters.AddWithValue("thanhTien", thanhTien);
            cmd.Parameters.AddWithValue("maThuePhong", maThuePhong);
            
            int j = cmd.ExecuteNonQuery();
            abo.Close();
        }
        public DataTable phong_nguoithuephong()
        {
            SqlConnection abo = ketnoi.Get();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthi_thuetheophong", abo);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.Commanttype = Commanttype.StoredProcedure;
            cmd.Connection = abo;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tt = new DataTable();
            da.Fill(tt);
            abo.Close();
            return tt;
        }
        
    }
}

