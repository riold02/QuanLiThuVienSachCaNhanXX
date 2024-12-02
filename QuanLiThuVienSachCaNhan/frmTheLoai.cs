using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;
using Presentation;
using DataAccess;

namespace QuanLiThuVienSachCaNhan
{
    public partial class FrmThemChuDe : Form
    {
        public FrmThemChuDe()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            DataTable ds = new DataTable();
            TheLoaiBL theLoaiBL = new TheLoaiBL();
            ds = theLoaiBL.GetAll();
            dgvTheLoai.DataSource = ds;

            dgvTheLoai.Columns["IDTheLoai"].HeaderText = "ID Thể Loại";
            dgvTheLoai.Columns["TheLoai"].HeaderText = "Thể Loại";

            dgvTheLoai.Columns["IDTheLoai"].Width = 250;
            dgvTheLoai.Columns["TheLoai"].Width = 250;

            lblTong.Text = $"Tổng số thể loại: {ds.Rows.Count}";

        }

        private void FrmThemChuDe_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            TheLoaiBL theLoaiBL = new TheLoaiBL();
            TheLoai_ temp = new TheLoai_();
            temp.TheLoai = txtTheLoai.Text.Trim();
            try
            {
                int rowsAffected = theLoaiBL.Insert(temp); ;
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm thể loại thành công!");
                    LoadForm(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Thêm thể loại thất bại.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Error");
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dgvTheLoai.SelectedRows[0].Index;
                    DataGridViewRow row = dgvTheLoai.Rows[rowIndex];
                    TheLoaiBL theLoaiBL = new TheLoaiBL();
                    TheLoai_ temp = new TheLoai_();
                    temp.IDTheLoai = Convert.ToInt32(row.Cells["IDTheLoai"].Value.ToString());

                    int rowsAffected = theLoaiBL.Delete(temp.IDTheLoai); 
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thể loại thành công!");
                            LoadForm(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa thể loại thất bại.");
                        }

                }
            }
        }
    }

 
}
