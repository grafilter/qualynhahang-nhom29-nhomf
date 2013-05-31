using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using DevComponents.DotNetBar;

namespace QLNhaHang
{
    public partial class Ctrl_DanhSachThucDon : UserControl
    {
        public Ctrl_DanhSachThucDon()
        {
            InitializeComponent();
        }

        private void Ctrl_DanhSachThucDon_Load(object sender, EventArgs e)
        {
            GvDsThucDon.AutoGenerateColumns = false;
            GvDsThucDon.DataSource = ThucDonBUS.DanhSachThucDon();
            DanhSachLTD();
            DanhSachDonVi();
        }

        private void DanhSachLTD()
        {
            DataTable dt = LoaiThucDonBUS.DanhSachLTD();
            DataRow dr = dt.NewRow();
            dr["MaLoaiThucDon"] = 0;
            dr["LoaiThucDon"] = "Chọn loại thực đơn";
            dt.Rows.InsertAt(dr, 0);
            cbxLoaiThucDon.DataSource = dt;
            cbxLoaiThucDon.DisplayMember = "LoaiThucDon";
            cbxLoaiThucDon.ValueMember = "MaLoaiThucDon";
        }

        private void DanhSachDonVi()
        {
            DataTable dt = DonViBUS.DanhSachDonVi();
            DataRow dr = dt.NewRow();
            dr["MaDonVi"] = 0;
            dr["TenDonVi"] = "Chọn đơn vị";
            dt.Rows.InsertAt(dr, 0);
            cbxDonVi.DataSource = dt;
            cbxDonVi.DisplayMember = "TenDonVi";
            cbxDonVi.ValueMember = "MaDonVi";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaThucDon.Enabled = true;
            txtMaThucDon.Text = "";
            txtTenThucDon.Text = "";
            txtMaThucDon.Focus();
            cbxLoaiThucDon.SelectedIndex = 0;
            cbxDonVi.SelectedIndex = 0;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            if (cbxLoaiThucDon.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn loại thực đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbxDonVi.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn đơn vị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ThucDonDTO td = new ThucDonDTO();
            td.MaThucDon = txtMaThucDon.Text;
            td.TenThucDon = txtTenThucDon.Text;
            td.MaDonVi = (int)cbxDonVi.SelectedValue;
            td.MaLoaiThucDon = (int)cbxLoaiThucDon.SelectedValue;
            ThucDonBUS.ThemThucDon(td);
            GvDsThucDon.DataSource = ThucDonBUS.DanhSachThucDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matd = GvDsThucDon.CurrentRow.Cells[0].Value.ToString();
            ThucDonBUS.XoaThucDon(matd);
            GvDsThucDon.DataSource = ThucDonBUS.DanhSachThucDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            if (cbxLoaiThucDon.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn loại thực đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbxDonVi.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn đơn vị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ThucDonDTO td = new ThucDonDTO();
            td.MaThucDon = GvDsThucDon.CurrentRow.Cells[0].Value.ToString();
            td.TenThucDon = txtTenThucDon.Text;
            td.MaDonVi = (int)cbxDonVi.SelectedValue;
            td.MaLoaiThucDon = (int)cbxLoaiThucDon.SelectedValue;
            ThucDonBUS.SuaThucDon(td);
            GvDsThucDon.DataSource = ThucDonBUS.DanhSachThucDon();
        }

        private void GvDsThucDon_SelectionChanged(object sender, EventArgs e)
        {
            if (GvDsThucDon.Rows.Count > 0)
            {
                txtMaThucDon.Enabled = false;
                txtMaThucDon.Text = GvDsThucDon.CurrentRow.Cells[0].Value.ToString();
                txtTenThucDon.Text = GvDsThucDon.CurrentRow.Cells[1].Value.ToString();
                cbxDonVi.SelectedValue = GvDsThucDon.CurrentRow.Cells[4].Value.ToString();
                cbxLoaiThucDon.SelectedValue = int.Parse(GvDsThucDon.CurrentRow.Cells[5].Value.ToString());
            }
        }
    }
}
