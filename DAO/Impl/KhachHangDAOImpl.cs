using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAO.impl;
using DTO;
using exception;

namespace DAO.Impl
{
    public class KhachHangDAOImpl : IKhachHangDAO
    {
        public List<KhachHangDTO> command(string query)
        {
            List<KhachHangDTO> khachHangDTOs = new List<KhachHangDTO>();
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                KhachHangDTO khachHangDTO = new KhachHangDTO();
                                khachHangDTO.MaKhachHang = int.Parse(dataReader["iMaKH"].ToString());
                                khachHangDTO.HoTen = dataReader["sHoTen"].ToString();
                                khachHangDTO.DiaChi = dataReader["sDiaChi"].ToString();
                                khachHangDTO.SoDienThoai = dataReader["sSoDienThoai"].ToString();
                                khachHangDTO.Email = dataReader["sEmail"].ToString();
                                khachHangDTO.NgayDangKy = DateTime.Parse(dataReader["dNgayDangKy"].ToString());

                                khachHangDTOs.Add(khachHangDTO);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Lỗi: " + ex.Message);
            }
            return khachHangDTOs;
        }

        public void deleteById(int id)
        {
            string query = "sp_KhachHang_Delete";
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add(new SqlParameter("@iMaKH", SqlDbType.Int)).Value = id;
                        int n = sqlCommand.ExecuteNonQuery();
                        if (n < 0) throw new DatabaseException("Lỗi! Chưa xóa được");
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable findAll(Dictionary<string, object> param)
        {
            StringBuilder query = new StringBuilder("spKhachHang_Get");
            queryWhere(param, query);

            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query.ToString(), sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Lỗi! không thể tìm\n" + ex.Message + "\n query: " + query.ToString());
            }
            finally
            {
            }
        }
        // Xem lai
        public void queryWhere(Dictionary<string, object> param, StringBuilder query)
        {
            foreach (var item in param)
            {
                string value = item.Value.ToString();

                if (!string.IsNullOrEmpty(value))
                {
                    //trang thai thanh thanh toan dang bit
                    if (item.Key.ToString().Equals("sTrangThai"))
                    {
                        query.Append($" and tblHoaDon.{item.Key} = {value} ");

                    }
                    else if (item.Key.ToString().Equals("dNgayLap"))
                    {
                        query.Append($" and convert(date, tblHoaDon.{item.Key}) = convert(date, '{value}')");
                    }

                    else if (item.Key.ToString().Equals("sHoTen")) //bảng khách hàng
                    {
                        query.Append($"and tblKhachHang.{item.Key} like N'%{value}%' ");
                    }
                    else //bảng hóa đơn
                    {
                        //nếu là số: truy vấn =, xâu: truy vấn like
                        if (isNumber(value))
                        {
                            query.Append($" and tblHoaDon.{item.Key.ToString()} = {value} ");
                        }
                        else
                        {
                            query.Append($" and tblHoaDon.{item.Key} like N'%{value}%' ");
                        }
                    }

                }

            }
        }
        public bool isNumber(string s)
        {
            try
            {
                long a = long.Parse(s);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<KhachHangDTO> getAll()
        {
            return command("select * from tblKhachHang");
        }



        public DataTable getAllByDataTable()
        {
            string query = "spKhachHang_Get";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                sqlConnection.Close();
            }
        }

        public DataTable KhachHangs()
        {
            throw new NotImplementedException();
        }
    }
}
