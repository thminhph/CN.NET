using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DAL_HocBong
    {
        private QLSVDataContext db;

        public DAL_HocBong()
        {
            this.db = new QLSVDataContext(Properties.Settings.Default.tspConnect);
        }
        public IQueryable layDSBangDiem()
        {
            IQueryable bangDiem = from s in db.bangDiems
                                  join k in db.hocPhans on s.maHP equals k.maHP
                                  join m in db.SinhViens on s.maSV equals m.maSV
                                  where s.diemTB>=8
                                  select new
                                  {
                                      s.maHP,
                                      k.tenHP,
                                      m.hoTenSV,
                                      k.tenHK,
                                      s.diemTB
                                  };
            return bangDiem;
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
