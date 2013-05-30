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
    public partial class Ctrl_QLKhuVuc : UserControl
    {
        public Ctrl_QLKhuVuc()
        {
            InitializeComponent();
        }

        private void Ctrl_QLKhuVuc_Load(object sender, EventArgs e)
        {
            GvKhuVuc.AutoGenerateColumns = false;
            GvKhuVuc.DataSource = KhuVucBUS.DanhSachKhuVuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenKhuVuc.Text = "";
            txtTenKhuVuc.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            KhuVucBUS.ThemKhuVuc(txtTenKhuVuc.Text);
            GvKhuVuc.DataSource = KhuVucBUS.DanhSachKhuVuc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int makv = (int)GvKhuVuc.CurrentRow.Cells[0].Value;
            KhuVucBUS.XoaKhuVuc(makv);
            GvKhuVuc.DataSource = KhuVucBUS.DanhSachKhuVuc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }
            int makv = (int)GvKhuVuc.CurrentRow.Cells[0].Value;
            KhuVucBUS.SuaKhuVuc(makv, txtTenKhuVuc.Text);
            GvKhuVuc.DataSource = KhuVucBUS.DanhSachKhuVuc();

        }

        private void GvKhuVuc_SelectionChanged(object sender, EventArgs e)
        {
            if (GvKhuVuc.Rows.Count > 0)
            {
                txtTenKhuVuc.Text = GvKhuVuc.CurrentRow.Cells[1].Value.ToString();
            }
        }

        public event EventHandler Menu_Clicked;

        private void Home_Click(object sender, EventArgs e)
        {
            if (Menu_Clicked != null)
            {
                Menu_Clicked(sender, e);
            }

        }

        public event EventHandler Home_Clicked;

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Home_Clicked != null)
            {
                Home_Clicked(sender, e);
            }
        }
    }
}
