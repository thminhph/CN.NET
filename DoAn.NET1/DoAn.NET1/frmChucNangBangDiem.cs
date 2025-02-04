using BLL;
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
using DTO;
using DevExpress.Data.Linq.Helpers;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using DevExpress.XtraGrid.Views.Grid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.Data.Svg;

namespace DoAn.NET1
{
    public partial class frmChucNangBangDiem : DevExpress.XtraEditors.XtraForm
    {
        
        public frmChucNangBangDiem()
        {
            InitializeComponent();
            

        }
        
        private BLL_BangDiem bangDiem = new BLL_BangDiem();
        private frmBangDiem frm;
        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DTO_BangDiem diem = new DTO_BangDiem(cbMaHP.Text, txtMaSV.Text, null, float.Parse(txtDiemGK.Text), float.Parse(txtDiemCK.Text), float.Parse(txtDiemTB.Text), DateTime.Now);
            if (diem.MaHP != string.Empty)
            {
                IQueryable temp = bangDiem.TimBangDiem(cbMaHP.Text);
                if (temp.Count() == 0)
                {
                    bangDiem.ThemBangDiem(diem);
                    frm.Load_Bangdiem();
                    cbMaHP.Text = string.Empty;
                    txtMaSV.Text = string.Empty;
                    txtDiemGK.Text = string.Empty;
                    txtDiemCK.Text = string.Empty;
                    txtDiemTB.Text = string.Empty;
                    
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

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa học phần -{cbMaHP.Text}- không?", "Thông báo",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bangDiem.XoaBangDiem(cbMaHP.Text);

            }
        }

        private void stbnCapNhap_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn Nhập thông tin học phần -{cbMaHP.Text}- không?", "Thông báo",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_BangDiem diem = new DTO_BangDiem(cbMaHP.Text, txtMaSV.Text, null, float.Parse(txtDiemGK.Text), float.Parse(txtDiemCK.Text), float.Parse(txtDiemTB.Text),DateTime.Now);
                bangDiem.SuaBangDiem(diem);
            }
        }

        private void stbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string  diemTB(string a)
        {
            return a +=(float.Parse( txtDiemGK.Text.ToString()) + float.Parse(txtDiemCK.Text.ToString())*2)/3;

        }

        private void txtDiemCK_Leave(object sender, EventArgs e)
        {
            if (txtDiemTB.Text==string.Empty)
            {
              
                txtDiemTB.Text = diemTB(txtDiemTB.Text.ToString());
                
            }
            else
            {
                txtDiemTB.Text = string.Empty;
                if(txtDiemTB.Text == string.Empty)
                {
                    txtDiemTB.Text = diemTB(txtDiemTB.Text.ToString());
                }
            }
            
        }

        private void frmChucNangBangDiem_Load(object sender, EventArgs e)
        {
            frm = new frmBangDiem();
            txtMaSV.DataSource = bangDiem.layDmSV();
            txtMaSV.DisplayMember = "maSV";
            txtMaSV.ValueMember = "maSV";
        }

        private void cbMaHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}