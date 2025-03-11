using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using exception;


namespace DAO.impl
{
    public class HoaDonDAOImpl : IHoaDonDAO
    {
        public DataTable HoaDons()
        {
            //List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
            DataTable dataTable = new DataTable();
            string query = "spHoaDon_Get";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void deleteById(int id)
        {
            string query = "spHoaDon_Delete";
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add(new SqlParameter("@iMaHD", SqlDbType.Int)).Value = id;
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
            StringBuilder query = new StringBuilder("  SELECT dbo.tblHoaDon.iMaHD AS [Mã hóa đơn], dbo.tblKhachHang.sHoTen AS [Tên khách hàng], tblHoaDon.iThang AS [Hóa đơn tháng], \r\n  tblHoaDon.iNam as [Hoá đơn năm], dbo.tblHoaDon.dNgayLap AS [Ngày lập hóa đơn], \r\n                  dbo.tblChiSoNuoc.fChiSoMoi - dbo.tblChiSoNuoc.fChiSoCu AS [Số nước tiêu thụ], dbo.tblHoaDon.fThanhTien AS [Tổng thành tiền], \r\n                  CASE WHEN tblHoaDon.sTrangThai = 1 THEN N'đã thanh toán' ELSE N'chưa thanh toán' END AS [Trạng thái thanh toán]\r\nFROM     dbo.tblChiSoNuoc INNER JOIN\r\n                  dbo.tblKhachHang ON dbo.tblChiSoNuoc.iMaKH = dbo.tblKhachHang.iMaKH INNER JOIN\r\n                  dbo.tblHoaDon ON dbo.tblChiSoNuoc.iMaChiSo = dbo.tblHoaDon.iMaChiSo where 1 = 1 ");
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

        //ktra so
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

        //kiem tra xau

    }
}
