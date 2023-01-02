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
    public partial class FrmLoaiSP : Form
    {
        public FrmLoaiSP()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        int vt;
        int flag = 0;
        void xulytextbox(Boolean t)
        {
            txtMaLoai.ReadOnly = t;
            txtTenLoai.ReadOnly = t;
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
                maloai = "LoaiSP0" + (ds.Tables[0].Rows.Count + 1).ToString();
            else
                maloai = "LoaiSP" + (ds.Tables[0].Rows.Count + 1).ToString();
            return maloai;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 1;
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Text = Maphatsinh(ds);
            txtTenLoai.Text = "";
            cboTrangThai.SelectedIndex = 1;
            cboTrangThai.Enabled = false;
            txtTenLoai.Focus();
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
            txtMaLoai.ReadOnly = true;
            xulybutton(false);
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            if (flag == 1)//them
            {
                sql = "INSERT INTO LoaiSP Values ('"+txtMaLoai.Text+"',N'"+txtTenLoai.Text+"'," + cboTrangThai.SelectedIndex+")";// luu y : trang thai kieu so
                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FrmLoaiSP_Load(sender, e);
                }
            }
            if (flag == 2)//sua
            {
                sql = "update LoaiSP set TenLoai=N'" + txtTenLoai.Text + "', TrangThai = "+cboTrangThai.SelectedIndex+" where MaLoai= '" + txtMaLoai.Text + "'";


                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    FrmLoaiSP_Load(sender, e);

                }
            }
            if (flag == 3)//xoa
            {
                sql = "update LoaiSP set TrangThai = 0 where MaLoai='" + txtMaLoai.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                    FrmLoaiSP_Load(sender, e);

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
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void FrmLoaiSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmLoaiSP_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);
            loaddulieu_datagird(dgvDS, "  select * from LoaiSP ");
            hienthi(ds.Tables[0], vt);
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void hienthi(DataTable dt, int vt)
        {
            txtMaLoai.Text = dt.Rows[vt]["MaLoai"].ToString();
            txtTenLoai.Text = dt.Rows[vt]["TenLoai"].ToString();
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
    }
}
