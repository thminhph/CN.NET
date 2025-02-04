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
    public class DAL_GiaoVien
    {
        private QLSVDataContext db;

        public DAL_GiaoVien()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable laydsgv()
        {
            IQueryable sv = from s in db.GiaoViens
                            join k in db.khoas
                            on s.maKhoa equals k.maKhoa 
                            select new
                            {
                                s.maGV,
                                s.hoTenGV,
                                s.gioitinh,
                                s.ngaySinh,
                                s.sDT,
                                s.eMail,
                                s.tenCV,
                                s.tenLop,
                                k.tenKhoa   
                            };

            return sv;
        }
        public IEnumerable  laydsgvcb()
        {
            IEnumerable sv = from s in db.khoas
                             select s;

            return sv;
        }
        public bool themGV(DTO_GiaoVien sv)
        {
            try
            {
                GiaoVien them = new GiaoVien();
                {
                    them.maGV = sv.MaGV;
                    them.hoTenGV = sv.HoTenGV;
                    them.gioitinh = sv.Gioitinh;
                    them.ngaySinh = sv.NgaySinh;
                    them.sDT = sv.SDT;
                    them.eMail = sv.EMail;
                    them.tenCV = sv.TenCV;
                    them.tenLop = sv.MaLop;
                    them.maKhoa = sv.MaKhoa;
                    
                };
                if (them.maGV != string.Empty)
                {
                    db.GiaoViens.InsertOnSubmit(them);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo!",
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
        public bool XoaGV(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.GiaoViens
                              join k in db.khoas
                              on s.maKhoa equals k.maKhoa
                              where s.maGV == id
                              select s;

                    foreach (var item in xoa)
                    {
                        db.GiaoViens.DeleteOnSubmit(item);
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
        public bool SuaGV(DTO_GiaoVien sv)
        {
            try
            {
                GiaoVien sua = db.GiaoViens.Single(d => d.maGV == sv.MaGV);

                if (sua.maGV != string.Empty)
                {
                    sua.tenCV = sv.HoTenGV;
                    sua.gioitinh = sv.Gioitinh;
                    sua.ngaySinh = sv.NgaySinh;
                    sua.sDT = sv.SDT;
                    sua.eMail = sv.EMail;
                    sua.tenCV = sv.TenCV;
                    sua.tenLop = sv.MaLop;
                    sua.maKhoa = sv.MaKhoa;
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
        public IQueryable TimGV(string name)
        {
            IQueryable temp = from s in db.GiaoViens
                              where s.maGV == name
                              select new
                              {
                                  s.maGV,
                                  s.hoTenGV,
                                  s.gioitinh,
                                  s.ngaySinh,
                                  s.sDT,
                                  s.eMail,
                                  s.tenCV,
                                  s.tenLop,
                                  s.maKhoa
                              };
            return temp;
        }
      
        
            
        public IQueryable TimTKGV(string name)
        {
            IQueryable temp = from s in db.GiaoViens
                              where s.maGV == name
                              select new
                              {
                                  s.maGV,
                                  s.passTK
                              };
            return temp;
        }
    }
}
