using BLL;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Utils.Extensions;
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
    public partial class frmDiemDanh : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemDanh()
        {
            InitializeComponent();
        }
        BLL_DiemDanh diemDanh;
        BLL_SinhVien sinhVien;
        DTO_DiemDanh diem;
        
        public void Load_L()
        {
            sinhVien = new BLL_SinhVien();  
            diemDanh = new BLL_DiemDanh();
           gridControl1 .DataSource = diemDanh.layDSDiemDanh();
            gridControl2.DataSource = sinhVien.AN(DateTime.Now);
            txtMaSV.DataSource = diemDanh.laymSV();
            txtMaSV.DisplayMember = "maSV";
            txtMaSV.ValueMember = "maSV";
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_L();
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            Load_L();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             diem = new DTO_DiemDanh(txtMaSV.Text,txtMaHP.Text,int.Parse(cbST.Text),txtNgaySinh.DateTime);
            if (diem.MaHP != string.Empty)
            {
                IQueryable temp = diemDanh.TimDiemDanh(txtMaSV.Text);
                if (temp.Count() == 0)
                {
                    diemDanh.themDiemDanh(diem);
                    Load_L() ;
                    txtMaSV.Text = string.Empty;
                    txtMaHP.Text = string.Empty;
                    cbST.Text = string.Empty;
                    txtNgaySinh.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Sinh viên    đã có trong danh sách!", "Thông báo",
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

        private void gridControl2_Click(object sender, EventArgs e)
        {
            Load_L();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMaSV.SelectedItem != null)
            {
                for (int i = 0; i < txtMaSV.Items.Count; i++)
                {
                    txtMaHP.DataSource = diemDanh.TimSV(txtMaSV.Text);
                    txtMaHP.DisplayMember = "maHP";
                    txtMaHP.ValueMember = "maHP";
                }
            }
        }
    }
}