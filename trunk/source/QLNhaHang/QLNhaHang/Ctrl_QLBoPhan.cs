using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QLNhaHang
{
    public partial class Ctrl_QLBoPhan : UserControl
    {
        public Ctrl_QLBoPhan()
        {
            InitializeComponent();
        }

        private void Ctrl_QLBoPhan_Load(object sender, EventArgs e)
        {
            GvBoPhan.AutoGenerateColumns = false;
            GvBoPhan.DataSource = BoPhanBUS.DanhSachBoPhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenBoPhan.Text = "";
            txtTenBoPhan.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator2.Validate())
            {
                return;
            }
            BoPhanBUS.ThemBoPhan(txtTenBoPhan.Text);
            GvBoPhan.DataSource = BoPhanBUS.DanhSachBoPhan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int makv = (int)GvBoPhan.CurrentRow.Cells[0].Value;
            BoPhanBUS.XoaBoPhan(makv);
            GvBoPhan.DataSource = BoPhanBUS.DanhSachBoPhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator2.Validate())
            {
                return;
            }
            int makv = (int)GvBoPhan.CurrentRow.Cells[0].Value;
            BoPhanBUS.SuaBoPhan(makv, txtTenBoPhan.Text);
            GvBoPhan.DataSource = BoPhanBUS.DanhSachBoPhan();
        }

        private void GvBoPhan_SelectionChanged(object sender, EventArgs e)
        {
            if (GvBoPhan.Rows.Count > 0)
            {
                txtTenBoPhan.Text = GvBoPhan.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
