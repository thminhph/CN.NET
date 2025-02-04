using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
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
    public partial class frmThongTinSV : DevExpress.XtraEditors.XtraForm
    {
        BLL_SinhVien sv;
        public frmThongTinSV()
        {
            InitializeComponent();
        }


        frmSinhVien s;
        public void LoadData()
        {
            sv = new BLL_SinhVien();
          
            gridControl1.DataSource =sv.LayDSSV();
            

        }
        private void frmThongTinSV_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(770,343);
            LoadData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            LoadData();
           
        }
        
        public List<string> LayDanhSachMaSV()
        {
            List<string> danhSachMaSV = new List<string>();

            // Lặp qua mỗi dòng trong gridControl và lấy giá trị từ cột cụ thể (ví dụ: cột "MaSV")
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object value = gridView1.GetRowCellValue(i, "maSV");
                if (value != null)
                {
                    danhSachMaSV.Add(value.ToString());
                }
            }

            return danhSachMaSV;
        }
    }
}