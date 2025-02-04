using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HocBong
    {
        private DAL_HocBong dal_hb = new DAL_HocBong();
        public IQueryable layDSHocBong()
        {
            return dal_hb.layDSBangDiem();
        }
        public IQueryable TimHocBong(string name)
        {
            return dal_hb.TimBangDiem(name);
        }
    }
}

