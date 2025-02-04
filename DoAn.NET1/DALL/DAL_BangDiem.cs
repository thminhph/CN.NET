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
    public class DAL_BangDiem
    {
        private QLSVDataContext db;

        public DAL_BangDiem()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }

        public IQueryable layDSBangDiem()
        {
            IQueryable bangDiem = from s in db.bangDiems
                                  join k in db.hocPhans
                                  on s.maHP equals k.maHP
                              select new
                              {
                                  s.maHP,
                                  s.maSV,
                                  k.tenHK,
                                  s.diemGK,
                                  s.diemCK,
                                  s.diemTB
                              };
            return bangDiem;
        }
        public IQueryable An(DateTime name)
{
           var query = from sv in db.bangDiems
                join bd in db.hocPhans on sv.maHP equals bd.maHP
                where !(from dd in db.hocPhans
                        where dd.tenHK == sv.tenHK && sv.thoigian == name && dd.maHP == bd.maHP
                        select dd).Any()
                select new
                {
                    sv.maSV,
                    bd.maHP,
                    sv.thoigian,
                    bd.maKhoa
                };
    return query;
}
        public IEnumerable layDSmSV()
        {
            IEnumerable hocPhan = from s in db.hocPhans
                                  join k in db.hocPhans
                                  on s.maHP equals k.maHP
                                  select s;
            return hocPhan;
        }
        public IEnumerable laymSV()
        {
            IEnumerable hocPhan = from s in db.SinhViens
                                  join i in db.bangDiems
                                  on s.maSV equals i.maSV
                                  select s;
            return hocPhan;
        }
        public IQueryable TimSV(string name)
        {
            IQueryable temp = from s in db.bangDiems
                              where s.maHP == name
                              select s;
                        
            return temp;
        }
        public bool ThemBangDiem(DTO_BangDiem bd)
        {
            try
            {
                bangDiem them = new bangDiem();
                {
                    them.maHP = bd.MaHP;
                    them.maSV = bd.MaSV;
                    them.tenHK = bd.TenHK;
                    them.diemGK = bd.DiemGK;
                    them.diemCK = bd.DiemCK;
                    them.diemTB = bd.DiemTB;
                };
                if (them.maSV != string.Empty)
                {
                    db.bangDiems.InsertOnSubmit(them);
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
        public bool ThemBangDiemHP(DTO_BangDiem bd)
        {
            try
            {
           
                bangDiem them = new bangDiem();
                {
                    them.maHP = bd.MaHP;
                    them.maSV = bd.MaSV;
                    them .thoigian = bd.ThoiGian;
                };
                if (them.maHP != string.Empty)
                {
                    db.bangDiems.InsertOnSubmit(them);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show( "Sinh viên  đã có trong học phần này !",ex.Message);
            }
            return false;
        }
        public bool SuaBangDiem(DTO_BangDiem bd)
        {
            try
            {
                bangDiem sua = db.bangDiems.Single(d => d.maSV==bd.MaSV);
                if (sua.maHP != string.Empty)
                {
                    sua.maHP = bd.MaHP;
                    sua.maSV = bd.MaSV;
                    sua.tenHK = bd.TenHK;
                    sua.diemGK = bd.DiemGK;
                    sua.diemCK = bd.DiemCK;
                    sua.diemTB = bd.DiemTB;

                    db.SubmitChanges();
                    MessageBox.Show("Nhập Thành Công!", "Thông Báo!",
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
        public bool XoaBangDiem(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.bangDiems
                              where s.maHP == id
                              select s;
                    foreach (var item in xoa)
                    {
                        db.bangDiems.DeleteOnSubmit(item);
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
        public IQueryable TimBangDiem(string name)
        {
            IQueryable temp = from s in db.bangDiems
                              where s.maSV == name
                              select new
                              {
                                  s.maHP,
                                  s.maSV,
                                  s.tenHK,
                                  s.diemGK,
                                  s.diemCK,
                                  s.diemTB
                              };
            return temp;
        }
        
    }
}
