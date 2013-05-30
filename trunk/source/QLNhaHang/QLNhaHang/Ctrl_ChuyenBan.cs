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
    public partial class Ctrl_ChuyenBan : UserControl
    {
        public Ctrl_ChuyenBan()
        {
            InitializeComponent();
        }

        private void Ctrl_ChuyenBan_Load(object sender, EventArgs e)
        {
            BanCanChuyen();
            BanChuyenDen();
        }

        private void BanCanChuyen()
        {
            DataTable dt = BanBUS.BanDangSuDung();
            DataRow dr = dt.NewRow();
            dr["MaBan"] = "Chọn bàn";
            dt.Rows.InsertAt(dr, 0);
            cbxBan.DataSource = dt;
            cbxBan.DisplayMember = "MaBan";
            cbxBan.ValueMember = "MaBan";
        }

        private void BanChuyenDen()
        {
            DataTable dt = BanBUS.BanConTrong();
            DataRow dr = dt.NewRow();
            dr["MaBan"] = "Chọn bàn";
            dt.Rows.InsertAt(dr, 0);
            cbxBanCD.DataSource = dt;
            cbxBanCD.DisplayMember = "MaBan";
            cbxBanCD.ValueMember = "MaBan";
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (cbxBan.SelectedIndex == 0 || cbxBanCD.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Bạn chưa chọn bàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string maBanCu = cbxBan.SelectedValue.ToString();
            string maBanMoi = cbxBanCD.SelectedValue.ToString();
            BanBUS.ChuyenBan(maBanCu, maBanMoi);
            MessageBoxEx.Show("Chuyển bàn thành công");
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
