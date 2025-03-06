using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class NhanVienGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienGUI));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbackgroud = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblNhanvienID = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSodienthoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.taiKhoanDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.dpkNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(485, 159);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hồ sơ nhân viên";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(1132, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(1132, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(1132, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 38);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(1132, 484);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 38);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(1132, 622);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblbackgroud);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 156);
            this.panel1.TabIndex = 7;
            // 
            // lblbackgroud
            // 
            this.lblbackgroud.AutoSize = true;
            this.lblbackgroud.BackColor = System.Drawing.Color.Transparent;
            this.lblbackgroud.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbackgroud.ForeColor = System.Drawing.Color.Black;
            this.lblbackgroud.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblbackgroud.Location = new System.Drawing.Point(355, 75);
            this.lblbackgroud.Name = "lblbackgroud";
            this.lblbackgroud.Size = new System.Drawing.Size(639, 53);
            this.lblbackgroud.TabIndex = 0;
            this.lblbackgroud.Text = "Quản lý thu phí cấp nước sạch";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblHoten.Location = new System.Drawing.Point(158, 350);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(79, 26);
            this.lblHoten.TabIndex = 8;
            this.lblHoten.Text = "Họ tên:";
            // 
            // lblNhanvienID
            // 
            this.lblNhanvienID.AutoSize = true;
            this.lblNhanvienID.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblNhanvienID.Location = new System.Drawing.Point(159, 281);
            this.lblNhanvienID.Name = "lblNhanvienID";
            this.lblNhanvienID.Size = new System.Drawing.Size(83, 26);
            this.lblNhanvienID.TabIndex = 9;
            this.lblNhanvienID.Text = "Mã NV:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblDiachi.Location = new System.Drawing.Point(158, 423);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(85, 26);
            this.lblDiachi.TabIndex = 10;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = true;
            this.lblSodienthoai.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblSodienthoai.Location = new System.Drawing.Point(591, 282);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(141, 26);
            this.lblSodienthoai.TabIndex = 11;
            this.lblSodienthoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblEmail.Location = new System.Drawing.Point(591, 346);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 26);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblNgaysinh.Location = new System.Drawing.Point(591, 419);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(111, 26);
            this.lblNgaysinh.TabIndex = 13;
            this.lblNgaysinh.Text = "Ngày sinh:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(234, 279);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(197, 32);
            this.txtStaffID.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 32);
            this.txtName.TabIndex = 15;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(234, 417);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(197, 32);
            this.txtAdd.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(725, 273);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(197, 32);
            this.txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(725, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 32);
            this.txtEmail.TabIndex = 18;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(74, 522);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 56;
            this.dgvNhanVien.Size = new System.Drawing.Size(1023, 248);
            this.dgvNhanVien.TabIndex = 20;
            // 
            // taiKhoanDTOBindingSource
            // 
            this.taiKhoanDTOBindingSource.DataSource = typeof(DTO.TaiKhoanDTO);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(1132, 558);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 38);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dpkNgaysinh
            // 
            this.dpkNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaysinh.Location = new System.Drawing.Point(725, 417);
            this.dpkNgaysinh.Name = "dpkNgaysinh";
            this.dpkNgaysinh.Size = new System.Drawing.Size(197, 32);
            this.dpkNgaysinh.TabIndex = 23;
            // 
            // NhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 760);
            this.Controls.Add(this.dpkNgaysinh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSodienthoai);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblNhanvienID);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NhanVienGUI";
            this.Text = "NhanVienGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExport;
        private Button btnClose;
        private Panel panel1;
        private Label lblbackgroud;
        private Label lblHoten;
        private Label lblNhanvienID;
        private Label lblDiachi;
        private Label lblSodienthoai;
        private Label lblEmail;
        private Label lblNgaysinh;
        private TextBox txtStaffID;
        private TextBox txtName;
        private TextBox txtAdd;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private DataGridView dgvNhanVien;
        private BindingSource taiKhoanDTOBindingSource;
        private Button btnSearch;
        private DateTimePicker dpkNgaysinh;
    }
}