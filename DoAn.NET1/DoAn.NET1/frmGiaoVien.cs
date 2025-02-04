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

namespace DoAn.NET1
{
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        BLL_GiaoVien gv;
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        public List<string> LayDanhSachMaGV()
        {
            List<string> danhSachMaSV = new List<string>();

            // Lặp qua mỗi dòng trong gridControl và lấy giá trị từ cột cụ thể (ví dụ: cột "MaGV")
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object value = gridView1.GetRowCellValue(i, "maGV");
                if (value != null)
                {
                    danhSachMaSV.Add(value.ToString());
                }
            }

            return danhSachMaSV;
        }
        public void LoadData()
        {
            gv = new BLL_GiaoVien();
            gridControl1.DataSource = gv.LayGV();
            //s.txtMaSV.Focus();
            //s.txtMaSV.Enabled = true;
            //s.sbtnThem.Enabled = false;
            //s.sbtnXoa.Enabled = false;
            //s.stbnCapNhat.Enabled = false;

        }
        
        private void sbtnThem_Click(object sender, EventArgs e)
        {
            
        }


        private void frmGiaoVien_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}