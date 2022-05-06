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
        DAO_TaiKhoan dao = new DAO_TaiKhoan();
        public DataTable getAllTaiKhoan(string maQT, string pass)
        {
            return dao.getAllTaiKhoan(maQT, pass);
        }
        public string NextMATHANHVIEN()
        {
            return "test";
        }
        public bool InsertTaiKhoan(DTO_ThemTK tk)
        {
            return dao.InsertTaiKhoan(tk);
        }
        public string GetHoTenFromTaiKhoan(string maTK)
        {
            return dao.GetHoTenFromTaiKhoan(maTK);
        }
        public bool DeleteTaikhoan(string MaTK)
        {
            return dao.DeleteTaikhoan(MaTK);
        }
        public DataTable GetAllGeneralInfoTaiKhoan(string maTK)
        {
            return dao.GetAllGeneralInfoTaiKhoan(maTK);
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
