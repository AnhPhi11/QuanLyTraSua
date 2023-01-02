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
    public partial class FrmHoaDonNhap : Form
    {
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);
            loaddulieu_datagird(dgvDS, "  select * from HoaDon ");
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            DataSet ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void xulytextbox(Boolean t)
        {           
            txtThanhTien.ReadOnly = t;
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            txtMaHDN.ReadOnly = true;
            xulybutton(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void FrmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
