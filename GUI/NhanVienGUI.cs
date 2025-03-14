using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using exception;
using Report;

namespace GUI
{
    public partial class NhanVienGUI : Form
    {
        private NhanVienBUS nhanVienBUS;
        string connectionString = "Data Source=LAPTOP-DTCTUVQ5\\SQLSERVER2022DEV;Initial Catalog=QuanLyThuPhiCapNuocSach_1;Integrated Security=True;TrustServerCertificate=True";

        public NhanVienGUI()
        {
            nhanVienBUS = new NhanVienBUS();
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhanVienGUI_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBUS.getAllByDataTable();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "spNhanVien_Insert";

                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sHoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@sSoDienThoai", txtSoDienThoai.Text);
                    cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                    string gioiTinh;
                    if( radNam.Checked = true) {
                        gioiTinh = "1";
                        cmd.Parameters.AddWithValue("@bGioiTinh", gioiTinh);
                    }
                    else if(radNu.Checked = true)
                    {
                        gioiTinh = "0";
                        cmd.Parameters.AddWithValue("@bGioiTinh", gioiTinh);
                    }
                    else
                    {
                        gioiTinh = null;
                        cmd.Parameters.AddWithValue("@bGioiTinh", gioiTinh);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            //if (checkHopLe())
            //{
            //    btnThem.Enabled = true;
            //}

            MessageBox.Show("Thêm thành công");
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề cột
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                
                if (row.Cells["Giới tính"].Value.ToString() == "nam")
                {
                    radNam.Checked = true;
                }
                else if (row.Cells["Giới tính"].Value.ToString() == "nu")
                {
                    radNu.Checked = true;
                }
                else
                {
                    radKhongLuaChon.Checked = true;
                }
                
                txtHoTen.Text = row.Cells["Họ tên"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["Số điện thoại"].Value.ToString();
                txtDiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                //radNam.Text = row.Cells["Ngày đăng ký"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text))
            {
                int maNV = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells["Mã Nhân Viên"].Value);
                string tenNV = txtHoTen.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string diaChi = txtDiaChi.Text;
                string Email = txtEmail.Text;
                string gioiTinh;
                if(radNam.Checked = true)
                {
                    gioiTinh = "1";
                }
                else if(radNu.Checked = true)
                {
                    gioiTinh = "0";
                }
                else
                {
                    gioiTinh = null;
                }


                    using (SqlConnection Cnn = new SqlConnection(connectionString))
                    {
                        Cnn.Open();
                        using (SqlCommand cmd = new SqlCommand("spNhanVien_Update", Cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaNV", maNV);
                            cmd.Parameters.AddWithValue("@sHoTen", tenNV);
                            cmd.Parameters.AddWithValue("@bGioiTinh", gioiTinh);
                            cmd.Parameters.AddWithValue("@sSoDienThoai", soDienThoai);
                            cmd.Parameters.AddWithValue("@sEmail", Email);
                            cmd.Parameters.AddWithValue("@sDiaChi", diaChi);

                        int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0) // Kiểm tra có chọn dòng không
            {
                int maKH = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells["Mã Nhân Viên"].Value);

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_NhanVien_Delete", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaNV", maKH);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            string hoTen = txtHoTen.Text;  // Tên khách hàng
            string soDienThoai = txtSoDienThoai.Text;  // Số điện thoại
            string Email = txtEmail.Text;  // Số điện thoại
            string diaChi = txtDiaChi.Text;  // Số điện thoại


            // Kiểm tra nếu ít nhất một trường được nhập
            if (string.IsNullOrEmpty(hoTen) && string.IsNullOrEmpty(soDienThoai) && !radNam.Checked && !radNu.Checked && !radKhongLuaChon.Checked)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin để tìm kiếm.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spNhanVien_Search", conn);
                cmd.CommandType = CommandType.StoredProcedure;  // Sử dụng stored procedure

                // Thêm tham số vào câu lệnh stored procedure
                cmd.Parameters.AddWithValue("@sHoTen", string.IsNullOrEmpty(hoTen) ? (object)DBNull.Value : hoTen);
                cmd.Parameters.AddWithValue("@sSoDienThoai", string.IsNullOrEmpty(soDienThoai) ? (object)DBNull.Value : soDienThoai);
                cmd.Parameters.AddWithValue("@sEmail", string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);
                cmd.Parameters.AddWithValue("@sDiaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi);

                // Thêm tham số cho giới tính
                if (radNam.Checked)
                    cmd.Parameters.AddWithValue("@bGioiTinh", 1);  // 1 cho Nam
                else if (radNu.Checked)
                    cmd.Parameters.AddWithValue("@bGioiTinh", 0);  // 0 cho Nữ
                else
                    cmd.Parameters.AddWithValue("@bGioiTinh", DBNull.Value);  // Nếu không chọn giới tính, truyền NULL

                // Mở kết nối và thực hiện truy vấn
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dt.Columns["iMaNV"].ColumnName = "Mã nhân viên";
                dt.Columns["bGioiTinh"].ColumnName = "Giới tính";
                dt.Columns["sSoDienThoai"].ColumnName = "Số điện thoại";
                dt.Columns["sHoTen"].ColumnName = "Họ tên";
                dt.Columns["sDiaChi"].ColumnName = "Địa chỉ";
                dt.Columns["sEmail"].ColumnName = "Email";
                
                dgvNhanVien.DataSource = dt;

                // Xử lý dữ liệu hiển thị lên DataGridView
                //dgvNhanVien.AutoGenerateColumns = false;  // Tắt tự động tạo cột cho DataGridView
                //dgvNhanVien.Rows.Clear();  // Xóa hết các dòng cũ trong DataGridView

                //if (dt.Rows.Count > 0)
                //{
                //    // Thêm từng dòng dữ liệu vào DataGridView
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        dgvNhanVien.Rows.Add(
                //            dr["iMaNV"].ToString(),
                //            dr["sHoTen"].ToString(),
                //            dr["sSoDienThoai"].ToString(),
                //            Convert.ToBoolean(dr["bGioiTinh"]) ? "Nam" : "Nữ"
                //        );
                //    }
                //}
            }
        }

        private void btnXuatDSNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienReportcs nhanVienReport = new NhanVienReportcs();
            string filePath = "C:\\Users\\ASUS\\Downloads\\btl\\winform_QuanLyThuPhiCapNuocSach\\Report\\CrystalReport_NhanVien.rpt";
            string recordFilter = "";
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString());
                recordFilter = "{tblNhanVien.iMaNV} = " + id + " ";

                MessageBox.Show(recordFilter);
            }


            nhanVienReport.showReport(filePath, "", recordFilter);
            nhanVienReport.Show();
        }
        private void findAll()
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            string gioiTinh = "";
            if (radNam.Checked = true)
                gioiTinh = "1";
            if (radNu.Checked = true)
                gioiTinh = "0";
            if (radKhongLuaChon.Checked = true)
                gioiTinh = null;
            param["@sHoTen"] = txtHoTen.Text;
            param["@sSoDienThoai"] = txtSoDienThoai.Text;
            param["@bGioiTinh"] = gioiTinh;

            try
            {
                dgvNhanVien.DataSource = nhanVienBUS.findAll(param);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void txtHoTen_TextChanged(object sender, EventArgs e)
        //{
        //    findAll();
        //}

        //private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        //{
        //    findAll();
        //}
    }
}
