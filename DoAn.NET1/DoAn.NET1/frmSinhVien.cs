using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DevExpress.Data.Linq.Helpers;

namespace DoAn.NET1
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private BLL_SinhVien svs = new BLL_SinhVien();

        private frmThongTinSV tv;
        private void frmSInhVien_Load(object sender, EventArgs e)
        {
            tv = new frmThongTinSV();
            txtmaGV.DataSource = svs.LayDSGV();
            txtmaGV.DisplayMember = "maGV";
            txtmaGV.ValueMember = "maGV";
        }
        

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DTO_SinhVien sv = new DTO_SinhVien(txtMaSV.Text, txtTenSV.Text, txtGioiTinh.Text, txtNgaySinh.DateTime, txtNoiSinh.Text,txtSdt.Text, txtEmail.Text, txtmaGV.Text, cbMaChucVu.Text, null,null);
            if (sv.MaSV != string.Empty)
            {
                IQueryable temp = svs.TimMSSV(txtMaSV.Text);
                if (temp.Count() == 0)
                {
                    svs.ThemSV(sv);
                    txtMaSV.Text = string.Empty;
                    txtTenSV.Text = string.Empty; 
                    txtGioiTinh.Text = string.Empty; 
                    txtNgaySinh.DateTime = DateTime.Now; 
                    txtNoiSinh.Text = string.Empty; 
                    txtSdt.Text = string.Empty; 
                    txtEmail.Text = string.Empty;
                    txtmaGV.Text = string.Empty;
                    cbMaChucVu.Text = string.Empty;
                    tv.LoadData();
                }
                else
                {
                    MessageBox.Show("MSSV đã có trong dssv!", "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("MSSV không hợp lệ!", "Thông báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        

        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa sv -{txtMaSV.Text}- không?", "Thông báo",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                svs.XoaSV(txtMaSV.Text);
                
            }
        }

        private void stbnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa ttsv -{txtMaSV.Text}- không?", "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_SinhVien sv = new DTO_SinhVien(txtMaSV.Text, txtTenSV.Text, txtGioiTinh.Text, txtNgaySinh.DateTime, txtNoiSinh.Text, txtSdt.Text, txtEmail.Text, txtmaGV.Text, cbMaChucVu.Text, null, null);
                svs.SuaSV(sv);
                
            }
        }

        private void stbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}