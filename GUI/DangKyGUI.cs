using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using exception;


namespace GUI
{
    public partial class DangKyGUI : Form
    {
        private TaiKhoanBUS taiKhoanBUS;
        private NhanVienBUS nhanVienBUS;

        public DangKyGUI()
        {
            InitializeComponent();
            taiKhoanBUS = new TaiKhoanBUS();
            nhanVienBUS = new NhanVienBUS();
        }

        //check tên tài khoản và mật khẩu
        private bool checkInputTaiKhoan(string s)
        {
            return Regex.IsMatch(s, "^[a-zA-Z0-9]{6,24}$");
        }

        //check định dạng email
        private bool checkInputEmail(string email)
        {
            //chỉ nhận từ a-z, A-Z, 0-9, _, . , từ 3 đến 20 kí tự, và theo định da @gmail...
            return Regex.IsMatch(email, "^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }

        private bool checkInput()
        {
            //check input tên tk
            if (!checkInputTaiKhoan(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("tên tài khoản không được chứa kí đặc biệt và từ phải từ 6 - 24 kí tự");
                return false;
            }

            //check mật khẩu
            if (!checkInputTaiKhoan(txtMatKhau.Text))
            {
                MessageBox.Show("mật khẩu không được chứa kí đặc biệt và từ phải từ 6 - 24 kí tự");
                return false;
            }

            //check email
            if (!checkInputEmail(txtEmail.Text))
            {
                MessageBox.Show("email không p được chứa kí tự đặc biệt và email phải có định dạng '@gmail.com'");
                return false;
            }

            //xac nhan mk
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                MessageBox.Show("mật khẩu không khớp");
                return false;
            }

            //
            //check xem đã có tên tài khaonr chx
            if (taiKhoanBUS.findByTentaikhoan(txtTenTaiKhoan.Text).Count > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
                return false;
            }

            //check email da co chx
            if (taiKhoanBUS.findByEmail(txtEmail.Text).Count > 0)
            {
                MessageBox.Show("Email đã tồn tại");
                return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                try
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO(txtTenTaiKhoan.Text, txtMatKhau.Text, txtEmail.Text);
                    NhanVienDTO nhanVienDTO = cboNhanVien.SelectedItem as NhanVienDTO;
                    taiKhoanBUS.add(taiKhoanDTO, nhanVienDTO);
                    DialogResult result = MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) this.Close();
                }
                catch (DatabaseException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//checkinput
        }

        private void DangKyGUI_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> nhanVienDTOs = nhanVienBUS.nhanVienDTOs();
            nhanVienDTOs.ForEach(item =>{cboNhanVien.Items.Add(item);});
        }


    }
}
