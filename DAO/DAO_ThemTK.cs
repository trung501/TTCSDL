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
    public class DAO_ThemTK : DBProvider
    {
        public DataTable getAllTaiKhoan()
        {
            string query = "SELECT * FROM TAIKHOAN";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string GetLastestMATHANHVIEN()
        {
            string query = "SELECT TOP(1) MATHANHVIEN FROM TAIKHOAN ORDER BY MATHANHVIEN DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public bool InsertTaiKhoan(DTO_ThemTK tk)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_InsertTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MATHANHVIEN", tk.MATHANHVIEN);
                cmd.Parameters.AddWithValue("@CHUCVU", tk.CHUCVU);
                cmd.Parameters.AddWithValue("@HOTEN", tk.HOTEN);
                cmd.Parameters.AddWithValue("@NGAYSINH", tk.NGAYSINH);
                cmd.Parameters.AddWithValue("@SDT", tk.SDT);
                cmd.Parameters.AddWithValue("@DIACHI", tk.DIACHI);
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
        
        public string GetHoTenFromTAIKHOAN(string maTK)
        {
            string query = @"SELECT tk.HOTEN 
                            FROM TAIKHOAN tk 
                            WHERE tk.MATHANHVIEN = @MATHANHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

            da.SelectCommand.Parameters.AddWithValue("@MATHANHVIEN", maTK);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return "";
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

        public DataTable GetAllTaiKhoanInfo(string maTK)
        {
            SqlDataReader rd;
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetTaiKhoanInfo", _conn);
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
                cmd.Parameters.AddWithValue("@MATHANHVIEN", tktp.MATHANHVIEN);
                cmd.Parameters.AddWithValue("@CHUCVU", tktp.CHUCVU);
                cmd.Parameters.AddWithValue("@HOTEN", tktp.HOTEN);
                cmd.Parameters.AddWithValue("@NGAYSINH", tktp.NGAYSINH);
                cmd.Parameters.AddWithValue("@SDT", tktp.SDT);
                cmd.Parameters.AddWithValue("@DIACHI", tktp.DIACHI);
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
