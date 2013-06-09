using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DevComponents.DotNetBar;

namespace QLNhaHang
{
    public partial class Ctrl_QLBangGia : UserControl
    {
        public Ctrl_QLBangGia()
        {
            InitializeComponent();
        }

        private void Ctrl_QLBangGia_Load(object sender, EventArgs e)
        {
            GvDsBangGia.AutoGenerateColumns = false;
            pnTraCuu.Visible = false;
            GvDsBangGia.DataSource = BangGiaBUS.DanhSachBangGia();
            DanhSachKhuVuc();
        }

        private void DanhSachKhuVuc()
        {
            DataTable dt = KhuVucBUS.DanhSachKhuVuc();
            DataRow dr = dt.NewRow();
            dr["MaKhuVuc"] = 0;
            dr["TenKhuVuc"] = "Chọn khu vực";
            dt.Rows.InsertAt(dr, 0);
            cbxKhuVuc.DataSource = dt;
            cbxKhuVuc.DisplayMember = "TenKhuVuc";
            cbxKhuVuc.ValueMember = "MaKhuVuc";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaThucDon.Text = "";
            txtDonGia.Value = 0;
            cbxKhuVuc.SelectedIndex = 0;
            txtMaThucDon.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            if (cbxKhuVuc.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn khu vực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string matd = txtMaThucDon.Text;
            int makv = (int)cbxKhuVuc.SelectedValue;
            double dongia = txtDonGia.Value;
            BangGiaBUS.ThemBangGia(makv, matd, dongia);
            GvDsBangGia.DataSource = BangGiaBUS.DanhSachBangGia();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mabg = int.Parse(GvDsBangGia.CurrentRow.Cells[0].Value.ToString());
            BangGiaBUS.XoaBangGia(mabg);
            GvDsBangGia.DataSource = BangGiaBUS.DanhSachBangGia();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            if (cbxKhuVuc.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn khu vực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int mabg = int.Parse(GvDsBangGia.CurrentRow.Cells[0].Value.ToString());
            string matd = txtMaThucDon.Text;
            int makv = (int)cbxKhuVuc.SelectedValue;
            double dongia = txtDonGia.Value;
            BangGiaBUS.SuaBangGia(mabg, makv, matd, dongia);
            GvDsBangGia.DataSource = BangGiaBUS.DanhSachBangGia();
        }

        private void GvDsBangGia_SelectionChanged(object sender, EventArgs e)
        {
            if (GvDsBangGia.Rows.Count > 0)
            {
                txtDonGia.Value = (double)GvDsBangGia.CurrentRow.Cells[4].Value;
                txtMaThucDon.Text = GvDsBangGia.CurrentRow.Cells[1].Value.ToString();
                cbxKhuVuc.SelectedValue = int.Parse(GvDsBangGia.CurrentRow.Cells[5].Value.ToString());
            }
        }

        DataTable dtTC;

        private void btnMaThucDon_Click(object sender, EventArgs e)
        {
            pnTraCuu.Visible = true;
            pnTraCuu.Expanded = true;
            GvTraCuuTD.AutoGenerateColumns = false;
            dtTC = ThucDonBUS.DanhSachThucDon();
        }


        private void LocDuLieu()
        {
            string dk = "";
            bool f = false;
            if (txtTenThucDon.Text.Length > 0)
            {
                if (f == true)
                    dk += " AND ";
                dk += string.Format("TenThucDon LIKE '%{0}%'", txtTenThucDon.Text);
            }
            DataView view = new DataView(dtTC);
            view.RowFilter = dk;
            GvTraCuuTD.DataSource = view;
        }

        private void txtTenThucDon_TextChanged(object sender, EventArgs e)
        {
            LocDuLieu();
        }

        private void GvTraCuuTD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThucDon.Text = GvTraCuuTD.CurrentRow.Cells[0].Value.ToString();
            pnTraCuu.Visible = false;
        }

        private void pnTraCuu_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (pnTraCuu.Expanded == false)
            {
                pnTraCuu.Visible = false;
            }
        }
    }
}
