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
    public class BLL_DKHP
    {
        private DAL_HocPhan dal_hp = new DAL_HocPhan();
        public IQueryable layDSHocPhan()
        {
            return dal_hp.layDSHocPhan();
        }
        public IEnumerable LaymaKH ()
        {
            return dal_hp.layDSKhoa();
        }
        public IEnumerable LayKH(string name)
        {
            return dal_hp.layKhoa( name);
        }
        public bool themHocPhan(DTO_HocPhan hp)
        {
            return dal_hp.ThemHocPhan(hp);
        }
        public bool XoaHocPhan(string id)
        {
            return dal_hp.XoaHocPhan(id);
        }
        public bool SuaHocPhan(DTO_HocPhan hp)
        {
            return dal_hp.SuaHocPhan(hp);
        }
        public IQueryable TimHocPhan(string name)
        {
            return dal_hp.TimHocPhan(name);
        }
    }
}
