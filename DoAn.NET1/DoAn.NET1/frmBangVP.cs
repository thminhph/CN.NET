using BLL;
using DevExpress.Data.Linq.Helpers;
using DevExpress.DirectX.NativeInterop.DXGI;
using DevExpress.XtraBars.ViewInfo;
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
    public partial class frmBangVP : DevExpress.XtraEditors.XtraForm
    {
        public frmBangVP()
        {
            InitializeComponent();
        }
        BLL_BangViPham bll_viPham;
        DTO_BangViPham dto_viPham;
        BLL_SinhVien bll_sinhVien;
        private frmBangVP frmbangVP;

        public void Load_BVP()
        {
            bll_viPham=new BLL_BangViPham();
            gridControl1.DataSource = bll_viPham.layDSBangViPham();
            txtMaSV.DataSource = bll_viPham.laymSV();
            txtMaSV.DisplayMember = "maSV";
            txtMaSV.ValueMember = "maSV";
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_BVP();
        }

        private void frmBangVP_Load(object sender, EventArgs e)
        {
            Load_BVP();
           
        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DTO_BangViPham bvp = new DTO_BangViPham(txtMaVP.Text, txtNoiDungVP.Text, txtMaSV.Text, txtMaHP.Text);
            if(bvp.MaVP != string.Empty)
            {
                IQueryable temp = bll_viPham.TimBangViPham(txtMaVP.Text);
                if (temp.Count() == 0)
                {
                    bll_viPham.ThemBangViPham(bvp);
                    Load_BVP();
                    txtMaVP.Text = string.Empty;
                    txtNoiDungVP.Text = string.Empty;
                    txtMaSV.Text = string.Empty;
                    txtMaHP.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo",
             MessageBoxButtons.OK,
             MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên không hợp lệ!", "Thông báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        }

        private void txtNoiDungVP_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void stbnCapNhap_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin vi phạm  -{txtMaVP.Text}- không?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_BangViPham bvp = new DTO_BangViPham(txtMaVP.Text, txtNoiDungVP.Text, txtMaSV.Text,txtMaHP.Text);
                bll_viPham.SuaBangViPham(bvp);

            }
        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa vi phạm -{txtMaVP.Text}- không?", "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bll_viPham.XoaBangViPham(txtMaVP.Text);

            }
        }

        private void stbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMaSV.SelectedItem != null)
            {
                for (int i = 0; i < txtMaSV.Items.Count; i++)
                {
                    txtMaHP.DataSource = bll_viPham.TimSV(txtMaSV.Text);
                    txtMaHP.DisplayMember = "maHP";
                    txtMaHP.ValueMember = "maHP";
                }
            }
        }
    }
}