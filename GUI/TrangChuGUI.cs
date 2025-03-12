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

namespace GUI
{
    public partial class TrangChuGUI : Form
    {
        private NhanVienBUS nhanVienBUS;
        private TaiKhoanDTO taiKhoanDTO;


        public TrangChuGUI(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            this.taiKhoanDTO = taiKhoanDTO;
        }




        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
                    DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        DangNhapGUI dangNhapGUI = new DangNhapGUI();
                        dangNhapGUI.ShowDialog();
                    }
                    else
                    {

                    }
                }

        private void btnTongQuan_Click_1(object sender, EventArgs e)
        {

        }

        private void TrangChuGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TrangChuGUI_Load_1(object sender, EventArgs e)
        {
            //NhanVienDTO nhanVienDTO = nhanVienBUS.findById(taiKhoanDTO.MaNhanVien)[0];
            //lblUsername.Text = "Xin chào! " + nhanVienDTO.HoTen;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = null;

            // Kiểm tra xem form đã mở chưa
            foreach (Form childForm in this.MdiChildren)
            {
                if ((e.ClickedItem.Name == "mnuNhanVien" && childForm is NhanVienGUI) ||
                    (e.ClickedItem.Name == "mnuKhachHang" && childForm is KhachHangGUI) ||
                    (e.ClickedItem.Name == "mnuQuanLySuDungNuoc" && childForm is QuanLySuDungNuocGUI) ||
                    (e.ClickedItem.Name == "mnuHoaDon" && childForm is HoaDonGUI))
                {
                    childForm.BringToFront();
                    return;
                }
            }

            // Nếu chưa mở, tạo mới form phù hợp
            switch (e.ClickedItem.Name)
            {
                case "mnuNhanVien":
                    frm = new NhanVienGUI();
                    break;
                case "mnuKhachHang":
                    frm = new KhachHangGUI();
                    break;
                case "mnuQuanLySuDungNuoc":
                    frm = new QuanLySuDungNuocGUI();
                    break;
                case "mnuHoaDon":
                    frm = new HoaDonGUI();
                    break;
                default:
                    break;
            }

            if (frm != null)
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.BringToFront();
            }
        }

    }
}
