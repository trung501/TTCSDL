﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTiemInfo
    {
        private string maPT;
        private string ngayTiem;
        private string tenKH;
        private string ngaySinh;
        private string gioiTinh;
        private string tieuSu;

        public string MaPT { get => maPT; set => maPT = value; }
        public string NgayTiem { get => ngayTiem; set => ngayTiem = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TieuSu { get => tieuSu; set => tieuSu = value; }

        public DTO_PhieuTiemInfo(string maPT, string ngayTiem, string tenKH, string ngaySinh, string gioiTinh, string tieuSu)
        {
            this.maPT = maPT;
            this.ngayTiem = ngayTiem;
            this.tenKH = tenKH;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.tieuSu = tieuSu;
        }
        public DTO_PhieuTiemInfo() { }
    }
}
