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
    public partial class frmChuacNangGV : DevExpress.XtraEditors.XtraForm
    {
        public frmChuacNangGV()
        {
            InitializeComponent();
        }
        private BLL_GiaoVien svs = new BLL_GiaoVien();

        private frmGiaoVien Gv;

        private void txtNgaySinh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void frmChuacNangGV_Load(object sender, EventArgs e)
        {
            Gv = new frmGiaoVien();
            txtKhoa.DataSource = svs.LayGVcb();
            txtKhoa.DisplayMember = "maKhoa";
            txtKhoa.ValueMember = "maKhoa";
        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DTO_GiaoVien sv = new DTO_GiaoVien(txtmaGV.Text, txtHoTen.Text, cbGioiTinh.Text, txtNgaySinh.DateTime, null,txtSDT.Text, txtEmail.Text, cbChucVu.Text, cbLop.Text, txtKhoa.Text, null);
            if (sv.MaGV != string.Empty)
            {
                IQueryable temp = svs.TimGV(txtmaGV.Text);
                if (temp.Count() == 0)
                {
                    svs.ThemGV(sv);
                    Gv.LoadData();
                    txtmaGV.Text = string.Empty;
                    txtHoTen.Text = string.Empty;
                    cbGioiTinh.Text = string.Empty;
                    txtNgaySinh.DateTime = DateTime.Now;
                    txtSDT.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    cbChucVu.Text = string.Empty;
                    cbLop.Text = string.Empty;
                   
                    
                }
                else
                {
                    MessageBox.Show("MGV đã có trong dssv!", "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("MGV không hợp lệ!", "Thông báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }


        }

        private void stbnCapNhap_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa ttsv -{txtmaGV.Text}- không?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_GiaoVien sv = new DTO_GiaoVien(txtmaGV.Text, txtHoTen.Text, cbGioiTinh.Text, txtNgaySinh.DateTime, null, txtSDT.Text, txtEmail.Text, cbChucVu.Text, cbLop.Text,  txtKhoa.Text, null);
                svs.SuaGV(sv);
                Gv.LoadData();
            }

        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa sv -{txtmaGV.Text}- không?", "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                svs.XoaGV(txtmaGV.Text);
                Gv.LoadData();

            }
           
        }

        private void stbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void txtKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}