
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
    public partial class frmDanhsachHocPhan : DevExpress.XtraEditors.XtraForm
    {
        
        public frmDanhsachHocPhan()
        {
            InitializeComponent();
        }
        BLL_DKHP hp;
        public void Load_HP()
        {
            hp = new BLL_DKHP();
            gridControl1.DataSource = hp.layDSHocPhan();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_HP();
        }

        private void frmDangKiHocPhan_Load(object sender, EventArgs e)
        {
            Load_HP();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmHocPhan es =new frmHocPhan();
            es.IsMdiContainer = true;
            es.ShowDialog();
        }
    }
}