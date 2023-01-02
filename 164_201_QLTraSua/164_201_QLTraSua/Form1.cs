using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _164_201_QLTraSua
{
    public partial class Form1 : Form
    {
        public Form1(string LoaiTK)
        {
            InitializeComponent();

            if (LoaiTK == "0")
            {
                //Admin
                mnuChucNang.Enabled = true;
                mnuTimKiem.Enabled = true;
                mnuThongKe.Enabled = true;

            }
            else
            {
                //Nhan vien
                mnuChucNang.Enabled = true;
                mnuTimKiem.Enabled = true;
                mnuThongKe.Enabled = false;
            }
        }

        Form frm;
        Boolean check = false;
        void xulyfrom(Form f)
        {
            if (check)
            {
                frm.Hide();

            }
            else
            {
                check = true;
            }
            frm = f;
            IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

       
     
        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            xulyfrom(f);
        }

        private void mnuHoaDonNhap_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap f = new FrmHoaDonNhap();
            xulyfrom(f);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            xulyfrom(f);
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            FrmLoaiSP f = new FrmLoaiSP();
            xulyfrom(f);
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            xulyfrom(f);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            xulyfrom(f);
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham f = new FrmSanPham();
            xulyfrom(f);
        }
        
        private void mnuTimKiemKH_Click(object sender, EventArgs e)
        {
            FrmTimKhachHang f = new FrmTimKhachHang();
            xulyfrom(f);
        }

        private void mnuTimKiemSP_Click(object sender, EventArgs e)
        {
            FrmTimSanPham f = new FrmTimSanPham();
            xulyfrom(f);
        }

        private void mnuTimKiemHD_Click(object sender, EventArgs e)
        {
            FrmTimHoaDon f = new FrmTimHoaDon();
            xulyfrom(f);
        }

        private void timToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimNhanVien f = new TimNhanVien();
            xulyfrom(f);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {          
            Application.Exit();
        }

        private void mnuThongKeNgay_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            xulyfrom(f);
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {

        }

        private void mnuChucNang_Click(object sender, EventArgs e)
        {

        }
    }
    
}