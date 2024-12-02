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
    /// Lớp ánh xạ bảng TacGia
    /// </summary>
    public class TacGiaDA
    {


        public DataTable Get_All()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.TacGia_GetAll; // Tên thủ tục lấy tất cả tác giả

            // Tạo DataTable để lưu trữ kết quả
            DataTable dataTable = new DataTable();

            // Đọc dữ liệu từ SqlDataReader vào DataTable
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader); // Tự động điền dữ liệu vào DataTable từ SqlDataReader

            // Đóng kết nối và trả về DataTable
            sqlConn.Close();
            return dataTable;
        }


        public int Insert_Update_Delete(TacGia_ tacGia, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.TacGia_InsertUpdateDelete; // Tên thủ tục lưu trữ

            // Thêm các tham số cho thủ tục
            SqlParameter IDPara = new SqlParameter("@IDTacGia", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput // Vừa vào vừa ra
            };
            command.Parameters.Add(IDPara).Value = tacGia.IDTacGia;
            command.Parameters.Add("@TacGia", SqlDbType.NVarChar, 200).Value = tacGia.TacGia;
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime).Value = tacGia.NamSinh ?? (object)DBNull.Value;
            command.Parameters.Add("@QuocTich", SqlDbType.NVarChar, 200).Value = tacGia.QuocTich ?? (object)DBNull.Value;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // Thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm/cập nhật/xóa
                return (int)command.Parameters["@IDTacGia"].Value;

            sqlConn.Close();
            return 0; // Trả về 0 nếu không thành công
        }
        public int Delete(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString))
            {
                try
                {
                    sqlConn.Open();

                    SqlCommand command = sqlConn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.TacGia_InsertUpdateDelete;

                    SqlParameter IDPara = new SqlParameter("@IDTacGia", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.InputOutput
                    };
                    command.Parameters.Add(IDPara).Value = id;
                    command.Parameters.Add("@TacGia", SqlDbType.NVarChar, 255).Value = DBNull.Value;
                    command.Parameters.Add("@NamSinh", SqlDbType.DateTime).Value = DBNull.Value;
                    command.Parameters.Add("@QuocTich", SqlDbType.NVarChar, 200).Value =DBNull.Value;
                    command.Parameters.Add("@Action", SqlDbType.Int).Value = 2;

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        return id;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return 0;
                }
            }
        }
    }

    }
