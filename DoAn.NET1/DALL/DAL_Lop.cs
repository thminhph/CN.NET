using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_Lop
    {
        private QLSVDataContext db;

        public DAL_Lop()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable layDSLop()
        {
            IQueryable lop = from s in db.SinhViens
                             join k in db.GiaoViens
                             on  s.maGV equals k.maGV
                             
                              select new
                              {
                                  s.hoTenSV,
                                  k.tenLop
                              };
            return lop;
        }
        public bool ThemLop(DTO_Lop lp)
        {
            try
            {
                Lop them = new Lop();
                {
                    them.tenLop = lp.TenLop;
                    them.maKhoa = lp.MaKhoa;
                };
                if (them.tenLop != string.Empty)
                {
                    db.Lops.InsertOnSubmit(them);
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
        public bool SuaLop(DTO_Lop lp)
        {
            try
            {
                Lop sua = db.Lops.Single(d => d.tenLop == lp.TenLop);
                if (sua.maKhoa != string.Empty)
                {
                    sua.tenLop = lp.TenLop;
                    sua.maKhoa = lp.MaKhoa;
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
        public bool XoaLop(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    {
                        var xoa = from s in db.Lops
                                  where s.tenLop == id
                                  select s;
                        foreach (var item in xoa)
                        {
                            db.Lops.DeleteOnSubmit(item);
                            db.SubmitChanges();
                        }
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo!",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return false;
        }
        public IQueryable TimLop(string name)
        {
            IQueryable temp = from s in db.Lops
                              where s.tenLop == name
                              select new
                              {
                                  s.tenLop,
                                  s.maKhoa,
                              };
            return temp;
        }
    }
}
