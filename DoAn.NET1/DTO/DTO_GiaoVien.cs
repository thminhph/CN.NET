using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoVien
    {
        private string maGV;
        private string hoTenGV;
        private string gioitinh;
        private DateTime ngaySinh;
        private string noiSinh;
        private string sDT;
        private string eMail;
        private string tenCV;
        private string maLop;
        private string maKhoa;
        private string passTK;

        public DTO_GiaoVien()
        {

        }

        public DTO_GiaoVien(string maGV, string hoTenGV, string gioitinh, DateTime ngaySinh, string noiSinh, string sDT, string eMail, string tenCV, string maLop, string maKhoa, string passTK)
        {
            this.maGV = maGV;
            this.hoTenGV = hoTenGV;
            this.gioitinh = gioitinh;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.sDT = sDT;
            this.eMail = eMail;
            this.tenCV = tenCV;
            this.maLop = maLop;
            this.maKhoa = maKhoa;
            this.passTK = passTK;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string HoTenGV { get => hoTenGV; set => hoTenGV = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string PassTK { get => passTK; set => passTK = value; }
    }
}
