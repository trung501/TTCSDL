using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_ThemTK
    {
        DAO_ThemTK dao = new DAO_ThemTK();
        public DataTable getAllTaikhoan()
        {
            return dao.getAllTaiKhoan();
        }
        public string NextMATHANHVIEN()
        {
            string MATHANHVIEN = dao.GetLastestMATHANHVIEN().Trim();
            int count = MATHANHVIEN.Length - 2;
            int ptIndex = Convert.ToInt32(MATHANHVIEN.Substring(2)) + 1;
            MATHANHVIEN = "PT";
            for (int i = 0; i < count - ptIndex.ToString().Length; i++)
                MATHANHVIEN += "0";
            MATHANHVIEN += (ptIndex).ToString();
            return MATHANHVIEN;
        }
        public bool InsertTaiKhoan(DTO_ThemTK tk)
        {
            return dao.InsertTaiKhoan(tk);
        }
        public string GetHoTenFromTAIKHOAN(string maTK)
        {
            return dao.GetHoTenFromTAIKHOAN(maTK);
        }
        public bool DeleteTaikhoan(string MaTK)
        {
            return dao.DeleteTaikhoan(MaTK);
        }
        public DataTable GetAllTaiKhoanInfo(string maTK)
        {
            return dao.GetAllTaiKhoanInfo(maTK);
        }
        public bool UpdateTaiKhoanInfo(DTO_ThemTK tktp)
        {
            return dao.UpdateTaiKhoanInfo(tktp);
        }
        public bool CheckExistance(string maTK)
        {
            return dao.CheckExistance(maTK);
        }
    }
}
