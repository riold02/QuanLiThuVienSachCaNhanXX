using BusinessLogic;
using Presentation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienSachCaNhan
{
    public partial class frmThemSach : Form
    {
      
  
        public frmThemSach()
        {

            InitializeComponent();
            LoadTheLoai();
            LoadTacGia();
        }
        private void LoadTacGia()
        {
            TacGiaBL tacGiaBL = new TacGiaBL();
            cbbTacGia.DisplayMember = "TacGia";
            cbbTacGia.ValueMember = "IDTacGia";
            cbbTacGia.DataSource = tacGiaBL.GetAll();

            
        }
        private void LoadTheLoai()
        {
            TheLoaiBL theLoaiBl = new TheLoaiBL();
            cbbTheLoai.DisplayMember = "TheLoai";
            cbbTheLoai.ValueMember = "IDTheLoai";
            cbbTheLoai.DataSource = theLoaiBl.GetAll();
        }

        private void bnt_themsach_Click(object sender, EventArgs e)
        {
            SachBL sach = new SachBL();
            Sach_ temp = new Sach_();
            temp.TenSach = txtTenSach.Text;
            temp.IDSach = txtIDSach.Text;
            temp.IDTheLoai = Convert.ToInt32(cbbTheLoai.SelectedValue);
            temp.IDTacGia = Convert.ToInt32(cbbTacGia.SelectedValue);
            if (rdKeA.Checked) temp.ViTri = rdKeA.Text;
            else
                if (rdKeB.Checked) temp.ViTri = rdKeB.Text;
            else
                if(rdKeC.Checked) temp.ViTri = rdKeC.Text;
            else temp.ViTri = rdKeD.Text;
            int result = sach.Insert(temp);
            if (result > 0)
                MessageBox.Show("Thêm sách thành công!");
            else
                MessageBox.Show("Thêm sách thất bại!");
            this.Close();
        }

        private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
