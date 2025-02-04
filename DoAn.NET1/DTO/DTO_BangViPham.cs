using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangViPham
    {
        private string maVP;
        private string noidungVP;
        private string maSV;
        private string maHP;

       
        public DTO_BangViPham()
        {
           
        }

        public DTO_BangViPham(string maVP, string noidungVP, string maSV, string maHP)
        {
            this.maVP = maVP;
            this.noidungVP = noidungVP;
            this.maSV = maSV;
            this.maHP = maHP;
        }

        public string MaVP { get => maVP; set => maVP = value; }
        public string NoidungVP { get => noidungVP; set => noidungVP = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
    }
}
