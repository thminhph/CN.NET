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
    public partial class frmHocBong : DevExpress.XtraEditors.XtraForm
    {
        BLL_HocBong hb;
        public frmHocBong()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            hb = new BLL_HocBong();
            dgvHocBong.DataSource = hb.layDSHocBong();
        }
        private void frmHocBong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHocBong_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}