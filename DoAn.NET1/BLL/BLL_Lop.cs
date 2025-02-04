using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Lop
    {
        private DAL_Lop dal_lop = new DAL_Lop();
        public IQueryable layDSLop()
        {
            return dal_lop.layDSLop();
        }
        
    }
}
