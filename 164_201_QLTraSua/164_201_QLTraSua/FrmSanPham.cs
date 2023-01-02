using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _164_201_QLTraSua
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        DataSet dsncc = new DataSet();
        DataSet dsloai = new DataSet();
        DataSet dssize = new DataSet();
        int vt = 0;
        int flag = 0;

        

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);
            btnthemctsp.Enabled = false; // Luu
            cboSize.Enabled = false;
            dgvDS.Enabled = true;

            loaddulieu_datagird(dgvDS, "  select * from SanPham ");
            dsncc = c.Laydulieu("select * from NhaCungCap");
            dsloai = c.Laydulieu("select * from LoaiSP");
            
            hienthicbo(dsncc, cboMaNCC, "MaNCC", "TenNCC");
            hienthicbo(dsloai, cboMaLoai, "MaLoai", "TenLoai");

            hienthi(ds.Tables[0], vt);
            khoadgvSP();
            khoadgvCTSP();
            f = true;
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void xulytextbox(Boolean t)
        {
            cboMaLoai.Enabled = false;
            cboMaNCC.Enabled = false;
            cboTrangThai.Enabled = false;
            cboSize.Enabled = false;
            txtsltheosize.ReadOnly = t;
            txtMaSP.ReadOnly = t;
            txtTenSP.ReadOnly = t;
            txtgianhap.ReadOnly = t;
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnthemctsp.Enabled = t; // luu ben ctsp
            btnThemCT.Enabled = t;
            btnLuu.Enabled = !t;
        }
        string Maphatsinh(DataSet d)
        {
            string masp = "";
            if ((ds.Tables[0].Rows.Count + 1) <= 9)
                masp = "SP0" + (ds.Tables[0].Rows.Count + 1).ToString();
            else
                masp = "SP" + (ds.Tables[0].Rows.Count + 1).ToString();
            return masp;
        }
        void clear()
        {
            txtTenSP.Text = "";
            txtgianhap.Text = "";
            txtTenSP.Text = "";
            ricMoTa.Text = "";
            cboTrangThai.SelectedIndex = 1;
            cboTrangThai.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            txtMaSP.ReadOnly = true;
            txtMaSP.Text = Maphatsinh(ds);
            clear();
            txtsltheosize.ReadOnly = true;
            btnThemCT.Enabled = false;
            cboMaLoai.Enabled = true;
            cboMaNCC.Enabled = true;
            dgvDS.Enabled = false;  
            hienthicbo(dsncc, cboMaNCC, "MaNCC", "TenNCC");
            hienthicbo(dsloai, cboMaLoai, "MaLoai", "TenLoai");
            
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 3;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            txtMaSP.ReadOnly = true;
            cboMaNCC.Enabled = true;
            cboMaLoai.Enabled = true;
            cboTrangThai.Enabled = true;
            ricMoTa.Enabled = false;
            dgvDS.Enabled = true;
            hienthicbo(dsncc, cboMaNCC, "MaNCC", "TenNCC");
            hienthicbo(dsloai, cboMaLoai, "MaLoai", "TenLoai");
            xulybutton(false);
            flag = 2;
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            if (flag == 1) //them
            {
                sql = "insert into SanPham values ('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + txtgianhap.Text + "','" + cboMaNCC.SelectedValue + "','" + cboMaLoai.SelectedValue + "','" + ricMoTa.Text + "','" + cboTrangThai.SelectedIndex + "'," + txtSLTon.Text + " )";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FrmSanPham_Load(sender, e);
                }
            }
            if (flag == 2) //sua
            {
                sql = "update SanPham set TenSP=N'" + txtTenSP.Text + "',";

                sql += "GiaNhap= '" + txtgianhap.Text + "',";
                sql += "MaNCC='" + cboMaNCC.SelectedValue + "',";
                sql += "MaLoai= '" + cboMaLoai.SelectedValue + "',";
                sql += "Hinh='" + ricMoTa.Text + "',";
                sql += "TrangThai='" + cboTrangThai.SelectedIndex + "',";
                sql += "SoLuong=" + txtSLTon.Text + "";
                sql += "where MaSP='" + txtMaSP.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FrmSanPham_Load(sender, e);
                }
            }

            if (flag == 3) //xoa
            {
                sql = "update SanPham set TrangThai = 0 where MaSP='" + txtMaSP.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                    FrmSanPham_Load(sender, e);

                }
            }

            flag = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //khoa ki tu
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
            //khoa so
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        void hienthi(DataTable dt, int vt)
        {
            txtMaSP.Text = dt.Rows[vt]["MaSP"].ToString();
            txtTenSP.Text = dt.Rows[vt]["TenSP"].ToString();
            txtgianhap.Text = dt.Rows[vt]["GiaNhap"].ToString();
            //cboMaLoai.Text = dt.Rows[vt]["maLoai"].ToString();
            if (dt.Rows[vt]["TrangThai"].ToString() == "1")
                cboTrangThai.SelectedIndex = 1;
            else
                cboTrangThai.SelectedIndex = 0;

            ricMoTa.Text = dt.Rows[vt]["Hinh"].ToString();
            txtSLTon.Text = dt.Rows[vt]["SoLuong"].ToString();
            string mancc;
            mancc = dt.Rows[vt]["MaNCC"].ToString();
            DataView dtvNCC = new DataView();
            dtvNCC.Table = dsncc.Tables[0];
            cboMaNCC.DataSource = dtvNCC;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";
            dtvNCC.RowFilter = "MaNCC = '" + mancc + "'";

            string maloai;
            maloai = dt.Rows[vt]["MaLoai"].ToString();
            DataView dtvLoai = new DataView();
            dtvLoai.Table = dsloai.Tables[0];
            cboMaLoai.DataSource = dtvLoai;
            cboMaLoai.DisplayMember = "TenLoai";
            cboMaLoai.ValueMember = "MaLoai";
            dtvLoai.RowFilter = "MaLoai = '" + maloai + "'";


            //load hinh
            string tenanh = Path.GetFullPath("hinhanh") + @"\";
            string ten = dt.Rows[vt]["Hinh"].ToString();
            tenanh += ten;
            Bitmap a = new Bitmap(tenanh);
            picAnh.Image = a;
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;

            //hien thi ctsp theo ma sp
            load_ctsptheosp(dt.Rows[vt]["MaSP"].ToString());
        }
        void load_ctsptheosp(string masp)
        {
            string s = "select * from CTSP where MaSP = '" + masp + "'";
            DataSet ctsp = c.Laydulieu(s);
            dgvCTSP.DataSource = null;
            dgvCTSP.DataSource = ctsp.Tables[0];
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvCTSP.Columns.Clear();
            FrmSanPham_Load(sender, e);
            hienthi(ds.Tables[0], vt);
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCTSP.Columns.Clear();
            vt = dgvDS.CurrentCell.RowIndex;
            hienthi(ds.Tables[0], vt);
        }
        string hinh = "";
        private void btn1anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("hinhanh") + @"\";
            o.ShowDialog();

            while (o.ShowDialog() == DialogResult.Cancel)
            {
                o.ShowDialog();
            }
                
            string TenHinh = o.FileName;
            ricMoTa.Text = TenHinh;

            Bitmap a = new Bitmap(TenHinh);
            picAnh.Image = a;
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;

            string[] ten = TenHinh.Split('\\');

            hinh = ten[ten.Length - 1];
            ricMoTa.Text = hinh;
        }

        void hienthicbo(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }

        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        Boolean f = false;
        private void dgvDS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            int gianhap = 0;
            string sql2 = "";

            if (f == true && e.ColumnIndex >= 1 && e.ColumnIndex <= 6)
            {
                sql += "update SanPham set TenSP = N'" + dgvDS.CurrentRow.Cells[1].Value.ToString() + "', " +
                "GiaNhap = " + dgvDS.CurrentRow.Cells[2].Value.ToString() + ", " +
                "maNCC = '" + dgvDS.CurrentRow.Cells[3].Value.ToString() + "', " +
                "maLoai = '" + dgvDS.CurrentRow.Cells[4].Value.ToString() + "', " +
                "Hinh = '" + dgvDS.CurrentRow.Cells[5].Value.ToString() + "', " +
                "TrangThai = " + dgvDS.CurrentRow.Cells[6].Value.ToString() +
                "where  MaSP = '" + dgvDS.CurrentRow.Cells[0].Value.ToString() + "'";

                gianhap = int.Parse(dgvDS.CurrentRow.Cells[2].Value.ToString());

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Sửa thành công");

                }
                if (dgvCTSP.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvCTSP.Rows.Count; i++)
                    {
                        if (dgvCTSP.Rows[i].Cells[2].Value.ToString() == "SZ01")
                        {
                            int giaban = gianhap * 3;
                            sql2 = "update CTSP set giaban = " + giaban + " where MaCTSP = '" + dgvCTSP.Rows[i].Cells[0].Value.ToString() + "'";
                            c.Capnhatdulieu(sql2);
                        }
                        else if (dgvCTSP.Rows[i].Cells[2].Value.ToString() == "SZ02")
                        {
                            int giaban = (gianhap * 3) + 10000;
                            sql2 = "update CTSP set giaban = " + giaban + " where MaCTSP = '" + dgvCTSP.Rows[i].Cells[0].Value.ToString() + "'";
                            c.Capnhatdulieu(sql2);
                        }
                        else
                        {
                            int giaban = (gianhap * 3) + 20000;
                            sql2 = "update CTSP set giaban = " + giaban + " where MaCTSP = '" + dgvCTSP.Rows[i].Cells[0].Value.ToString() + "'";
                            c.Capnhatdulieu(sql2);
                        }
                    }
                    if (c.Capnhatdulieu(sql2) > 0)
                    {
                        MessageBox.Show("Sửa CT thành công");
                    }
                }

                FrmSanPham_Load(sender, e);
            }
        }

        void khoadgvSP()
        {
            dgvDS.Columns[0].ReadOnly = true;
            dgvDS.Columns[4].ReadOnly = true;
            dgvDS.Columns[5].ReadOnly = true;
            dgvDS.Columns[6].ReadOnly = true;
            dgvDS.Columns[3].ReadOnly = true;
        }
        void khoadgvCTSP()
        {
            dgvCTSP.Columns[0].ReadOnly = true;
            dgvCTSP.Columns[1].ReadOnly = true;
            dgvCTSP.Columns[2].ReadOnly = true;
            dgvCTSP.Columns[3].ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)//them ben ctsp
        {
            //cboSize.Text = "";
            try
            {
                for (int i = 0; i < dgvCTSP.Rows.Count; i++)
                {
                    string ct, sp, si, gb, sl;
                    ct = dgvCTSP.Rows[i].Cells[0].Value.ToString();
                    sp = dgvCTSP.Rows[i].Cells[1].Value.ToString();
                    si = dgvCTSP.Rows[i].Cells[2].Value.ToString();
                    gb = dgvCTSP.Rows[i].Cells[3].Value.ToString();
                    sl = dgvCTSP.Rows[i].Cells[4].Value.ToString();
                    string h = dgvCTSP.Rows[i].Cells[5].Value.ToString();

                    string ctsp = "";
                    ctsp += "insert into CTSP values ('" + ct + "','" + sp + "','" + si + "'," + gb + "," + sl + ",'" + h + "')";

                    if (c.Capnhatdulieu(ctsp) > 0)
                    {
                        MessageBox.Show("Thêm Thành Công!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Size đã tồn tại");
            }
            dgvCTSP.Columns.Clear();
            txtsltheosize.Clear();
            FrmSanPham_Load(sender, e);

        }
        void TaoCotSP()
        {
            dgvCTSP.DataSource = null;
            dgvCTSP.Columns.Add("MaCTSP", "Mã CTSP");
            dgvCTSP.Columns.Add("maSP", "Mã SP");
            dgvCTSP.Columns.Add("maSize", "Size");
            dgvCTSP.Columns.Add("giaban", "Giá bán");
            dgvCTSP.Columns.Add("soluong", "Số lượng");
            dgvCTSP.Columns.Add("TrangThai", "Trạng thái");
        }
        private bool KiemtraSP(object[] d, DataGridView dv)
        {
            for (int i = 0; i < dv.Rows.Count; i++)
            {
                if (d[0].ToString() == dv.Rows[i].Cells[0].Value.ToString())
                {
                    int soluongmoi = int.Parse(d[4].ToString());
                    string soluongcu = dv.Rows[i].Cells[4].Value.ToString();
                    int soluongcu2 = int.Parse(soluongcu);
                    int sl = soluongmoi + soluongcu2;
                    d[4] = sl;
                    dv.Rows.Add(d);
                    dgvCTSP.Rows.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)//keydown so luog ben chitietsp
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtsltheosize.Text != "0")
                {
                    string tenloai = cboMaLoai.Text;
                    string size = cboSize.Text;
                    if (size == "M")
                    {

                        int gia = int.Parse(txtgianhap.Text);
                        object[] d = { txtMaSP.Text + "." + cboSize.SelectedValue.ToString(), txtMaSP.Text, cboSize.SelectedValue.ToString(), gia * 3, txtsltheosize.Text, cboTrangThai.SelectedIndex };
                        if (KiemtraSP(d, dgvCTSP) == false)
                        {
                            dgvCTSP.DataSource = null;
                            dgvCTSP.Rows.Add(d);
                        }
                    }
                    if (size == "L")
                    {

                        int gia = int.Parse(txtgianhap.Text);
                        object[] d = { txtMaSP.Text + "." + cboSize.SelectedValue.ToString(), txtMaSP.Text, cboSize.SelectedValue.ToString(), (gia * 3) + 10000, txtsltheosize.Text, cboTrangThai.SelectedIndex };
                        
                        if (KiemtraSP(d, dgvCTSP) == false)
                        {
                            dgvCTSP.DataSource = null;
                            dgvCTSP.Rows.Add(d);
                        }
                    }
                    if (size == "XL")
                    {

                        int gia = int.Parse(txtgianhap.Text);
                        object[] d = { txtMaSP.Text + "." + cboSize.SelectedValue.ToString(), txtMaSP.Text, cboSize.SelectedValue.ToString(), (gia * 3) + 15000, txtsltheosize.Text, cboTrangThai.SelectedIndex };
                        //dgvCTSP.DataSource = null;
                        //dgvCTSP.Rows.Add(d);
                        if (KiemtraSP(d, dgvCTSP) == false)
                        {
                            dgvCTSP.DataSource = null;
                            dgvCTSP.Rows.Add(d);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!. ", "Thông báo");
                }
            }
        }
        private void txtsltheosize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            cboSize.Text = "";
            dgvCTSP.DataSource = null;
            TaoCotSP();
            xulybutton(false);
            btnLuu.Enabled = false;
            //dgvDS.Enabled = false;
            cboSize.Enabled = true;
            txtsltheosize.ReadOnly = false;
            btnthemctsp.Enabled = true;
            btnThemCT.Enabled = false;
            dssize = c.Laydulieu(" select * from Size where MaSize not in ( select s.MaSize from Size s,CTSP c where s.MaSize = c.maSize and c.MaSP = '" + txtMaSP.Text + "')");
            hienthicbo(dssize, cboSize, "MaSize", "TenSize");
        }
        
        //private void button1_Click(object sender, EventArgs e) - flpAnh
        //{
        //    OpenFileDialog o = new OpenFileDialog();
        //    o.InitialDirectory = Path.GetFullPath("hinhanh") + @"\";
        //    o.Multiselect = true;

        //    if (o.ShowDialog() == DialogResult.Cancel)
        //        o.ShowDialog();
        //    string[] Chuoiten = o.FileNames;
        //    foreach (string TenAnh in Chuoiten)
        //    {
        //        PictureBox p = new PictureBox();
        //        p.Height = 100;
        //        p.Width = 100;

        //        Bitmap z = new Bitmap(TenAnh);
        //        p.Image = z;
        //        p.SizeMode = PictureBoxSizeMode.StretchImage;

        //        flpAnh.Controls.Add(p);
        //    }
        //}
        private void txtgianhap_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    float giaban = float.Parse(txtgianhap.Text);
            //    txtGiaBan.Text = (giaban*3).ToString();
            //}
        }

        private void dgvCTSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            string sql2 = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex < 6)
            {
                sql += "update CTSP set soluong = " + dgvCTSP.CurrentRow.Cells[4].Value.ToString() + " where MaCTSP = '" + dgvCTSP.CurrentRow.Cells[0].Value.ToString() + "'";
                c.Capnhatdulieu(sql);
                int sl = 0;

                for (int i = 0; i < dgvCTSP.Rows.Count; i++)
                {
                    string a = dgvCTSP.Rows[i].Cells[4].Value.ToString();
                    sl += int.Parse(a);
                    //int b;
                    //b = int.Parse(dgvCTSP.Rows[i].Cells[4].Value.ToString());
                    //sl += b;
                }
                sql2 += "update SanPham set SoLuong = " + sl + "where MaSP = '" + txtMaSP.Text + "'";
                if (c.Capnhatdulieu(sql2) > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    FrmSanPham_Load(sender, e);
                }
            }
        }



    }
}