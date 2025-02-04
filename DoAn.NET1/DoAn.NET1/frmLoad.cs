using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET1
{
    public partial class frmLoad : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn { get; set; }

        public frmLoad(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            timer1.Enabled = true;
        }
        void NextForm()
        {
            frmLogin f = new frmLogin(conn);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoad_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            NextForm();
        }
    }
}