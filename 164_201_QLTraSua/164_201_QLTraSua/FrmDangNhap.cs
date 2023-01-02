using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _164_201_QLTraSua
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        public static string ConnectionString = @"Data source=DESKTOP-FRCK2IT\SQLEXPRESS;Initial Catalog=QLTraSua2;integrated Security=True";
        public static string LoaiTK = "-1";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTaiKhoan.Text != null && txtTenTaiKhoan.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập tên tài khoản", "Thông báo");
                    txtTenTaiKhoan.Focus();
                    return;
                }

                if (txtMatKhau.Text != null && txtMatKhau.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo");
                    txtMatKhau.Focus();
                    return;
                }

                //Kiểm tra thông tin tài khoản  so sánh với dữ liệu bên trong sql
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TenTaiKhoan = txtTenTaiKhoan.Text.Trim();
                string MatKhau = txtMatKhau.Text.Trim();
                string query = "Select * From TaiKhoan Where TenTK= '" + TenTaiKhoan + "' and MatKhau= '" + MatKhau + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    LoaiTK = ds.Tables[0].Rows[0]["LoaiTK"].ToString();
                    Form1 f = new Form1(LoaiTK);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa chính xác. ", "Thông báo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa chính xác. ", "Thông báo");
            }
        }

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.ShowDialog();
        }
    }
}
