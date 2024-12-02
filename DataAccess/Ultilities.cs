using System;
using System.Configuration;

namespace DataAccess
{
    public class Ultilities
    {
        // Tham chiếu đến tên chuỗi kết nối trong file cấu hình
        public static string StrName = "ConnectionStringName"; // Đảm bảo rằng tên này khớp với tên trong App.config

        // Lấy chuỗi kết nối từ file cấu hình
        public static string ConnectionString
        {
            get
            {
                // Kiểm tra xem có chuỗi kết nối với tên tương ứng không
                if (ConfigurationManager.ConnectionStrings[StrName] != null)
                {
                    return ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
                }
                else
                {
                    throw new Exception("Không tìm thấy chuỗi kết nối với tên: " + StrName);
                }
            }
        }

        // Các thủ tục của bảng DSMuon
        public static string DSMuon_GetAll = "DSMuon_GetAll";
        public static string DSMuon_InsertUpdateDelete = "DSMuon_InsertUpdateDelete";
        public static string DSMuon_Delete = "DSMuon_Delete";
        // Các thủ tục của bảng Sach
        public static string Sach_GetAll = "Sach_GetAll";
        public static string Sach_InsertUpdateDelete = "Sach_InsertUpdateDelete";
        public static string DeleteSach = "DeleteSach";
        public static string Search = "sp_FilterSach";
        // Các thủ tục của bảng TacGia
        public static string TacGia_GetAll = "TacGIa_GetAll";
        public static string TacGia_InsertUpdateDelete = "TacGIa_InsertUpdateDelete";

        // Các thủ tục của bảng TheLoai
        public static string TheLoai_GetAll = "TheLoai_GetAll";
        public static string TheLoai_InsertUpdateDelete = "TheLoai_InsertUpdateDelete";
    }
}
