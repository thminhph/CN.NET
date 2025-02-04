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
    public partial class frmHocPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmHocPhan()
        {
            InitializeComponent();
        }
        BLL_BangDiem bd;
        BLL_DKHP hp;
        DTO_HocPhan hocphan;
        DTO_BangDiem diem;
        public void Load_L()
        {
            bd = new BLL_BangDiem();
            hp = new BLL_DKHP();
            gridControl1.DataSource = bd.AN(DateTime.Now); 
            gridControl2.DataSource = hp.layDSHocPhan();
            txtMaHP.DataSource = bd.laymSV();
            txtMaHP.DisplayMember = "maHP";
            txtMaHP.ValueMember = "maHP";
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            diem = new DTO_BangDiem(txtMaHP.Text, txtMaSV.Text,null, 0,0,0,txtNgaySinh.DateTime);
            if (diem.MaHP != string.Empty)
            {
                IQueryable temp = bd.TimSV(txtMaHP.Text);
                if (temp.Count() == 0 || temp.Count() != 0 )
                {
                    bd.ThemBangDiemHP(diem);
                    Load_L();
                    txtMaSV.Text = string.Empty;
                    txtMaHP.Text = string.Empty;
                    txtNgaySinh.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Sinh viên  đã có trong học phần này !", "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mã Sinh viên  không hợp lệ!", "Thông báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
        }

        private void txtMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMaHP.SelectedItem != null)
            {
                for (int i = 0; i < txtMaHP.Items.Count; i++)
                {
                    txtMaKhoa.DataSource = hp.LayKH(txtMaHP.Text);
                    txtMaKhoa.DisplayMember = "maKhoa";
                    txtMaKhoa.ValueMember = "maKhoa";
                }
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            Load_L();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_L();
        }

        private void txtMaHP_EditValueChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}