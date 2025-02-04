using DALL;
using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_BangDiem
    {
       
            private DAL_BangDiem dal_bd = new DAL_BangDiem();
            public IQueryable layDSBangDiem()
            {
                return dal_bd.layDSBangDiem();
            }
        public IEnumerable laymSV()
        {
            return dal_bd.layDSmSV();
        }
        public IEnumerable layDmSV()
        {
            return dal_bd.laymSV();
        }
        public IQueryable TimSV(string name)
        {
            return dal_bd.TimSV(name);
        }
        public bool ThemBangDiem(DTO_BangDiem bd)
            {
                return dal_bd.ThemBangDiem(bd);
            }
        public bool ThemBangDiemHP(DTO_BangDiem bd)
        {
            return dal_bd.ThemBangDiemHP(bd);
        }
        public bool XoaBangDiem(string id)
            {
                return dal_bd.XoaBangDiem(id);
            }
            public bool SuaBangDiem(DTO_BangDiem bd)
            {
                return dal_bd.SuaBangDiem(bd);
            }
        public IQueryable AN(DateTime name)
        {
            return dal_bd.An(name);
        }
        public IQueryable TimBangDiem(string name)
            {
                return dal_bd.TimBangDiem(name);
            }
    
    }
    }

