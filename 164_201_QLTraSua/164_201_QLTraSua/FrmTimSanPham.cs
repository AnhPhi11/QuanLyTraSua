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
    public partial class FrmTimSanPham : Form
    {
        public FrmTimSanPham()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        DataSet dsloai = new DataSet();
        private void FrmTimSanPham_Load(object sender, EventArgs e)
        {
            //loaddulieu_datagird(dgvDS, "  select * from SanPham ");
            dsloai = c.Laydulieu("select * from LoaiSP ");
            radLoaiSP.Checked = true;
            cboLoaiSP.DataSource = dsloai.Tables[0];
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
            cboLoaiSP.SelectedIndex = -1;
            //cboLoaiSP.Enabled = false;
            txtGiaSP.ReadOnly = true;
            loaddulieu_datagird(dgvDS, "  select * from SanPham ");
            dgvDS.Focus();
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];

        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSP.SelectedIndex != -1)
            {
                string MaLoai = cboLoaiSP.SelectedValue.ToString();
                string sql = "Select * From SanPham where MaLoai = '" + MaLoai + "'";
                loaddulieu_datagird(dgvDS, sql);

            }
        }

        private void radSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (radSanPham.Checked == true)
            {
                cboLoaiSP.Text = "";               
                cboLoaiSP.Enabled = false;
                txtGiaSP.ReadOnly = false;
            }
            
        }

        private void radLoaiSP_CheckedChanged(object sender, EventArgs e)
        {
            if (radLoaiSP.Checked == true)
            {
                cboLoaiSP.Enabled = true;
                txtGiaSP.ReadOnly = true;
            }
        }

        private void txtGiaSP_TextChanged(object sender, EventArgs e)
        {
            string TenSP = txtGiaSP.Text;
            loaddulieu_datagird(dgvDS, "Select * From SanPham Where TenSP like N'%" + TenSP + "%'");
        }

        private void FrmTimSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cboLoaiSP_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cboLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khoa chu, ki tu
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            //khoa so, ki tu
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
