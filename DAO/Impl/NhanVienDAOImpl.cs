using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using exception;
//using Microsoft.Data.SqlClient;

namespace DAO.impl
{
    public class NhanVienDAOImpl : INhanVienDAO
    {
        public List<NhanVienDTO> findById(int maNhanVien)
        {
            return command($"select * from tblNhanVien where iMaNV = {maNhanVien}");
        }

        public List<NhanVienDTO> command(string query)
        {
            List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            NhanVienDTO nhanVienDTO = new NhanVienDTO();
                            nhanVienDTO.MaNhanVien = int.Parse(dataReader["iMaNV"].ToString());
                            nhanVienDTO.HoTen = dataReader["sHoTen"].ToString();
                            nhanVienDTO.SoDienThoai = dataReader["sSoDienThoai"].ToString();
                            nhanVienDTO.Email = dataReader["sEmail"].ToString();
                            nhanVienDTO.DiaChi = dataReader["sDiaChi"].ToString();
                            if (bool.Parse(dataReader["bGioiTinh"].ToString()) == true)
                            {
                                nhanVienDTO.GioiTinh = "nam";
                            }
                            else
                            {
                                nhanVienDTO.GioiTinh = "nữ";
                            }
                            nhanVienDTOs.Add(nhanVienDTO);
                        }
                    }
                }//cmd
                sqlConnection.Close();
            }

            return nhanVienDTOs;
        }
        public void deleteById(int id)
        {
            string query = "sp_NhanVien_Delete";
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add(new SqlParameter("@iMaNV", SqlDbType.Int)).Value = id;
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
            StringBuilder query = new StringBuilder("spNhanVien_Get");
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

        public List<NhanVienDTO> getAll()
        {
            return command("select * from tblNhanVien");
        }

        public DataTable getAllByTable()
        {
            string query = "spNhanVien_Get";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataTable.Columns["iMaNV"].ColumnName = "Mã nhân viên";
                        dataTable.Columns["bGioiTinh"].ColumnName = "Giới tính";
                        dataTable.Columns["sSoDienThoai"].ColumnName = "Số điện thoại";
                        dataTable.Columns["sHoTen"].ColumnName = "Họ tên";
                        dataTable.Columns["sDiaChi"].ColumnName = "Địa chỉ";
                        dataTable.Columns["sEmail"].ColumnName = "Email";
                        dataTable.Columns.Add("bGioiTinh", typeof(string));
 
                        return dataTable;
                    }
                }//cmd
                sqlConnection.Close();
            }
        }

        public DataTable NHanViens()
        {
            throw new NotImplementedException();
        }
    }
}
