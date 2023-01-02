namespace _164_201_QLTraSua
{
    partial class FrmTimSanPham
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
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.radLoaiSP = new System.Windows.Forms.RadioButton();
            this.radSanPham = new System.Windows.Forms.RadioButton();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.GiaBan,
            this.MaNCC,
            this.maLoai,
            this.Hinh,
            this.TrangThai});
            this.dgvDS.Location = new System.Drawing.Point(6, 27);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 29;
            this.dgvDS.Size = new System.Drawing.Size(1063, 256);
            this.dgvDS.TabIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Ma SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Ten SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "So luong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaNhap";
            this.GiaBan.HeaderText = "Gia nhap";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 125;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Ma NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 125;
            // 
            // maLoai
            // 
            this.maLoai.DataPropertyName = "maLoai";
            this.maLoai.HeaderText = "Ma loai";
            this.maLoai.MinimumWidth = 6;
            this.maLoai.Name = "maLoai";
            this.maLoai.Width = 125;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hinh";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trang thai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvDS);
            this.grpDanhSach.Location = new System.Drawing.Point(14, 235);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1075, 310);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh Sách Sản Phẩm";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(270, 103);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(475, 28);
            this.cboLoaiSP.TabIndex = 3;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            this.cboLoaiSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLoaiSP_KeyDown);
            this.cboLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLoaiSP_KeyPress);
            // 
            // radLoaiSP
            // 
            this.radLoaiSP.AutoSize = true;
            this.radLoaiSP.Location = new System.Drawing.Point(53, 109);
            this.radLoaiSP.Name = "radLoaiSP";
            this.radLoaiSP.Size = new System.Drawing.Size(127, 24);
            this.radLoaiSP.TabIndex = 1;
            this.radLoaiSP.TabStop = true;
            this.radLoaiSP.Text = "Loại Sản Phẩm";
            this.radLoaiSP.UseVisualStyleBackColor = true;
            this.radLoaiSP.CheckedChanged += new System.EventHandler(this.radLoaiSP_CheckedChanged);
            // 
            // radSanPham
            // 
            this.radSanPham.AutoSize = true;
            this.radSanPham.Location = new System.Drawing.Point(53, 173);
            this.radSanPham.Name = "radSanPham";
            this.radSanPham.Size = new System.Drawing.Size(122, 24);
            this.radSanPham.TabIndex = 4;
            this.radSanPham.TabStop = true;
            this.radSanPham.Text = "Tên Sản Phẩm";
            this.radSanPham.UseVisualStyleBackColor = true;
            this.radSanPham.CheckedChanged += new System.EventHandler(this.radSanPham_CheckedChanged);
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(270, 172);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(475, 27);
            this.txtGiaSP.TabIndex = 5;
            this.txtGiaSP.TextChanged += new System.EventHandler(this.txtGiaSP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(461, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm Sản Phẩm";
            // 
            // FrmTimSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 600);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.radLoaiSP);
            this.Controls.Add(this.radSanPham);
            this.Controls.Add(this.txtGiaSP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimSanPham";
            this.Text = "FrmTimSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTimSanPham_FormClosing);
            this.Load += new System.EventHandler(this.FrmTimSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvDS;
        private GroupBox grpDanhSach;
        private ComboBox cboLoaiSP;
        private RadioButton radLoaiSP;
        private RadioButton radSanPham;
        private TextBox txtGiaSP;
        private Label label1;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn MaNCC;
        private DataGridViewTextBoxColumn maLoai;
        private DataGridViewTextBoxColumn Hinh;
        private DataGridViewTextBoxColumn TrangThai;
    }
}