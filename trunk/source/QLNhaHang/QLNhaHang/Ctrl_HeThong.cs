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
using DevComponents.DotNetBar;

namespace QLNhaHang
{
    public partial class Ctrl_HeThong : UserControl
    {
        
        public Ctrl_HeThong()
        {
            InitializeComponent();
        }

        public event EventHandler Menu_Clicked;

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Menu_Clicked != null)
            {
                Menu_Clicked(sender, e);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            pnDK.Controls.Clear();
            superValidator1.Enabled = false;
            Ctrl_DoiMatKhau c = new Ctrl_DoiMatKhau();
            pnDK.Controls.Add(c);
            
            
        }

        private void DanhSachBoPhan()
        {
            DataTable dt = BoPhanBUS.DanhSachBoPhan();
            DataRow dr = dt.NewRow();
            dr["MaBoPhan"] = 0;
            dr["TenBoPhan"] = "Chọn bộ phận";
            dt.Rows.InsertAt(dr, 0);
            cbxBoPhan.DataSource = dt;
            cbxBoPhan.DisplayMember = "TenBoPhan";
            cbxBoPhan.ValueMember = "MaBoPhan";

            cbxBoPhan1.DataSource = dt;
            cbxBoPhan1.DisplayMember = "TenBoPhan";
            cbxBoPhan1.ValueMember = "MaBoPhan";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            if (cbxBoPhan.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn bộ phận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int kt = NhanVienBUS.KiemTraDangKy(txtTenDangNhap.Text);
            if (kt == 1)
            {
                MessageBoxEx.Show("Tên đăng nhập đã có người sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            NhanVienDTO nv = new NhanVienDTO();
            nv.TenNhanVien = txtTenNV.Text;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.MaBoPhan = (int)cbxBoPhan.SelectedValue;
            NhanVienBUS.DangKy(nv);

            MessageBoxEx.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            Ctrl_QLBoPhan c = new Ctrl_QLBoPhan();
            pnBoPhan.Controls.Add(c);
        }

        private void Ctrl_HeThong_Load(object sender, EventArgs e)
        {
            DanhSachBoPhan();
        }

        private void ResetCheckbox()
        {
            
            chkBaoCao.Checked = false;
            chkHeThong.Checked = false;
            chkPhucVu.Checked = false;
            chkQLDuLieu.Checked = false;
            chkQLHoaDon.Checked = false;
            chkQLThucDon.Checked = false;
        }

        private void cbxBoPhan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBoPhan1.SelectedIndex > 0)
            {
                int mabp = (int)cbxBoPhan1.SelectedValue;
                DataTable dt = BoPhanBUS.DanhSachQuyenHan(mabp);
                ResetCheckbox();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["QuyenHan"].ToString().Contains("Phục vụ"))
                    {
                        chkPhucVu.Checked = true;
                    }
                    if (dt.Rows[i]["QuyenHan"].ToString().Contains("Quản lý thực đơn"))
                    {
                        chkQLThucDon.Checked = true;
                    }                   
                    if (dt.Rows[i]["QuyenHan"].ToString().Contains("Quản lý hóa đơn"))
                    {
                        chkQLHoaDon.Checked = true;
                    }
                    if (dt.Rows[i]["QuyenHan"].ToString().Contains("Quản lý dữ liệu"))
                    {
                        chkQLDuLieu.Checked = true;
                    }          
                    if (dt.Rows[i]["QuyenHan"].ToString().Contains("Báo cáo doanh thu"))
                    {
                        chkBaoCao.Checked = true;
                    }
                    if (dt.Rows[i]["QuyenHan"].ToString().Contains("Hệ thống"))
                    {
                        chkHeThong.Checked = true;
                    }
                   
                }
            }


        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            superValidator1.Enabled = false;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            superValidator1.Enabled = true;
            pnDK.Controls.Clear();
            pnDK.Controls.Add(panelEx1);
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mabp = (int)cbxBoPhan1.SelectedValue;
            if (chkBaoCao.Checked == true)
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Báo cáo doanh thu", 0);
            }
            else
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Báo cáo doanh thu", 1);
            }
            if (chkHeThong.Checked == true)
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Hệ thống", 0);
            }
            else
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Hệ thống", 1);
            }
            if (chkPhucVu.Checked == true)
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Phục Vụ", 0);
            }
            else
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Phục Vụ", 1);
            }
            if (chkQLDuLieu.Checked == true)
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Quản lý dữ liệu", 0);
            }
            else
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Quản lý dữ liệu", 1);
            }
            if (chkQLHoaDon.Checked == true)
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Quản lý hóa đơn", 0);
            }
            else
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Quản lý hóa đơn", 1);
            }
            if (chkQLThucDon.Checked == true)
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Quản lý thực đơn", 0);
            }
            else
            {
                BoPhanBUS.CapNhatQuyenHan(mabp, "Quản lý thực đơn", 1);
            }
            MessageBoxEx.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
    }
}
