using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;
using Presentation;
using DataAccess;
namespace QuanLiThuVienSachCaNhan
{
    public partial class Form_chinh : Form
    {
        public Form_chinh()
        {
            InitializeComponent();
        }

        private void CustomizeDataGridViewColumns1()
        {
            dgvSach.Columns["IDSach"].HeaderText = "ID Sách";
            dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvSach.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvSach.Columns["ViTri"].HeaderText = "Vị Trí";

            dgvSach.Columns["IDSach"].Width = 100;
            dgvSach.Columns["TenSach"].Width = 200;
            dgvSach.Columns["TacGia"].Width = 150;
            dgvSach.Columns["TheLoai"].Width = 150;
            dgvSach.Columns["ViTri"].Width = 100;
        }

        private void CustomizeDataGridViewColumns2()
        {
            dgvDanhSachMuon.Columns["IDMuon"].HeaderText = "ID Mượn";
            dgvDanhSachMuon.Columns["IDSach"].HeaderText = "ID Sách";
            dgvDanhSachMuon.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvDanhSachMuon.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDanhSachMuon.Columns["SDT"].HeaderText = "Số Điện Thoại";

            dgvDanhSachMuon.Columns["IDMuon"].Width = 60;
            dgvDanhSachMuon.Columns["IDSach"].Width = 60;
            dgvDanhSachMuon.Columns["TenSach"].Width = 150;
            dgvDanhSachMuon.Columns["HoTen"].Width = 150;
            dgvDanhSachMuon.Columns["SDT"].Width = 100;
        }

        private void LoadTheLoai()
        {
            TheLoaiBL theLoaiBl = new TheLoaiBL();
            cbbTheLoai.DisplayMember = "TheLoai";
            cbbTheLoai.ValueMember = "IDTheLoai";
            cbbTheLoai.DataSource = theLoaiBl.GetAll();
            TacGiaBL tacGiaBL = new TacGiaBL();
            cbbTacGia.DisplayMember = "TacGia";
            cbbTacGia.ValueMember = "IDTacGia";
            cbbTacGia.DataSource = tacGiaBL.GetAll();
        }

        private void LoadSach()
        {
            SachBL sachBL = new SachBL();
            DataTable dtsach = sachBL.GetAll();
            dgvSach.DataSource = dtsach;
            CustomizeDataGridViewColumns1();
            lblTong.Text = $"Tổng số sách: {dtsach.Rows.Count}";
        }

        private void LoadDSMuon()
        {
            DSMuonBL dSMuonBL = new DSMuonBL();
            DataTable dtDSMuon = dSMuonBL.GetAll();
            dgvDanhSachMuon.DataSource = dtDSMuon;
            CustomizeDataGridViewColumns2();
            lblTongMuon.Text = $"Tổng số sách đã cho mượn và mượn: {dtDSMuon.Rows.Count}";
        }

        private void Form_chinh_Load(object sender, EventArgs e)
        {
            LoadSach();
            LoadDSMuon();
            LoadTheLoai();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemSach addsachForm = new frmThemSach();
            addsachForm.TopMost = true;
            addsachForm.ShowDialog();
            addsachForm.Activate();
            LoadSach();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void thêmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia form = new frmTacGia();
            form.TopMost = true;
            form.Show();
            form.Activate();
        }

        private void thêmChủĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThemChuDe form = new FrmThemChuDe();
            form.TopMost = true;
            form.Show();
            form.Activate();
        }

        private void choMượnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSach.SelectedRows[0];
                string IDSach = selectedRow.Cells["IDSach"].Value.ToString();
                string tenSach = selectedRow.Cells["TenSach"].Value.ToString();

                Frm_ChoMuon form2 = new Frm_ChoMuon();
                form2.TopMost = true;
                form2.Activate();
                form2.SetSach(IDSach, tenSach);

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DSMuonBL dSMuonBL = new DSMuonBL();
                        var thongtin = form2.LayTTSach();
                        DSMuon_ ds = new DSMuon_();
                        ds.IDSach = thongtin.Item1;
                        ds.TenSach = thongtin.Item2;
                        ds.HoTen = thongtin.Item3;
                        ds.SDT = thongtin.Item4;
                        ds.DiaChi = thongtin.Item5;
                        ds.DaTra = thongtin.Item6 != 0;
                        ds.NgayMuon = thongtin.Item7;
                        ds.NgayTra = thongtin.Item8;

                        if (dSMuonBL.Insert(ds) > 0)
                        {
                            MessageBox.Show("Thêm thông tin sách thành công!");
                            LoadDSMuon();
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được thông tin sách.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trước.");
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSach.SelectedRows[0];
                string IDSach = selectedRow.Cells["IDSach"].Value.ToString(); // Get IDSach from selected row

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SachBL sachBL = new SachBL();
                    int actionResult = sachBL.Delete(IDSach); // Call Delete method in SachBL

                    if (actionResult > 0) // 1 indicates success in deletion
                    {
                        MessageBox.Show("Xoá sách thành công");
                        LoadSach(); // Reload the list of books after successful deletion
                    }
                    else
                    {
                        MessageBox.Show("Xoá sách không thành công. Vui lòng thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }





        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMuon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSachMuon.SelectedRows[0];
                int IDMuon = Convert.ToInt32(selectedRow.Cells["IDMuon"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DSMuonBL DA = new DSMuonBL();
            
                    int actionResult = DA.Delete(IDMuon); // Call Delete method in SachBL

                    if (actionResult > 0) // Assuming 1 means success in deletion
                    {
                        MessageBox.Show("Xoá sách mượn thành công");
                        LoadDSMuon(); // Reload the list of books after successful deletion
                    }
                    else
                    {
                        MessageBox.Show("Xoá sách mượn không thành công. Vui lòng thử lại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
            LoadDSMuon();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add functionality if necessary
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
{
    // Kiểm tra xem có dòng nào được chọn trong DataGridView hay không
    if (dgvDanhSachMuon.SelectedRows.Count > 0)
    {
        DataGridViewRow selectedRow = dgvDanhSachMuon.SelectedRows[0];

        // Lấy dữ liệu từ dòng được chọn
        DSMuon_ dsMuon = new DSMuon_()
        {
            IDMuon = Convert.ToInt32(selectedRow.Cells["IDMuon"].Value),
    IDSach = selectedRow.Cells["IDSach"].Value.ToString(),
    TenSach = selectedRow.Cells["TenSach"].Value.ToString(),
    HoTen = selectedRow.Cells["HoTen"].Value.ToString(),
    SDT = selectedRow.Cells["SDT"].Value.ToString(),
    ChoMuon = selectedRow.Cells["ChoMuon"].Value != DBNull.Value ? (bool?)selectedRow.Cells["ChoMuon"].Value : null,
    Muon = selectedRow.Cells["Muon"].Value != DBNull.Value ? (bool?)selectedRow.Cells["Muon"].Value : null,
    
    DiaChi = selectedRow.Cells["DiaChi"].Value != DBNull.Value ? selectedRow.Cells["DiaChi"].Value.ToString() : string.Empty,
    DaTra = selectedRow.Cells["DaTra"].Value != DBNull.Value ? (bool?)selectedRow.Cells["DaTra"].Value : null
        };

        // Hiển thị hộp thoại để chỉnh sửa thông tin
        using (Frm_ChoMuon formSua = new Frm_ChoMuon(dsMuon))
        {
            if (formSua.ShowDialog() == DialogResult.OK)
            {
                // Nếu người dùng bấm "Lưu" trong Frm_ChoMuon, tiến hành cập nhật
                DSMuon_ updatedDSMuon = formSua.UpdatedDSMuon;

                DSMuonBL dsMuonBL = new DSMuonBL();
                int result = dsMuonBL.Update(updatedDSMuon);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật danh sách mượn thành công!");
                    LoadDSMuon(); // Reload danh sách mượn
                }
                else
                {
                    MessageBox.Show("Cập nhật danh sách mượn thất bại!");
                }
            }
        }
    }
    else
    {
        MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa.");
    }
}

        private void dtpSeachTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntLoc_Click(object sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text; // Tên sách từ TextBox
            int? idTheLoai = (int?)cbbTheLoai.SelectedValue; // Thể loại từ ComboBox
            int? idTacGia = (int?)cbbTacGia.SelectedValue; // Tác giả từ ComboBox
            string ViTri = null;
            if (rdKeA.Checked) ViTri = rdKeA.Text;
            else
               if (rdKeB.Checked)ViTri = rdKeB.Text;
            else
               if (rdKeC.Checked)ViTri = rdKeC.Text;
            if (rdKeD.Checked) ViTri = rdKeD.Text;
            SachBL sachBL = new SachBL();
            // Lọc dữ liệu và trả về DataTable
            DataTable dtFilteredSach = sachBL.Search(tenSach, idTheLoai, idTacGia,ViTri);

            // Hiển thị DataTable lên DataGridView
            dgvSach.DataSource = dtFilteredSach;
        }
    }
}
