using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class TrangChuGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySuDungNuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchNhânVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuQuanLySuDungNuoc,
            this.mnuHoaDon,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1609, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(112, 28);
            this.mnuHeThong.Text = "Trang chủ";
            this.mnuHeThong.Click += new System.EventHandler(this.mnuHeThong_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(181, 28);
            this.mnuNhanVien.Text = "Quản lý nhân viên";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(197, 28);
            this.mnuKhachHang.Text = "Quản lý khách hàng";
            // 
            // mnuQuanLySuDungNuoc
            // 
            this.mnuQuanLySuDungNuoc.Name = "mnuQuanLySuDungNuoc";
            this.mnuQuanLySuDungNuoc.Size = new System.Drawing.Size(215, 28);
            this.mnuQuanLySuDungNuoc.Text = "Quản lý sử dụng nước";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(167, 28);
            this.mnuHoaDon.Text = "Quản lý hóa đơn";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtDanhSáchNhânVToolStripMenuItem,
            this.xuấtDanhSáchKháchHàngToolStripMenuItem,
            this.xuấtHóaĐơnToolStripMenuItem});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(95, 28);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // xuấtDanhSáchNhânVToolStripMenuItem
            // 
            this.xuấtDanhSáchNhânVToolStripMenuItem.Name = "xuấtDanhSáchNhânVToolStripMenuItem";
            this.xuấtDanhSáchNhânVToolStripMenuItem.Size = new System.Drawing.Size(339, 28);
            this.xuấtDanhSáchNhânVToolStripMenuItem.Text = "Xuất danh sách nhân viên";
            // 
            // xuấtDanhSáchKháchHàngToolStripMenuItem
            // 
            this.xuấtDanhSáchKháchHàngToolStripMenuItem.Name = "xuấtDanhSáchKháchHàngToolStripMenuItem";
            this.xuấtDanhSáchKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(339, 28);
            this.xuấtDanhSáchKháchHàngToolStripMenuItem.Text = "Xuất danh sách khách hàng";
            // 
            // xuấtHóaĐơnToolStripMenuItem
            // 
            this.xuấtHóaĐơnToolStripMenuItem.Name = "xuấtHóaĐơnToolStripMenuItem";
            this.xuấtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(339, 28);
            this.xuấtHóaĐơnToolStripMenuItem.Text = "Xuất hóa đơn";
            // 
            // TrangChuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1609, 885);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChuGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản ly thu phí cấp nước sạch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChuGUI_FormClosing);
            this.Load += new System.EventHandler(this.TrangChuGUI_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuQuanLySuDungNuoc;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem xuấtDanhSáchNhânVToolStripMenuItem;
        private ToolStripMenuItem xuấtDanhSáchKháchHàngToolStripMenuItem;
        private ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem;
    }
}