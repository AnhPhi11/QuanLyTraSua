namespace _164_201_QLTraSua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeNgay});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(86, 24);
            this.mnuThongKe.Text = "Thống Kê";
            this.mnuThongKe.Click += new System.EventHandler(this.mnuThongKe_Click);
            // 
            // mnuThongKeNgay
            // 
            this.mnuThongKeNgay.Name = "mnuThongKeNgay";
            this.mnuThongKeNgay.Size = new System.Drawing.Size(224, 26);
            this.mnuThongKeNgay.Text = "Thống Kê Ngày";
            this.mnuThongKeNgay.Click += new System.EventHandler(this.mnuThongKeNgay_Click);
            // 
            // mnuTimKiemSP
            // 
            this.mnuTimKiemSP.Name = "mnuTimKiemSP";
            this.mnuTimKiemSP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuTimKiemSP.Size = new System.Drawing.Size(292, 26);
            this.mnuTimKiemSP.Text = "Tìm Kiếm Sản Phẩm";
            this.mnuTimKiemSP.Click += new System.EventHandler(this.mnuTimKiemSP_Click);
            // 
            // mnuTimKiemKH
            // 
            this.mnuTimKiemKH.Name = "mnuTimKiemKH";
            this.mnuTimKiemKH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuTimKiemKH.Size = new System.Drawing.Size(292, 26);
            this.mnuTimKiemKH.Text = "Tìm Kiếm Khách Hàng";
            this.mnuTimKiemKH.Click += new System.EventHandler(this.mnuTimKiemKH_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimKiemKH,
            this.mnuTimKiemSP,
            this.timToolStripMenuItem});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(86, 24);
            this.mnuTimKiem.Text = "Tìm Kiếm";
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.timToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.timToolStripMenuItem.Text = "Tìm Kiếm Nhân Viên";
            this.timToolStripMenuItem.Click += new System.EventHandler(this.timToolStripMenuItem_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.mnuSanPham.Size = new System.Drawing.Size(239, 26);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.mnuNhanVien.Size = new System.Drawing.Size(239, 26);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.mnuNhaCungCap.Size = new System.Drawing.Size(239, 26);
            this.mnuNhaCungCap.Text = "Nhà Cung Cấp";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuLoaiSanPham
            // 
            this.mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            this.mnuLoaiSanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnuLoaiSanPham.Size = new System.Drawing.Size(239, 26);
            this.mnuLoaiSanPham.Text = "Loại Sản Phẩm";
            this.mnuLoaiSanPham.Click += new System.EventHandler(this.mnuLoaiSanPham_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuKhachHang.Size = new System.Drawing.Size(239, 26);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuHoaDon.Size = new System.Drawing.Size(239, 26);
            this.mnuHoaDon.Text = "Hóa Đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDon,
            this.mnuKhachHang,
            this.mnuLoaiSanPham,
            this.mnuNhaCungCap,
            this.mnuNhanVien,
            this.mnuSanPham});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(96, 24);
            this.mnuChucNang.Text = "Chức Năng";
            this.mnuChucNang.Click += new System.EventHandler(this.mnuChucNang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang,
            this.mnuTimKiem,
            this.mnuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuTimKiemSP;
        private ToolStripMenuItem mnuTimKiemKH;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuChucNang;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem timToolStripMenuItem;
        private ToolStripMenuItem mnuThongKeNgay;
    }
}