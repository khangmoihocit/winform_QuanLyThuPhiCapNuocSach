﻿namespace Report
{
    partial class HoaDonReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer_Hoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReport_HoaDon1 = new Report.CrystalReport_HoaDon();
            this.cachedCrystalReport_HoaDon1 = new Report.CachedCrystalReport_HoaDon();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_Hoadon
            // 
            this.crystalReportViewer_Hoadon.ActiveViewIndex = -1;
            this.crystalReportViewer_Hoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Hoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Hoadon.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Hoadon.Name = "crystalReportViewer_Hoadon";
            this.crystalReportViewer_Hoadon.Size = new System.Drawing.Size(986, 681);
            this.crystalReportViewer_Hoadon.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(986, 681);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // HoaDonReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 681);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "HoaDonReport";
            this.Text = "HoaDonReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Hoadon;
        private CrystalReport_HoaDon crystalReport_HoaDon1;
        private CachedCrystalReport_HoaDon cachedCrystalReport_HoaDon1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}