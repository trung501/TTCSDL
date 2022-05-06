using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_TaiKhoan : DBProvider
    {
        public DataTable getAllTaiKhoan( string maQT, string pass)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_getAllTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maTK", maQT);
                cmd.Parameters.AddWithValue("@pass", pass);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
        
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }
       
        public bool InsertTaiKhoan(DTO_ThemTK tk)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_InsertTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MATK", tk.MATAIKHOAN);
                cmd.Parameters.AddWithValue("@CHUCVU", tk.CHUCVU);
                cmd.Parameters.AddWithValue("@HOTEN", tk.HOTEN);
                cmd.Parameters.AddWithValue("@NGAYSINH", tk.NGAYSINH);
                cmd.Parameters.AddWithValue("@SDT", tk.SDT);
                cmd.Parameters.AddWithValue("@DIACHI", tk.DIACHI);
                cmd.Parameters.AddWithValue("@CHUYENKHOA", tk.CHUYENKHOA);
                cmd.Parameters.AddWithValue("@BANGCAP", tk.BANGCAP);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        
        public string GetHoTenFromTaiKhoan(string maTK)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_GetHoTenFromTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MATK", maTK);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
               

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }


    
        public bool DeleteTaikhoan(string MaTK)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_DeleteTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MATHANHVIEN", MaTK);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public DataTable GetAllGeneralInfoTaiKhoan(string maTK)
        {
            SqlDataReader rd;
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetAllGeneralInfoTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MATHANHVIEN", maTK);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        public bool UpdateTaiKhoanInfo(DTO_ThemTK tktp)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_UpdateTaiKhoanInfo", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MATHANHVIEN", tktp.MATAIKHOAN);
                cmd.Parameters.AddWithValue("@CHUCVU", tktp.CHUCVU);
                cmd.Parameters.AddWithValue("@HOTEN", tktp.HOTEN);
                cmd.Parameters.AddWithValue("@NGAYSINH", tktp.NGAYSINH);
                cmd.Parameters.AddWithValue("@SDT", tktp.SDT);
                cmd.Parameters.AddWithValue("@DIACHI", tktp.DIACHI);
                cmd.Parameters.AddWithValue("@CHUYENKHOA", tktp.CHUYENKHOA);
                cmd.Parameters.AddWithValue("@BANGCAP", tktp.BANGCAP);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        

      

        public bool CheckExistance(string maTK)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE MATHANHVIEN = @MATHANHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MATHANHVIEN", maTK);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
    }
}
