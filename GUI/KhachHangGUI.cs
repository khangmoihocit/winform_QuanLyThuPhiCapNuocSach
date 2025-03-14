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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class KhachHangGUI: Form
    {
        private KhachHangBUS khachHangBUS;
        public KhachHangGUI()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachHangBUS.getAllByDataTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnThem.Enabled = false;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "spKhachHang_Insert";
                
                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sHoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@sSoDienThoai", txtSoDienThoai.Text);
                    cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text); 
                    cmd.Parameters.AddWithValue("@dNgayDangKy", DateTime.Parse(dtpNgayDangKy.Value.ToString()));
                    cmd.ExecuteNonQuery();
                }
            }
            //if (checkHopLe())
            //{
            //    btnThem.Enabled = true;
            //}

            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //using (SqlConnection cnn = new SqlConnection(connectionString))
            //{
            //    cnn.Open();
            //    StringBuilder query = new StringBuilder("UPDATE tblKhachHang ");
            //    List<SqlParameter> parameters = new List<SqlParameter>();
            //    if (!string.IsNullOrEmpty(txtHoTen.Text))
            //    {
            //        query.Append(" SET sHoTen like @sHoTen");
            //        parameters.Add(new SqlParameter("@sHoTen", "%" + txtHoTen.Text.Trim() + "%"));
            //    }

            //    if (!string.IsNullOrEmpty(dtpNgayDangKy.Value.ToString()))
            //    {
            //        DateTime ngaysinh;
            //        //  ngaysinh=DateTime.Parse(mskNgaysinh.Text);
            //        if (DateTime.TryParseExact(dtpNgayDangKy.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
            //        {
            //            query.Append(" SET dNgayDangKy = @dNgayDangKy");
            //            parameters.Add(new SqlParameter("@dNgayDangKy", ngaysinh));
            //        }
            //    }

            //    if (!string.IsNullOrEmpty(txtDiaChi.Text))
            //    {
            //        query.Append(" SET sDiaChi like @sDiaChi");
            //        parameters.Add(new SqlParameter("@sDiaChi", "%" + txtDiaChi.Text.Trim() + "%"));
            //    }

            //    if (!string.IsNullOrEmpty(txtSoDienThoai.Text))
            //    {
            //        query.Append(" SET sSoDienThoai like @sSoDienThoai");
            //        parameters.Add(new SqlParameter("@sSoDienThoai", "%" + txtSoDienThoai.Text.Trim() + "%"));
            //    }

            //    if (!string.IsNullOrEmpty(txtEmail.Text))
            //    {
            //        query.Append(" SET sEmail like @sEmail");
            //        parameters.Add(new SqlParameter("@sEmail", "%" + txtEmail.Text.Trim() + "%"));
            //    }
            //    // Xem lại
            //    DataGridViewRow selectedRow = dgvKhachHang.SelectedRows[0];
            //    int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            //    query.Append(" WHERE iMaKH = @iMaKH");
            //    parameters.Add(new SqlParameter("@iMaKH", "%" + id + "%"));

            //}
            //MessageBox.Show("Sửa thành công");

            if (!string.IsNullOrEmpty(txtHoTen.Text))
            {
                int maKH = Convert.ToInt32(dgvKhachHang.SelectedRows[0].Cells["Mã Khách Hàng"].Value);
                string tenKH = txtHoTen.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string email = txtEmail.Text;
                DateTime ngayDangKy = DateTime.Parse(dtpNgayDangKy.Value.ToString());

                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    Cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("spKhachHang_Update", Cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iMaKH", maKH);
                        cmd.Parameters.AddWithValue("@sHoTen", tenKH);
                        cmd.Parameters.AddWithValue("@sDiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@sSoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@sEmail", email);
                        cmd.Parameters.AddWithValue("@dNgayDangKy", ngayDangKy);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLichSuTieuThuNuoc_Click(object sender, EventArgs e)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                List<SqlParameter> parameters = new List<SqlParameter>();
                StringBuilder query = new StringBuilder("sp_ChiSoNuoc_GET");
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Cnn;

                // Nếu người dùng nhập tên
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                {
                    query.Append(" AND sHoTen LIKE @sHoTen");
                    Cmd.Parameters.AddWithValue("@sHoTen", "%" + txtHoTen.Text.Trim() + "%");
                }

                // Nếu người dùng nhập dia chi
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    query.Append(" AND sDiachi LIKE @sDiachi");
                    Cmd.Parameters.AddWithValue("@sDiachi", "%" + txtDiaChi.Text.Trim() + "%");
                }

                // Nếu người dùng nhập số điện thoại
                if (!string.IsNullOrEmpty(txtSoDienThoai.Text))
                {
                    query.Append(" AND sDienthoai LIKE @sDienthoai");
                    Cmd.Parameters.AddWithValue("@sDienthoai", "%" + txtSoDienThoai.Text.Trim() + "%");
                }

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    query.Append(" AND sEmail LIKE @sEmail");
                    Cmd.Parameters.AddWithValue("@sEmail", "%" + txtEmail.Text.Trim() + "%");
                }

                if (!string.IsNullOrEmpty(dtpNgayDangKy.Value.ToString()))
                {
                    DateTime ngaysinh;
                    //  ngaysinh=DateTime.Parse(mskNgaysinh.Text);
                    if (DateTime.TryParseExact(dtpNgayDangKy.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                    {
                        query.Append(" and dtpNgayDangKy=@ngaysinh");
                        parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
                    }

                }


                Cmd.CommandText = query.ToString();

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns["iMaKH"].ColumnName = "Mã khách hàng";
                dt.Columns["fChiSoCu"].ColumnName = "Chỉ số cũ";
                dt.Columns["fChiSoMoi"].ColumnName = "Chỉ số mới";
                dt.Columns["dNgayGhi"].ColumnName = "Ngày ghi";
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKhachHang.DataSource = dt;

            }
        }
        //private Boolean checkHopLe()
        //{
        //    if (!string.IsNullOrEmpty(txtHoTen.Text))
        //    {
        //        if (!string.IsNullOrEmpty(txtDiaChi.Text))
        //        {
        //            if (!string.IsNullOrEmpty(txtEmail.Text))
        //            {
        //                if (!string.IsNullOrEmpty(txtSoDienThoai.Text))
        //                {
        //                    if (dtpNgayDangKy.Value != null)
        //                    {
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề cột
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtHoTen.Text = row.Cells["Họ tên"].Value.ToString();
                txtDiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["Số điện thoại"].Value.ToString();
                dtpNgayDangKy.Text = row.Cells["Ngày đăng ký"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dgvKhachHang.SelectedRows.Count > 0)
            //{
            //    try
            //    {
            //        DataGridViewRow selectedRow = dgvKhachHang.SelectedRows[0];

            //        if (selectedRow.Cells[0].Value != null)
            //        {
            //            int id = int.Parse(selectedRow.Cells[0].Value.ToString());

            //            DialogResult re = MessageBox.Show("Bạn có muốn xóa hóa đơn có mã là: " + id,
            //                                              "Thông báo",
            //                                              MessageBoxButtons.YesNo,
            //                                              MessageBoxIcon.Question);

            //            if (re == DialogResult.Yes)
            //            {
            //                khachHangBUS.deleteById(id);
            //                KhachHangGUI_Load(sender, e);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Hóa đơn không hợp lệ hoặc dữ liệu trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        MessageBox.Show("Lỗi: dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    catch (DatabaseException ex)
            //    {
            //        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //using (SqlConnection Cnn = new SqlConnection(connectionString))
            //{
            //    Cnn.Open();
            //    string query = "sp_KhachHang_Delete";
            //    using (SqlCommand cmd = new SqlCommand(query, Cnn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@iMaKH", (getIDKhachHang(txtHoTen.Text)));
            //        cmd.ExecuteNonQuery();
            //    }
            //}

            //using (SqlConnection cnn = new SqlConnection(connectionString))
            //{
            //    cnn.Open();
            //    DataGridViewRow selectedRow = dgvKhachHang.SelectedRows[0];
            //    int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            //    StringBuilder query = new StringBuilder("EXEC sp_KhachHang_Delete EXEC @iMaKH = " + id);
            //    List<SqlParameter> parameters = new List<SqlParameter>();
            //    // Xem lại
            //    //DataGridViewRow selectedRow = dgvKhachHang.SelectedRows[0];
            //    //int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            //    //query.Append(" @iMaKH = " + id);
            //    //parameters.Add(new SqlParameter("@iMAKH", "%" + id + "%"));
            //    MessageBox.Show("mã khách hàng " + id);
            //}
            //MessageBox.Show("Xóa thành công");
            if (dgvKhachHang.SelectedRows.Count > 0) // Kiểm tra có chọn dòng không
            {
                int maKH = Convert.ToInt32(dgvKhachHang.SelectedRows[0].Cells["Mã Khách Hàng"].Value);

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_KhachHang_Delete", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaKH", maKH);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        public int getIDKhachHang(string tenKH)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                int maKH = 0;
                string query = "spKhachHang_GET2";
                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sHoTen", txtHoTen.Text);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Kiểm tra nếu có dữ liệu
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Lấy dữ liệu từ từng cột
                                maKH = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không có dữ liệu.");
                        }
                    }
                }
                return maKH;
            }
        }
        //Xem lai
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Dictionary<string, object> param = new Dictionary<string, object>();
            //param["sHoTen"] = txtHoTen.Text;
            //param["sDiaChi"] = txtDiaChi.Text;
            //param["sEmail"] = txtEmail.Text;
            //param["sSoDienThoai"] = txtSoDienThoai.Text;
            //param["dNgayDangKy"] = dtpNgayDangKy.Value;

            //try
            //{
            //    dgvKhachHang.DataSource = khachHangBUS.findAll(param);
            //}
            //catch (DatabaseException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //string tenKH = txtHoTen.Text.Trim();
            //string diaChi = txtDiaChi.Text.Trim();
            //string soDienThoai = txtSoDienThoai.Text.Trim();
            //string email = txtEmail.Text.Trim();
            //DateTime? ngayDangKy = DateTime.Parse(dtpNgayDangKy.Value.ToString());

            //using (SqlConnection Cnn = new SqlConnection(connectionString))
            //{
            //    Cnn.Open();
            //    using (SqlCommand cmd = new SqlCommand("spKhachHang_Search", Cnn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        // Gửi tham số, nếu trống thì gửi NULL
            //        cmd.Parameters.AddWithValue("@sHoTen", string.IsNullOrEmpty(tenKH) ? (object)DBNull.Value : tenKH);
            //        cmd.Parameters.AddWithValue("@sDiaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi);
            //        cmd.Parameters.AddWithValue("@sSoDienThoai", string.IsNullOrEmpty(soDienThoai) ? (object)DBNull.Value : soDienThoai);
            //        cmd.Parameters.AddWithValue("@sEmail", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
            //        cmd.Parameters.AddWithValue("@dNgayDangKy", ngayDangKy.HasValue ? (object)DBNull.Value : ngayDangKy);

            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        dt.Columns["iMaKH"].ColumnName = "Mã khách hàng";
            //        dt.Columns["sDiaChi"].ColumnName = "Địa chỉ";
            //        dt.Columns["sEmail"].ColumnName = "Email";
            //        dt.Columns["dNgayDangKy"].ColumnName = "NGày đăng ký";
            //        dt.Columns["sSoDienThoai"].ColumnName = "Số điện thoại";
            //        dt.Columns["sHoTen"].ColumnName = "Họ tên";
            //        dgvKhachHang.DataSource = dt;
            //    }
            //}
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblKhachHang WHERE 1=1";
                DateTime ngayDK = DateTime.Parse(dtpNgayDangKy.Value.ToString());

                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    query += " AND sHoTen = @sHoTen";

                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    query += " AND sDiaChi = @sDiaChi";

                if (!string.IsNullOrEmpty(txtSoDienThoai.Text))
                    query += " AND sSoDienThoai = @sSoDienThoai";
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    query += " AND sEmail = @sEmail";
                //if (dtpNgayDangKy.Value != null)
                //    query += " AND dNgayDangKy = @dNgayDangKy";
                SqlCommand cmd = new SqlCommand(query, Cnn);
                cmd.Parameters.AddWithValue("@sHoTen", "%" + txtHoTen.Text + "%");
                cmd.Parameters.AddWithValue("@sDiaChi", "%" + txtDiaChi.Text + "%");
                cmd.Parameters.AddWithValue("@sEmail", "%" + txtEmail.Text + "%");
                cmd.Parameters.AddWithValue("@sSoDienThoai", "%" + txtSoDienThoai.Text + "%");
                //cmd.Parameters.AddWithValue("@dNgayDangKy", "%" + ngayDK + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns["iMaKH"].ColumnName = "Mã khách hàng";
                dt.Columns["sDiaChi"].ColumnName = "Địa chỉ";
                dt.Columns["sEmail"].ColumnName = "Email";
                dt.Columns["dNgayDangKy"].ColumnName = "Ngày đăng ký";
                dt.Columns["sSoDienThoai"].ColumnName = "Số điện thoại";
                dt.Columns["sHoTen"].ColumnName = "Họ tên";
                dgvKhachHang.DataSource = dt;
            }


        }
    }
}
