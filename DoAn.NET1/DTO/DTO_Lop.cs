using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string tenLop;
        private string maKhoa;


        public DTO_Lop(string tenLop, string maKhoa)
        {
            this.TenLop = tenLop;
            this.MaKhoa = maKhoa;

        }
        public DTO_Lop()
        {
           
        }

        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
