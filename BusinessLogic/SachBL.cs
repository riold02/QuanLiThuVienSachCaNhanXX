
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
    public class SachBL
    {
        SachDA ds = new SachDA();
        //Phương thức lấy hết dữ liệu
        public DataTable GetAll()
        {
            return ds.GetAll();
        }
        //Phương thức thêm dữ liệu
        public int Insert(Sach_ DSMuon)
        {
            return ds.Insert_Update_Delete(DSMuon, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Sach_ DSMuon)
        {
            return ds.Insert_Update_Delete(DSMuon, 1);
        }
        //Phương thức xoá dữ liệu truyền vào ID
        public int Delete(string str)
        {
            return ds.Delete(str);
        }
        public DataTable Search (string tensach,int? idTheLoai,int? idTacGia,string ViTri)
        {
            return ds.FilterSach(tensach, idTheLoai, idTacGia,ViTri);
        }

    }
}
