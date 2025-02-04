using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocPhan
    {
        private string maHP;
        private string tenHP;
        private int soTC;
        private string loaiHP;
        private int gia;
        private string tenHK;
        private string maKhoa;



        public DTO_HocPhan()
        {

        }

        public DTO_HocPhan(string maHP, string tenHP, int soTC, string loaiHP, int gia, string tenHK, string maKhoa)
        {
            this.maHP = maHP;
            this.tenHP = tenHP;
            this.soTC = soTC;
            this.loaiHP = loaiHP;
            this.gia = gia;
            this.tenHK = tenHK;
            this.maKhoa = maKhoa;

        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string TenHP { get => tenHP; set => tenHP = value; }
        public int SoTC { get => soTC; set => soTC = value; }
        public string LoaiHP { get => loaiHP; set => loaiHP = value; }
        public int Gia { get => gia; set => gia = value; }
        public string TenHK { get => tenHK; set => tenHK = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}

