using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class NhanVienReportcs: Form
    {
        public NhanVienReportcs()
        {
            InitializeComponent();
        }
        public void showReport(string reportFilePath, string reportTitle, string recordFilter)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(reportFilePath);

            TableLogOnInfo tableLogonInfo = new TableLogOnInfo();
            tableLogonInfo.ConnectionInfo.ServerName = "LAPTOP-DTCTUVQ5\\SQLSERVER2022DEV";
            tableLogonInfo.ConnectionInfo.DatabaseName = "QuanLyThuPhiCapNuocSach_1";
            tableLogonInfo.ConnectionInfo.UserID = "DMINH";
            tableLogonInfo.ConnectionInfo.Password = "1";

            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tableLogonInfo);
            }

            rpt.RecordSelectionFormula = recordFilter;
            rpt.SummaryInfo.ReportTitle = reportTitle;
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
