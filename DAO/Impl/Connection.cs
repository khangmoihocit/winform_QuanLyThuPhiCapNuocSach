﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;

namespace DAO.impl
{
    public class Connection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThuPhiCapNuocSach_1"].ConnectionString;
        //private static string connectionString = "Data Source = LAPTOP - DTCTUVQ5\\SQLSERVER2022DEV;Initial Catalog = QuanLyThuPhiCapNuocSach_1; Integrated Security = True; TrustServerCertificate=True";

        //private static string connectionString = "Data Source=KHANG\\SQLEXPRESS02;Initial Catalog=QuanLyThuPhiCapNuocSach;Integrated Security = True; TrustServerCertificate=True";

        public static SqlConnection GetSqlConnection() => new SqlConnection(connectionString);
    }
}
