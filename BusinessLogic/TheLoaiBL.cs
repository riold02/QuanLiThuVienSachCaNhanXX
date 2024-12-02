
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccess;
using Presentation;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace BusinessLogic
{
    public class TheLoaiBL
    {
        TheLoaiDA ds = new TheLoaiDA();
        //Phương thức lấy hết dữ liệu
        public DataTable GetAll()
        {
            return ds.Get_All();
        }
        //Phương thức thêm dữ liệu
        public int Insert(TheLoai_ DSMuon)
        {
            return ds.Insert_Update_Delete(DSMuon, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(TheLoai_ DSMuon)
        {
            return ds.Insert_Update_Delete(DSMuon, 1);
        }
        //Phương thức xoá dữ liệu truyền vào ID
        public int Delete(int idTheLoai)
        {
            return ds.DeleteTheLoai(idTheLoai );
        }
    }
}
