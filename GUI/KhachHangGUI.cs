using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DAO.impl;

namespace GUI
{
    public partial class KhachHangGUI : Form
    {
        //string connectionString = "Data Source=LAPTOP-DTCTUVQ5\\SQLSERVER2022DEV;Initial Catalog=QuanLyThuPhiCapNuocSach;Integrated Security=True;Trust Server Certificate=True";

        string connectionString = Connection.connectionString;
        public KhachHangGUI()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                try
                {
                    Cnn.Open();
                    string query = "spKhachHang_Get";
                    SqlDataAdapter da = new SqlDataAdapter(query, Cnn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //dt.Columns["iMaKhachHang"].ColumnName = "Mã khách hàng";
                    //dt.Columns["sHoTen"].ColumnName = "Họ tên";
                    //dt.Columns["sDiaChi"].ColumnName = "Địa chỉ";
                    //dt.Columns["sSoDienThoai"].ColumnName = "Số điện thoại";
                    //dt.Columns["sEmail"].ColumnName = "Email";
                    //dt.Columns["dNgayDangKy"].ColumnName = "Ngày đăng ký";
                    //dt.Columns["iMaNhanVien"].ColumnName = "Mã nhân viên";

                    //dgvKhachhang.Columns["iMaKhachHang"].Width = 100; // Cột đầu tiên rộng 100px
                    //dgvKhachhang.Columns["sHoTen"].Width = 150;
                    //dgvKhachhang.Columns["sDiaChi"].Width = 150;
                    //dgvKhachhang.Columns["sSoDienThoai"].Width = 150;
                    //dgvKhachhang.Columns["sEmail"].Width = 150;
                    //dgvKhachhang.Columns["dNgayDangKy"].Width = 150;
                    //dgvKhachhang.Columns["iMaNhanVien"].Width = 150; 
                    dgvKhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    // Gán dữ liệu vào DataGridView
                    dgvKhachhang.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
                //try
                //{
                //    conn.Open();
                //    string query = "INSERT INTO tblKhachHang (iMaKhachHang, sHoTen, sDiaChi, sSoDienThoai, sEmail, dNgayDangKy) VALUES (@iMaKhachHang, @sHoTen, @sDiaChi, @sSoDienThoai, @sEmail, @dNgayDangKy)";

                //    using (SqlCommand cmd = new SqlCommand(query, conn))
                //    {
                //        cmd.Parameters.AddWithValue("@iMaKhachHang", txtCustomeID.Text);
                //        cmd.Parameters.AddWithValue("@sHoTen", txtName.Text);
                //        cmd.Parameters.AddWithValue("@sSoDienThoai", txtPhone.Text);
                //        cmd.Parameters.AddWithValue("@sDiaChi", txtAdd.Text);
                //        cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
                //        cmd.Parameters.AddWithValue("@dNgayDangKy", dpkNgaysinh.Value.ToString());

                //        int result = cmd.ExecuteNonQuery();
                //        if (result > 0)
                //        {
                //            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            LoadData(); // Tải lại dữ liệu vào DataGridView
                //        }
                //        else
                //        {
                //            MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            //}
        }
        //public void ThemKH() // Chua xong
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "INSERT INTO tblKhachHang (iMaKhachHang, sHoTen, sDiaChi, sSoDienThoai, sEmail, dNgayDangKy) VALUES (@iMaKhachHang, @sHoTen, @sDiaChi, @sSoDienThoai, @sEmail, @dNgayDangKy)";

        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@iMaKhachHang", txtCustomeID.Text);
        //                cmd.Parameters.AddWithValue("@sHoTen", txtName.Text);
        //                cmd.Parameters.AddWithValue("@sSoDienThoai", txtPhone.Text);
        //                cmd.Parameters.AddWithValue("@sDiaChi", txtAdd.Text);
        //                cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
        //                cmd.Parameters.AddWithValue("@dNgayDangKy", dpkNgaysinh.Value.ToString());

        //                int result = cmd.ExecuteNonQuery();
        //                if (result > 0)
        //                {
        //                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    LoadData(); // Tải lại dữ liệu vào DataGridView
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Chua xong
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                StringBuilder query = new StringBuilder("UPDATE tblKhachhang ");
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query.Append(" SET sHoTen like @sHoTen");
                    parameters.Add(new SqlParameter("@sHoTen", "%" + txtName.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(dpkNgaydangky.Value.ToString()))
                {
                    DateTime ngaysinh;
                    //  ngaysinh=DateTime.Parse(mskNgaysinh.Text);
                    if (DateTime.TryParseExact(dpkNgaydangky.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                    {
                        query.Append(" SET dNgayDangKy = @dNgayDangKy");
                        parameters.Add(new SqlParameter("@dNgayDangKy", ngaysinh));
                    }

                }

                if (!string.IsNullOrEmpty(txtAdd.Text))
                {
                    query.Append(" SET sDiaChi like @sDiaChi");
                    parameters.Add(new SqlParameter("@sDiaChi", "%" + txtAdd.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(txtPhone.Text))
                {
                    query.Append(" SET sSoDienThoai like @sSoDienThoai");
                    parameters.Add(new SqlParameter("@sSoDienThoai", "%" + txtPhone.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    query.Append(" SET sEmail like @sEmail");
                    parameters.Add(new SqlParameter("@sEmail", "%" + txtPhone.Text.Trim() + "%"));
                }
                parameters.Add(new SqlParameter("@id", "%" + txtCustomeID.Text.Trim() + "%"));
                query.Append(" WHERE iMaKhachHang = @id");

            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "DELETE FROM tblKhachHang WHERE iMaKhachHang = @id;";
                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtCustomeID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                StringBuilder query = new StringBuilder("select * from tblKhachHang where 1=1");
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query.Append(" and sHoTen like @sHoTen");
                    parameters.Add(new SqlParameter("@sHoTen", "%" + txtName.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(dpkNgaydangky.Value.ToString()))
                {
                    DateTime ngaydangky;
                    //  ngaysinh=DateTime.Parse(mskNgaysinh.Text);
                    if (DateTime.TryParseExact(dpkNgaydangky.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaydangky))
                    {
                        query.Append(" and tNgaysinh=@ngaysinh");
                        parameters.Add(new SqlParameter("@ngaysinh", ngaydangky));
                    }

                }


                if (!string.IsNullOrEmpty(txtAdd.Text))
                {
                    query.Append(" and sDiaChi like @sDiaChi");
                    parameters.Add(new SqlParameter("@sDiaChi", "%" + txtAdd.Text.Trim() + "%"));
                }



                if (!string.IsNullOrEmpty(txtPhone.Text))
                {
                    query.Append(" and sSoDienThoai like @sSoDienThoai");
                    parameters.Add(new SqlParameter("@sSoDienThoai", "%" + txtPhone.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    query.Append(" and sEmail like @sEmail");
                    parameters.Add(new SqlParameter("@sEmail", "%" + txtEmail.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(txtCustomeID.Text))
                {
                    query.Append(" and iMaKhachHang like @iMaKhachHang");
                    parameters.Add(new SqlParameter("@iMaKhachHang", "%" + txtCustomeID.Text.Trim() + "%"));
                }

                using (SqlCommand cmd = new SqlCommand(query.ToString(), cnn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvKhachhang.DataSource = dt;
                    }
                }

            }
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề cột
            {
                DataGridViewRow row = dgvKhachhang.Rows[e.RowIndex];

                //txtCustomeID.Text = row.Cells["Mã khách hàng"].Value.ToString();
                //txtName.Text = row.Cells["Họ tên"].Value.ToString();
                //txtAdd.Text = row.Cells["Địa chỉ"].Value.ToString();
                //txtEmail.Text = row.Cells["Email"].Value.ToString();
                //txtPhone.Text = row.Cells["Số điện thoại"].Value.ToString();
                //dpkNgaydangky.Text = row.Cells["Ngày đăng ký"].Value.ToString();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "INSERT INTO tblKhachHang(sHoTen, sDiaChi, sSoDienThoai, sEmail, dNgayDangKy)\r\nVALUES(@sHoTen, @sDiaChi, @sSoDienThoai, @sEmail, @dNgayDangKy);";
                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.Parameters.AddWithValue("@sHoTen", txtName.Text);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@sSoDienThoai", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@dNgayDangKy", DateTime.Parse(dpkNgaydangky.Value.ToString()));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData(); // Cập nhật DataGridView
            MessageBox.Show("Thêm thành công");
        }
    }
}
