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
    public partial class Ctrl_QLBan : UserControl
    {
        public Ctrl_QLBan()
        {
            InitializeComponent();
        }

        private void Ctrl_QLBan_Load(object sender, EventArgs e)
        {
            GvDsBan.AutoGenerateColumns = false;
            DanhSachKhuVuc();
            GvDsBan.DataSource = BanBUS.DanhSachBan();
        }

        private void DanhSachKhuVuc()
        {
            DataTable dt = KhuVucBUS.DanhSachKhuVuc();
            cbxKhuVuc.DataSource = dt;
            cbxKhuVuc.DisplayMember = "TenKhuVuc";
            cbxKhuVuc.ValueMember = "MaKhuVuc";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "";
            txtSoGhe.Value = 0;
            cbxKhuVuc.SelectedIndex = 0;
            txtMaBan.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            BanDTO b = new BanDTO();
            b.MaBan = txtMaBan.Text;
            b.SoGhe = txtSoGhe.Value;
            b.MaKhuVuc = (int)cbxKhuVuc.SelectedValue;
            b.TinhTrang = 0;
            b.MaBanGhep = "0";
            BanBUS.ThemBan(b);
            GvDsBan.DataSource = BanBUS.DanhSachBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mab = GvDsBan.CurrentRow.Cells[0].Value.ToString();
            BanBUS.XoaBan(mab);
            GvDsBan.DataSource = BanBUS.DanhSachBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            BanDTO b = new BanDTO();
            b.MaBan = txtMaBan.Text;
            b.SoGhe = txtSoGhe.Value;
            b.MaKhuVuc = (int)cbxKhuVuc.SelectedValue;
            BanBUS.SuaBan(b);
            GvDsBan.DataSource = BanBUS.DanhSachBan();
        }

        private void GvDsBan_SelectionChanged(object sender, EventArgs e)
        {
            if (GvDsBan.Rows.Count > 0)
            {
                txtMaBan.Text = GvDsBan.CurrentRow.Cells[0].Value.ToString();
                txtSoGhe.Text = GvDsBan.CurrentRow.Cells[1].Value.ToString();
                cbxKhuVuc.Text  = GvDsBan.CurrentRow.Cells[2].Value.ToString();
            }
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
