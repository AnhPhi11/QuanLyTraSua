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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        DataSet dscv = new DataSet();
        int flag = 0;
        int vt = 0;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);
            loaddulieu_datagird(dgvDS, "  select * from NhanVien ");
            dscv = c.Laydulieu("select * from ChucVu");
            hienthicbo(dscv, cboChucVu, "MaCV", "TenCV");
            hienthi(ds.Tables[0], vt);

        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void xulytextbox(Boolean t)
        {
            txtHoTen.ReadOnly = t;
            txtMaNhanVien.ReadOnly = t;
            dtpNgaySinh.Enabled = !t;
            txtDiaChi.ReadOnly = t;
            txtSDT.ReadOnly = t;
            cboGioiTinh.Enabled = !t;
            cboChucVu.Enabled = !t;
            dtpNgayVaoLam.Enabled = !t;
            cboTrangThai.Enabled = !t;

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
            string maloai = "";
            if ((ds.Tables[0].Rows.Count + 1) <= 9)
                maloai = "NV0" + (ds.Tables[0].Rows.Count + 1).ToString();
            else
                maloai = "NV" + (ds.Tables[0].Rows.Count + 1).ToString();
            return maloai;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 1;
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Text = Maphatsinh(ds);
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cboChucVu.Text="";
            cboGioiTinh.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 1;
            cboTrangThai.Enabled = false;
            txtHoTen.Focus();
            hienthicbo(dscv, cboChucVu, "MaCV", "TenCV");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            txtMaNhanVien.ReadOnly = true;
            xulybutton(false);
            flag = 3;
            hienthicbo(dscv, cboChucVu, "MaCV", "TenCV");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            if (flag == 1)//them
            {
                sql = "insert into NhanVien VALUES('" + txtMaNhanVien.Text + "',N'" + txtHoTen.Text + "','" + dtpNgaySinh.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "',N'" + cboGioiTinh.Text + "','" + cboChucVu.SelectedValue + "','" + dtpNgayVaoLam.Text + "','" + cboTrangThai.SelectedIndex + "')";
                MessageBox.Show(sql);
                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FrmNhanVien_Load(sender, e);
                }
            }
            if (flag == 3)//sua
            {
                sql = "update NhanVien set HoTenNV=N'" + txtHoTen.Text + "',NgSinh='" + dtpNgaySinh.Text + "',DiaChi=N'" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',ChucVu='" + cboChucVu.SelectedValue + "',NgayVaoLam='" + dtpNgayVaoLam.Text + "',TrangThai='" + cboTrangThai.SelectedIndex + "'where MaNV= '" + txtMaNhanVien.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    FrmNhanVien_Load(sender, e);
                }
            }
            if (flag == 2)//xoa
            {
                sql = "update NhanVien set TrangThai = 0 where MaNV='" + txtMaNhanVien.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                    FrmNhanVien_Load(sender, e);

                }
            }
            //txtMaloaiSP.ReadOnly = true;
            flag = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {          
                this.Close();           
        }

        private void cboTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
            hienthi(ds.Tables[0], vt);
        }
        void hienthi(DataTable dt, int vt)
        {

            txtMaNhanVien.Text = dt.Rows[vt]["MaNV"].ToString();
            txtHoTen.Text = dt.Rows[vt]["HoTenNV"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DiaChi"].ToString();
            txtSDT.Text = dt.Rows[vt]["SDT"].ToString();
            dtpNgaySinh.Text = dt.Rows[vt]["NgSinh"].ToString();
            dtpNgayVaoLam.Text = dt.Rows[vt]["NgayVaoLam"].ToString();
            cboGioiTinh.Text = dt.Rows[vt]["GioiTinh"].ToString();
            cboChucVu.Text = dt.Rows[vt]["ChucVu"].ToString();

            if (dt.Rows[vt]["TrangThai"].ToString() == "1")
                cboTrangThai.SelectedIndex = 1;
            else
                cboTrangThai.SelectedIndex = 0;
           
            string macv;
            macv = dt.Rows[vt]["ChucVu"].ToString();
            DataView dtvChucVu = new DataView();
            dtvChucVu.Table = dscv.Tables[0];
            cboChucVu.DataSource = dtvChucVu;
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
            dtvChucVu.RowFilter = "MaCV = '" + macv + "'";
         
        }
        void hienthicbo(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDS.CurrentCell.RowIndex;
            hienthi(ds.Tables[0], vt);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
