using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _164_201_QLTraSua
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        DataSet dsnv = new DataSet();
        DataSet dsloai = new DataSet();
        DataSet dssp = new DataSet();
        DataSet dssize = new DataSet();
        
        int vt = 0;
        int flag = 0;
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            vt = 0;
            xulytextbox(true);
            xulybutton(true);
            btnThemCTHD.Enabled = false;
            dgvDS.Enabled = true;
            btnTinhTien.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtTienNhan.ReadOnly = true;

            loaddulieu_datagird(dgvDS, "  select * from HoaDon ");

            dsnv = c.Laydulieu("select * from NhanVien");
            dsloai = c.Laydulieu("select * from LoaiSP");
            //dssp = c.Laydulieu("select * from SanPham");
            dssize = c.Laydulieu("select * from Size");

            hienthicbo(dsnv, cboMaNV, "MaNV", "HoTenNV");
            hienthicbo(dsloai, cboLoaiSP, "MaLoai", "TenLoai");
            //hienthicbo(dssp, cboTenSP, "MaSP", "TenSP");

            hienthicbo(dssize, cboSize, "MaSize", "TenSize");
            hienthi(ds.Tables[0], vt);
            
            khoadgvHD();
            khoadgvCTHD();
            f = true;

        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void xulytextbox(Boolean t)
        {
            txtMaHD.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtThanhTien.ReadOnly = t;
            dtpNgayLap.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaKH.Enabled = false;
            cboTrangThai.Enabled = false;
            txtThanhTien.ReadOnly = true;
            btnTim.Enabled = false;
            btnKhachHangMoi.Enabled = false;
            btnThemCTHD.Enabled = false;

            cboLoaiSP.Enabled = false;
            cboTenSP.Enabled = false;
            txtSoLuong.ReadOnly = true;
            cboSize.Enabled = false;
            
            
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        string Maphatsinh(DataSet d)
        {
            string mahd = "";
            if ((ds.Tables[0].Rows.Count + 1) <= 9)
                mahd = "HD0" + (ds.Tables[0].Rows.Count + 1).ToString();
            else
                mahd = "HD" + (ds.Tables[0].Rows.Count + 1).ToString();
            return mahd;
        }

        private void FrmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        void hienthi(DataTable dt, int vt)
        {
            txtMaHD.Text = dt.Rows[vt]["MaHD"].ToString();
            txtThanhTien.Text = dt.Rows[vt]["ThanhTien"].ToString();
            cboMaKH.Text = dt.Rows[vt]["maKH"].ToString();
            cboMaNV.Text = dt.Rows[vt]["maNV"].ToString();           

            if (dt.Rows[vt]["TrangThai"].ToString() == "1")
                cboTrangThai.SelectedIndex = 1;
            else
                cboTrangThai.SelectedIndex = 0;
            dtpNgayLap.CustomFormat = DateTime.Parse(dt.Rows[vt]["NgayLap"].ToString()).ToString("MM-dd-yyyy HH:mm:ss");           
            //dtpNgayLap.Text = dt.Rows[vt]["NgayLap"].ToString();

            string manv;
            manv = dt.Rows[vt]["maNV"].ToString();
            DataView dtvMaNV = new DataView();
            dtvMaNV.Table = dsnv.Tables[0];
            cboMaNV.DataSource = dtvMaNV;
            cboMaNV.DisplayMember = "HoTenNV";
            cboMaNV.ValueMember = "MaNV";
            dtvMaNV.RowFilter = "MaNV = '" + manv + "'";

            load_cthdtheohd(dt.Rows[vt]["MaHD"].ToString());
        }
        void load_cthdtheohd(string mahd)
        {
            string s = "select * from CTHD where MaHD = '" + mahd + "'";
            DataSet cthd = c.Laydulieu(s);
            dgvCTHD.DataSource = null;
            dgvCTHD.DataSource = cthd.Tables[0];
        }

        void hienthicbo(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            txtMaHD.Text = Maphatsinh(ds);
            txtMaHD.ReadOnly = true;
            txtSDT.ReadOnly = false;           
            txtThanhTien.Text = "";
            dtpNgayLap.CustomFormat = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            dtpNgayLap.Enabled = true;
            cboMaNV.Enabled = true;
            cboMaKH.Text = "";
            btnTim.Enabled = true;
            btnKhachHangMoi.Enabled = true;
            
            btnThemCTHD.Enabled = false;

            dgvCTHD.DataSource = null;
            TaoCotHD();

            cboLoaiSP.Enabled = true;
            cboTenSP.Enabled = true;
            txtSoLuong.ReadOnly = false;          
            cboSize.Enabled = true;

            lblKhachHang.Text = "";
            txtSDT.Text = "";

            dgvDS.Enabled = false;
            btnThemCTHD.Enabled = true;
            hienthicbo(dsnv, cboMaNV, "MaNV", "HoTenNV");
            opendgvCTHD();
            flag = 1;
           
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            flag = 3;
            xulytextbox(false);
            txtMaHD.ReadOnly = true;
            xulybutton(false);

          
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            flag = 2;
            xulytextbox(false);
            xulybutton(false);
            txtMaHD.ReadOnly = true;
            cboMaNV.Enabled = true;
            //cboTrangThai.Enabled = true;
            dtpNgayLap.Enabled = true;
            hienthicbo(dsnv, cboMaNV, "MaNV", "HoTenNV");
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            string cthd = "";

            string sql2 = "";
            string sql3 = "";
            string sql4 = "";
            string sql5 = "";

            if (flag == 1)//them
            {
                sql = "insert into HoaDon VALUES('" + txtMaHD.Text + "','" + dtpNgayLap.CustomFormat + "','" + txtThanhTien.Text + "','" + cboMaNV.SelectedValue + "','" + cboMaKH.Text + "','" + cboTrangThai.SelectedIndex + "')";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                }

                int tongsoluong = 0;

                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    string hd, sp, si, ten, tensize, sl, gb, tt;
                    hd = dgvCTHD.Rows[i].Cells[0].Value.ToString();
                    sp = dgvCTHD.Rows[i].Cells[1].Value.ToString();
                    si = dgvCTHD.Rows[i].Cells[2].Value.ToString();
                    ten = dgvCTHD.Rows[i].Cells[3].Value.ToString();
                    tensize = dgvCTHD.Rows[i].Cells[4].Value.ToString();
                    sl = dgvCTHD.Rows[i].Cells[5].Value.ToString();
                    gb = dgvCTHD.Rows[i].Cells[6].Value.ToString();
                    tt = dgvCTHD.Rows[i].Cells[7].Value.ToString();
                    
                    cthd += "insert into CTHD values ('" + hd + "','" + sp + "','" + si + "',N'" + ten + "','" + tensize + "', " + sl + ", " + gb + "," + tt + ")";                                       

                    string masp = dgvCTHD.Rows[i].Cells["maSP"].Value.ToString();
                    string masize = dgvCTHD.Rows[i].Cells["maSize"].Value.ToString();
                    DataSet dsctsp = c.Laydulieu("Select SoLuong from CTSP where MaSP = '" + masp + "' and MaSize='" + masize + "'");
                    string soluongct = dsctsp.Tables[0].Rows[0]["SoLuong"].ToString();

                    int slct1 = int.Parse(soluongct);   
                    int slct2 = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                    slct1 = slct1 - slct2;
                    sql2 = "update CTSP set SoLuong=" + slct1 + " where MaSP='" + masp + "' and MaSize='" + masize + "'";
                    c.Capnhatdulieu(sql2);

                    dssp = c.Laydulieu("Select SoLuong from SanPham where MaSP = '" + masp + "'");
                    string soluong2 = dssp.Tables[0].Rows[0]["SoLuong"].ToString();
                    int sl1 = int.Parse(soluong2);
                    int sl2 = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                    sl1 -= sl2;
                    sql3 = "update SanPham set SoLuong=" + sl1 + " where MaSP= '" + masp + "'";
                    c.Capnhatdulieu(sql3);

                }
                               
                if (c.Capnhatdulieu(cthd) > 0)
                {
                    MessageBox.Show("Thêm CTHD Thành Công!");
                }
               
                if (c.Capnhatdulieu(sql2) > 0)
                {
                    MessageBox.Show("Cập nhật Số Lượng Tồn Thành Công!");
                }

                FrmHoaDon_Load(sender, e);
            }
            if (flag == 2)//sua
            {
                sql = "update HoaDon set NgayLap='" + dtpNgayLap.CustomFormat + "',ThanhTien= '" + txtThanhTien.Text + "', maNV= '" + cboMaNV.SelectedValue + "' , maKH = '" + cboMaKH.Text + "' ,TrangThai ='" + cboTrangThai.SelectedIndex + "'where MaHD='" + txtMaHD.Text + "'";
                MessageBox.Show(sql);
                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    FrmHoaDon_Load(sender, e);
                }
            }
            if (flag == 3)//xoa
            {
                sql = "update HoaDon set TrangThai = 0 where MaHD='" + txtMaHD.Text + "'";

                
                    if (c.Capnhatdulieu(sql) > 0)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        
                        for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                        {
                            string masp = dgvCTHD.Rows[i].Cells["maSP"].Value.ToString();
                            string masize = dgvCTHD.Rows[i].Cells["maSize"].Value.ToString();
                            DataSet dsctsp = c.Laydulieu("Select SoLuong from CTSP where MaSP = '" + masp + "' and MaSize='" + masize + "'");
                            string soluongct = dsctsp.Tables[0].Rows[0]["SoLuong"].ToString();

                            int slct1 = int.Parse(soluongct);
                            int slct2 = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                            slct1 = slct1 + slct2;
                            sql2 = "update CTSP set SoLuong=" + slct1 + " where MaSP='" + masp + "' and MaSize='" + masize + "'";
                            c.Capnhatdulieu(sql2);

                            dssp = c.Laydulieu("Select SoLuong from SanPham where MaSP = '" + masp + "'");
                            string soluong2 = dssp.Tables[0].Rows[0]["SoLuong"].ToString();
                            int sl1 = int.Parse(soluong2);
                            int sl2 = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                            sl1 += sl2;
                            sql3 = "update SanPham set SoLuong=" + sl1 + " where MaSP= '" + masp + "'";
                            c.Capnhatdulieu(sql3);


                        }

                    FrmHoaDon_Load(sender, e);

                    }
                

            }
            flag = 0;

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvCTHD.Columns.Clear();
            lblKhachHang.Text = "";
            txtSDT.Text = "";
            FrmHoaDon_Load(sender, e);
            hienthi(ds.Tables[0], vt);
        }

        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.ShowDialog();
            cboMaKH.Text = f.makh;
            lblKhachHang.Text = f.tenkh;
            txtSDT.Text = f.sdt;
        }
        string makh;
        Boolean TimKH()
        {
            ds = new DataSet();
            ds = c.Laydulieu("select * from khachhang where SDT ='" + txtSDT.Text + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {               
                makh = ds.Tables[0].Rows[0]["MaKH"].ToString();
                lblKhachHang.Text = ds.Tables[0].Rows[0]["HoTenKH"].ToString();
                cboMaKH.Text = makh;
                return true;
            }
            return false;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text != "")
                if (!TimKH())
                    MessageBox.Show("Không tìm thấy SĐT");

        }

        private void dgvDS_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvCTHD.Columns.Clear();
            vt = dgvDS.CurrentCell.RowIndex;
            hienthi(ds.Tables[0], vt);
            lblTongTien.Text = txtThanhTien.Text;           
            
        }

        //void taoanh_tufile(PictureBox p, string filename)
        //{
        //    Bitmap a = new Bitmap(filename);
        //    picMotAnh.Image = a;
        //    picMotAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        //}
        //private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        //{
        //    int soluongton = 0;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        string MaSP = txtMaSP.Text;

        //        DataSet dsctsp = new DataSet();
        //        dsctsp = c.Laydulieu("select * from CTSP where MaCTSP= '" + MaSP + "'");
        //        lblgiaban.Text = dsctsp.Tables[0].Rows[0]["GiaBan"].ToString();
        //        //txtSoLuong.Text = dsctsp.Tables[0].Rows[0]["SoLuong"].ToString();

        //        DataSet dssp = new DataSet();
        //        dssp = c.Laydulieu("select s.TenSP from SanPham s, CTSP c where s.MaSP = c.MaSP and c.MaCTSP = '" + MaSP + "'");
        //        txtTenSP.Text = dssp.Tables[0].Rows[0]["TenSP"].ToString();

        //        string hinh = dsctsp.Tables[0].Rows[0]["Hinh"].ToString();
        //        string duongdan = Path.GetFullPath("hinhanh") + @"\";
        //        taoanh_tufile(picMotAnh, duongdan + hinh);

        //        soluongton = int.Parse(dsctsp.Tables[0].Rows[0]["SoLuong"].ToString());
        //        btnThemCTHD.Enabled = true;

        //        DataSet dss = new DataSet();
        //        //string mas = MaCTSP.Substring(5);
        //        string mas = dsctsp.Tables[0].Rows[0]["maSize"].ToString();
        //        dss = c.Laydulieu("select masize, tensize from size where masize = '" + mas + "'");
        //        cboSize.Text = dss.Tables[0].Rows[0]["tenSize"].ToString();

        //    }
        //}

        void TaoCotHD()
        {            
            dgvCTHD.Columns.Add("MaHD", "Mã hóa đơn");
            dgvCTHD.Columns.Add("MaSP", "Mã sản phẩm");
            dgvCTHD.Columns.Add("MaSize", "Mã Size");
            dgvCTHD.Columns.Add("TenSP", "Tên sản phẩm");
            dgvCTHD.Columns.Add("TenSize", "Size");
            dgvCTHD.Columns.Add("SoLuong", "Số lượng");
            dgvCTHD.Columns.Add("GiaBan", "Giá bán");
            dgvCTHD.Columns.Add("ThanhTien", "Thành tiền");
        }

        void clearcthd()
        {
            cboLoaiSP.Text = "";
            cboTenSP.Text = "";
            txtSoLuong.Text = "";
            lblGiaNhap.Text = "";
            cboSize.Text = "";
        }
        
        float tongtien = 0;
        private bool KiemtraSP(object[] d, DataGridView dv)
        {
            for (int i = 0; i < dv.Rows.Count; i++)
            {
                if ( d[1].ToString() == dv.Rows[i].Cells[1].Value.ToString() && d[2].ToString() == dv.Rows[i].Cells[2].Value.ToString() )
                {
                    int soluongmoi = int.Parse(d[5].ToString());
                    string soluongcu = dv.Rows[i].Cells[5].Value.ToString();
                    int soluongcu2 = int.Parse(soluongcu);
                    int sl = soluongmoi + soluongcu2;
                    d[5] = sl;

                    int thanhtiencu = int.Parse(dgvCTHD.Rows[i].Cells[7].Value.ToString());
                    d[7] = int.Parse(d[7].ToString()) + thanhtiencu;
                    tongtien -= thanhtiencu;
                    tongtien += int.Parse(d[7].ToString());
                    dv.Rows.Add(d);
                    dgvCTHD.Rows.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLoaiSP.SelectedIndex != -1 && cboLoaiSP.SelectedIndex != -1 && txtSoLuong.Text != "" && lblGiaNhap.Text != "" && cboSize.SelectedIndex != -1)
                {
                    if (txtSoLuong.Text != "0")
                    {                       
                        string masp1 = dssp.Tables[0].Rows[0]["MaSP"].ToString();
                        string mas1 = cboSize.Text;
                        dssize = c.Laydulieu("select masize, tensize from size where tensize = '" + mas1 + "'");
                        string masize1 = dssize.Tables[0].Rows[0]["MaSize"].ToString();

                        DataSet dsctsp = c.Laydulieu("select SoLuong from CTSP where masp= '" + masp1 + "' and masize= '" + masize1 + "'");
                        string soluongton = dsctsp.Tables[0].Rows[0]["SoLuong"].ToString();
                        int soluongton1 = int.Parse(soluongton);

                        int soluong1 = int.Parse(txtSoLuong.Text);

                        if (soluongton1 > soluong1)
                        {
                            string mahd = txtMaHD.Text;
                            string masp = dssp.Tables[0].Rows[0]["MaSP"].ToString();
                            string tensp = dssp.Tables[0].Rows[0]["TenSP"].ToString();

                            string mas = cboSize.Text;
                            dssize = c.Laydulieu("select masize, tensize from size where tensize = '" + mas + "'");
                            string masize = dssize.Tables[0].Rows[0]["MaSize"].ToString();
                            string tensize = dssize.Tables[0].Rows[0]["TenSize"].ToString();

                            int soluong = int.Parse(txtSoLuong.Text);

                            float gianhap = float.Parse(lblGiaNhap.Text);
                            float giaban = 0;
                            if (masize == "SZ01")
                            {
                                giaban = gianhap * 3;
                            }
                            if (masize == "SZ02")
                            {
                                giaban = (gianhap * 3) + 10000;
                            }
                            if (masize == "SZ03")
                            {
                                giaban = (gianhap * 3) + 20000;
                            }
                            float thanhtien = (soluong * giaban);
                            //tongtien += thanhtien;
                            object[] d = { mahd, masp, masize, tensp, tensize, soluong, giaban, thanhtien };
                            //dgvCTHD.DataSource = null;
                            //dgvCTHD.Rows.Add(d);
                            //lblTongTien.Text = tongtien.ToString();

                            if (KiemtraSP(d, dgvCTHD) == false)
                            {
                                dgvCTHD.DataSource = null;
                                dgvCTHD.Rows.Add(d);
                                tongtien += thanhtien;
                                lblTongTien.Text = tongtien.ToString();
                                txtThanhTien.Text = tongtien.ToString();
                            }
                            else
                            {
                                lblTongTien.Text = tongtien.ToString();
                                txtThanhTien.Text = tongtien.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm này chỉ còn "+ soluongton1 + " không đủ để thêm vào hóa đơn!, Vui lòng mua sản phẩm khác!", "Thông báo");
                            return;
                            clearcthd();
                        }
                        

                        
                    }
                    else {
                        MessageBox.Show("Số lượng phải lớn hơn 0!. ", "Thông báo");
                        return;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin!. ", "Thông báo");
                    return;
                }
                clearcthd();
            }
            catch (Exception err)
            {           
                MessageBox.Show("Chưa nhập đầy đủ thông tin!. ", "Thông báo");
                dgvCTHD.Columns.Clear();
            }          
        }

        void khoadgvHD()
        {
            dgvDS.Columns[0].ReadOnly = true;
            dgvDS.Columns[1].ReadOnly = true;
            dgvDS.Columns[2].ReadOnly = true;
            dgvDS.Columns[3].ReadOnly = true;
            dgvDS.Columns[4].ReadOnly = true;
            dgvDS.Columns[5].ReadOnly = true;

        }

        void opendgvCTHD()
        {
            dgvCTHD.Columns[0].ReadOnly = true;
            dgvCTHD.Columns[1].ReadOnly = true;
            dgvCTHD.Columns[2].ReadOnly = true;
            dgvCTHD.Columns[3].ReadOnly = true;
            dgvCTHD.Columns[4].ReadOnly = true;
            dgvCTHD.Columns[5].ReadOnly = false;
            dgvCTHD.Columns[6].ReadOnly = true;
            dgvCTHD.Columns[7].ReadOnly = true;
        }

        void khoadgvCTHD()
        {
            dgvCTHD.Columns[0].ReadOnly = true;
            dgvCTHD.Columns[1].ReadOnly = true;
            dgvCTHD.Columns[2].ReadOnly = true;
            dgvCTHD.Columns[3].ReadOnly = true;
            dgvCTHD.Columns[4].ReadOnly = true;
            dgvCTHD.Columns[5].ReadOnly = true;
            dgvCTHD.Columns[6].ReadOnly = true;
            dgvCTHD.Columns[7].ReadOnly = true;
        }

        Boolean f = false;

        private void dgvCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sql = "";
                string sql2 = "";
                string sql3 = "";
                string sql4 = "";
                string sql5 = "";

                int slm = int.Parse(dgvCTHD.CurrentRow.Cells[5].Value.ToString());

                if (f == true && e.ColumnIndex >= 1 && e.ColumnIndex <= 6)
                {
                    if (slm <= 0)
                    {
                        MessageBox.Show("Số lượng phải được sửa >= 1, Vui lòng sửa lại! ");
                        //FrmHoaDon_Load(sender, e);
                      
                    }
                    else
                    {
                        sql += "update CTHD set SoLuong = " + dgvCTHD.CurrentRow.Cells[5].Value.ToString() +
                        "where  MaHD = '" + dgvCTHD.CurrentRow.Cells[0].Value.ToString() + "' and  maSP = '" + dgvCTHD.CurrentRow.Cells[1].Value.ToString() + "' and maSize = '" + dgvCTHD.CurrentRow.Cells[2].Value.ToString() + "'";

                        if (c.Capnhatdulieu(sql) > 0)
                        {
                            MessageBox.Show("Sửa thành công");
                        }
                        int tongtien3 = 0;
                        if (dgvCTHD.Rows.Count > 0)
                        {
                            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                            {
                                int sl = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                                int gb = int.Parse(dgvCTHD.Rows[i].Cells[6].Value.ToString());
                                int tt = sl * gb;
                                sql2 = "update CTHD set ThanhTien = " + tt + " where MaHD = '" + dgvCTHD.Rows[i].Cells[0].Value.ToString() + "' and  maSP = '" + dgvCTHD.Rows[i].Cells[1].Value.ToString() + "' and maSize = '" + dgvCTHD.Rows[i].Cells[2].Value.ToString() + "'";
                                tongtien3 += tt;
                                c.Capnhatdulieu(sql2);

                                string masp = dgvCTHD.Rows[i].Cells["maSP"].Value.ToString();
                                string masize = dgvCTHD.Rows[i].Cells["maSize"].Value.ToString();
                                DataSet dsctsp = c.Laydulieu("Select SoLuong from CTSP where MaSP = '" + masp + "' and MaSize='" + masize + "'");
                                string soluongct = dsctsp.Tables[0].Rows[0]["SoLuong"].ToString();

                                int slct1 = int.Parse(soluongct);
                                int slct2 = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                                slct1 = slct1 + slct2 - slm;
                                sql4 = "update CTSP set SoLuong=" + slct1 + " where MaSP='" + masp + "' and MaSize='" + masize + "'";
                                c.Capnhatdulieu(sql4);

                                dssp = c.Laydulieu("Select SoLuong from SanPham where MaSP = '" + masp + "'");
                                string soluong2 = dssp.Tables[0].Rows[0]["SoLuong"].ToString();
                                int sl1 = int.Parse(soluong2);
                                int sl2 = int.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                                sl1 =sl1 - sl2 ;
                                sql5 = "update SanPham set SoLuong=" + sl1 + " where MaSP= '" + masp + "'";
                                c.Capnhatdulieu(sql5);

                            }
                            sql3 = "update HoaDon set ThanhTien = " + tongtien3 + "where MaHD = '" + dgvDS.CurrentRow.Cells[0].Value.ToString() + "'";
                            c.Capnhatdulieu(sql3);
                            lblTongTien.Text = tongtien3.ToString();

                        }

                        if (c.Capnhatdulieu(sql2) > 0)
                        {
                            MessageBox.Show("Cập nhật Chi tiết hóa đơn!");
                            //FrmHoaDon_Load(sender, e);
                        }
                        if (c.Capnhatdulieu(sql3) > 0)
                        {
                            MessageBox.Show("Cập nhật hóa đơn!");
                            //FrmHoaDon_Load(sender, e);
                        }
              
                    }
                }
                FrmHoaDon_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng phải được sửa >= 1. ", "Thông báo");
            }
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khoa chu, ki tu
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            //khoa so, ki tu
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }            
      
        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSP.SelectedIndex != -1)
            {               
                string MaLoai = cboLoaiSP.SelectedValue.ToString();
                string sql = "Select * From SanPham where MaLoai = '" + MaLoai + "'";
                dssp = c.Laydulieu(sql);
                hienthicbo(dssp, cboTenSP, "MaSP", "TenSP");
            }
            lblGiaNhap.Text = "";
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cboTenSP.SelectedIndex != -1)
            {
                lblGiaNhap.Text = "";
                string masp = cboTenSP.SelectedValue.ToString();
                dssp = c.Laydulieu("select * from SanPham where MaSP= '" + masp + "'");
                lblGiaNhap.Text = dssp.Tables[0].Rows[0]["GiaNhap"].ToString();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(220, 120));
            e.Graphics.DrawString("MILK TEA", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString("Ngày: " + dtpNgayLap.CustomFormat, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Nhân Viên Lập: " + cboMaNV.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(250, 200));
            e.Graphics.DrawString("Size", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(400, 200));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(680, 200));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            int yPos = 240;

            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                DataSet getSize = c.Laydulieu("Select * from Size where MaSize = '" + dgvCTHD.Rows[i].Cells["MaSize"].Value.ToString() + "'");
                DataSet getTenSanPham = c.Laydulieu("Select * from SanPham where MaSP = '" + dgvCTHD.Rows[i].Cells["MaSP"].Value.ToString() + "'");
                string size = getSize.Tables[0].Rows[0]["TenSize"].ToString();
                string tenSP = getTenSanPham.Tables[0].Rows[0]["TenSP"].ToString();
                e.Graphics.DrawString(tenSP, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(size, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(415, yPos));
                e.Graphics.DrawString(dgvCTHD.Rows[i].Cells["SoLuong"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, yPos));
                e.Graphics.DrawString(dgvCTHD.Rows[i].Cells["GiaBan"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, yPos));
                e.Graphics.DrawString(dgvCTHD.Rows[i].Cells["ThanhTien"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(680, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Tổng phải trả: " + lblTongTien.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(450, yPos + 60));
            e.Graphics.DrawString("Tiền nhận của khách: " + txtTienNhan.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(450, yPos + 30));
            e.Graphics.DrawString("Tiền trả khách: " + lblTienThoi.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(450, yPos + 90));

        }

        private void btnInHoaDon_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = true;
            txtTienNhan.ReadOnly = false;
           
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {          
            try
            {
                int tiennhan = int.Parse(txtTienNhan.Text);
                int ttien = int.Parse(lblTongTien.Text);
                int tienthoi = 0;
                if (tiennhan < ttien)
                {
                   MessageBox.Show("Tiền nhận ít hơn tổng tiên! Vui lòng nhập lại! ");
                    txtTienNhan.Text = "";
                    txtTienNhan.Focus();
                }
                else
                {
                    tienthoi = tiennhan - ttien;
                    lblTienThoi.Text = tienthoi.ToString();
                    MessageBox.Show("Thanh toán thành công! ");
                    btnInHoaDon.Enabled = true;
                }                             
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập tiền nhận! ");
                txtTienNhan.Focus();
            }
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

        }

       
    }
}