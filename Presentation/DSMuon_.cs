using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class DSMuon_
    {
        // ID của lần mượn, tự tăng trong CSDL
        public int IDMuon { get; set; }

        // Mã sách
        public string IDSach { get; set; }

        // Tên sách
        public string TenSach { get; set; }

        // Họ tên người mượn
        public string HoTen { get; set; }

        // Số điện thoại
        public string SDT { get; set; }

        // Cho mượn (1: Có, 0: Không)
        public bool? ChoMuon { get; set; }

        // Trạng thái mượn (1: Đã mượn, 0: Chưa mượn)
        public bool? Muon { get; set; }

        // Ngày mượn
        public DateTime NgayMuon { get; set; }

        // Ngày trả
        public DateTime? NgayTra { get; set; }

        // Địa chỉ
        public string DiaChi { get; set; }

        // Đã trả (1: Đã trả, 0: Chưa trả)
        public bool? DaTra { get; set; }
        public DSMuon_()
        {
        }
       
    }
}
