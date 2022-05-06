﻿using System;
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
        DBProvider dp = new DBProvider();

        DAO_TaiKhoan dao = new DAO_TaiKhoan();
        public DataTable getAllTaiKhoan(string maQT, string pass)
        {
            return dao.getAllTaiKhoan(maQT, pass);
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
        public DataRow GetGeneralInfoTaiKhoan(string maTK)
        {
            return dao.GetGeneralInfoTaiKhoan(maTK);
        }
        public DataRow GetFullInfoTaiKhoan(string maTK)
        {
            return dao.GetFullInfoTaiKhoan(maTK);
        }
        public DataTable GetAllGeneralInfoTaiKhoan(string matk,string pass)
        {
            return dao.GetAllGeneralInfoTaiKhoan(matk,pass);
        }
        public bool UpdateTaiKhoanInfo(DTO_ThemTK tktp)
        {
            return dao.UpdateTaiKhoanInfo(tktp);
        }
        public bool CheckExistance(string maTK)
        {
            return dao.CheckExistance(maTK);
        }
        public string createHashPass(string userQT, string passQT, string newPass)
        {
            return dp.createHashPass(userQT, passQT, newPass);
        }

    }
}
