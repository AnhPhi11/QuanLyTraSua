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
    public partial class FrmTimKhachHang : Form
    {
        public FrmTimKhachHang()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        //DataSet ds = new DataSet();
        private void FrmTimKhachHang_Load(object sender, EventArgs e)
        {
            loaddulieu_datagird(dgvDS, "  select * from KhachHang ");
            txtHoTen.ReadOnly = true;
            txtSDT.ReadOnly = true;
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            DataSet ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }

        private void radHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (radHoTen.Checked == true)
            { 
                txtHoTen.ReadOnly = false;
                txtSDT.ReadOnly = true;
            }
        }

        private void radSDT_CheckedChanged(object sender, EventArgs e)
        {
            if (radSDT.Checked == true)
            {
                txtHoTen.ReadOnly = true;
                txtSDT.ReadOnly = false;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            loaddulieu_datagird(dgvDS, "select * from KhachHang where HoTenKH like N'%" + hoten + "%'");
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            loaddulieu_datagird(dgvDS, "select * from KhachHang where SDT like '%" + sdt + "%'");
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void FrmTimKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
