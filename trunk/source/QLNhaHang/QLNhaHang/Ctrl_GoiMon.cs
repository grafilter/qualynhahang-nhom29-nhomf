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

namespace QLNhaHang
{
    public partial class Ctrl_GoiMon : UserControl
    {
        string _maBan;
        int _maKV;
        int _tinhTrang;
        public Ctrl_GoiMon(string mb,int maKV, int tt)
        {
            InitializeComponent();
            _maBan = mb;
            _maKV = maKV;
            _tinhTrang = tt;
        }

        public void LayMaTD(string matd)
        {
            txtMaThucDon.Text = matd;
        }

        private void Ctrl_GoiMon_Load(object sender, EventArgs e)
        {
            pnTraCuu.Visible = false;
            GvDsMon.AutoGenerateColumns = false;
            DanhSachKhuVuc();
            if (_maBan != null)
            {               
                cbxKhuVuc.SelectedValue = _maKV;
                cbxKhuVuc.Enabled = false;
                DsBanTheoKhuVuc(_maKV);
                cbxBan.SelectedValue = _maBan;
                cbxBan.Enabled = false;
            }
            else
            {
                cbxBan.Enabled = false;
            }
            if (_tinhTrang != 0)
            {
                int p = PhieuGoiMonBUS.LayPhieuGoi(_maBan);
                if (p != 0)
                {
                    GvDsMon.DataSource = PhieuGoiMonBUS.DsPhieuGoi(p);
                    txtMaPhieuGoi.Text = p.ToString();
                    btnLapPhieu.Enabled = false;
                }
            }
        }

        private void DsBanTheoKhuVuc(int maKV)
        {
            DataTable dt = BanBUS.DsBanTheoKhuVuc(maKV);
            DataRow dr = dt.NewRow();
            dr["MaBan"] = "Chọn bàn";
            dt.Rows.InsertAt(dr, 0);
            cbxBan.DataSource = dt;
            cbxBan.DisplayMember = "MaBan";
            cbxBan.ValueMember = "MaBan";
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


        DataTable dtTC;

        private void btnMaThucDon_Click(object sender, EventArgs e)
        {
            pnTraCuu.Visible = true;
            pnTraCuu.Expanded = true;
            GvTraCuuTD.AutoGenerateColumns = false;
            dtTC = ThucDonBUS.DanhSachThucDon();
            //GvTraCuuTD.DataSource = dtTC;
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

        private void cbxKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhuVuc.SelectedIndex != 0)
            {
                cbxBan.Enabled = true;
                DsBanTheoKhuVuc(int.Parse(cbxKhuVuc.SelectedValue.ToString()));
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            txtMaPhieuGoi.Text = PhieuGoiMonBUS.MaPhieuGoi().ToString();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {

            if (!superValidator1.Validate())
            {
                return;
            }
            PhieuGoiMonDTO p = new PhieuGoiMonDTO();
            p.MaBan = cbxBan.SelectedValue.ToString();
            p.MaKhuVuc = (int)cbxKhuVuc.SelectedValue;
            p.MaPhieuGoi = int.Parse(txtMaPhieuGoi.Text);
            p.MaThucDon = txtMaThucDon.Text;
            p.SoLuong = int.Parse(txtSoLuong.Text);
            PhieuGoiMonBUS.GoiMon(p);

            GvDsMon.DataSource = PhieuGoiMonBUS.DsPhieuGoi(int.Parse(txtMaPhieuGoi.Text));
            if (_tinhTrang != 3 && _tinhTrang !=2)
            {
                BanBUS.CapNhatTinhTrangBan(p.MaBan, 1);
            }
        }

        private void GvDsMon_SelectionChanged(object sender, EventArgs e)
        {
            if (GvDsMon.Rows.Count > 0)
            {
                txtSoLuongCN.Value = int.Parse(GvDsMon.CurrentRow.Cells[3].Value.ToString());
            }
            
        }

        private void btnCapNhatSL_Click(object sender, EventArgs e)
        {
            if (GvDsMon.Rows.Count < 1)
            {
                return;
            }
            int soluong = int.Parse(txtSoLuongCN.Text);
            int maCT = (int)GvDsMon.CurrentRow.Cells[5].Value;
            PhieuGoiMonBUS.CapNhatSoLuong(soluong, maCT);
            GvDsMon.DataSource = PhieuGoiMonBUS.DsPhieuGoi(int.Parse(txtMaPhieuGoi.Text));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GvDsMon.Rows.Count < 1)
            {
                return;
            }
            int maCT = (int)GvDsMon.CurrentRow.Cells[5].Value;
            PhieuGoiMonBUS.XoaGoiMon(maCT);
            GvDsMon.DataSource = PhieuGoiMonBUS.DsPhieuGoi(int.Parse(txtMaPhieuGoi.Text));
        }

        private void btnUSD_Click(object sender, EventArgs e)
        {
            pnUSD.Visible = true;
            pnUSD.Expanded = true;
        }

        double tongtien=0;
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!superValidator2.Validate())
            {
                return;
            }
            int map = int.Parse(txtMaPhieuGoi.Text);
            tongtien = HoaDonBUS.TinhTien(map, DateTime.Now, txtKhuyenMai.Value);
            lblTongTien.Text = tongtien + " VNĐ";
            if (_tinhTrang != 2)
            {
                BanBUS.CapNhatTinhTrangBan(cbxBan.SelectedValue.ToString(), 0);
                
            }
            
        }

        private void btnDoiUSD_Click(object sender, EventArgs e)
        {
            double usd = txtUSD.Value;
            double s = tongtien / usd;
            lblUSD.Text = Math.Round(s, 3).ToString() + " USD";
            pnUSD.Visible = false;
        }

        public event EventHandler Menu_Clicked;

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Menu_Clicked != null)
            {
                Menu_Clicked(sender, e);
            }
        }

        public event EventHandler Home_Clicked;

        private void Home_Click(object sender, EventArgs e)
        {
            if (Home_Clicked != null)
            {
                Home_Clicked(sender, e);
            }
            
        }

        
   
    }
}
