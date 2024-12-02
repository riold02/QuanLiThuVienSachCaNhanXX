using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class TacGia_
    {
        // ID của tác giả, tự tăng trong CSDL
        public int IDTacGia { get; set; }

        // Tên tác giả
        public string TacGia { get; set; }

        // Năm sinh của tác giả
        public DateTime? NamSinh { get; set; }

        // Quốc tịch của tác giả
        public string QuocTich { get; set; }
        public TacGia_()
        {

        }
    }
}
