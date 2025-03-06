using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.impl;

namespace DAO.Impl
{
    public class ChiSoNuocDAOImpl : IChiSoNuocDAO
    {
        public DataTable getAllByDataTable()
        {
            string query = "spChiSoNuoc_Get";
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                sqlConnection.Close();

            }
        }
    }
}
