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
    public partial class TimNhanVien : Form
    {
        public TimNhanVien()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        private void TimNhanVien_Load(object sender, EventArgs e)
        {
            loaddulieu_datagird(dgvNhanVien, "  select * from NhanVien ");
            txtHoTen.ReadOnly = true;
            txtSDT.ReadOnly = true;
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }

        private void radHoTen_CheckedChanged(object sender, EventArgs e)
        {
            txtHoTen.ReadOnly = false;
            txtSDT.ReadOnly = true;
            radHoTen.Enabled = true;
            txtHoTen.Focus();
        }

        private void radSDT_CheckedChanged(object sender, EventArgs e)
        {
            txtHoTen.ReadOnly = true;
            txtSDT.ReadOnly = false;
            radSDT.Enabled = true;
            txtHoTen.Focus();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            loaddulieu_datagird(dgvNhanVien, "Select * From NhanVien Where HoTenNV like N'%" + HoTen + "%'");
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtSDT.Text;
            loaddulieu_datagird(dgvNhanVien, "Select * From NhanVien Where SDT like N'%" + SDT + "%'");
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
