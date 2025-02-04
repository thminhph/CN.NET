using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAn.NET1.TaiKhoan
{
    internal interface IDangNhap
    {
        string TenDangNhap { get; set; }
        string MatKhau { get; set; }
        bool CheckDangNhap(SqlConnection conn, int ID);
        void NhoMK(SqlConnection conn);
        void HuyNhoMK(SqlConnection conn);
        DataTable LoadNhoMatKhau(SqlConnection conn);
    }
}
