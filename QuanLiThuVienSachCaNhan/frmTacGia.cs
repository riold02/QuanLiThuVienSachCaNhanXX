using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;
using Presentation;
using DataAccess;

namespace QuanLiThuVienSachCaNhan
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            DataTable ds = new DataTable();
            TacGiaBL tacGiaBL = new TacGiaBL();
            ds = tacGiaBL.GetAll();
         
            dgvTacGia.DataSource = ds;

                dgvTacGia.Columns["IDTacGia"].HeaderText = "ID Tác Giả";
                dgvTacGia.Columns["TacGia"].HeaderText = "Tác Giả";
                dgvTacGia.Columns["NamSinh"].HeaderText = "Năm Sinh";
                dgvTacGia.Columns["QuocTich"].HeaderText = "Quốc Tịch";

                dgvTacGia.Columns["IDTacGia"].Width = 100;
                dgvTacGia.Columns["TacGia"].Width = 200;
                dgvTacGia.Columns["NamSinh"].Width = 150;
                dgvTacGia.Columns["QuocTich"].Width = 150;
                lblTong.Text = $"Tổng số tác giả: {ds.Rows.Count}";
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            // Create and open a connection to your database
            TacGiaBL tacGiaBL = new TacGiaBL();
            TacGia_ temp = new TacGia_();

            temp.TacGia = txtTacGia.Text.Trim();
            temp.NamSinh = dtpNamSinh.Value;
            temp.QuocTich = txtQuocTich.Text.Trim();
            int rowsAffected = tacGiaBL.Insert(temp);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm tác giả thành công!");
                            LoadForm(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Thêm tác giả thất bại.");
                        }
                 
                
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvTacGia.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dgvTacGia.SelectedRows[0].Index;
                    DataGridViewRow row = dgvTacGia.Rows[rowIndex];
                    TacGiaBL tacGiaBL = new TacGiaBL();
                    TacGia_ temp = new TacGia_();
                    temp.IDTacGia = Convert.ToInt32(row.Cells["IDTacGia"].Value.ToString());

                    int rowsAffected = tacGiaBL.Delete(temp.IDTacGia);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa tác giả thành công!");
                        LoadForm(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả thất bại.");
                    }

                }

            }
            }

        }
    }

