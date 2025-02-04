using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string maSV;
        private string hoTenSV;
        private string gioitinh;
        private DateTime ngaySinh;
        private string noiSinh;
        private string  sDT;
        private string eMail;
        private string maGV;
        private string tenCV;
        private string tenLop;
        private string passTK;
        public DTO_SinhVien()
        {

        }

        public DTO_SinhVien(string maSV, string hoTenSV, string gioitinh, DateTime ngaySinh, string noiSinh, string sDT, string eMail, string maGV, string tenCV, string tenLop, string passTK)
        {
            this.maSV = maSV;
            this.hoTenSV = hoTenSV;
            this.gioitinh = gioitinh;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.sDT = sDT;
            this.eMail = eMail;
            this.maGV = maGV;
            this.tenCV = tenCV;
            this.tenLop = tenLop;
            this.passTK = passTK;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTenSV { get => hoTenSV; set => hoTenSV = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string PassTK { get => passTK; set => passTK = value; }
    }
}
