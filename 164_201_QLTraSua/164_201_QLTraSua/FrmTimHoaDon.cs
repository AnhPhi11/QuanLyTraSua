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
    public partial class FrmTimHoaDon : Form
    {
        public FrmTimHoaDon()
        {
            InitializeComponent();
        }
        QLTraSua c = new QLTraSua();
        DataSet ds = new DataSet();

        private void FrmTimHoaDon_Load(object sender, EventArgs e)
        {
            loaddulieu_datagird(dgvDS, "select * from HoaDon");
            dgvDS.Focus();
        }
        void loaddulieu_datagird(DataGridView d, string sql)
        {
            ds = c.Laydulieu(sql);
            d.DataSource = ds.Tables[0];

        }
        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            string ngaylap = dtpThoiGian.Text;
            string sql = "Select * From HoaDon where NgayLap = '" + ngaylap + "'";
            loaddulieu_datagird(dgvDS, sql);
        }


    }
}
