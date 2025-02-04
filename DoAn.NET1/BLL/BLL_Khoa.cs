using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Khoa
    {
        private DAL_Khoa dal_kh = new DAL_Khoa();
        public IQueryable layDSKhoa()
        {
            return dal_kh.layDSKhoa();
        }
        public bool themKhoa(DTO_Khoa kh)
        {
            return dal_kh.ThemKhoa(kh);
        }
        public bool XoaKhoa(string id)
        {
            return dal_kh.XoaKhoa(id);
        }
        public bool SuaKhoa(DTO_Khoa kh)
        {
            return dal_kh.SuaKhoa(kh);
        }
        public  IQueryable TimKhoa(string name)
        {
            return dal_kh.TimKhoa(name);
        }
    }
}
