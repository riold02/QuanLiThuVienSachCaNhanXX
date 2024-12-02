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
    /// Lớp ánh xạ bảng DSMuon
    /// </summary>
    public class DSMuonDA
    {



        public DataTable GetAll()
        {
            // Tạo kết nối với cơ sở dữ liệu
           SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Tạo đối tượng SqlCommand để gọi thủ tục hoặc câu truy vấn SQL
            SqlCommand command = new SqlCommand("SELECT * FROM DSMuon", sqlConn);

            // Tạo DataAdapter để điền dữ liệu vào DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            // Điền dữ liệu vào DataTable
            adapter.Fill(dt);

            // Đóng kết nối
            sqlConn.Close();

            // Trả về DataTable chứa dữ liệu
            return dt;
        }


        /// <summary>
        /// Phương thức thêm, sửa, xóa theo thủ tục DSMuon_InsertUpdateDelete
        /// </summary>
        public int Insert_Update_Delete(DSMuon_ dsMuon, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DSMuon_InsertUpdateDelete;

            // Thêm các tham số cho thủ tục
            SqlParameter IDPara = new SqlParameter("@IDMuon", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput // Vừa vào vừa ra
            };
            command.Parameters.Add(IDPara).Value = dsMuon.IDMuon;
            command.Parameters.Add("@IDSach", SqlDbType.NVarChar, 50).Value = dsMuon.IDSach;
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar, 255).Value = dsMuon.TenSach;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 255).Value = dsMuon.HoTen;
            command.Parameters.Add("@SDT", SqlDbType.Char, 20).Value = dsMuon.SDT;
            command.Parameters.Add("@ChoMuon", SqlDbType.Bit).Value = dsMuon.ChoMuon ?? (object)DBNull.Value;
            command.Parameters.Add("@Muon", SqlDbType.Bit).Value = dsMuon.Muon ?? (object)DBNull.Value;
            command.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = dsMuon.NgayMuon;
            command.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = dsMuon.NgayTra; ;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = dsMuon.DiaChi;
            command.Parameters.Add("@DaTra", SqlDbType.Bit).Value = dsMuon.DaTra ?? (object)DBNull.Value;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // Thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm/cập nhật/xóa
                return (int)command.Parameters["@IDMuon"].Value;

            sqlConn.Close();
            return 0;
        }
        public int DeleteDSMuon(int idMuon)
        {
            using (SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString))
            {
                try
                {
                    sqlConn.Open();
                    SqlCommand command = sqlConn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.DSMuon_Delete; // Tên thủ tục

                    command.Parameters.Add(new SqlParameter("@IDMuon", SqlDbType.Int)).Value = idMuon;

                    // Thực thi lệnh và nhận kết quả
                    int result = command.ExecuteNonQuery();

                    return result; // Trả về số dòng bị ảnh hưởng
                }
                catch (Exception ex)
                {
                   return 0; // Lỗi
                }
            }
        }

    }

}
