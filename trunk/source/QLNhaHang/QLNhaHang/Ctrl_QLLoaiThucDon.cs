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
    public partial class Ctrl_QLLoaiThucDon : UserControl
    {
        public Ctrl_QLLoaiThucDon()
        {
            InitializeComponent();
        }

        private void Ctrl_QLLoaiThucDon_Load(object sender, EventArgs e)
        {
            GvLoaiThucDon.AutoGenerateColumns = false;
            GvLoaiThucDon.DataSource = LoaiThucDonBUS.DanhSachLTD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenLTD.Text = "";
            txtTenLTD.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            LoaiThucDonBUS.ThemLTD(txtTenLTD.Text);
            GvLoaiThucDon.DataSource = LoaiThucDonBUS.DanhSachLTD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maltd = (int)GvLoaiThucDon.CurrentRow.Cells[0].Value;
            LoaiThucDonBUS.XoaLTD(maltd);
            GvLoaiThucDon.DataSource = LoaiThucDonBUS.DanhSachLTD();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            int maltd = (int)GvLoaiThucDon.CurrentRow.Cells[0].Value;
            LoaiThucDonBUS.SuaLTD(maltd, txtTenLTD.Text);
            GvLoaiThucDon.DataSource = LoaiThucDonBUS.DanhSachLTD();
        }

        private void GvLoaiThucDon_SelectionChanged(object sender, EventArgs e)
        {
            if (GvLoaiThucDon.Rows.Count > 0)
            {
                txtTenLTD.Text = GvLoaiThucDon.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
