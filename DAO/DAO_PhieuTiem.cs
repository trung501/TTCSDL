using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_PhieuTiem : DBProvider
    {
        public DataTable getAllPhieuTiem()
        {
            string query = "SELECT * FROM PHIEUTIEM";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string GetLastestMAPHIEUTIEM()
        {
            string query = "SELECT TOP(1) MAPHIEUTIEM FROM PHIEUTIEM ORDER BY MAPHIEUTIEM DESC";
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

        public bool InsertPhieuTiem(DTO_PhieuTiem pt)
        {
            try
            {
                //_conn.Open();

                //string SQL = "INSERT INTO PHIEUTIEM " +
                //    "(MAPHIEUTIEM, MAKH, MABS) " +
                //    "VALUES " +
                //    "(@MAPHIEUTIEM, @MAKH, @MABS)";

                //SqlCommand cmd = new SqlCommand(SQL, _conn);

                //cmd.Parameters.AddWithValue("@MAPHIEUTIEM", pt.MAPHIEUTIEM);
                //cmd.Parameters.AddWithValue("@MAKH", pt.MAKH);
                //cmd.Parameters.AddWithValue("@MABS", pt.MABS);

                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;


                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_InsertPhieuTiem", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAPHIEUTIEM", pt.MAPHIEUTIEM);
                cmd.Parameters.AddWithValue("@NGAYTIEM", pt.NGAYTIEM);
                cmd.Parameters.AddWithValue("@MAKH", pt.MAKH);
                cmd.Parameters.AddWithValue("@MABS", pt.MABS);
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

        //public List<DTO_Vaccine> GetVCFromPHIEUTIEM(string maPT)
        //{ 
            //List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            //try
            //{
            //    _conn.Open();
            //    SqlCommand cmd = new SqlCommand("sp_GetVCFromPhieuTiem", _conn);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);

            //    SqlDataReader dataReader = cmd.ExecuteReader();
            //    while (dataReader.Read())
            //    {
            //        string maVC = dataReader[0].ToString();
            //        string tenVC = dataReader[1].ToString();
            //        string nhaSX = dataReader[2].ToString();
            //        string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
            //        string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
            //        string soLo = dataReader[5].ToString();
            //        int soLuongSan = int.Parse(dataReader[6].ToString());
            //        int donGia = int.Parse(dataReader[7].ToString());
            //        string loaiVC = dataReader[8].ToString();

            //        DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, donGia, loaiVC);
            //        list.Add(vaccine);
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    _conn.Close();
            //}
            //return list;
        //}

        public DataTable GetVCFromPHIEUTIEM(string maPT)
        {
            SqlDataReader rd;
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetVCFromPhieuTiem", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);
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

        public string GetTenKHFromPHIEUTIEM(string maPT)
        {
            string query = @"SELECT kh.TENKH 
                            FROM KHACHHANG kh INNER JOIN PHIEUTIEM pt
                            ON pt.MAKH = kh.MAKH
                            WHERE pt.MAPHIEUTIEM = @MAPHIEUTIEM";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

            da.SelectCommand.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);

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

        public bool DeletePhieuTiem(string MaPT)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_DeletePhieuTiem", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAPHIEUTIEM", MaPT);
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

        public DataTable GetAllPhieuTiemInfo()
        {
            SqlDataReader rd;
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetPhieuTiemsInfo", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public bool UpdatePhieuTiemInfo(DTO_PhieuTiemInfo ptif)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_UpdatePhieuTiemInfo", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAPHIEUTIEM", ptif.MaPT);
                cmd.Parameters.AddWithValue("@NGAYTIEM", ptif.NgayTiem);
                cmd.Parameters.AddWithValue("@TENKH", ptif.TenKH);
                cmd.Parameters.AddWithValue("@NGAYSINH", ptif.NgaySinh);
                cmd.Parameters.AddWithValue("@GIOITINH", ptif.GioiTinh);
                cmd.Parameters.AddWithValue("@TIEUSU", ptif.TieuSu); 
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

        public bool CheckPaymentStatus(string maPT)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand("sp_CheckPaymentStatus", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);

            SqlParameter retParam = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            _conn.Close();

            int retVal = Convert.ToInt32(retParam.Value);

            if (retVal == 1)
            {
                return true;
            }
            return false;
        }

        public bool CheckExistance(string maPT)
        {
            string query = "SELECT * FROM PHIEUTIEM WHERE MAPHIEUTIEM = @MAPHIEUTIEM";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);

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

        public DataTable GetReportInfo(string maPT)
        {
            SqlDataReader rd;
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetPhieuTiemReportInfo", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAPT", maPT);
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
    }
}
