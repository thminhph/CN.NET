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
    public partial class frmChucNangKhoa : DevExpress.XtraEditors.XtraForm
    {
        public frmChucNangKhoa()
        {
            InitializeComponent();
        }
        private BLL_Khoa kh = new BLL_Khoa();
        private frmKhoa khs;
        private void frmChucNangKhoa_Load(object sender, EventArgs e)
        {
            khs = new frmKhoa();
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DTO_Khoa kH = new DTO_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
            if (kH.MaKhoa != string.Empty)
            {
                IQueryable temp = kh.TimKhoa(txtMaKhoa.Text);
                if (temp.Count() == 0)
                {
                    kh.themKhoa(kH);
                    txtMaKhoa.Text = string.Empty;
                    txtTenKhoa.Text = string.Empty;
                 
                    khs.Load_Khoa();
                }
                else
                {
                    MessageBox.Show("Khoa đã có trong danh sách!", "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mã khoa  không hợp lệ!", "Thông báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        }

        private void stbnCapNhap_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin khoa  -{txtMaKhoa.Text}- không?", "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_Khoa kH = new DTO_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
                kh.SuaKhoa(kH);

            }
        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa khoa -{txtMaKhoa.Text}- không?", "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                kh.XoaKhoa(txtMaKhoa.Text);

            }
        }

        private void stbnThoat_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
      
        private void cbmaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}