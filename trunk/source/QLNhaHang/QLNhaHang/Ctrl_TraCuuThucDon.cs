using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLNhaHang
{
    public partial class Ctrl_TraCuuThucDon : UserControl
    {
        public Ctrl_TraCuuThucDon()
        {
            InitializeComponent();
        }

        private void Ctrl_TraCuuThucDon_Load(object sender, EventArgs e)
        {
            GvDsThucDon.AutoGenerateColumns = false;
            DanhSachKhuVuc();
            DanhSachLTD();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThucDonDTO td = new ThucDonDTO();
            td.MaThucDon = txtMaThucDon.Text;
            td.TenThucDon = txtTenThucDon.Text;
            td.MaKhuVuc = (int)cbxKhuVuc.SelectedValue;
            td.MaLoaiThucDon = (int)cbxLoaiThucDon.SelectedValue;
            td.GiaTu = txtGiaTu.Value;
            td.GiaDen = txtGiaDen.Value;
            GvDsThucDon.DataSource = ThucDonBUS.TraCuuThucDon(td);
        }
    }
}
