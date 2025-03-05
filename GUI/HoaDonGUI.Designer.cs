using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class HoaDonGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkbox_ngaylaphd = new System.Windows.Forms.CheckBox();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThaiThanhToan = new System.Windows.Forms.ComboBox();
            this.txtHoaDonNam = new System.Windows.Forms.TextBox();
            this.txtHoaDonThang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkbox_ngaylaphd);
            this.panel1.Controls.Add(this.btnXuatHoaDon);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.dtpNgayLapHD);
            this.panel1.Controls.Add(this.cboTrangThaiThanhToan);
            this.panel1.Controls.Add(this.txtHoaDonNam);
            this.panel1.Controls.Add(this.txtHoaDonThang);
            this.panel1.Controls.Add(this.txtTenKhachHang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 235);
            this.panel1.TabIndex = 0;
            // 
            // checkbox_ngaylaphd
            // 
            this.checkbox_ngaylaphd.AutoSize = true;
            this.checkbox_ngaylaphd.Location = new System.Drawing.Point(884, 88);
            this.checkbox_ngaylaphd.Name = "checkbox_ngaylaphd";
            this.checkbox_ngaylaphd.Size = new System.Drawing.Size(18, 17);
            this.checkbox_ngaylaphd.TabIndex = 5;
            this.checkbox_ngaylaphd.UseVisualStyleBackColor = true;
            this.checkbox_ngaylaphd.CheckedChanged += new System.EventHandler(this.checkbox_ngaylaphd_CheckedChanged);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.AutoSize = true;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(876, 185);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(139, 34);
            this.btnXuatHoaDon.TabIndex = 4;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(730, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 34);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(601, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(471, 185);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 34);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(917, 79);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(157, 32);
            this.dtpNgayLapHD.TabIndex = 3;
            this.dtpNgayLapHD.Value = new System.DateTime(2025, 3, 1, 0, 0, 0, 0);
            // 
            // cboTrangThaiThanhToan
            // 
            this.cboTrangThaiThanhToan.FormattingEnabled = true;
            this.cboTrangThaiThanhToan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cboTrangThaiThanhToan.Location = new System.Drawing.Point(917, 26);
            this.cboTrangThaiThanhToan.Name = "cboTrangThaiThanhToan";
            this.cboTrangThaiThanhToan.Size = new System.Drawing.Size(282, 32);
            this.cboTrangThaiThanhToan.TabIndex = 2;
            this.cboTrangThaiThanhToan.SelectedIndexChanged += new System.EventHandler(this.cboTrangThaiThanhToan_SelectedIndexChanged);
            // 
            // txtHoaDonNam
            // 
            this.txtHoaDonNam.Location = new System.Drawing.Point(345, 131);
            this.txtHoaDonNam.Name = "txtHoaDonNam";
            this.txtHoaDonNam.Size = new System.Drawing.Size(282, 32);
            this.txtHoaDonNam.TabIndex = 1;
            this.txtHoaDonNam.TextChanged += new System.EventHandler(this.txtHoaDonNam_TextChanged);
            // 
            // txtHoaDonThang
            // 
            this.txtHoaDonThang.Location = new System.Drawing.Point(345, 79);
            this.txtHoaDonThang.Name = "txtHoaDonThang";
            this.txtHoaDonThang.Size = new System.Drawing.Size(282, 32);
            this.txtHoaDonThang.TabIndex = 1;
            this.txtHoaDonThang.TextChanged += new System.EventHandler(this.txtHoaDonThang_TextChanged);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(345, 20);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(282, 32);
            this.txtTenKhachHang.TabIndex = 1;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày lập hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hóa đơn năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa đơn tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 525);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 525);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDon.ColumnHeadersHeight = 29;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 28);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1324, 494);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1057, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HoaDonGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HoaDonGUI";
            this.Text = "HoaDonGUI";
            this.Load += new System.EventHandler(this.HoaDonGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtTenKhachHang;
        private Label label1;
        private DateTimePicker dtpNgayLapHD;
        private ComboBox cboTrangThaiThanhToan;
        private TextBox txtHoaDonNam;
        private TextBox txtHoaDonThang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXuatHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private CheckBox checkbox_ngaylaphd;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dgvHoaDon;
        private Button button1;
    }
}