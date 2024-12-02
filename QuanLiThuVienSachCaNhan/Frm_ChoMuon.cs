using Presentation;
using System;
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
    public partial class Frm_ChoMuon : Form
    {

        public Frm_ChoMuon()
        {
            InitializeComponent();
        }

        public DSMuon_ UpdatedDSMuon { get; set; }

        public Frm_ChoMuon(DSMuon_ dsMuon)
        {
            InitializeComponent();

            UpdatedDSMuon = dsMuon;

            // Gán giá trị cho các trường văn bản
            txtIDSach.Text = dsMuon.IDSach;
            txtHoTen.Text = dsMuon.HoTen;
            txtSDT.Text = dsMuon.SDT;

            // Chọn trạng thái cho radio button (Cho Mượn hoặc Mượn)
            if (dsMuon.ChoMuon == true)
                rdChoMuon.Checked = true;
            else
                rdMuon.Checked = true;

            // Gán giá trị cho Ngày Mượn
            dtpNgayMuon.Value = dsMuon.NgayMuon;

            // Kiểm tra giá trị Ngày Trả, nếu không phải null thì gán cho DateTimePicker
            if (dsMuon.NgayTra.HasValue)
                dtpNgayTra.Value = dsMuon.NgayTra.Value;  // Dùng .Value để lấy giá trị thực của Nullable<DateTime>

            // Gán giá trị cho địa chỉ
            txtDiaChi.Text = dsMuon.DiaChi;

            // Kiểm tra và gán giá trị cho CheckBox DaTra
            cbDaTra.Checked = dsMuon.DaTra.HasValue ? dsMuon.DaTra.Value : false;  // Nếu DaTra là null thì gán false

        }

        // Cập nhật thông tin khi bấm Lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatedDSMuon.HoTen = txtHoTen.Text;
            UpdatedDSMuon.SDT = txtSDT.Text;
            // Cập nhật các trường khác...

            DialogResult = DialogResult.OK;
            this.Close();
        }
        public void SetSach(string maSach, string tenSach)
        {
            txtIDSach.Text = maSach;
            txtTenSach.Text = tenSach;
     
        }
        public (string, string, string, string, string, int, DateTime, DateTime) LayTTSach()
        {
            int TinhTrang = rdChoMuon.Checked ? 0 : 1;
            DateTime NgayTra = dtpNgayTra.Value;
            DateTime NgayMuon = dtpNgayMuon.Value;

            return (txtIDSach.Text, txtTenSach.Text, txtHoTen.Text, txtSDT.Text, txtDiaChi.Text, TinhTrang, NgayMuon, NgayTra);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  
            this.Close();
        }

        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Frm_ChoMuon_Load(object sender, EventArgs e)
        {
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value =  DateTime.Now.AddDays(14);
        }
    }
}
