using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _164_201_QLTraSua
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        public bool checkAccount(string ac) //check tentk va mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{3,24}$"); //bẫy lỗi chỉ nhập từ a->z, từ 0 -> 9 , ít 3 kí tự đến 24 kí tự. 
        }
        Modify modify = new Modify();

        void cleardangky()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMK.Text = "";
            cboLoaiTK.Text = "";
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string xacnhanmk = txtXacNhanMK.Text;

            if(!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản 3-24 ký tự, với các ký tự số, chữ hoa và chữ thường! "); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu 3-24 ký tự, với các ký tự số, chữ hoa và chữ thường! "); return; }
            if (xacnhanmk != matkhau) { MessageBox.Show("Mật khẩu xác nhận chưa chính xác! "); return; }

            try
            {
                if (cboLoaiTK.Text != "")
                {
                    string query = "insert into TaiKhoan values ('" + tentk + "','" + matkhau + "', '" + cboLoaiTK.SelectedIndex + "')";
                    modify.Command(query);
                    MessageBox.Show("Đăng ký thành công! ");

                    if (MessageBox.Show("Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }

                    cleardangky();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!, Bạn chưa chọn LOẠI TÀI KHOẢN ! ");
                    cleardangky();
                }
                
            }
            catch(Exception er)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!, Vui lòng đăng ký tài khoản khác! ");
                cleardangky();
            }

        }

        private void cboLoaiTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khoa chu, ki tu
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

            //khoa so, ki tu
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void cboLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
