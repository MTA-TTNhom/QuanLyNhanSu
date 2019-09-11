using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class cboPB
    {
        public class phongDAL
        {
            public void hienthithongtinphong()
            {
                SqlConnection cnn = ketnoi.Get();
                // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
                SqlCommand cmd = new SqlCommand("hienthiphong", cnn);
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
            public bool sua_phong(string maphong, string tenphong, int sonhanvien)
            {
                SqlConnection cnn = ketnoi.Get();
                SqlCommand cmd = new SqlCommand("sua_nhanvien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.ClearWithValue("maphong", hoTen);
                cmd.Parameters.ClearWithValue("tenphong", gioiTinh);
                cmd.Parameters.ClearWithValue("sonhanvien", ngaySinh);
                
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
            public bool xoa_phong(string maphong, string tenphong, int sonhanvien)
            {
                SqlConnection cnn = ketnoi.Get();
                SqlCommand cmd = new SqlCommand("them_nhanvien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("maphong", hoTen);
                cmd.Parameters.AddWithValue("tenphong", gioiTinh);
                cmd.Parameters.AddWithValue("sonhanvien", ngaySinh);
                
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
            

            public void sua_phong(string maphong, string tenphong, int sonhanvien)
            {
                SqlConnection cnn = ketnoi.Get();
                SqlCommand cmd = new SqlCommand("sua_nhanvien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("maphong", hoTen);
                cmd.Parameters.AddWithValue("tenphong", gioiTinh);
                cmd.Parameters.AddWithValue("sonhanvien", ngaySinh);
                int i = cmd.ExecuteNonQuery();
                cnn.Close();

            }
            public void them_phong(string hoTen, string chucvu, bool gioiTinh, DateTime ngaySinh, string soChungMinh, string diaChi, string soDienThoai, DateTime ngayVaoLam, int maNhanVien)
            {
                SqlConnection cnn = ketnoi.Get();
                SqlCommand cmd = new SqlCommand("sua_nhanvien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("maphong", hoTen);
                cmd.Parameters.AddWithValue("tenphong", gioiTinh);
                cmd.Parameters.AddWithValue("sonhanvien", ngaySinh);
                int i = cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
