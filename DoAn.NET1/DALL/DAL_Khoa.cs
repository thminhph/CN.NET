using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_Khoa
    {
        private QLSVDataContext db;

        public DAL_Khoa()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable layDSKhoa()
        {
            IQueryable khoa = from s in db.khoas
                              select new
                              {
                                  s.maKhoa,
                                  s.tenKhoa,
                                  
                              };
            return khoa;
        }
        public bool ThemKhoa(DTO_Khoa kh)
        {
            try
            {
                khoa them = new khoa();
                {
                    them.maKhoa = kh.MaKhoa;
                    them.tenKhoa = kh.TenKhoa;
                   
                };
                if (them.maKhoa != string.Empty)
                {
                    db.khoas.InsertOnSubmit(them);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool SuaKhoa(DTO_Khoa kh)
        {
            try
            {
                khoa sua = db.khoas.Single(d => d.maKhoa == kh.MaKhoa);
                if(sua.maKhoa != string.Empty)
                {
                    sua.maKhoa = kh.MaKhoa;
                    sua.tenKhoa = kh.TenKhoa;
                 
                    db.SubmitChanges();
                    MessageBox.Show("Sửa Thành Công!", "Thông Báo!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool XoaKhoa(string id)
        {
                try
                {
                    if (id != string.Empty)
                    {  
                        var xoa = from s in db.khoas
                                    where s.maKhoa == id
                                    select s;
                        foreach (var item in xoa)
                        {
                            db.khoas.DeleteOnSubmit(item);
                            db.SubmitChanges();
                        }
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo!",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        return true;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return false;
        }
        public IQueryable TimKhoa(string name)
        {
            IQueryable temp = from s in db.khoas
                              where s.maKhoa == name
                              select new
                              {
                                  s.maKhoa,
                                  s.tenKhoa,
                               
                              };
            return temp;
        }
    }
}
    

