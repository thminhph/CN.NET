 using DALL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GiaoVien
    {
        private DAL_GiaoVien dal_sv = new DAL_GiaoVien();

        //Methods
        //LayDSSV
        public IQueryable LayGV()
        {
            return dal_sv.laydsgv();
        }
        public IEnumerable LayGVcb()
        {
            return dal_sv.laydsgvcb();
        }
        //ThemSV
        public bool ThemGV(DTO_GiaoVien sv)
        {
            return dal_sv.themGV(sv);
        }

        //XoaSV
        public bool XoaGV(string id)
        {
            return dal_sv.XoaGV(id);
        }

        //SuaSV
        public bool SuaGV(DTO_GiaoVien sv)
        {
            return dal_sv.SuaGV(sv);
        }

        //TimMSSV
        public IQueryable TimGV(string name)
        {
            return dal_sv.TimGV(name);
        }
        public IQueryable LayDSTKGV(string name)
        {
            return dal_sv.TimTKGV(name);
        }
    }
}
