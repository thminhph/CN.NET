using BLL;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET1
{
    public partial class frmChucNangDKHP : DevExpress.XtraEditors.XtraForm
    {
        public frmChucNangDKHP()
        {
            InitializeComponent();
        }
        private BLL_DKHP hp = new BLL_DKHP();
        private frmDanhsachHocPhan cn;
        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DTO_HocPhan hps = new DTO_HocPhan(txtMaHP.Text, txtTenHP.Text, int.Parse(txtSoTC.Text), txtLoaiHP.Text, int.Parse(txtGiaHP.Text), cbHocKi.Text, txtMaKhoa.Text);
            if (hps.MaHP != string.Empty)
            {
                IQueryable temp = hp.TimHocPhan(txtMaHP.Text);
                if (temp.Count() == 0)
                {
                    hp.themHocPhan(hps);
                    cn.Load_HP();
                    txtMaHP.Text = string.Empty;
                    txtTenHP.Text = string.Empty;
                    txtSoTC.Text = string.Empty;
                    txtGiaHP.Text = string.Empty;
                    cbHocKi.Text = string.Empty;
                    txtMaKhoa.Text = string.Empty;
                    
                }
                else
                {
                    MessageBox.Show("Học phần   đã có trong danh sách!", "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mã học phần không hợp lệ!", "Thông báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        }

        private void stbnCapNhap_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin học phần -{txtMaHP.Text}- không?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_HocPhan hps = new DTO_HocPhan(txtMaHP.Text, txtTenHP.Text, int.Parse(txtSoTC.Text), txtLoaiHP.Text, int.Parse(txtGiaHP.Text), cbHocKi.Text, txtMaKhoa.Text);
                hp.SuaHocPhan(hps);
            }
        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa học phần -{txtMaHP.Text}- không?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                hp.XoaHocPhan(txtMaHP.Text);

            }
        }

        private void stbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChucNangDKHP_Load(object sender, EventArgs e)
        {
            cn= new frmDanhsachHocPhan();
            txtMaKhoa.DataSource = hp.LaymaKH();
            txtMaKhoa.DisplayMember = "maKhoa";
            txtMaKhoa.ValueMember = "maKhoa";
        }
    }
}