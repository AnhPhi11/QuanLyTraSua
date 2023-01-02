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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        int vt = 0;
        DataSet ds = new DataSet();
        int flag = 0;
        public string makh, tenkh, sdt;
       private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);
            loaddulieu_datagird(dgvDS, "  select * from KhachHang ");
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
            txtHoTenKhachHang.ReadOnly = t;
            txtMaKH.ReadOnly = t;
            txtSDT.ReadOnly = t;
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
                maloai = "KH0" + (ds.Tables[0].Rows.Count + 1).ToString();
            else
                maloai = "KH" + (ds.Tables[0].Rows.Count + 1).ToString();
            return maloai;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 1;
            txtMaKH.ReadOnly = true;
            txtMaKH.Text = Maphatsinh(ds);
            txtHoTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cboTrangThai.SelectedIndex = 1;
            cboTrangThai.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(false);
            flag = 3;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            txtMaKH.ReadOnly = true;
            xulybutton(false);
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            if (flag == 1)//them
            {
                sql = "INSERT INTO KhachHang VALUES('" + txtMaKH.Text + "',N'" + txtHoTenKhachHang.Text + "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "','"+cboTrangThai.SelectedIndex+"')";
                makh = txtMaKH.Text;
                tenkh = txtHoTenKhachHang.Text;
                sdt = txtSDT.Text;
                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FrmKhachHang_Load(sender, e);
                }
            }
            if (flag == 2)//sua
            {
                sql = "update KhachHang set HoTenKH=N'" + txtHoTenKhachHang.Text + "', SDT = '" + txtSDT.Text + "',DiaChi = N'" + txtDiaChi.Text + "', TrangThai = "+cboTrangThai.SelectedIndex+" where MaKH = '"+txtMaKH.Text+"'";


                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    FrmKhachHang_Load(sender, e);

                }
            }
            if (flag == 3)//xoa
            {
                sql = "update KhachHang set TrangThai = 0 where MaKH='" + txtMaKH.Text + "'";

                if (c.Capnhatdulieu(sql) > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                    FrmKhachHang_Load(sender, e);

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

        private void FrmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        void hienthi(DataTable dt, int vt)
        {
            txtMaKH.Text = dt.Rows[vt]["MaKH"].ToString();
            txtHoTenKhachHang.Text = dt.Rows[vt]["HoTenKH"].ToString();
            txtSDT.Text = dt.Rows[vt]["SDT"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DiaChi"].ToString();
            if (dt.Rows[vt]["TrangThai"].ToString() == "1")
                cboTrangThai.SelectedIndex = 1;
            else
                cboTrangThai.SelectedIndex = 0;

        }
        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDS.CurrentCell.RowIndex;
            hienthi(ds.Tables[0], vt);
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
            hienthi(ds.Tables[0], vt);
        }

        private void txtHoTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
