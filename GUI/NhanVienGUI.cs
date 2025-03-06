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
using DAO.impl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class NhanVienGUI : Form
    {
        string connectionString = Connection.connectionString;
        public NhanVienGUI()
        {
            InitializeComponent();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                try
                {
                    Cnn.Open();
                    string query = "spNhanVien_Get";
                    SqlDataAdapter da = new SqlDataAdapter(query, Cnn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //dt.Columns["iMaNhanVien"].ColumnName = "Mã nhân viên";
                    //dt.Columns["sHoTen"].ColumnName = "Họ tên";
                    //dt.Columns["sDiaChi"].ColumnName = "Địa chỉ";
                    //dt.Columns["sSoDienThoai"].ColumnName = "Số điện thoại";
                    //dt.Columns["sEmail"].ColumnName = "Email";
                    //dt.Columns["dNgaySinh"].ColumnName = "Ngày sinh";

                    //dgvKhachhang.Columns["iMaKhachHang"].Width = 100; // Cột đầu tiên rộng 100px
                    //dgvKhachhang.Columns["sHoTen"].Width = 150;
                    //dgvKhachhang.Columns["sDiaChi"].Width = 150;
                    //dgvKhachhang.Columns["sSoDienThoai"].Width = 150;
                    //dgvKhachhang.Columns["sEmail"].Width = 150;
                    //dgvKhachhang.Columns["dNgayDangKy"].Width = 150;
                    //dgvKhachhang.Columns["iMaNhanVien"].Width = 150; 
                    dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    // Gán dữ liệu vào DataGridView
                    dgvNhanVien.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        //private void LoadDataToListView()
        //{
        //    listView1.Items.Clear(); // Xóa dữ liệu cũ trong ListView

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            // Chưa xong
        //            string query = "spThongtin3_Get"; // Thay đổi theo bảng của bạn 
        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                ListViewItem item = new ListViewItem(reader["iMaKhachHang"].ToString()); // Cột 1
        //                item.SubItems.Add(reader["tenKH"].ToString());                 // Cột 2
        //                item.SubItems.Add(reader["sSoDienThoai"].ToString());                // Cột 3
        //                item.SubItems.Add(reader["sDiachi"].ToString());                // Cột 4
        //                item.SubItems.Add(reader["tenNV"].ToString());                // Cột 5
        //                item.SubItems.Add(reader["bTrangThaiThanhtoan"].ToString());                // Cột 6
        //                item.SubItems.Add(reader["TieuThu"].ToString());                // Cột 7
        //                listView1.Items.Add(item);
        //            }
        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi: " + ex.Message);
        //        }
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "INSERT INTO tblNhanVien(sHoTen, sDiaChi, sSoDienThoai, sEmail, dNgaySinh)\r\nVALUES(@sHoTen, @sDiaChi, @sSoDienThoai, @sEmail, @dNgaySinh)";
                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.Parameters.AddWithValue("@sHoTen", txtName.Text);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@sSoDienThoai", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@dNgaySinh", DateTime.Parse(dpkNgaysinh.Value.ToString()));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData(); // Cập nhật DataGridView
            MessageBox.Show("Thêm thành công");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "tblNhanVien_Delete";
                using (SqlCommand cmd = new SqlCommand(query, Cnn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtStaffID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                StringBuilder query = new StringBuilder("UPDATE tblNhanVien ");
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query.Append(" SET sHoTen like @sHoTen");
                    parameters.Add(new SqlParameter("@sHoTen", "%" + txtName.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(dpkNgaysinh.Value.ToString()))
                {
                    DateTime ngaysinh;
                    //  ngaysinh=DateTime.Parse(dpkNgaysinh.Value.ToString());
                    if (DateTime.TryParseExact(dpkNgaysinh.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                    {
                        query.Append(" SET dNgaySinh = @dNgaySinh");
                        parameters.Add(new SqlParameter("@dNgaySinh", ngaysinh));
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
                query.Append(" WHERE 1=1");

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
                StringBuilder query = new StringBuilder("select * from tblNhanVien where 1=1");
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query.Append(" and sHoTen like @sHoTen");
                    parameters.Add(new SqlParameter("@sHoTen", "%" + txtName.Text.Trim() + "%"));
                }

                if (!string.IsNullOrEmpty(dpkNgaysinh.Value.ToString()))
                {
                    DateTime ngaySinh;
                    //  ngaysinh=DateTime.Parse(dpkNgaysinh.Value.ToString());
                    if (DateTime.TryParseExact(dpkNgaysinh.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                    {
                        query.Append(" and dNgaySinh=@dNgaySinh");
                        parameters.Add(new SqlParameter("@dNgaySinh", ngaySinh));
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

                if (!string.IsNullOrEmpty(txtStaffID.Text))
                {
                    query.Append(" and iMaNhanVien like @iMaNhanVien");
                    parameters.Add(new SqlParameter("@iMaNhanVien", "%" + txtStaffID.Text.Trim() + "%"));
                }

                using (SqlCommand cmd = new SqlCommand(query.ToString(), cnn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvNhanVien.DataSource = dt;
                    }
                }

            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề cột
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtStaffID.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txtName.Text = row.Cells["Họ tên"].Value.ToString();
                txtAdd.Text = row.Cells["Địa chỉ"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Số điện thoại"].Value.ToString();
                dpkNgaysinh.Text = row.Cells["Ngày sinh"].Value.ToString();
            }
        }
    }
}
