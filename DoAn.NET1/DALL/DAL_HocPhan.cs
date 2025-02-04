using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_HocPhan
    {
        private QLSVDataContext db;

        public DAL_HocPhan()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable layDSHocPhan()
        {
            IQueryable hocPhan = from s in db.hocPhans
                              select new
                              {
                                  s.maHP,
                                  s.tenHP,
                                  s.soTC,
                                  s.loaiHP,
                                  s.gia,
                                  s.tenHK,
                                  s.maKhoa,
                         
                              };
            return hocPhan;
        }
        public IEnumerable layDSKhoa()
        {
            IEnumerable khoa = from s in db.khoas
                              select new
                              {
                                  s.maKhoa
                              };
            return khoa;
        }
        public IEnumerable layKhoa(string name)
        {
            IEnumerable khoa = from s in db.hocPhans
                               where s.maHP == name
                               select new
                               {
                                   s.maKhoa
                               };
            return khoa;
        }
        public bool ThemHocPhan(DTO_HocPhan hp)
        {
            try
            {
                hocPhan them = new hocPhan();
                {
                    them.maHP = hp.MaHP;
                    them.tenHP = hp.TenHP;
                    them.soTC = hp.SoTC;
                    them.loaiHP = hp.LoaiHP;
                    them.gia = hp.Gia;
                    them.tenHK = hp.TenHK;
                    them.maKhoa = hp.MaKhoa;
                  
                };
                if (them.maHP != string.Empty)
                {
                    db.hocPhans.InsertOnSubmit(them);
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
        public bool SuaHocPhan(DTO_HocPhan hp)
        {
            try
            {
                hocPhan sua = db.hocPhans.Single(d => d.maHP == hp.MaHP);
                if (sua.maHP != string.Empty)
                {
                    sua.maHP = hp.MaHP;
                    sua.tenHP = hp.TenHP;
                    sua.soTC = hp.SoTC;
                    sua.loaiHP = hp.LoaiHP;
                    sua.gia = hp.Gia;
                    sua.tenHK = hp.TenHK;
                    sua.maKhoa = hp.MaKhoa;
                 
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
        public bool XoaHocPhan(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    {
                        var xoa = from s in db.hocPhans
                                  where s.maHP == id
                                  select s;
                        foreach (var item in xoa)
                        {
                            db.hocPhans.DeleteOnSubmit(item);
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
        public IQueryable TimHocPhan(string name)
        {
            IQueryable temp = from s in db.hocPhans
                              where s.maHP == name
                              select new
                              {
                                  s.maHP,
                                  s.tenHP,
                                  s.soTC,
                                  s.loaiHP,
                                  s.gia,
                                  s.tenHK,
                                  s.maKhoa,
                           
                              };
            return temp;
        }
    }
}
