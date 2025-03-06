using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class KhachHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangGUI));
            this.taiKhoanDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustomeID = new System.Windows.Forms.TextBox();
            this.lblNgaydangky = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSodienthoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblKhachhangID = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblbackgroud = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dpkNgaydangky = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taiKhoanDTOBindingSource
            // 
            this.taiKhoanDTOBindingSource.DataSource = typeof(DTO.TaiKhoanDTO);
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Location = new System.Drawing.Point(141, 501);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.ReadOnly = true;
            this.dgvKhachhang.RowHeadersWidth = 50;
            this.dgvKhachhang.Size = new System.Drawing.Size(786, 194);
            this.dgvKhachhang.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(746, 316);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 32);
            this.txtEmail.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(746, 224);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 32);
            this.txtPhone.TabIndex = 37;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(203, 400);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(196, 32);
            this.txtAdd.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 316);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 32);
            this.txtName.TabIndex = 35;
            // 
            // txtCustomeID
            // 
            this.txtCustomeID.Location = new System.Drawing.Point(203, 231);
            this.txtCustomeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomeID.Name = "txtCustomeID";
            this.txtCustomeID.Size = new System.Drawing.Size(196, 32);
            this.txtCustomeID.TabIndex = 34;
            // 
            // lblNgaydangky
            // 
            this.lblNgaydangky.AutoSize = true;
            this.lblNgaydangky.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNgaydangky.Location = new System.Drawing.Point(632, 400);
            this.lblNgaydangky.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaydangky.Name = "lblNgaydangky";
            this.lblNgaydangky.Size = new System.Drawing.Size(123, 22);
            this.lblNgaydangky.TabIndex = 33;
            this.lblNgaydangky.Text = "Ngày đăng ký:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEmail.Location = new System.Drawing.Point(632, 316);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email:";
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = true;
            this.lblSodienthoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSodienthoai.Location = new System.Drawing.Point(638, 231);
            this.lblSodienthoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(120, 22);
            this.lblSodienthoai.TabIndex = 31;
            this.lblSodienthoai.Text = "Số điện thoại:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDiachi.Location = new System.Drawing.Point(141, 410);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(74, 22);
            this.lblDiachi.TabIndex = 30;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblKhachhangID
            // 
            this.lblKhachhangID.AutoSize = true;
            this.lblKhachhangID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblKhachhangID.Location = new System.Drawing.Point(141, 238);
            this.lblKhachhangID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhachhangID.Name = "lblKhachhangID";
            this.lblKhachhangID.Size = new System.Drawing.Size(75, 22);
            this.lblKhachhangID.TabIndex = 29;
            this.lblKhachhangID.Text = "Mã KH:";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblHoten.Location = new System.Drawing.Point(141, 326);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(68, 22);
            this.lblHoten.TabIndex = 28;
            this.lblHoten.Text = "Họ tên:";
            // 
            // lblbackgroud
            // 
            this.lblbackgroud.AutoSize = true;
            this.lblbackgroud.BackColor = System.Drawing.Color.Transparent;
            this.lblbackgroud.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbackgroud.ForeColor = System.Drawing.Color.Black;
            this.lblbackgroud.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblbackgroud.Location = new System.Drawing.Point(259, 41);
            this.lblbackgroud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbackgroud.Name = "lblbackgroud";
            this.lblbackgroud.Size = new System.Drawing.Size(639, 53);
            this.lblbackgroud.TabIndex = 0;
            this.lblbackgroud.Text = "Quản lý thu phí cấp nước sạch";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblbackgroud);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 106);
            this.panel1.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(1019, 547);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 37);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(1019, 409);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 37);
            this.btnExport.TabIndex = 25;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(1019, 348);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(1019, 276);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 37);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(1019, 205);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(453, 148);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 45);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Hồ sơ khách hàng";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(1019, 482);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 37);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dpkNgaydangky
            // 
            this.dpkNgaydangky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaydangky.Location = new System.Drawing.Point(746, 400);
            this.dpkNgaydangky.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpkNgaydangky.Name = "dpkNgaydangky";
            this.dpkNgaydangky.Size = new System.Drawing.Size(196, 32);
            this.dpkNgaydangky.TabIndex = 43;
            // 
            // KhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 760);
            this.Controls.Add(this.dpkNgaydangky);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCustomeID);
            this.Controls.Add(this.lblNgaydangky);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSodienthoai);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblKhachhangID);
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
            this.Name = "KhachHangGUI";
            this.Text = "KhachHangGUI";
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource taiKhoanDTOBindingSource;
        private DataGridView dgvKhachhang;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAdd;
        private TextBox txtName;
        private TextBox txtCustomeID;
        private Label lblNgaydangky;
        private Label lblEmail;
        private Label lblSodienthoai;
        private Label lblDiachi;
        private Label lblKhachhangID;
        private Label lblHoten;
        private Label lblbackgroud;
        private Panel panel1;
        private Button btnClose;
        private Button btnExport;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblTitle;
        private Button btnSearch;
        private DateTimePicker dpkNgaydangky;
    }
}