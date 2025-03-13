namespace GUI
{
    partial class HoaDonGUI_Sua
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
            this.checkbox_ngaylaphd = new System.Windows.Forms.CheckBox();
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
            this.SuspendLayout();
            // 
            // checkbox_ngaylaphd
            // 
            this.checkbox_ngaylaphd.AutoSize = true;
            this.checkbox_ngaylaphd.Location = new System.Drawing.Point(741, 82);
            this.checkbox_ngaylaphd.Name = "checkbox_ngaylaphd";
            this.checkbox_ngaylaphd.Size = new System.Drawing.Size(18, 17);
            this.checkbox_ngaylaphd.TabIndex = 27;
            this.checkbox_ngaylaphd.UseVisualStyleBackColor = true;
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(774, 73);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(157, 32);
            this.dtpNgayLapHD.TabIndex = 26;
            this.dtpNgayLapHD.Value = new System.DateTime(2025, 3, 1, 0, 0, 0, 0);
            // 
            // cboTrangThaiThanhToan
            // 
            this.cboTrangThaiThanhToan.FormattingEnabled = true;
            this.cboTrangThaiThanhToan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cboTrangThaiThanhToan.Location = new System.Drawing.Point(774, 25);
            this.cboTrangThaiThanhToan.Name = "cboTrangThaiThanhToan";
            this.cboTrangThaiThanhToan.Size = new System.Drawing.Size(282, 32);
            this.cboTrangThaiThanhToan.TabIndex = 25;
            // 
            // txtHoaDonNam
            // 
            this.txtHoaDonNam.Location = new System.Drawing.Point(218, 128);
            this.txtHoaDonNam.Name = "txtHoaDonNam";
            this.txtHoaDonNam.Size = new System.Drawing.Size(282, 32);
            this.txtHoaDonNam.TabIndex = 24;
            // 
            // txtHoaDonThang
            // 
            this.txtHoaDonThang.Location = new System.Drawing.Point(218, 76);
            this.txtHoaDonThang.Name = "txtHoaDonThang";
            this.txtHoaDonThang.Size = new System.Drawing.Size(282, 32);
            this.txtHoaDonThang.TabIndex = 23;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(218, 28);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(282, 32);
            this.txtTenKhachHang.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày lập hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trạng thái thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hóa đơn năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hóa đơn tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên khách hàng";
            // 
            // HoaDonGUI_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 522);
            this.Controls.Add(this.checkbox_ngaylaphd);
            this.Controls.Add(this.dtpNgayLapHD);
            this.Controls.Add(this.cboTrangThaiThanhToan);
            this.Controls.Add(this.txtHoaDonNam);
            this.Controls.Add(this.txtHoaDonThang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HoaDonGUI_Sua";
            this.Text = "HoaDon_SuaGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_ngaylaphd;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.ComboBox cboTrangThaiThanhToan;
        private System.Windows.Forms.TextBox txtHoaDonNam;
        private System.Windows.Forms.TextBox txtHoaDonThang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}