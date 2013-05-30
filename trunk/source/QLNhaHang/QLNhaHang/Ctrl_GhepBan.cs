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
using DTO;

namespace QLNhaHang
{
    public partial class Ctrl_GhepBan : UserControl
    {
        public Ctrl_GhepBan()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();

        private void Ctrl_GhepBan_Load(object sender, EventArgs e)
        {
            DanhSachKhuVuc();
            cbxBan.Enabled = false;
            data.Columns.Add("MaBan", typeof(string));
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

        private void cbxKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhuVuc.SelectedIndex > 0)
            {
                cbxBan.Enabled = true;
                DsBanTheoKhuVuc(int.Parse(cbxKhuVuc.SelectedValue.ToString()));
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cbxKhuVuc.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Chưa chọn khu vực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbxBan.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Chưa chọn bàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataRow dr in data.Rows)
            {
                if (dr["MaBan"].ToString() == cbxBan.SelectedValue.ToString())
                {
                    MessageBoxEx.Show("Xin chọn bàn khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            DataRow dr1 = data.NewRow();
            dr1["MaBan"] = cbxBan.SelectedValue.ToString();
            data.Rows.Add(dr1);
            GvDsBan.DataSource = data;
        }

        private void btnGhepBan_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            if (data.Rows.Count < 1 || data.Rows.Count == 1)
            {
                MessageBoxEx.Show("Số bàn cần ghép >=2", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BanDTO b = new BanDTO();
            b.MaBan = txtMaBanGhep.Text;
            b.MaKhuVuc = (int)cbxKhuVuc.SelectedValue;
            b.TinhTrang = 2;
            b.MaBanGhep = "0";
            int soghe = 0;

            foreach (DataRow dr in data.Rows)
            {
                BanBUS.CapNhatBanGhep(dr["MaBan"].ToString(), b.MaBan);
                soghe += BanBUS.SoGhe(dr["MaBan"].ToString());
            }
            b.SoGhe = soghe;
            BanBUS.ThemBan(b);
            MessageBoxEx.Show("Ghép bàn thành công");
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
