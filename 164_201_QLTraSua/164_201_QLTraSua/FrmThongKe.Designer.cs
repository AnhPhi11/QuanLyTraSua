namespace _164_201_QLTraSua
{
    partial class FrmThongKe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvchitiet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthongke = new System.Windows.Forms.Button();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.radchon = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvchitiet);
            this.groupBox2.Location = new System.Drawing.Point(16, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(789, 315);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // dgvchitiet
            // 
            this.dgvchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvchitiet.Location = new System.Drawing.Point(3, 24);
            this.dgvchitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvchitiet.Name = "dgvchitiet";
            this.dgvchitiet.RowHeadersWidth = 51;
            this.dgvchitiet.RowTemplate.Height = 25;
            this.dgvchitiet.Size = new System.Drawing.Size(783, 287);
            this.dgvchitiet.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDS);
            this.groupBox1.Location = new System.Drawing.Point(469, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(742, 243);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.ThanhTien,
            this.maNV,
            this.maKH,
            this.TrangThai});
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(3, 24);
            this.dgvDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 25;
            this.dgvDS.Size = new System.Drawing.Size(736, 215);
            this.dgvDS.TabIndex = 0;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 125;
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "maKH";
            this.maKH.HeaderText = "Mã KH";
            this.maKH.MinimumWidth = 6;
            this.maKH.Name = "maKH";
            this.maKH.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.BackColor = System.Drawing.Color.Cyan;
            this.lbldoanhthu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldoanhthu.Location = new System.Drawing.Point(178, 182);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(207, 41);
            this.lbldoanhthu.TabIndex = 13;
            this.lbldoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 49);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doanh Thu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.Lime;
            this.btnthongke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnthongke.Location = new System.Drawing.Point(19, 63);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(160, 73);
            this.btnthongke.TabIndex = 11;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // dtpngay
            // 
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngay.Location = new System.Drawing.Point(294, 6);
            this.dtpngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(156, 27);
            this.dtpngay.TabIndex = 10;
            // 
            // radchon
            // 
            this.radchon.AutoSize = true;
            this.radchon.Location = new System.Drawing.Point(178, 6);
            this.radchon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radchon.Name = "radchon";
            this.radchon.Size = new System.Drawing.Size(100, 24);
            this.radchon.TabIndex = 9;
            this.radchon.TabStop = true;
            this.radchon.Text = "Chọn ngày";
            this.radchon.UseVisualStyleBackColor = true;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(23, 6);
            this.radAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(70, 24);
            this.radAll.TabIndex = 8;
            this.radAll.TabStop = true;
            this.radAll.Text = "Tất cả";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldoanhthu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.dtpngay);
            this.Controls.Add(this.radchon);
            this.Controls.Add(this.radAll);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvchitiet;
        private GroupBox groupBox1;
        private DataGridView dgvDS;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn maNV;
        private DataGridViewTextBoxColumn maKH;
        private DataGridViewTextBoxColumn TrangThai;
        private Label lbldoanhthu;
        private Label label1;
        private Button btnthongke;
        private DateTimePicker dtpngay;
        private RadioButton radchon;
        private RadioButton radAll;
    }
}