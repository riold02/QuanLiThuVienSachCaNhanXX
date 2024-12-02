using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation;
using System.Windows.Forms;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Sach
    /// </summary>
    public class SachDA
    {
        // Mã sách

        public DataTable GetAll()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Sach_GetAll; // Tên thủ tục lưu trữ để lấy dữ liệu sách

            // Tạo DataTable để lưu trữ kết quả
            DataTable dataTable = new DataTable();

            // Đọc dữ liệu từ SqlDataReader vào DataTable
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader); // Tự động điền dữ liệu vào DataTable từ SqlDataReader

            // Đóng kết nối và trả về DataTable
            sqlConn.Close();
            return dataTable;
        }

        public int Insert_Update_Delete(Sach_ sach, int action)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString))
                {
                    sqlConn.Open();

                    // Tạo SqlCommand và thiết lập kiểu xử lý
                    using (SqlCommand command = sqlConn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = Ultilities.Sach_InsertUpdateDelete;

                   
                  
                        command.Parameters.Add("@IDSach", SqlDbType.NVarChar, 50).Value = sach.IDSach;
                        command.Parameters.Add("@TenSach", SqlDbType.NVarChar, 255).Value = sach.TenSach;
                        command.Parameters.Add("@IDTacGia", SqlDbType.Int).Value = sach.IDTacGia;
                        command.Parameters.Add("@IDTheLoai", SqlDbType.Int).Value = sach.IDTheLoai;
                        command.Parameters.Add("@ViTri", SqlDbType.NVarChar, 255).Value = sach.ViTri;
                        command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                        // Thực thi lệnh
                        int result = command.ExecuteNonQuery();

                        if (result > 0) // Thành công
                        {
                            string idSachOutput = command.Parameters["@IDSach"].Value?.ToString();
                            return !string.IsNullOrEmpty(idSachOutput) ? int.Parse(idSachOutput) : 0;
                        }

                        return 0; // Không thành công
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc hiển thị thông báo tùy theo yêu cầu
                Console.WriteLine($"Lỗi: {ex.Message}");
                return 0; // Trả về 0 trong trường hợp lỗi
            }
        }


        public int Delete(string idSach)
        {
            using (SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString))
            {
                try
                {
                    sqlConn.Open();

                    SqlCommand command = sqlConn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.DeleteSach;
                    // Thêm tham số IDSach cần xóa
                    command.Parameters.Add(new SqlParameter("@IDSach", idSach));

                    // Thực thi lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0) 
                    {
                     
                        return 1; // Thành công
                    }
                    else
                    {
                        
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0; // Trả về 0 nếu có lỗi
                }
            }
        }

        public DataTable FilterSach(string tenSach = null, int? idTheLoai = null, int? idTacGia = null, string viTri = null)
        {
            // Khởi tạo DataTable để lưu kết quả
            DataTable dtSach = new DataTable();

            // Tạo kết nối với cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(Ultilities.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_FilterSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.AddWithValue("@TenSach", string.IsNullOrEmpty(tenSach) ? (object)DBNull.Value : "%" + tenSach + "%");
                cmd.Parameters.AddWithValue("@IDTheLoai", idTheLoai.HasValue ? (object)idTheLoai.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IDTacGia", idTacGia.HasValue ? (object)idTacGia.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ViTri", string.IsNullOrEmpty(viTri) ? (object)DBNull.Value : "%" + viTri + "%");

                // Mở kết nối và sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dtSach); // Điền dữ liệu vào DataTable
            }

            return dtSach; // Trả về DataTable chứa dữ liệu lọc được
        }





    }
}
