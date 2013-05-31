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
    public partial class Ctrl_QLDonVi : UserControl
    {
        public Ctrl_QLDonVi()
        {
            InitializeComponent();
        }

        private void Ctrl_DonVi_Load(object sender, EventArgs e)
        {
            GvDonVi.AutoGenerateColumns = false;
            GvDonVi.DataSource = DonViBUS.DanhSachDonVi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenDonVi.Text = "";
            txtTenDonVi.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            DonViBUS.ThemDonVi(txtTenDonVi.Text);
            GvDonVi.DataSource = DonViBUS.DanhSachDonVi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int madv = (int)GvDonVi.CurrentRow.Cells[0].Value;
            DonViBUS.XoaDonVi(madv);
            GvDonVi.DataSource = DonViBUS.DanhSachDonVi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            int madv = (int)GvDonVi.CurrentRow.Cells[0].Value;
            DonViBUS.SuaDonVi(madv, txtTenDonVi.Text);
            GvDonVi.DataSource = DonViBUS.DanhSachDonVi();
        }

        private void GvDonVi_SelectionChanged(object sender, EventArgs e)
        {
            if (GvDonVi.Rows.Count > 0)
            {
                txtTenDonVi.Text = GvDonVi.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
