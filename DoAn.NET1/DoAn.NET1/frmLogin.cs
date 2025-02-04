using BLL;
using DevExpress.CodeParser;
using DevExpress.Data.Helpers;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using DevExpress.Utils;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DTO;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn { get; set; }
        public frmLogin(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            clsDangNhap DN = new clsDangNhap(txtUser.Text, txtPass.Text);
            if (CheckNhap())
            {
                int ID;
                if (cbQuyen.Text == "Giáo Viên")
                    ID = 1;
                else
                {
                    ID = 0;
                }
                if (DN.CheckDangNhap(conn, ID) == true)
                {
                    if (CheckRemember.Checked == true)
                    {
                        DN.NhoMK(conn);
                    }
                    else
                    {
                        DN.HuyNhoMK(conn);
                    }
                    frmMain f = new frmMain(conn,DN.TenDangNhap,DN.MatKhau,cbQuyen.Text);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    fLogin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool CheckNhap()
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            cbQuyen.Text = "Giáo Viên";
            clsDangNhap DN = new clsDangNhap();
            DataTable table = DN.LoadNhoMatKhau(conn);
            if (table.Rows[0][0].ToString() != "")
            {
                txtUser.Text = table.Rows[0][0].ToString();
                txtPass.Text = table.Rows[0][1].ToString();
                CheckRemember.Checked = true;

            }
            else
            {
                txtUser.Text = "";
                txtPass.Text = "";
                CheckRemember.Checked = true;
            }
        }

        private void CheckRemember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
 }
