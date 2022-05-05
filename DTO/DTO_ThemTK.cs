using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThemTK
    {
        private string maThanhVien;
        private string ChucVu;
        private string HoTen;
        private string NgaySinh;
        private string sdt;
        private string DiaChi;

        public DTO_ThemTK(string maThanhVien, string ChucVu, string HoTen, string NgaySinh, string sdt, string DiaChi)
        {
            this.maThanhVien = maThanhVien;
            this.ChucVu = ChucVu;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.sdt = sdt;
            this.DiaChi = DiaChi;
        }
       
        public string MATHANHVIEN { get => maThanhVien; set => maThanhVien = value; }
        public string CHUCVU { get => ChucVu; set => ChucVu = value; }
        public string HOTEN { get => HoTen; set => HoTen = value; }
        public string NGAYSINH { get => NgaySinh; set => NgaySinh = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string DIACHI { get => DiaChi; set => DiaChi = value; }

    }
}
