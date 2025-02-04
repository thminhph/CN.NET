    using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DALL
{
    public class DAL_DiemDanh
    {
        private QLSVDataContext db;

        public DAL_DiemDanh()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable layDSDiemDanh()
        {
            IQueryable diemDanh = from s in db.diemDanhs
                              select new
                              {
                                  s.maSV,
                                  s.maHP,
                                  s.sotiet,
                                  s.thoiGian
                              };
            return diemDanh;
        }
        public IEnumerable layDSmSV()
        {
            IEnumerable hocPhan = from s in db.bangDiems
                                  join k in db.hocPhans
                                  on s.maHP equals k.maHP
                                  select s;
            return hocPhan;
        }
        public IQueryable TimSV(string name)
        {
            IQueryable temp = from s in db.bangDiems
                              where s.maSV == name
                              select new
                              {
                                  s.maHP
                              };
            return temp;
        }
        public bool ThemDiemDanh(DTO_DiemDanh dd)
        {
            try
            {
                diemDanh them = new diemDanh();
                {
                    them.maSV = dd.MaSV;
                    them.maHP = dd.MaHP;
                    them.sotiet = dd.Sotiet;
                    them.thoiGian = dd.ThoiGian;
                };
                if (them.maSV != string.Empty)
                {
                    db.diemDanhs.InsertOnSubmit(them);
                    db.SubmitChanges();
                    MessageBox.Show("Điểm  thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool SuaDiemDanh(DTO_DiemDanh dd)
        {
            try
            {
                diemDanh sua = db.diemDanhs.Single(d => d.maSV == dd.MaSV);
                if (sua.maSV != string.Empty)
                {
                    sua.maSV = dd.MaSV;
                    sua.maHP = dd.MaHP;
                    sua.sotiet = dd.Sotiet;
                    sua.thoiGian = dd.ThoiGian;

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
        public bool XoaDiemDanh(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.diemDanhs
                              where s.maSV == id
                              select s;
                    foreach (var item in xoa)
                    {
                        db.diemDanhs.DeleteOnSubmit(item);
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
        public IQueryable TimDiemDanh(string name)
        {
            IQueryable temp = from s in db.diemDanhs
                              where s.maSV == name
                              select new
                              {
                                  s.maSV,
                                  s.maHP,
                                  s.sotiet,
                                  s.thoiGian
                              };
            return temp;
        }
    }
}
