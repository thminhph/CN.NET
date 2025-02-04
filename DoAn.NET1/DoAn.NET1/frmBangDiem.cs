using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace DoAn.NET1
{
    public partial class frmBangDiem : DevExpress.XtraEditors.XtraForm
    {

        public frmBangDiem()
        {
            InitializeComponent();
        }
        BLL_BangDiem bangDiem;
        public void Load_Bangdiem()
        {
            bangDiem = new BLL_BangDiem();
            gridControl1.DataSource = bangDiem.layDSBangDiem();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_Bangdiem();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            Load_Bangdiem();
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }
    }
}