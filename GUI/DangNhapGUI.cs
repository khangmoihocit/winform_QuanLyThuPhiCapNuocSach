using System;
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
//using exception;

namespace GUI
{
    public partial class DangNhapGUI : Form
    {
        private TaiKhoanBUS taiKhoanBUS;

        public DangNhapGUI()
        {
            InitializeComponent();
            taiKhoanBUS = new TaiKhoanBUS();
        }

        private void lklQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhauGUI quenMatKhauGUI = new QuenMatKhauGUI();
            quenMatKhauGUI.ShowDialog();
        }

        private void lklDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKyGUI dangKyGUI = new DangKyGUI();
            dangKyGUI.ShowDialog();

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "") MessageBox.Show("Vui lòng nhập tên tài khoản");
            else if (txtMatKhau.Text.Trim() == "") MessageBox.Show("Vui lòng nhập mật khẩu");
            else
            {
                try
                {
                    List<TaiKhoanDTO> taiKhoanDTOs = taiKhoanBUS.findByTentaikhoanAndMatkhau(txtTaiKhoan.Text, txtMatKhau.Text);
                    if (taiKhoanDTOs.Count > 0)
                    {
                        DialogResult re = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (re == DialogResult.OK)
                        {
                            TrangChuGUI trangChuGUI = new TrangChuGUI(taiKhoanDTOs[0]);
                            trangChuGUI.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (DatabaseException ex)
                {
                    MessageBox.Show(ex.Message);
                }//try
            }//else
        }

        public TaiKhoanDTO getTaiKhoanDTO()
        {
            return null;
        }

        private void DangNhapGUI_Load_1(object sender, EventArgs e)
        {

        }

        private void DangNhapGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
