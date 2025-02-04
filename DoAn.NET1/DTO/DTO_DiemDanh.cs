using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DiemDanh
    {
        private string maSV;
        private string maHP;
        private int  sotiet;
        private DateTime thoiGian;



        public DTO_DiemDanh()
        {
            
        }

        public DTO_DiemDanh(string maSV, string maHP, int sotiet, DateTime thoiGian)
        {
            this.maSV = maSV;
            this.maHP = maHP;
            this.sotiet = sotiet;
            this.thoiGian = thoiGian;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public int Sotiet { get => sotiet; set => sotiet = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
    }
}
