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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        BLL_Khoa kh;

        public frmKhoa()
        {
            InitializeComponent();
        }
        public void Load_Khoa()
        {
            kh = new BLL_Khoa();
            gridControl1.DataSource = kh.layDSKhoa();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_Khoa();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            Load_Khoa();
        }
    }
}