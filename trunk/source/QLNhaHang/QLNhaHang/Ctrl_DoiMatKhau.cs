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
    public partial class Ctrl_DoiMatKhau : UserControl
    {
        
        public Ctrl_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            int kt = NhanVienBUS.DangNhap(txtDangNhap.Text, txtMatKhauCu.Text);

            if (kt == 1)
            {
                MessageBoxEx.Show("Mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (kt == 2)
            {
                MessageBoxEx.Show("Tên đăng nhập không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (kt == 0)
            {
                NhanVienBUS.DoiMatKhau(txtDangNhap.Text, txtMatKhauMoi.Text);
                MessageBoxEx.Show("Đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            

        }
    }
}
