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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();
        int vt = 0;
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];
        }
        string tongdoanhthu()
        {

            int kq = 0;
            if (dgvDS.Rows.Count == 0)
            {
                return kq.ToString();
            }
            for (int i = 0; i < dgvDS.Rows.Count; i++)
            {

                int doanhthu = int.Parse(dgvDS.Rows[i].Cells[2].Value.ToString());
                kq += doanhthu;

            }
            return kq.ToString();
        }

        void load_cthdtheohd(string mahd)
        {
            string s = "select * from CTHD where MaHD = '" + mahd + "'";
            DataSet cthd = c.Laydulieu(s);
            dgvchitiet.DataSource = null;
            dgvchitiet.DataSource = cthd.Tables[0];
        }
        void layma(DataTable dt, int vt)
        {
            load_cthdtheohd(dt.Rows[vt]["MaHD"].ToString());
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                loaddulieu_datagird(dgvDS, "select * from HoaDon");
                lbldoanhthu.Text = tongdoanhthu().ToString();
            }

            if (radchon.Checked)
            {
                string[] date = dtpngay.Text.Split('-');
                string ngay = date[1];
                string thang = date[0];
                string nam = date[2];

                loaddulieu_datagird(dgvDS, "select * from HoaDon where day(NgayLap) = " + ngay + " and month(NgayLap) = " + thang + " and year(NgayLap) = " + nam);
                lbldoanhthu.Text = tongdoanhthu().ToString();
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDS.CurrentCell.RowIndex;
            layma(ds.Tables[0], vt);
        }
    }
}
