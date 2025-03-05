﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using exception;
using Report;

namespace GUI
{
    public partial class HoaDonGUI : Form
    {
        private HoaDonBUS hoaDonBUS;
        public HoaDonGUI()
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBUS();
        }



        private void HoaDonGUI_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoaDonBUS.HoaDons();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvHoaDon.SelectedRows[0];

                    if (selectedRow.Cells[0].Value != null)
                    {
                        int id = int.Parse(selectedRow.Cells[0].Value.ToString());

                        DialogResult re = MessageBox.Show("Bạn có muốn xóa hóa đơn có mã là: " + id,
                                                          "Thông báo",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            hoaDonBUS.deleteById(id);
                            HoaDonGUI_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn không hợp lệ hoặc dữ liệu trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi: dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DatabaseException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        //
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param["sHoTen"] = txtTenKhachHang.Text;
            param["iThang"] = txtHoaDonThang.Text;
            param["iNam"] = txtHoaDonNam.Text;
            if(cboTrangThaiThanhToan.SelectedItem != null)
            {
                if (cboTrangThaiThanhToan.SelectedItem.ToString().Equals("Đã thanh toán"))
                {
                    param["sTrangThai"] = 1;
                }
                else
                {
                    param["sTrangThai"] = 0;
                }
            }
            
            if(checkbox_ngaylaphd.Checked == true)
            {
                param["dNgayLap"] = dtpNgayLapHD.Value.ToString("yyyy/MM/dd");
            }
            try
            {
                dgvHoaDon.DataSource = hoaDonBUS.findAll(param);
            }catch(DatabaseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findAll()
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param["sHoTen"] = txtTenKhachHang.Text;
            param["iThang"] = txtHoaDonThang.Text;
            param["iNam"] = txtHoaDonNam.Text;
            if (cboTrangThaiThanhToan.SelectedItem != null)
            {
                if (cboTrangThaiThanhToan.SelectedItem.ToString().Equals("Đã thanh toán"))
                {
                    param["sTrangThai"] = 1;
                }
                else
                {
                    param["sTrangThai"] = 0;
                }
            }

            if (checkbox_ngaylaphd.Checked == true)
            {
                param["dNgayLap"] = dtpNgayLapHD.Value.ToString("yyyy/MM/dd");
            }
            try
            {
                dgvHoaDon.DataSource = hoaDonBUS.findAll(param);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonReport hoaDonReport = new HoaDonReport();
            hoaDonReport.showReport("D:\\C#\\BTL\\QuanLyThuPhiCapNuocSach\\Report\\CrystalReport_HoaDon.rpt", "", "");
            hoaDonReport.Show();
        }

        private void checkbox_ngaylaphd_CheckedChanged(object sender, EventArgs e)
        {
            findAll();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            findAll();
        }

        private void txtHoaDonThang_TextChanged(object sender, EventArgs e)
        {
            findAll();
        }

        private void txtHoaDonNam_TextChanged(object sender, EventArgs e)
        {
            findAll();
        }

        private void cboTrangThaiThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            findAll();
        }
    }
}
