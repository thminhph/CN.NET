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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        private string tenDN { get; set; }
        private string passHT { get; set; }
        private SqlConnection conn { get; set; }



        public frmChangePass(SqlConnection conn, string tenDN, string passHT)
        {
            InitializeComponent();
            this.tenDN = tenDN;
            this.passHT = passHT;
            this.conn = conn;
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            
            if(txtPass.Text== passHT)
            {
                clsDangNhap dpass = new clsDangNhap(tenDN, txtPassWord.Text);
                dpass.doiMK(conn);
                MessageBox.Show("đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng !!!");
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

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUser.Text = tenDN;
            txtUser.Enabled = false;
        }
    }
}