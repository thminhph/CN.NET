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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        BLL_Lop l;
        public frmLop()
        {
            InitializeComponent();
        }
        public void Load_L()
        {
            l = new BLL_Lop();
            gridControl1.DataSource = l.layDSLop();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            Load_L();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_L();
        }
    }
}