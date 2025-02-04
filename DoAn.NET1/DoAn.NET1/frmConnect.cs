using DevExpress.DataAccess;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
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
    public partial class frmConnect : DevExpress.XtraEditors.XtraForm
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        public void frmConnect_Load(object sender, EventArgs e)
        {
            cbXacThuc.Text = "Windows authentication";
            loadform();
            txbCSDL.Text = "QLSV";
        }
        void loadform()
        {
            if (txbTenMayChu.Text == Environment.MachineName + @"\SQLEXPRESS")
            {
                txbTenMayChu.Text = Environment.MachineName + @"\SQLEXPRESS";
            }
            else
            {
                txbTenMayChu.Text = Environment.MachineName;
            }
            if (cbXacThuc.Text == "Windows authentication")
            {
                lbTen.Enabled = false;
                lbMK.Enabled = false;
                txbTenNguoiDung.Enabled = false;
                txbMatKhau.Enabled = false;
            }
            else
            {
                lbTen.Enabled = true;
                lbMK.Enabled = true;
                txbTenNguoiDung.Enabled = true;
                txbMatKhau.Enabled = true;
            }
        }

        public void cbXacThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadform();
        }

        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            DataConnect.DataConnect conn = new DataConnect.DataConnect(txbTenMayChu.Text, txbCSDL.Text);
            try
            {
                conn.SqlConnectionWindowsAuthentication().Open();
                MessageBox.Show("Kết nối thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.SqlConnectionWindowsAuthentication().Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKetNoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataConnect.DataConnect conn = new DataConnect.DataConnect(txbTenMayChu.Text, txbCSDL.Text);
                conn.SqlConnectionWindowsAuthentication().Open();
                frmLoad f = new frmLoad(conn.SqlConnectionWindowsAuthentication());
                conn.SqlConnectionWindowsAuthentication().Close();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}