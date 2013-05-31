using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using QLNhaHang.App_data;
using DevComponents.DotNetBar;

namespace QLNhaHang
{
    public partial class Ctrl_BaoCaoDoanhThu : UserControl
    {
        public Ctrl_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void Ctrl_BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            DanhSachKhuVuc();
            cbxThoiGianTG.SelectedIndex = 0;
            cbxKhuVuc.SelectedIndex = 0;
            cbxThoiGianKV.SelectedIndex = 0;
            cbxThoiGianMA.SelectedIndex = 0;
            
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

        private void btnBaoCaoTG_Click(object sender, EventArgs e)
        {
         
            if (cbxThoiGianTG.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!superValidator1.Validate())
            {
                return;
            }

            int ngaytu = txtNgayTu.Value;
            int ngayden = txtNgayDen.Value;
            int loai = cbxThoiGianTG.SelectedIndex;



            DataTable dt = HoaDonBUS.DoanhThuTheoThoiGian(ngaytu, ngayden,loai);
            crpTheoThoiGian r = new crpTheoThoiGian();
            r.SetDataSource(dt);
            crpDTTheoThoiGian.ReportSource = r;
        }

        public event EventHandler Menu_Clicked;

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Menu_Clicked != null)
            {
                Menu_Clicked(sender, e);
            }
        }

        private void btnBaoCaoKV_Click(object sender, EventArgs e)
        {
            if (cbxThoiGianKV.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbxKhuVuc.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn khu vực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!superValidator2.Validate())
            {
                return;
            }

            int ngay = txtNgayKV.Value;
            int loai = cbxThoiGianKV.SelectedIndex;
            int makv = (int)cbxKhuVuc.SelectedValue;

            DataTable dt = HoaDonBUS.DoanhThuTheoKhuVuc(ngay,makv,loai);
            crpTheoKhuVuc r = new crpTheoKhuVuc();
            r.SetDataSource(dt);
            crpDTTheoKhuVuc.ReportSource = r;

        }

        private void btnBaoCaoMA_Click(object sender, EventArgs e)
        {
            if (cbxThoiGianMA.SelectedIndex == 0)
            {
                MessageBoxEx.Show("Xin chọn thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!superValidator3.Validate())
            {
                return;
            }

            int ngay = txtNgayMA.Value;
            int loai = cbxThoiGianMA.SelectedIndex;

            DataTable dt = HoaDonBUS.DoanhThuTheoMonAn(ngay,loai);
            crpTheoMonAn r = new crpTheoMonAn();
            r.SetDataSource(dt);
            crpDTTheoMonAn.ReportSource = r;
        }

 

        

    }
}
