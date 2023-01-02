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
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        int vt;
        int flag = 0;
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);
            loaddulieu_datagird(dgvDS, "  select * from NhaCungCap ");
            hienthi(ds.Tables[0], vt);
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void xulytextbox(Boolean t)
        {
            txtDiaChi.ReadOnly = t;
            txtDienThoai.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtMaNCC.ReadOnly = t; 
            txtTenNCC.ReadOnly = t;
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
                maloai = "NCC0" + (ds.Tables[0].Rows.Count + 1).ToString();
            else
                maloai = "NCC" + (ds.Tables[0].Rows.Count + 1).ToString();
            return maloai;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 1;
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Text = Maphatsinh(ds);
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            cboTrangThai.SelectedIndex = 1;
            cboTrangThai.Enabled = false;
            txtTenNCC.Focus();
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
            txtMaNCC.ReadOnly = true;
            xulybutton(false);
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            if (flag == 1)//them
            {
                sql = "INSERT INTO NhaCungCap  ";
                sql += "VALUES('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "','" + txtDienThoai.Text + "',N'" + txtDiaChi.Text + "','" + txtEmail.Text + "',"+cboTrangThai.SelectedIndex+")"; // trang thai co the k dung ''
                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FrmNhaCungCap_Load(sender, e);
                }
            }
            if (flag == 2)//sua
            {
                sql = "update NhaCungCap set TenNCC=N'" + txtTenNCC.Text + "', SDT = '" + txtDienThoai.Text + "',DiaChi = N'" + txtDiaChi.Text+ "', Email = '"+txtEmail.Text+"', TrangThai = "+cboTrangThai.SelectedIndex+"where MaNCC='"+ txtMaNCC.Text+"'";


                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    FrmNhaCungCap_Load(sender, e);

                }
            }
            if (flag == 3)//xoa
            {
                sql = "update NhaCungCap set TrangThai = 0 where MaNCC='" + txtMaNCC.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                    FrmNhaCungCap_Load(sender, e);

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

        private void FrmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cboTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void hienthi(DataTable dt, int vt)
        {
            txtMaNCC.Text = dt.Rows[vt]["MaNCC"].ToString();
            txtTenNCC.Text = dt.Rows[vt]["TenNCC"].ToString();           
            txtDienThoai.Text = dt.Rows[vt]["SDT"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DiaChi"].ToString();
            txtEmail.Text = dt.Rows[vt]["Email"].ToString();
            if (dt.Rows[vt]["TrangThai"].ToString() == "1")
                cboTrangThai.SelectedIndex = 1;
            else
                cboTrangThai.SelectedIndex = 0;

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
            hienthi(ds.Tables[0], vt);
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDS.CurrentCell.RowIndex;
            hienthi(ds.Tables[0], vt);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
