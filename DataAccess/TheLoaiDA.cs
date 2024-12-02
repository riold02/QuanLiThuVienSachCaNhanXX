using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation;
namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng TheLoai
    /// </summary>
    public class TheLoaiDA
    {
        // ID của thể loại, tự tăng trong CSDL

        public DataTable Get_All()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.TheLoai_GetAll; // Tên thủ tục lấy tất cả thể loại

            // Tạo DataTable để lưu trữ kết quả
            DataTable dataTable = new DataTable();

            // Đọc dữ liệu từ SqlDataReader vào DataTable
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader); // Tự động điền dữ liệu vào DataTable từ SqlDataReader

            // Đóng kết nối và trả về DataTable
            sqlConn.Close();
            return dataTable;
        }

        public int Insert_Update_Delete(TheLoai_ theLoai, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.TheLoai_InsertUpdateDelete; // Tên thủ tục xử lý

            // Thêm các tham số cho thủ tục
            SqlParameter IDPara = new SqlParameter("@IDTheLoai", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput // Vừa vào vừa ra
            };
            command.Parameters.Add(IDPara).Value = theLoai.IDTheLoai;
            command.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 200).Value = theLoai.TheLoai;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // Thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công, trả về ID đã thêm/cập nhật/xóa
                return (int)command.Parameters["@IDTheLoai"].Value;

            sqlConn.Close();
            return 0;
        }
        public int DeleteTheLoai(int idTheLoai)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            using (SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString))
            {
                try
                {
                    sqlConn.Open();

                    // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
                    SqlCommand command = sqlConn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.TheLoai_InsertUpdateDelete; // Tên thủ tục xử lý

                    // Thêm các tham số cho thủ tục
                    SqlParameter IDPara = new SqlParameter("@IDTheLoai", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.InputOutput // Vừa vào vừa ra
                    };
                    command.Parameters.Add(IDPara).Value = idTheLoai; // Truyền IDTheLoai cần xóa
                    command.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 200).Value = DBNull.Value; // Không cần tên thể loại cho xóa
                    command.Parameters.Add("@Action", SqlDbType.Int).Value = 2; // 2 là hành động Xóa

                    // Thực thi lệnh
                    int result = command.ExecuteNonQuery();

                    // Nếu xóa thành công, trả về ID đã xóa (hoặc 0 nếu không thành công)
                    if (result > 0)
                    {
                        return idTheLoai;
                    }
                    else
                    {
                        return 0; // Trả về 0 nếu không thành công
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ (optional logging)
                    Console.WriteLine("Error: " + ex.Message);
                    return 0; // Trả về 0 nếu có lỗi
                }
            }
        }


    }

}
