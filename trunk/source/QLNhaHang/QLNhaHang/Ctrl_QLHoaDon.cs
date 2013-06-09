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
    public partial class Ctrl_QLHoaDon : UserControl
    {
        public Ctrl_QLHoaDon()
        {
            InitializeComponent();
        }

        private void Ctrl_QLHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            labelX8.ForeColor = Color.Red;
            lblBan.ForeColor = Color.Red;
            lblKhuyenMai.ForeColor = Color.Red;
            lblTongTien.ForeColor = Color.Red;
            GvDsMon.AutoGenerateColumns = false;
            GvHoaDon.AutoGenerateColumns = false;
            panelEx1.Controls.Clear();
            txtNgayTu.Value = DateTime.Now.Date;
            txtNgayDen.Value = DateTime.Now.Date;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            DateTime ngaytu = txtNgayTu.Value;
            DateTime ngayden = txtNgayDen.Value;
            GvHoaDon.DataSource = HoaDonBUS.TraCuuHoaDon(ngaytu, ngayden);
            if (GvHoaDon.Rows.Count < 1)
            {
                MessageBoxEx.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            
            if (GvHoaDon.Rows.Count < 1)
            {
                return;
            }
            panelEx1.Controls.Add(pnChiTiet);
            int map = (int)GvHoaDon.CurrentRow.Cells[2].Value;
            DataTable dt = HoaDonBUS.ChiTietHoaDon(map);
            GvDsMon.DataSource = dt;
            lblBan.Text = dt.Rows[0]["MaBan"].ToString();
            lblKhuyenMai.Text = dt.Rows[0]["KhuyenMai"].ToString();
            lblTongTien.Text = dt.Rows[0]["TongTien"].ToString();

        }

        public event EventHandler Menu_Clicked;

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Menu_Clicked != null)
            {
                Menu_Clicked(sender, e);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            pnInHoaDon.Visible = true;
            pnInHoaDon.Expanded = true;
            int map = (int)GvHoaDon.CurrentRow.Cells[2].Value;
            DataTable dt = HoaDonBUS.ChiTietHoaDon(map);
            crpHoaDon r = new crpHoaDon();
            r.SetDataSource(dt);
            crptInHoaDon.ReportSource = r;
        }

        private void pnInHoaDon_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnInHoaDon.Expanded == false)
            {
                pnInHoaDon.Visible = false;
            }
        }

    }
}
