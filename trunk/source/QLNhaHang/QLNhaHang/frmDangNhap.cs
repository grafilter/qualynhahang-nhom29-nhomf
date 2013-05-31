using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BUS;

namespace QLNhaHang
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            int kt = NhanVienBUS.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (kt == 1)
            {
                MessageBoxEx.Show("Mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (kt == 2)
            {
                MessageBoxEx.Show("Tên đăng nhập không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (kt == 0)
            {
                DataTable dt = NhanVienBUS.ThongTinNhanVien(txtTenDangNhap.Text, txtMatKhau.Text);
                int manv = int.Parse(dt.Rows[0]["MaNhanVien"].ToString());
                string tennv = dt.Rows[0]["TenNhanVien"].ToString();
                int mabp = int.Parse(dt.Rows[0]["MaBoPhan"].ToString());
                frmMain f = new frmMain(tennv, manv, mabp);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

    }
}