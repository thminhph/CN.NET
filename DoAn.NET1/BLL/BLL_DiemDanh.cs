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
    public class BLL_DiemDanh
    {
        private DAL_DiemDanh dal_dd = new DAL_DiemDanh();
        public IQueryable layDSDiemDanh()
        {
            return dal_dd.layDSDiemDanh();
        }
        public IEnumerable laymSV()
        {
            return dal_dd.layDSmSV();
        }
        public IQueryable TimSV(string name)
        {
            return dal_dd.TimSV(name);
        }
        public bool themDiemDanh(DTO_DiemDanh dd)
        {
            return dal_dd.ThemDiemDanh(dd);
        }
        public bool XoaDiemDanh(string id)
        {
            return dal_dd.XoaDiemDanh(id);
        }
        public bool SuaDiemDanh(DTO_DiemDanh dd)
        {
            return dal_dd.SuaDiemDanh(dd);
        }

        public IQueryable TimDiemDanh(string name)
        {
            return dal_dd.TimDiemDanh(name);
        }
    }
}
