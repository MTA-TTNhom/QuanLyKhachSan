using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class thuephongDAL
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
        public DataTable hienthi_thuetheophong()
        {
            SqlConnection cnn = ketnoi.Get();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthi_thuetheophong", cnn);
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
        public void tinhtien(DateTime ngayDi, float thanhTien, int maThuePhong, int maPhong)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("tinhtien ", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ngayDi", ngayDi);
            cmd.Parameters.AddWithValue("thanhTien", thanhTien);
            cmd.Parameters.AddWithValue("maThuePhong", maThuePhong);
            cmd.Parameters.AddWithValue("maPhong", maPhong);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
    
     Bai toan tinh quan ly khach san
     (1) Giá theo giờ: Nhập list giá. Tiền theo giờ không được lớn hơn số tiền theo ngày.
Nếu không qui định. Giá sẽ áp dụng theo ngày . Ví dụ trên. Từ 3 tiếng - 12 tiếng giá 400.000. Sau 12 tiếng tính thành 1 ngày

(2) Giá qua đêm: Giá qua đêm qui định theo danh sách cài đặt. Danh sách giá qua đêm bắt đầu từ thời điểm tính giá qua đêm trở về sau. Ví dụ 18h00 -> 22h00 -> 2h00 (sáng hôm sau). Bỏ trống nếu khách sạn của bạn không có chính sách giá này.

Ví dụ bên trên: Qui định giờ trả phòng để bắt đầu tính qua đên sau 0h00 và giờ nhận phòng trước 5 sáng (Sau 5h sáng giá phòng sẽ tính theo giờ) . Xem cài đặt qui định này ở mục ghi chú số 11 Qui định giá.

Theo ví vụ trên:
- Nếu khách nhận phòng sau 18h00 trả phòng sau 0h00 -12h trưa giá: 300.000 VNĐ
- Nếu khách nhận phòng sau 22h00 trả phòng sau 0h00 -12h trưa giá: 250.000 VNĐ
- Nếu khách nhận phòng sau 2h00 sáng trả phòng sau 3h00 -12h trưa giá: 250.000 VNĐ
+ Mục theo giờ (2) : Nhập số giờ qui định. Bấm biểu tượng  THÊM bên phải để tiếp tục

+ Nhập giá qua đêm: (Vào trễ và trả trước 12h trưa): Ví dụ trường hợp trên. Khách vào 12h khuya trả phòng vào 12h trưa giá qui định là 300.000 (0h-12h= 12 tiếng: 300.000) . Nếu khách vào sớm hơn lúc 21h . Qui định là 350.000. Trước 21h tính thành một ngày.
Một số trường hợp tính giá qua đêm không theo qui ước. Ví dụ khách vào từ 12h khuya trả phòng bất kỳ thời gian nào trước 12h trưa hôm sau đều tính giá qua đêm. Bạn nhập mục giá qua đêm (4) . Khi trả phòng chỉ việc click vào dấu chech  Tính giá qua đêm để áp dụng giá này

+ Giá theo ngày (3): Qui ước tính từ 12h trưa (giờ trả phòng) đến 12h trưa ngày hôm sau

+ Phụ thu thêm người: Nếu muốn phụ thu tự động bạn nhập qui định phụ thu quá người. Bạn phải qui định rõ số người trong mỗi phòng và thêm đủ danh sach khách hàng khi nhận phòng trong trường hợp này hoặc đơn giản hơn có thể dùng mục thêm dịch vụ Xem hướng dẫn
    (1) Chọn mục THÔNG TIN -> Khách sạn: để cài đặt qui định tính tiền
- (2) Giờ trả phòng: Qui định giờ trả phòng. Sau giờ này bắt đầu tính thêm phụ thu
- (3) Đơn vị tiền & tỉ giá: Hỗ trợ VND / USD / Cả hai. Nếu bạn nhập tỉ giá USD/VNĐ khi tính tiền hóa đơn đơn sẽ tự động chuyển đổi sang đơn vị còn lại
- (4) Làm tròn: Ví dụ 1h25 phút được tính thành 2h
- (5) Tính quá giờ: Mục (7) cho phép bạn qui định số giờ lưu trú bắt đầu tính quá giờ. Nếu thời gian lưu trú lớn hơn giá trị này thì sẽ áp dụng phụ thu cho thời gian quá giờ trả phòng theo danh sách bên dưới
Ví dụ trên: Khách ở trên 8h mới bắt đầu tính theo giờ chẳng hạn khách vào từ 6h sáng đến 13h chiều = 7h . Phần mềm sẽ áp dụng giá theo giờ 7h ~ giá ngày/đêm. Nếu khách trả phòng lúc 15h chiều thì phần mềm sẽ áp dụng tính theo giờ 4h đầu (6h-12h) + Phụ thu từ (12h-15h) theo qui định phụ thu bên dưới.
Gợi ý: Nên đặt giá trị =12h)

(6) + Ví dụ trên: Nếu khách trả phòng sau 12h 1 tiếng thì miễn phí. Giờ thứ 2 cộng thêm 20.000, Giờ thứ 03 và 06 lần lượt cộng thêm 20% và 50%. Quá 06 sẽ tính nguyên ngày. Bạn có thể sử dụng mục THÊM/Xóa để thêm bớt dòng

- (6) Nếu vào trước: Miễn phí cho khách ngày nếu vào sớm hơn giờ trả phòng 3h theo ví dụ trên. Ví dụ khách vào từ 9h sáng nếu ở qua ngày sẽ không tính tiền từ 9h-12h trưa. Nếu quá áp dụng theo giá giờ

- (9) Linh động giá: Cho phép nhân viên linh động giá khi nhận phòng. Ví dụ phòng cài đặt ngày 500.000 . Khi nhận phòng nhân viên có thể linh động giá 450.000. Mặc định sẽ theo qui định giá 500.000 nếu ko thay đổi.

Phiên bản có phí
(11) Qui định áp dụng giá qua đêm: Bản có phí cung cấp thêm tính năng tính thiết lập tính giá qua đêm có thể giải quyết được mọi vấn đề hoàn toàn tự động. (Phiển bản miễn phí chỉ giải quyết hầu hết tình huống về giá cơ bản)

(12) Giờ bắt đầu tính qua đêm: Ví dụ bạn nhập vào 0h00 nghĩa là trả phòng sau giờ này thì bắt đầu tính giờ qua đêm (không phải là giờ trả phòng) và thường áp dụng từ 00h00 đến 12h trưa ngày hôm sau

(13) Giờ nhận phòng giới hạn tính giá qua đêm: Nếu nhận phòng sau giờ này. Ví dụ bắt đầu từ 5h sáng thì tính theo giờ bình thường

Ví dụ: Nếu khách trả phòng sau 0h00 sáng và giờ nhận phòng trước 5h00 sáng thì sẽ áp dụng giá qua đêm lần lượt theo qui định tại mục Cài đặt giá theo giờ qua đêm. Click để xem:

(14) Qui định phụ thu giờ qua đêm:
- Nếu bạn muốn phụ thu theo giờ áp dụng nhận phòng từ 0h00 (Mục 15) đến 6h00 (Mục 16) . Bạn nhập 10% nếu muốn cộng thêm 10% giá giờ hoặc nhập thêm 20.000 nếu muốn cộng thêm 20.000 VNĐ. Bỏ trống nếu không áp dụng.

Chính sách này giúp khách sạn có thể bán giá giờ ban ngày và ban đêm khác nhau

Lưu ý: Nếu bạn vẫn vừa muốn bán giá qua đêm vừa áp dụng bán theo giờ 24/24 bạn vui lòng nhập mục giá qua đêm Áp dụng sau (Mục 12) = 12 (giờ trả phòng). Nếu giá theo giờ lớn hơn giá qua đêm thì sẽ áp dụng giá qua đêm.

Để xây dựng chính sách giá chuyên nghiệp giúp tăng doanh thu hoặc hỗ trợ để được thiết lập giá. Vui lòng liên hệ hỗ trợ O2b để được giúp đỡ

     
}

