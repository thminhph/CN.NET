using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;


namespace DALL
{
    public  class DAL_SinhVien
    {
        private QLSVDataContext db;

        public DAL_SinhVien()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable laydssv()
        {
            IQueryable sv = from s in db.SinhViens
                            join k in db.GiaoViens
                            on s.maGV equals k.maGV
                            select new 
                            {
                                s.maSV,
                                s.hoTenSV,
                                s.gioitinh,
                                s.ngaySinh,
                                s.noiSinh,
                                s.sDT,
                                s.eMail,
                                s.maGV,
                                s.tenCV,
                                k.tenLop
                            };
            
            return sv;
        }
        
        public IQueryable An(DateTime name)
        {
            IQueryable query = from sv in db.SinhViens
                               join bd in db.bangDiems on sv.maSV equals bd.maSV
                               where !(from dd in db.diemDanhs
                                       where dd.maSV == sv.maSV && dd.thoiGian == name && dd.maHP == bd.maHP
                                       select dd).Any()
                               select new
                               {
                                   bd.maSV,
                                   bd.maHP,
                                   sv.hoTenSV,
                                   sv.ngaySinh
                               };

            return query;
        }
        public bool themSV(DTO_SinhVien sv)
        {
            try
            {
                SinhVien them = new SinhVien();
                {
                     them.maSV=sv.MaSV;
                     them.hoTenSV=sv.HoTenSV;
                     them.gioitinh=sv.Gioitinh;
                     them.ngaySinh=sv.NgaySinh;
                     them.noiSinh=sv.NoiSinh;
                     them.sDT=sv.SDT;
                     them.eMail=sv.EMail;
                     them.maGV=sv.MaGV;
                    them.tenCV = sv.TenCV;
                    them.tenLop = sv.TenLop;
                };
                if (them.maSV != string.Empty )
                {
                    db.SinhViens.InsertOnSubmit(them);
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
        public bool XoaSV(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.SinhViens
                              where s.maSV == id
                              select s;

                    foreach (var item in xoa)
                    {
                        db.SinhViens.DeleteOnSubmit(item);
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
        public bool SuaSV(DTO_SinhVien sv)
        {
            try
            {
                SinhVien sua = db.SinhViens.Single(d => d.maSV == sv.MaSV);

                if (sua.maSV != string.Empty)
                {
                    sua.hoTenSV = sv.HoTenSV;
                    sua.gioitinh = sv.Gioitinh;
                    sua.ngaySinh = sv.NgaySinh;
                    sua.noiSinh = sv.NoiSinh;
                    sua.sDT = sv.SDT;
                    sua.eMail = sv.EMail;
                    sua.maGV = sv.MaGV;
                    sua.tenLop = sv.TenLop;
                    sua.tenCV = sv.TenCV;

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
        public IQueryable TimMSSV(string name)
        {
            IQueryable temp = from s in db.SinhViens
                              where s.maSV == name
                              select new
                              {
                                  s.maSV,
                                  s.hoTenSV,
                                  s.gioitinh,
                                  s.ngaySinh.Value,
                                  s.noiSinh,
                                  s.sDT,
                                  s.eMail,
                                  s.maGV,
                                  s.tenLop,
                                  s.tenCV,
                              };
            return temp;
        }
        public IQueryable TimTKSV(string name)
        {
            IQueryable temp = from s in db.SinhViens
                              where s.maSV == name
                              select new
                              {
                                  s.maSV,
                                  s.passTK 
                              };
            return temp;
        }
        public IQueryable laydsgv()
        {
            IQueryable sv = from s in db.GiaoViens
                             select s;

            return sv;
        }
    }
}
